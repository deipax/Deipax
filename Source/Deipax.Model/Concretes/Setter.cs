using Deipax.Convert;
using Deipax.Core.Extensions;
using Deipax.Model.Extensions;
using Deipax.Model.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Deipax.Model.Concretes
{
    internal class Setter<T, TProp> : ISetter<T>
    {
        public Setter(IModelInfo info)
        {
            Name = info.Name;
            ModelInfo = info;
            _cache = new ConcurrentDictionary<Type, Delegate>();
        }

        #region Field Members
        private readonly ConcurrentDictionary<Type, Delegate> _cache;
        #endregion

        #region ISetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }

        public SetDelegate<T, TValue> GetDelegate<TValue>()
        {
            return (SetDelegate<T, TValue>)_cache.GetOrAdd(typeof(TValue), x => GetExpression<TValue>().Compile());
        }

        public Expression<SetDelegate<T, TValue>> GetExpression<TValue>()
        {
            var xType = typeof(TValue);

            var tmp = Expression.Variable(typeof(TProp), "tmp");
            var input = Expression.Parameter(typeof(TValue), "input");
            var instance = Expression.Parameter(typeof(T).MakeByRefType(), "instance");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                ModelInfo.GetOptimalMemberInfo());

            var invoke = Expression.Invoke(
                ConvertTo<TValue, TProp>.Result.Expression,
                input,
                provider);

            BlockExpression block = null;

            if (ModelInfo.Type == xType)
            {
                block = Expression.Block(Expression.Assign(memberExpression, input));
            }
            else if (ModelInfo.Type == typeof(object) &&
                     !xType.IsNullable())
            {
                block = Expression.Block(Expression.Assign(
                    memberExpression,
                    Expression.Convert(input, typeof(object))));
            }
            else if (ModelInfo.Type == typeof(object) &&
                     xType.IsNullable())
            {
                var value = Expression.Property(input, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(input, "HasValue"),
                    Expression.Assign(memberExpression, Expression.Convert(value, typeof(object))),
                    Expression.Assign(memberExpression, Expression.Default(ModelInfo.Type)));

                block = Expression.Block(ifThenElse);
            }
            else if (xType.IsNullable() &&
                     Nullable.GetUnderlyingType(xType) == ModelInfo.Type)
            {
                var value = Expression.Property(input, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(input, "HasValue"),
                    Expression.Assign(memberExpression, Expression.Convert(value, ModelInfo.Type)),
                    Expression.Assign(memberExpression, Expression.Default(ModelInfo.Type)));

                block = Expression.Block(ifThenElse);
            }
            else if (ModelInfo.Type.IsNullable() &&
                     Nullable.GetUnderlyingType(ModelInfo.Type) == xType)
            {
                block = Expression.Block(Expression.Assign(
                    memberExpression,
                    Expression.Convert(input, ModelInfo.Type)));
            }
            else if (xType == typeof(object))
            {
                var ifThenElse = Expression.IfThenElse(
                    Expression.TypeEqual(input, ModelInfo.Type),
                    Expression.Assign(memberExpression, Expression.Convert(input, ModelInfo.Type)),
                    Expression.Block(
                        new[] { tmp },
                        Expression.Assign(tmp, invoke),
                        Expression.Assign(memberExpression, tmp)));

                block = Expression.Block(ifThenElse);
            }
            else if (xType != ModelInfo.Type)
            {
                block = Expression.Block(
                    new[] { tmp },
                    Expression.Assign(tmp, invoke),
                    Expression.Assign(memberExpression, tmp));
            }

            return Expression.Lambda<SetDelegate<T, TValue>>(
                block,
                instance,
                input,
                provider);
        }
    }
    #endregion
}