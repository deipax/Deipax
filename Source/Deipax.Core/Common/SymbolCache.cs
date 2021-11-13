using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Deipax.Core.Common
{
    public static class SymbolCache
    {
        private static ConcurrentDictionary<string, Symbol> _cache =
            new ConcurrentDictionary<string, Symbol>(ReferenceEqualsComparer.Instance);

        private static Func<string, Symbol> _valueFactory = Create;


        public static Symbol Get(string key)
        {
            return _cache.GetOrAdd(key, _valueFactory);
        }

        #region Private Members
        private static Symbol Create(string key)
        {
            return new Symbol() { Key = key };
        }
        #endregion
    }

    [DebuggerDisplay("{Key}")]
    public class Symbol
    {
        public string Key;
    }
}
