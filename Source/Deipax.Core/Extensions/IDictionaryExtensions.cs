using System.Collections.Generic;

namespace Deipax.Core.Extensions
{
	public static class IDictionaryExtensions
	{
		public static TValue TryGetValue<TKey, TValue>(
			this IDictionary<TKey, TValue> source,
			TKey key,
			TValue defaultValue = default(TValue))
		{
			TValue retvalue;

			if (source != null &&
				source.TryGetValue(key, out retvalue))
			{
				return retvalue;
			}

			return defaultValue;
		}
	}
}