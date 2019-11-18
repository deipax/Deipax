using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests.Common
{
    public class ItemGenerator<T>
    {
        public ItemGenerator(
            Func<T> initializer, 
            IEqualityComparer<T> equalityComparer)
        {
            _initializer = initializer;
            Comparer = equalityComparer;
        }

        #region Field Members
        private readonly Func<T> _initializer;
        private readonly List<T> _uniqueItems = new List<T>();
        #endregion

        #region Public Members
        public IEqualityComparer<T> Comparer { get; private set; }

        public IEnumerable<T> GetItems(int count)
        {
            return Enumerable
                .Range(0, count)
                .Select(x => GetItem())
                .ToList();
        }

        public T GetItem()
        {
            T item;

            while(true)
            {
                item =  _initializer();

                if (!_uniqueItems.Contains(item, Comparer))
                {
                    _uniqueItems.Add(item);
                    break;
                }
            }

            return item;
        }
        #endregion
    }
}
