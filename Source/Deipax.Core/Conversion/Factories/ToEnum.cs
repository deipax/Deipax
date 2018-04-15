using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class ToEnum : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type toType = typeof(TTo);
            Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            Type fromType = typeof(TFrom);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (underlyingToType.IsEnum)
            {
                ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                var returnTarget = Expression.Label(toType);
                var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                Expression guardedInput = fromType != underlyingFromType
                    ? Expression.Property(input, "Value")
                    : (Expression)input;

                var callExpression = Expression.Call(
                    typeof(ToEnumHelper<TTo>),
                    "Convert",
                    new [] { underlyingFromType },
                    guardedInput,
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
                    GuardCall = true,
                    Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                };
            }

            return null;
        }
        #endregion

        #region Helpers
        static class ToEnumHelper<TTo>
        {
            static ToEnumHelper()
            {
                Type toType = typeof(TTo);

                foreach (var name in Enum.GetNames(toType))
                {
                    _enumValues.Add(name, (TTo)Enum.Parse(toType, name));
                }

                foreach (var value in Enum.GetValues(toType).Cast<int>())
                {
                    string valueAsString = value.ToString();
                    _enumValues.Add(valueAsString, (TTo)Enum.Parse(toType, valueAsString));

                    _intValues.Add(value, (TTo)Enum.Parse(toType, valueAsString));
                }
            }

            #region Field Members
            private static Dictionary<string, TTo> _enumValues = new Dictionary<string, TTo>();
            private static Dictionary<int, TTo> _intValues = new Dictionary<int, TTo>();

            private static TTo _default = default(TTo);
            #endregion

            #region Public Members
            public static TTo Convert<TFrom>(TFrom from, IFormatProvider provider = null)
            {
                TTo returnValue = _default;
                string key = from as string;

                if (key != null)
                {
                    if (key != string.Empty)
                    {
                        _enumValues.TryGetValue(key, out returnValue);
                    }

                    return returnValue;
                }

                int intKey = ConvertTo2<int, TFrom>.From(from, provider);
                _intValues.TryGetValue(intKey, out returnValue);
                return returnValue;
            }
            #endregion
        }
        #endregion
    }
}