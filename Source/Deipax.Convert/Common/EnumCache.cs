using Deipax.Core.Common;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Deipax.Convert.Common
{
    /// <summary>
    /// This class holds onto Enum mappings and shares the same
    /// dictionary between an Enum and its nullable form.
    /// </summary>
    public static class EnumCache
    {
        #region Field Members
        private static readonly ConcurrentDictionary<Type, object> _enumValueCache =
            new ConcurrentDictionary<Type, object>(8, 16, ReferenceEqualsComparer.Instance);

        private static readonly ConcurrentDictionary<Type, object> _stringValueCache =
            new ConcurrentDictionary<Type, object>(8, 16, ReferenceEqualsComparer.Instance);
        #endregion

        #region Public Members
        public static IReadOnlyDictionary<string, TUnderlyingType> GetEnumValues<TEnum, TUnderlyingType>()
        {
            Type toType = typeof(TEnum);
            Type enumType = Nullable.GetUnderlyingType(toType) ?? toType;
            var cache = _enumValueCache.GetOrAdd(
                enumType,
                (key) => GetEnumValuesHelper<TEnum, TUnderlyingType>());
            return cache as IReadOnlyDictionary<string, TUnderlyingType>;
        }

        public static IReadOnlyDictionary<TUnderlyingType, string> GetStringValues<TEnum, TUnderlyingType>()
        {
            Type toType = typeof(TEnum);
            Type enumType = Nullable.GetUnderlyingType(toType) ?? toType;
            var cache = _stringValueCache.GetOrAdd(
                enumType,
                (key) => GetStringValuesHelper<TEnum, TUnderlyingType>());
            return cache as IReadOnlyDictionary<TUnderlyingType, string>;
        }
        #endregion

        #region Private Members
        public static object GetEnumValuesHelper<TEnum, TUnderlyingType>()
        {
            Type toType = typeof(TEnum);
            Type enumType = Nullable.GetUnderlyingType(toType) ?? toType;
            Dictionary<string, TUnderlyingType> cache = new Dictionary<string, TUnderlyingType>();

            if (enumType.IsEnum)
            {
                foreach (var enumValue in Enum.GetValues(enumType))
                {
                    TUnderlyingType enumAsUnderlyingType = (TUnderlyingType)enumValue;
                    cache.Add(enumValue.ToString(), enumAsUnderlyingType);
                    cache.Add(enumAsUnderlyingType.ToString(), enumAsUnderlyingType);
                }
            }

            return cache;
        }

        private static object GetStringValuesHelper<TEnum, TUnderlyingType>()
        {
            Type toType = typeof(TEnum);
            Type enumType = Nullable.GetUnderlyingType(toType) ?? toType;
            Dictionary<TUnderlyingType, string> cache = new Dictionary<TUnderlyingType, string>();

            if (enumType.IsEnum)
            {
                foreach (var enumValue in Enum.GetValues(enumType))
                {
                    TUnderlyingType enumAsUnderlyingType = (TUnderlyingType)enumValue;
                    cache.Add(enumAsUnderlyingType, enumValue.ToString());
                }
            }

            return cache;
        }
        #endregion
    }
}
