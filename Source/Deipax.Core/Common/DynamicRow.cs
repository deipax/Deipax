using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Core.Common
{
    public class DynamicRow :
        IDynamicMetaObjectProvider,
        IDictionary<string, object>,
        IReadOnlyDictionary<string, object>
    {
        public DynamicRow(
            DynamicTable table = null,
            object[] values = null)
        {
            _table = table ?? new DynamicTable();

            var fieldCount = _table.GetFieldCount();

            _values = values != null && values.Length == fieldCount
                ? values
                : new object[fieldCount];
        }

        #region Field Members
        private DynamicTable _table;
        private object[] _values;
        #endregion

        #region Public Members
        public object SetValue(
            string key,
            object value)
        {
            if (key == null)
            {
                return null;
            }

            int index = _table.GetIndex(key);

            if (index < 0)
            {
                index = _table.AddField(key);

                int oldLength = _values.Length;

                if (oldLength <= index)
                {
                    Array.Resize(ref _values, _table.GetFieldCount());

                    for (int i = oldLength; i < _values.Length; i++)
                    {
                        _values[i] = Null.Value;
                    }
                }
            }

            return _values[index] = value;
        }

        public object GetValue(
            string key)
        {
            object val = default(object);
            TryGetValue(key, out val);
            return val;
        }
        #endregion

        #region IDynamicMetaObjectProvider Members
        DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
        {
            return new DynamicRowMetaObjectProvider(parameter, BindingRestrictions.Empty, this);
        }
        #endregion

        #region IDictionary Members
        ICollection<string> IDictionary<string, object>.Keys
        {
            get
            {
                return this.Select(kv => kv.Key).ToArray();
            }
        }

        ICollection<object> IDictionary<string, object>.Values
        {
            get
            {
                return this.Select(kv => kv.Value).ToArray();
            }
        }

        int ICollection<KeyValuePair<string, object>>.Count
        {
            get
            {
                int count = 0;

                for (int i = 0; i < _values.Length; i++)
                {
                    if (!(_values[i] is Null))
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        bool ICollection<KeyValuePair<string, object>>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        object IDictionary<string, object>.this[string key]
        {
            get
            {
                TryGetValue(key, out object val);
                return val;
            }
            set
            {
                SetValue(key, value);
            }
        }

        void IDictionary<string, object>.Add(
            string key,
            object value)
        {
            SetValue(key, value);
        }

        bool IDictionary<string, object>.ContainsKey(
            string key)
        {
            int index = _table.GetIndex(key);

            if (index < 0 || index >= _values.Length || _values[index] is Null)
            {
                return false;
            }

            return true;
        }

        bool IDictionary<string, object>.Remove(
            string key)
        {
            int index = _table.GetIndex(key);

            if (index < 0 || index >= _values.Length || _values[index] is Null)
            {
                return false;
            }

            _values[index] = Null.Value;

            return true;
        }

        public bool TryGetValue(
            string key,
            out object value)
        {
            var index = _table.GetIndex(key);

            if (index < 0)
            {
                value = null;
                return false;
            }

            value = index < _values.Length ? _values[index] : null;

            if (value is Null)
            {
                value = null;
                return false;
            }

            return true;
        }

        void ICollection<KeyValuePair<string, object>>.Add(
            KeyValuePair<string, object> item)
        {
            IDictionary<string, object> dic = this;
            dic.Add(item.Key, item.Value);
        }

        void ICollection<KeyValuePair<string, object>>.Clear()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                _values[i] = Null.Value;
            }
        }

        bool ICollection<KeyValuePair<string, object>>.Contains(
            KeyValuePair<string, object> item)
        {
            return TryGetValue(item.Key, out object value) && Equals(value, item.Value);
        }

        void ICollection<KeyValuePair<string, object>>.CopyTo(
            KeyValuePair<string, object>[] array,
            int arrayIndex)
        {
            foreach (var kv in this)
            {
                array[arrayIndex++] = kv;
            }
        }

        bool ICollection<KeyValuePair<string, object>>.Remove(
            KeyValuePair<string, object> item)
        {
            IDictionary<string, object> dic = this;
            return dic.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            var names = _table.GetNames();

            for (var i = 0; i < names.Count(); i++)
            {
                object value = i < _values.Length ? _values[i] : null;

                if (!(value is Null))
                {
                    yield return new KeyValuePair<string, object>(names.ElementAt(i), value);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        #region IReadOnlyDictionary Members
        IEnumerable<string> IReadOnlyDictionary<string, object>.Keys
        {
            get
            {
                return this.Select(kv => kv.Key);
            }
        }

        IEnumerable<object> IReadOnlyDictionary<string, object>.Values
        {
            get
            {
                return this.Select(kv => kv.Value);
            }
        }

        int IReadOnlyCollection<KeyValuePair<string, object>>.Count
        {
            get
            {
                return _values.Count(t => !(t is Null));
            }
        }

        object IReadOnlyDictionary<string, object>.this[string key]
        {
            get
            {
                TryGetValue(key, out object val);
                return val;
            }
        }

        bool IReadOnlyDictionary<string, object>.ContainsKey(string key)
        {
            int index = _table.GetIndex(key);

            return index >= 0 &&
                   index < _values.Length &&
                   !(_values[index] is Null);
        }
        #endregion
    }
}