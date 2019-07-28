using Deipax.Core.Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Core.Common
{
    public static class EnumHelper<TTo>
    {
        static EnumHelper()
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

            foreach (var value in Enum.GetValues(underlyingToType).Cast<TTo>())
            {
                _stringValues.Add(value, value.ToString());
            }

            var p = Expression.Parameter(typeof(int));
            var c = Expression.Convert(p, typeof(TTo));
            _cast = Expression.Lambda<Func<int, TTo>>(c, p).Compile();
        }

        #region Field Members
        private static Dictionary<string, TTo> _enumValues = new Dictionary<string, TTo>();
        private static Dictionary<TTo, string> _stringValues = new Dictionary<TTo, string>();
        private static TTo _default = default;
        private static Func<int, TTo> _cast;
        #endregion

        #region Public Members
        public static TTo ConvertFromObject(
            object from,
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

            int intKey = ConvertTo<int, object>.From(from, provider);
            return _cast(intKey);
        }

        public static TTo ConvertFromString(
            string from,
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

        public static string ConvertToString(
            TTo from,
            IFormatProvider provider = null)
        {
            _stringValues.TryGetValue(from, out string returnValue);
            return returnValue;
        }
        #endregion
    }
}