using Deipax.Core.Conversion;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Deipax.Core.Common
{
    public static class EnumHelper<TTo>
    {
        static EnumHelper()
        {
            Type toType = typeof(TTo);
            Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

            foreach (var value in Enum.GetValues(underlyingToType))
            {
                TTo enumValue = (TTo)value;
                int enumAsInt = (int)value;

                _enumValues.Add(enumValue.ToString(), enumAsInt);
                _enumValues.Add(enumAsInt.ToString(), enumAsInt);
                _stringValues.Add(enumAsInt, enumValue.ToString());
            }

            var p = Expression.Parameter(typeof(int));
            var c = Expression.Convert(p, typeof(TTo));
            _cast = Expression.Lambda<Func<int, TTo>>(c, p).Compile();
        }

        #region Field Members
        private static Dictionary<string, int> _enumValues = new Dictionary<string, int>();
        private static Dictionary<int, string> _stringValues = new Dictionary<int, string>();
        private static TTo _default = default;
        private static Func<int, TTo> _cast;
        #endregion

        #region Public Members
        public static TTo ConvertFromObject(
            object from,
            IFormatProvider provider = null)
        {
            if (from == null || DBNull.Value.Equals(from))
            {
                return _default;
            }

            string key = from as string;

            if (key != null)
            {
                if (key != string.Empty &&
                    _enumValues.TryGetValue(key, out int returnValue))
                {
                    return _cast(returnValue);
                }

                return _default;
            }

            int? intKey = ConvertTo<int?, object>.From(from, provider);

            return intKey.HasValue
                ? _cast(intKey.Value)
                : _default;
        }

        public static TTo ConvertFromString(
            string from,
            IFormatProvider provider = null)
        {
            if (!string.IsNullOrEmpty(from) &&
                _enumValues.TryGetValue(from, out int returnValue))
            {
                return _cast(returnValue);
            }

            return _default;
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

        public static string ConvertToString(
            TTo from,
            IFormatProvider provider = null)
        {
            string returnValue = default;
            int? value = ConvertTo<int?, TTo>.From(from);

           if (value.HasValue)
            {
                _stringValues.TryGetValue(value.Value, out returnValue);
            }
       
            return returnValue;
        }
        #endregion
    }
}