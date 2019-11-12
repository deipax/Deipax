using Deipax.Cloning.Extensions;
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
        private static MethodInfo _tryGetCopy = typeof(CopyContext).GetMethod("TryGetCopy");
        private static MethodInfo _recordCopy = typeof(CopyContext).GetMethod("RecordCopy");
        #endregion

        #region Public Members
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
            ParameterExpression fromContext = Expression.Variable(typeof(object), "fromContext");

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
                new[] { args.Target, fromContext },
                expressions);

            return Expression.Lambda<CloneDel<T>>(block, args.Source, args.Context);
        }

        public static BlockExpression GetMemberAssignments<T>(
            ParameterExpression source,
            ParameterExpression target,
            ParameterExpression context)
        {
            List<Expression> expressions = new List<Expression>();

            foreach (var field in CloneCmdConfig<T>.GetFields())
            {
                var memberType = field.Type;
                var memberInfo = field.FieldInfo;

                var cloneExpression = field.CanShallowClone()
                    ? Expression.MakeMemberAccess(source, memberInfo)
                    : (Expression)GetSafeClone(memberType, Expression.MakeMemberAccess(source, memberInfo),
                        context);

                expressions.Add(Expression.Assign(
                    Expression.MakeMemberAccess(target, memberInfo),
                    cloneExpression));
            }

            foreach (var prop in CloneCmdConfig<T>.GetProperties())
            {
                var memberType = prop.Type;
                var memberInfo = prop.HasBackingField ?
                    prop.BackingField.FieldInfo :
                    (MemberInfo)prop.PropertyInfo;

                var cloneExpression = prop.CanShallowClone()
                    ? Expression.MakeMemberAccess(source, memberInfo)
                    : (Expression)GetSafeClone(memberType, Expression.MakeMemberAccess(source, memberInfo), context);

                expressions.Add(Expression.Assign(
                    Expression.MakeMemberAccess(target, memberInfo),
                    cloneExpression));
            }

            return expressions.Count > 0 ?
                Expression.Block(expressions) :
                null;
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
                    ? currentProperty
                    : (Expression)GetSafeClone(itemType, currentProperty, context);

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

            return null;
        }

        public static MethodCallExpression GetSafeClone(
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

        public static InvocationExpression GetUnSafeClone(
            Type t,
            Expression source,
            Expression context)
        {
            var fieldInfo = typeof(Cloner<>)
                .MakeGenericType(t)
                .GetRuntimeFields()
                .Where(x => x.Name == "_del")
                .FirstOrDefault();

            var del = (Delegate)fieldInfo.GetValue(null);

            return Expression.Invoke(
                Expression.Constant(del),
                Expression.Convert(source, t),
                context);
        }

        public static CloneDel<T> CreateShallowClone<T>()
        {
            var type = typeof(T);
            ParameterExpression source = Expression.Parameter(type, "source");
            ParameterExpression context = Expression.Parameter(typeof(CopyContext), "context");
            ConstantExpression defaultValue = Expression.Constant(default(T), type);
            LabelTarget returnTarget = Expression.Label(type);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

            GotoExpression returnExpression = Expression.Return(
                returnTarget,
                source,
                type);

            var block = Expression.Block(
                returnExpression,
                returnLabel);

            return Expression.Lambda<CloneDel<T>>(block, source, context).Compile();
        }
        #endregion
    }
}