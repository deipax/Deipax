using Deipax.Core.Conversion;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Deipax.Core.Concretes
{
    internal class Getter<T, P> : IGetter<T>
    {
        public Getter(IModelInfo info)
        {
            _cache = new ConcurrentDictionary<Type, Delegate>();
            Name = info.Name;
            ModelInfo = info;
        }

        #region Field Members
        private ConcurrentDictionary<Type, Delegate> _cache;
        #endregion

        #region IGetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }

        public Get<T, X> GetDelegate<X>()
        {
            return (Get<T, X>)_cache.GetOrAdd(typeof(X), x => GetExpression<X>().Compile());
        }

        public Expression<Get<T, X>> GetExpression<X>()
        {
            var xType = typeof(X);
            var labelTarget = Expression.Label(xType);
            var labelExpression = Expression.Label(labelTarget, Expression.Default(xType));
            var instance = Expression.Parameter(typeof(T).MakeByRefType(), "instance");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                ModelInfo.GetOptimalMemberInfo());

            BlockExpression block = null;

            if (xType == ModelInfo.Type)
            {
                block = Expression.Block(
                    xType,
                    Expression.Return(labelTarget, memberExpression),
                    labelExpression);
            }
            else if (xType == typeof(object) &&
                     !ModelInfo.Type.IsNullable())
            {
                block = Expression.Block(
                    xType,
                    Expression.Return(labelTarget, Expression.Convert(memberExpression, xType)),
                    labelExpression);
            }
            else if (xType == typeof(object) &&
                     ModelInfo.Type.IsNullable())
            {
                var value = Expression.Property(memberExpression, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(memberExpression, "HasValue"),
                    Expression.Return(labelTarget, Expression.Convert(value, xType)),
                    Expression.Return(labelTarget, Expression.Default(xType)));

                block = Expression.Block(
                    xType, 
                    ifThenElse,
                    labelExpression);
            }
            else if (xType.IsNullable() &&
                     Nullable.GetUnderlyingType(xType) == ModelInfo.Type)
            {
                block = Expression.Block(
                    xType,
                    Expression.Return(labelTarget, Expression.Convert(memberExpression, xType)),
                    labelExpression);
            }
            else if (ModelInfo.Type.IsNullable() &&
                     Nullable.GetUnderlyingType(ModelInfo.Type) == xType)
            {
                var value = Expression.Property(memberExpression, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(memberExpression, "HasValue"),
                    Expression.Return(labelTarget, Expression.Convert(value, xType)),
                    Expression.Return(labelTarget, Expression.Default(xType)));

                block = Expression.Block(
                    xType, 
                    ifThenElse,
                    labelExpression);
            }
            else if (xType != ModelInfo.Type)
            {
                var invoke = Expression.Invoke(
                    ConvertTo<X, P>.Expression,
                    memberExpression,
                    provider);

                block = Expression.Block(
                    xType, 
                    Expression.Return(labelTarget, invoke),
                    labelExpression);
            }

            return Expression.Lambda<Get<T, X>>(
                block,
                instance,
                provider);
        }
        #endregion
    }
}