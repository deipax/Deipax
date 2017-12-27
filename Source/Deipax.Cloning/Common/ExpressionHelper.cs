using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Common
{
    public static class ExpressionHelper
    {
        #region Field Members
        private static Type _objectType = typeof(object);
        private static ConstantExpression _nullConstant = Expression.Constant(null, _objectType);
        private static ConstantExpression _dbNullConstant = Expression.Constant(DBNull.Value, _objectType);
        private static MethodInfo _tryGetCopy = typeof(ICopyContext).GetMethod("TryGetCopy");
        private static MethodInfo _recordCopy = typeof(ICopyContext).GetMethod("RecordCopy");
        #endregion

        #region Public Members
        public static BinaryExpression IsNull(
            Expression source)
        {
            return Expression.Or(
                Expression.Equal(source, _nullConstant),
                Expression.Equal(source, _dbNullConstant));
        }

        public static UnaryExpression IsNotNull(
            Expression source)
        {
            return Expression.Not(IsNull(source));
        }

        public static MethodCallExpression TryGetCopy(
            ParameterExpression context,
            ParameterExpression source,
            ParameterExpression target)
        {
            return Expression.Call(
                context,
                _tryGetCopy,
                source,
                target);
        }

        public static MethodCallExpression RecordCopy(
            ParameterExpression context,
            ParameterExpression source,
            ParameterExpression target)
        {
            return Expression.Call(
                context,
                _recordCopy,
                source,
                target);
        }

        public static Expression<CloneDel<T>> Get<T>(
            CloneArgs args)
        {
            ConstantExpression defaultValue = Expression.Constant(default(T), args.Type);
            LabelTarget returnTarget = Expression.Label(args.Type);
            ParameterExpression fromContext = Expression.Variable(_objectType, "fromContext");

            List<Expression> expressions = new List<Expression>();

            if (!args.Type.IsValueType() && args.CheckContext)
            {
                expressions.Add(Expression.IfThenElse(
                    TryGetCopy(args.Context, args.Source, fromContext),
                    Expression.Assign(args.Target, Expression.Convert(fromContext, args.Type)),
                    args.CloneExpression));
            }
            else
            {
                expressions.Add(args.CloneExpression);
            }

            expressions.Add(Expression.Return(returnTarget, args.Target, args.Type));
            expressions.Add(Expression.Label(returnTarget, defaultValue));

            var block = Expression.Block(
                new[] { args.Target, fromContext},
                expressions);

            return Expression.Lambda<CloneDel<T>>(block, args.Source, args.Context);
        }

        public static BlockExpression GetMemberAssignments<T>(
            ParameterExpression source,
            ParameterExpression target,
            ParameterExpression context)
        {
            List<Expression> expressions = new List<Expression>();

            var type = typeof(T);

            bool cloneAll = type
                .GetCustomAttributes<CloneAllAttribute>()
                .Count() > 0;

            var fields = type.GetAllFields();
            var properties = type.GetFilteredProperties(fields);

            fields.Where(x =>
                x.CanRead &&
                x.CanWrite &&
                !x.IsStatic &&
                !x.IsLiteral &&
                !x.IsBackingField &&
                (x.IsPublic || cloneAll || x.GetCustomAttributes<CloneAttribute>().Count() > 0) &&
                x.GetCustomAttributes<NoCloneAttribute>().Count() == 0)
            .ToList()
            .ForEach(x =>
            {
                var memberType = x.Type;
                var memberInfo = x.FieldInfo;

                var cloneExpression = memberType.CanShallowClone()
                    ? (Expression)Expression.MakeMemberAccess(source, memberInfo)
                    : (Expression)GetGuardedClone(memberType, Expression.MakeMemberAccess(source, memberInfo), context);

                expressions.Add(Expression.Assign(
                    Expression.MakeMemberAccess(target, memberInfo),
                    cloneExpression));
            });

            properties.Where(x =>
                x.CanRead &&
                x.CanWrite &&
                !x.IsLiteral &&
                !x.IsStatic &&
                !x.HasParameters &&
                (x.IsPublic || cloneAll || x.GetCustomAttributes<CloneAttribute>().Count() > 0) &&
                x.GetCustomAttributes<NoCloneAttribute>().Count() == 0)
            .ToList()
            .ForEach(x =>
            {
                var memberType = x.Type;
                var memberInfo = x.HasBackingField ?
                    (MemberInfo)x.BackingField.FieldInfo :
                    (MemberInfo)x.PropertyInfo;

                var cloneExpression = memberType.CanShallowClone()
                    ? (Expression)Expression.MakeMemberAccess(source, memberInfo)
                    : (Expression)GetGuardedClone(memberType, Expression.MakeMemberAccess(source, memberInfo), context);

                expressions.Add(Expression.Assign(
                    Expression.MakeMemberAccess(target, memberInfo),
                    cloneExpression));
            });

            return expressions.Count > 0 ?
                Expression.Block(expressions) :
                Expression.Block(Expression.Empty());
        }

        public static BlockExpression GetCollectionAssignment<T>(
            ParameterExpression source,
            ParameterExpression target,
            ParameterExpression context)
        {
            Type collectionType = typeof(T)
                .GetInterfaces()
                .Where(x =>
                    x.IsGenericType() &&
                    x.GetGenericTypeDefinition() == typeof(ICollection<>))
                .FirstOrDefault();

            if (collectionType != null)
            {
                var collection = Expression.Variable(collectionType);
                var itemType = collectionType.GetGenericArguments().First();
                var enumerableType = typeof(IEnumerable<>).MakeGenericType(itemType);
                var enumeratorType = typeof(IEnumerator<>).MakeGenericType(itemType);
                var enumerator = Expression.Variable(enumeratorType);
                var getEnumeratorCall = Expression.Call(Expression.Convert(source, enumerableType), "GetEnumerator", null);
                var assignToEnumerator = Expression.Assign(enumerator, Expression.Convert(getEnumeratorCall, enumeratorType));
                var assignToCollection = Expression.Assign(collection, Expression.Convert(target, collectionType));
                var moveNextCall = Expression.Call(enumerator, typeof(IEnumerator).GetMethod("MoveNext"));
                var currentProperty = Expression.Property(enumerator, "Current");
                var breakLabel = Expression.Label();

                var addMethod = typeof(ICollection<>)
                    .MakeGenericType(itemType)
                    .GetRuntimeMethods()
                    .Where(x => x.Name == "Add")
                    .FirstOrDefault();

                Expression cloneItem = itemType.CanShallowClone()
                    ? (Expression)currentProperty
                    : (Expression)GetGuardedClone(itemType, currentProperty, context);

                LoopExpression loop = Expression.Loop(
                    Expression.IfThenElse(
                        Expression.NotEqual(moveNextCall, Expression.Constant(false, typeof(bool))),
                        Expression.Call(collection, addMethod, cloneItem),
                        Expression.Break(breakLabel)),
                    breakLabel);

                return Expression.Block(
                    new[] { enumerator, collection },
                    assignToEnumerator,
                    assignToCollection,
                    loop);
            }

            return Expression.Block(Expression.Empty());
        }

        public static MethodCallExpression GetGuardedClone(
            Type t,
            Expression source,
            Expression context)
        {
            var methodInfo = typeof(Cloner<>)
                .MakeGenericType(t)
                .GetRuntimeMethods()
                .Where(x => x.Name == "Get")
                .FirstOrDefault();

            return Expression.Call(null, methodInfo, source, context);
        }

        public static MethodCallExpression GetUnGuardedClone(
            Type t,
            Expression source,
            Expression context)
        {
            var methodInfo = typeof(Cloner<>)
                .MakeGenericType(t)
                .GetRuntimeMethods()
                .Where(x => x.Name == "GetUnsafe")
                .FirstOrDefault();

            return Expression.Call(null, methodInfo, source, context);
        }
        #endregion
    }
}