using Deipax.Core.Conversion;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Deipax.Core.Concretes
{
    internal class Setter<T, P> : ISetter<T>
    {
        public Setter(IModelInfo info)
        {
            Name = info.Name;
            ModelInfo = info;
            _cache = new ConcurrentDictionary<Type, Delegate>();
        }

        #region Field Members

        private ConcurrentDictionary<Type, Delegate> _cache;

        #endregion

        #region ISetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }

        public Set<T, X> GetDelegate<X>()
        {
            return (Set<T, X>) _cache.GetOrAdd(typeof(X), x => GetExpression<X>().Compile());
        }

        public Expression<Set<T, X>> GetExpression<X>()
        {
            var xType = typeof(X);

            var tmp = Expression.Variable(typeof(P), "tmp");
            var input = Expression.Parameter(typeof(X), "input");
            var instance = Expression.Parameter(typeof(T).MakeByRefType(), "instance");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                ModelInfo.GetOptimalMemberInfo());

            var invoke = Expression.Invoke(
                ConvertTo<P, X>.Expression,
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

            return Expression.Lambda<Set<T, X>>(
                block,
                instance,
                input,
                provider);
        }
    }
    #endregion
}