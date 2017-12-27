using System;
using System.Collections.Generic;

namespace Deipax.Cloning.Common
{
    public class QuickCache<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public QuickCache()
            : base()
        {
        }

        public QuickCache(IDictionary<TKey, TValue> dictionary)
            : base(dictionary)
        {
        }

        public QuickCache(IEqualityComparer<TKey> comparer)
            : base(comparer)
        {
        }

        public QuickCache(int capacity)
            : base(capacity)
        {
        }

        public QuickCache(
            IDictionary<TKey, TValue> dictionary,
            IEqualityComparer<TKey> comparer)
            : base(dictionary, comparer)
        {
        }

        public QuickCache(int capacity, IEqualityComparer<TKey> comparer)
            : base(capacity, comparer)
        {
        }

        #region Field Members
        private readonly object _lock = new object();
        #endregion

        #region Public Members
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> factory)
        {
            TValue value;

            if (!TryGetValue(key, out value))
            {
                lock (_lock)
                {
                    if (!TryGetValue(key, out value))
                    {
                        value = factory(key);
                        Add(key, value);
                    }
                }
            }

            return value;
        }
        #endregion
    }
}