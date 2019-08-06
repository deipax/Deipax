using System;
using System.Collections.Generic;

namespace Deipax.Core.Common
{
    public static class EnumCache
    {
        #region Field Members
        private static QuickCache<Type, IReadOnlyDictionary<string, int>> _enumValueCache =
            new QuickCache<Type, IReadOnlyDictionary<string, int>>(ReferenceEqualsComparer.Instance);

        private static QuickCache<Type, IReadOnlyDictionary<int, string>> _stringValueCache =
            new QuickCache<Type, IReadOnlyDictionary<int, string>>(ReferenceEqualsComparer.Instance);

        private static Func<Type, IReadOnlyDictionary<string, int>> _getEnumValues = GetEnumValues;

        private static Func<Type, IReadOnlyDictionary<int, string>> _getStringValues = GetStringValues;
        #endregion

        #region Public Members
        public static IReadOnlyDictionary<string, int> GetEnumValues<T>()
        {
            Type toType = typeof(T);
            Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            return _enumValueCache.GetOrAdd(underlyingToType, _getEnumValues);
        }

        public static IReadOnlyDictionary<int, string> GetStringValues<T>()
        {
            Type toType = typeof(T);
            Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            return _stringValueCache.GetOrAdd(underlyingToType, _getStringValues);
        }
        #endregion

        #region Private Members
        private static IReadOnlyDictionary<string, int> GetEnumValues(Type t)
        {
            Dictionary<string, int> cache = new Dictionary<string, int>();

            if (t.IsEnum)
            {
                foreach (var enumValue in Enum.GetValues(t))
                {
                    int enumAsInt = (int)enumValue;
                    cache.Add(enumValue.ToString(), enumAsInt);
                    cache.Add(enumAsInt.ToString(), enumAsInt);
                }
            }

            return cache;
        }

        private static IReadOnlyDictionary<int, string> GetStringValues(Type t)
        {
            Dictionary<int, string> cache = new Dictionary<int, string>();

            if (t.IsEnum)
            {
                foreach (var enumValue in Enum.GetValues(t))
                {
                    int enumAsInt = (int)enumValue;
                    cache.Add(enumAsInt, enumValue.ToString());
                }
            }

            return cache;
        }
        #endregion
    }
}
