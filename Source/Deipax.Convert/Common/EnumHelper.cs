using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Deipax.Convert.Common
{
    public static class EnumHelper<TEnum, TUnderlyingType> where TUnderlyingType : struct
    {
        #region Field Members
        private static readonly IReadOnlyDictionary<string, TUnderlyingType> _enumValues =
            EnumCache.GetEnumValues<TEnum, TUnderlyingType>();
        private static readonly IReadOnlyDictionary<TUnderlyingType, string> _stringValues =
            EnumCache.GetStringValues<TEnum, TUnderlyingType>();
        private static readonly TEnum _default = default;
        private static readonly Func<TUnderlyingType, TEnum> _cast = InitCast();
        #endregion

        #region Public Members
        public static TEnum ConvertFromObject(
            object from,
            IFormatProvider provider = null)
        {
            if (from == null || DBNull.Value.Equals(from))
            {
                return _default;
            }

            TUnderlyingType? value;

            if (from is string key)
            {
                if (!string.IsNullOrEmpty(key) &&
                 _enumValues.TryGetValue(key, out TUnderlyingType returnValue))
                {
                    return _cast(returnValue);
                }

                value = ConvertTo<TUnderlyingType?, string>.From(key, provider);

                return value.HasValue
                    ? _cast(value.Value)
                    : _default;
            }

            value = ConvertTo<TUnderlyingType?, object>.From(from, provider);

            return value.HasValue
                ? _cast(value.Value)
                : _default;
        }

        public static TEnum ConvertFromString(
            string from,
            IFormatProvider provider = null)
        {
            if (!string.IsNullOrEmpty(from) &&
                _enumValues.TryGetValue(from, out TUnderlyingType returnValue))
            {
                return _cast(returnValue);
            }

            TUnderlyingType? value = ConvertTo<TUnderlyingType?, string>.From(from, provider);

            return value.HasValue
                ? _cast(value.Value)
                : _default;
        }

        public static TEnum Convert<TFrom>(
            TFrom from,
            IFormatProvider provider = null)
        {
            TUnderlyingType? value = ConvertTo<TUnderlyingType?, TFrom>.From(from, provider);

            return value.HasValue
                ? _cast(value.Value)
                : _default;
        }

        public static string ConvertToString(
            TEnum from,
            IFormatProvider provider = null)
        {
            string returnValue = default;
            TUnderlyingType? value = ConvertTo<TUnderlyingType?, TEnum>.From(from, provider);

            if (value.HasValue)
            {
                _stringValues.TryGetValue(value.Value, out returnValue);
            }

            return returnValue;
        }
        #endregion

        #region Members
        private static Func<TUnderlyingType, TEnum> InitCast()
        {
            var p = Expression.Parameter(typeof(TUnderlyingType));
            var c = Expression.Convert(p, typeof(TEnum));
            return Expression.Lambda<Func<TUnderlyingType, TEnum>>(c, p).Compile();
        }
        #endregion
    }
}