using Deipax.Core.Extensions;
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
        public Convert<TFrom, TTo> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.UnderlyingToType.IsEnum)
            {
                Expression guardedInput = args.FromType.IsNullable()
                    ? Expression.Property(args.Input, "Value")
                    : (Expression)args.Input;

                var callExpression = Expression.Call(
                    typeof(ToEnumHelper<>).MakeGenericType(args.UnderlyingToType),
                    "Convert",
                    new[] { args.UnderlyingFromType },
                    guardedInput,
                    args.GetDefaultProvider());

                GotoExpression returnExpression = args.ToType.IsNullable()
                    ? Expression.Return(args.LabelTarget, Expression.Convert(callExpression, args.ToType))
                    : Expression.Return(args.LabelTarget, callExpression);

                args.AddGuards();
                args.Add(returnExpression);
                args.Add(args.LabelExpression);

                return args.GetConvertResult();
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
            public static TTo Convert<TFrom>(
                TFrom from, 
                IFormatProvider provider = null)
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