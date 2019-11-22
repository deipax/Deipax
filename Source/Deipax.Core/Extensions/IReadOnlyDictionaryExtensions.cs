using System.Collections.Generic;

namespace Deipax.Core.Extensions
{
    public static class IReadOnlyDictionaryExtensions
    {
        public static TValue TryGetValue<TKey, TValue>(
            this IReadOnlyDictionary<TKey, TValue> source,
            TKey key,
            TValue defaultValue = default)
        {
            TValue retvalue = defaultValue;
            source?.TryGetValue(key, out retvalue);
            return retvalue;
        }
    }
}