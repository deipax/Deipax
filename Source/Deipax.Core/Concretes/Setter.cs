using Deipax.Core.Conversion;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

namespace Deipax.Core.Concretes
{
    internal class Setter<T, P> : ISetter<T>
    {
        public Setter(IModelInfo info)
        {
            Name = info.Name;
            ModelInfo = info;

            _cache = new ConcurrentDictionary<Type, Delegate>();
            _lazy = new Lazy<SetFromRecord<T>>(
                GetSetFromRecord,
                LazyThreadSafetyMode.ExecutionAndPublication);
        }

        #region Field Members
        private ConcurrentDictionary<Type, Delegate> _cache;
        private Lazy<SetFromRecord<T>> _lazy;
        #endregion

        #region ISetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }

        public SetFromRecord<T> SetFromRecord
        {
            get { return _lazy.Value; }
        }

        public Set<T, X> GetDelegate<X>()
        {
            return (Set<T, X>)_cache.GetOrAdd(typeof(X), x => Create<X>(ModelInfo));
        }
        #endregion

        #region Private Members
        private static Set<T, X> Create<X>(
            IModelInfo info)
        {
            var setter = CreateExpression<X>(info);
            return setter.Compile();
        }

        private static Expression<Set<T, X>> CreateExpression<X>(
            IModelInfo info)
        {
            var xType = typeof(X);

            var input = Expression.Parameter(typeof(X), "input");
            var instance = Expression.Parameter(typeof(T).MakeByRefType(), "instance");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                info.GetOptimalMemberInfo());

            List<Expression> expressions = new List<Expression>();

            if (info.Type == xType)
            {
                expressions.Add(Expression.Assign(memberExpression, input));
            }
            else if (info.Type == typeof(object) &&
                     !xType.IsNullable())
            {
                expressions.Add(Expression.Assign(memberExpression, Expression.Convert(input, typeof(object))));
            }
            else if (info.Type == typeof(object) &&
                     xType.IsNullable())
            {
                var value = Expression.Property(input, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(input, "HasValue"),
                    Expression.Assign(memberExpression, Expression.Convert(value, typeof(object))),
                    Expression.Assign(memberExpression, Expression.Default(info.Type)));

                expressions.Add(ifThenElse);
            }
            else if (xType.IsNullable() &&
                     Nullable.GetUnderlyingType(xType) == info.Type)
            {
                var value = Expression.Property(input, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(input, "HasValue"),
                    Expression.Assign(memberExpression, Expression.Convert(value, info.Type)),
                    Expression.Assign(memberExpression, Expression.Default(info.Type)));

                expressions.Add(ifThenElse);
            }
            else if (info.Type.IsNullable() &&
                     Nullable.GetUnderlyingType(info.Type) == xType)
            {
                expressions.Add(Expression.Assign(memberExpression, Expression.Convert(input, info.Type)));
            }
            else if (xType == typeof(object))
            {
                var invoke = Expression.Invoke(
                    Expression.Constant(ConvertTo<P, X>.From),
                    input,
                    provider);

                var ifThenElse = Expression.IfThenElse(
                    Expression.TypeEqual(input, info.Type),
                    Expression.Assign(memberExpression, Expression.Convert(input, info.Type)),
                    Expression.Assign(memberExpression, invoke));

                expressions.Add(ifThenElse);
            }
            else if (xType != info.Type)
            {
                var invoke = Expression.Invoke(
                    Expression.Constant(ConvertTo<P, X>.From),
                    input,
                    provider);

                expressions.Add(Expression.Assign(memberExpression, invoke));
            }

            return Expression.Lambda<Set<T, X>>(
                Expression.Block(expressions),
                instance,
                input,
                provider);
        }

        private SetFromRecord<T> GetSetFromRecord()
        {
            var instance = Expression.Parameter(typeof(T).MakeByRefType(), "instance");
            var record = Expression.Parameter(typeof(IDataRecord), "record");
            var index = Expression.Parameter(typeof(int), "index");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var method = typeof(IDataRecord)
                .GetRuntimeMethods()
                .Where(x =>
                    x.ReturnType == typeof(object) &&
                    x.Name == "GetValue" &&
                    x.GetParameters().Count() == 1 &&
                    x.GetParameters()[0].ParameterType == typeof(int))
                .FirstOrDefault();

            MethodCallExpression readCall = Expression.Call(
                record,
                method,
                index);

            InvocationExpression setCall = Expression.Invoke(
                CreateExpression<object>(ModelInfo),
                instance,
                readCall,
                provider);

            var lambda = Expression.Lambda<SetFromRecord<T>>(
                setCall,
                instance,
                record,
                index,
                provider);

            return lambda.Compile();
        }
    }
    #endregion
}