using System;
using System.Collections.Generic;

namespace Deipax.Core.Common
{
    public class DynamicTable
    {
        public DynamicTable(
            string[] fields = null)
        {
            _fields = fields ?? Array.Empty<string>();
            _lookup = new Dictionary<string, int>(_fields.Length);

            for (int i = _fields.Length - 1; i >= 0; i--)
            {
                string key = _fields[i];
                if (!string.IsNullOrEmpty(key)) _lookup[key] = i;
            }
        }

        #region Field Members
        private string[] _fields;
        private readonly Dictionary<string, int> _lookup;
        #endregion

        #region Public Members
        public int GetIndex(string name)
        {
            return _lookup.TryGetValue(name, out int result)
                ? result
                : -1;
        }

        public bool FieldExists(string name)
        {
            return _lookup.ContainsKey(name);
        }

        public IEnumerable<string> GetNames()
        {
            return _fields;
        }

        public int GetFieldCount()
        {
            return _fields.Length;
        }

        public int AddField(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            if (_lookup.ContainsKey(name)) throw new InvalidOperationException("Field already exists: " + name);
            int oldLen = _fields.Length;
            Array.Resize(ref _fields, oldLen + 1);
            _fields[oldLen] = name;
            _lookup[name] = oldLen;
            return oldLen;
        }
        #endregion
    }
}