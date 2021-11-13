using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Deipax.Core.Common
{
    public class SymbolDictionary<T> : IDictionary<string, T>
    {
        private ConcurrentDictionary<Symbol, T> _internal =
            new ConcurrentDictionary<Symbol, T>(2, 10, ReferenceEqualsComparer.Instance);

        public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
        {
            foreach (var item in _internal)
            {
                yield return KeyValuePair.Create(item.Key.Key, item.Value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<string, T> item)
        {
            _internal.AddOrUpdate(SymbolCache.Get(item.Key), item.Value, (k, v) => item.Value);
        }

        public void Clear()
        {
            _internal.Clear();
        }

        public bool Contains(KeyValuePair<string, T> item)
        {
            if (_internal.TryGetValue(SymbolCache.Get(item.Key), out T value))
            {
                return EqualityComparer<T>.Default.Equals(item.Value, value);
            }

            return false;
        }

        public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (arrayIndex < 0 || arrayIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            }

            if (array.Length - arrayIndex < Count)
            {
                throw new ArgumentException("arrayIndex invalid");
            }

            int count = _internal.Count;

            for (int i = 0; i < count; i++)
            {
                var element = _internal.ElementAt(i);

                if (element.Key.GetHashCode() >= 0)
                {
                    array[arrayIndex++] = KeyValuePair.Create(element.Key.Key, element.Value);
                }
            }

        }

        public bool Remove(KeyValuePair<string, T> item)
        {
            return _internal.Remove(SymbolCache.Get(item.Key), out T value);
        }

        public int Count
        {
            get
            {
                return _internal.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(string key, T value)
        {
            _internal.AddOrUpdate(SymbolCache.Get(key), value, (k, v) => value);
        }

        public bool ContainsKey(string key)
        {
            return _internal.ContainsKey(SymbolCache.Get(key));
        }

        public bool Remove(string key)
        {
            return _internal.Remove(SymbolCache.Get(key), out T value);
        }

        public bool TryGetValue(string key, out T value)
        {
            return _internal.TryGetValue(SymbolCache.Get(key), out value);
        }

        public T this[string key]
        {
            get
            {
                _internal.TryGetValue(SymbolCache.Get(key), out var value);
                return value;
            }
            set
            {
                _internal.AddOrUpdate(SymbolCache.Get(key), value, (k, v) => value);
            }
        }

        public ICollection<string> Keys
        {
            get
            {
                return _internal.Keys.Select(x => x.Key).ToList();
            }
        }

        public ICollection<T> Values
        {
            get
            {
                return _internal.Values.ToList();
            }
        }
    }
}
