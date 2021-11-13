using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace Deipax.Core.Common
{
    public static class SymbolCache
    {
        private static ConcurrentDictionary<string, Symbol> _cache =
            new ConcurrentDictionary<string, Symbol>(2, 10);

        private static int _count = 0;

        private static Func<string, Symbol> _valueFactory = Create;

        public static Symbol Get(string key)
        {
            return _cache.GetOrAdd(key, _valueFactory);
        }

        public static IEnumerable<string> Keys
        {
            get
            {
                return _cache.Keys;
            }
        }

        public static IEnumerable<Symbol> Values
        {
            get
            {
                return _cache.Values;
            }
        }

        public static int Count
        {
            get
            {
                return _cache.Count;
            }
        }


        #region Private Members
        private static Symbol Create(string key)
        {
            return new Symbol()
            {
                Key = key,
                Instance = _count++,
            };
        }
        #endregion
    }

    [DebuggerDisplay("{Key}")]
    public class Symbol
    {
        public string Key;
        public int Instance;
    }
}
