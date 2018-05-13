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
        public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.UnderlyingToType.IsEnum)
            {
                MethodCallExpression callExpression = null;

                if (args.FromType == typeof(string))
                {
                    callExpression = Expression.Call(
                        typeof(ToEnumHelper<>).MakeGenericType(args.ToType),
                        "ConvertFromString",
                        new[] { args.FromType },
                        args.Input,
                        args.GetDefaultProvider());
                }
                else if (args.FromType == typeof(object))
                {
                    callExpression = Expression.Call(
                        typeof(ToEnumHelper<>).MakeGenericType(args.ToType),
                        "ConvertFromObject",
                        new[] { args.FromType },
                        args.Input,
                        args.GetDefaultProvider());
                }
                else
                {
                    Expression guardedInput = args.FromType.IsNullable()
                        ? Expression.Property(args.Input, "Value")
                        : (Expression)args.Input;

                    callExpression = Expression.Call(
                        typeof(ToEnumHelper<>).MakeGenericType(args.ToType),
                        "Convert",
                        new[] { args.UnderlyingFromType },
                        guardedInput,
                        args.GetDefaultProvider());
                }

                GotoExpression returnExpression = args.ToType.IsNullable()
                    ? Expression.Return(args.LabelTarget, Expression.Convert(callExpression, args.ToType))
                    : Expression.Return(args.LabelTarget, callExpression);

                args.AddGuards();
                args.Add(returnExpression);
                args.Add(args.LabelExpression);

                return args.Get();
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
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                foreach (var name in Enum.GetNames(underlyingToType))
                {
                    _enumValues.Add(name, (TTo)Enum.Parse(underlyingToType, name));
                }

                foreach (var value in Enum.GetValues(underlyingToType).Cast<int>())
                {
                    string valueAsString = value.ToString();
                    _enumValues.Add(valueAsString, (TTo)Enum.Parse(underlyingToType, valueAsString));
                }

                var p = Expression.Parameter(typeof(int));
                var c = Expression.Convert(p, typeof(TTo));
                _cast = Expression.Lambda<Func<int, TTo>>(c, p).Compile();
            }

            #region Field Members
            private static Dictionary<string, TTo> _enumValues = new Dictionary<string, TTo>();
            private static TTo _default = default(TTo);
            private static Func<int, TTo> _cast;
            #endregion

            #region Public Members
            public static TTo ConvertFromObject<TFrom>(
                TFrom from,
                IFormatProvider provider = null)
            {
                TTo returnValue = _default;

                if (from == null || DBNull.Value.Equals(from))
                {
                    return returnValue;
                }

                string key = from as string;

                if (key != null)
                {
                    if (key != string.Empty)
                    {
                        _enumValues.TryGetValue(key, out returnValue);
                    }

                    return returnValue;
                }

                int intKey = ConvertTo<int, TFrom>.From(from, provider);
                return _cast(intKey);
            }

            public static TTo ConvertFromString<TFrom>(
                TFrom from,
                IFormatProvider provider = null)
            {
                TTo returnValue = _default;
                string key = from as string;

                if (!string.IsNullOrEmpty(key))
                {
                    _enumValues.TryGetValue(key, out returnValue);
                }

                return returnValue;
            }

            public static TTo Convert<TFrom>(
                TFrom from,
                IFormatProvider provider = null)
            {
                int? intKey = ConvertTo<int?, TFrom>.From(from, provider);

                return intKey.HasValue
                    ? _cast(intKey.Value)
                    : _default;
            }
            #endregion
        }
        #endregion
    }
}