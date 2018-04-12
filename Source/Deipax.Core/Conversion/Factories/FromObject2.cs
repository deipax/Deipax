using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromObject2 : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);

            if (fromType == typeof(object))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                var returnTarget = Expression.Label(toType);
                var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                var callExpression = Expression.Call(
                    typeof(FromObject<TTo>),
                    "Convert",
                    null,
                    input,
                    provider);

                GotoExpression returnExpression = toType == underlyingToType
                    ? Expression.Return(returnTarget, callExpression)
                    : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                BlockExpression block = Expression.Block(
                    toType,
                    returnExpression,
                    returnLabel);

                return new ConvertFactoryResult<TFrom, TTo>()
                {
                    Factory = this,
                    GuardCall = false,
                    Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                };
            }

            return null;
        }
        #endregion

        #region Helpers
        static class FromObject<TTo>
        {
            #region Field Members
            private static TTo _default = default(TTo);

            private static Type _toType = typeof(TTo);

            private static MethodInfo _helper = typeof(FromObject<TTo>)
                .GetRuntimeMethods()
                .Where(x => x.Name == "GetHelper")
                .FirstOrDefault();

            private static readonly QuickCache<Type, Convert<object, TTo>> _cache =
                new QuickCache<Type, Convert<object, TTo>>(16, ReferenceEqualsComparer.Instance);

            private static readonly Func<Type, Convert<object, TTo>> _create = Create;
            #endregion

            #region Public Members
            public static TTo Convert(object from, IFormatProvider provider = null)
            {
                if (from == null ||
                    from == DBNull.Value)
                {
                    return _default;
                }

                var runtimeType = from.GetType();

                if (runtimeType == _toType)
                {
                    return (TTo)from;
                }

                var func = _cache.GetOrAdd(runtimeType, _create);

                return func(from, provider);
            }
            #endregion

            #region Private Members
            private static Convert<object, TTo> Create(Type runtimeType)
            {
                ConstantExpression defaultValue = Expression.Constant(default(TTo), _toType);
                LabelTarget returnTarget = Expression.Label(_toType);
                LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

                ParameterExpression input = Expression.Parameter(typeof(object), "input");
                ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");

                var convertTo = (Delegate)_helper
                        .MakeGenericMethod(new[] { runtimeType })
                        .Invoke(null, null);

                var callExpression = Expression.Invoke(
                    Expression.Constant(convertTo),
                    Expression.Convert(input, runtimeType),
                    provider);

                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    callExpression,
                    _toType);

                var block = Expression.Block(
                    returnExpression,
                    returnLabel);

                return Expression.Lambda<Convert<object, TTo>>(block, input, provider).Compile();
            }

            private static Delegate GetHelper<TFrom>()
            {
                return ConvertTo2<TTo, TFrom>.Result?.Func;
            }
            #endregion
        }
        #endregion
    }
}