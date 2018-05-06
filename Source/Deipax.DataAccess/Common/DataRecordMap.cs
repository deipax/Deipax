using System;
using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Common
{
    public class DataRecordMap<T> where T : new()
    {
        private DataRecordMap(List<SetHelper<T>> setters)
        {
            _setters = setters;
        }

        private DataRecordMap()
        {
        }

        #region Field Members
        private List<SetHelper<T>> _setters;
        #endregion

        #region Public Members
        public static DataRecordMap<T> Create(IDataReader r)
        {
            var setters = ModelAccess<T>.Setters;
            int fieldCount = r.FieldCount;
            List<SetHelper<T>> tmp = new List<SetHelper<T>>(fieldCount);

            for (var i = 0; i < fieldCount; i++)
            {
                if (setters.TryGetValue(r.GetName(i), out ISetter<T> setter) &&
                    setter != null)
                {
                    tmp.Add(new SetHelper<T>(i, setter.GetDelegate<object>()));
                }
            }

            return new DataRecordMap<T>(tmp);
        }

        public T From(IDataRecord r)
        {
            T retVal = new T();

            for (int i = 0; i < _setters.Count; i++)
            {
                _setters[i].Set(ref retVal, r);
            }

            return retVal;
        }
        #endregion
    }

    class SetHelper<T>
    {
        public SetHelper(int index, Set<T, object> set)
        {
            _index = index;
            _set = set;
        }

        #region Fields
        private int _index;
        private Set<T, object> _set;
        #endregion

        #region Public Members
        public void Set(ref T instance, IDataRecord r)
        {
            object x = r.GetValue(_index);

            if (!DBNull.Value.Equals(x) && x != null)
            {
                _set(ref instance, x);
            }
        }
        #endregion
    }
}