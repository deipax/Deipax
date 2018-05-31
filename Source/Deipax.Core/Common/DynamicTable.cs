using System.Collections.Generic;
using System.Linq;

namespace Deipax.Core.Common
{
    public class DynamicTable
    {
        public DynamicTable(
            IEnumerable<string> fields = null)
        {
            _fields = (fields ?? new string[0])
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct()
                .ToList();

            int count = 0;

            _lookup = _fields
                .ToDictionary(x => x, x => count++);
        }

        #region Field Members
        private List<string> _fields;
        private Dictionary<string, int> _lookup;
        #endregion

        #region Public Members
        public int GetIndex(string name)
        {
            if (!string.IsNullOrEmpty(name) &&
                _lookup.TryGetValue(name, out int result))
            {
                return result;
            }

            return -1;
        }

        public bool FieldExists(string name)
        {
            return name != null &&
                   _lookup.ContainsKey(name);
        }

        public IEnumerable<string> GetNames()
        {
            return _fields;
        }

        public int GetFieldCount()
        {
            return _fields.Count();
        }

        public int AddField(string name)
        {
            if (!string.IsNullOrEmpty(name) &&
                !_lookup.ContainsKey(name))
            {
                int count = _fields.Count;
                _fields.Add(name);
                _lookup.Add(name, count);
            }

            return _fields.Count - 1;
        }
        #endregion
    }
}