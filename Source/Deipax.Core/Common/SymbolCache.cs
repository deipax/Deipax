using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Deipax.Core.Common
{
    public static class SymbolCache
    {
        #region Field Members
        private static readonly ConcurrentDictionary<string, ISymbol> _cache =
            new ConcurrentDictionary<string, ISymbol>(2, 10);

        private static readonly Func<string, ISymbol> _create = Create;

        private static int _count = 0;
        #endregion

        #region Public Members
        public static ISymbol Get(string name)
        {
            return _cache.GetOrAdd(name, _create);
        }
        #endregion

        #region Private Members
        private static ISymbol Create(string key)
        {
            return new Symbol()
            {
                Key = key,
                Id = _count++
            };
        }
        #endregion

        #region Helper Class
        [DebuggerDisplay("Key:{Key},Id:{Id}")]
        private class Symbol : ISymbol
        {
            public string Key { get; set; }
            public int Id { get; set; }
        }
        #endregion
    }

    public interface ISymbol
    {
        string Key { get; }
        int Id { get; }
    }
}
