using System.Collections.Generic;
using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using System.Data;

namespace Deipax.DataAccess.Common
{
    public class DataRecordMap<T> where T : new()
    {
        private DataRecordMap(List<SetHelper<T>> setters)
        {
            _setters = setters;
            _count = setters.Count;
        }

        private DataRecordMap()
        {
        }

        #region Field Members
        private List<SetHelper<T>> _setters;
        private int _count;
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
                    tmp.Add(SetHelper<T>.Create(i, setter));
                }
            }

            return new DataRecordMap<T>(tmp);
        }

        public T From(IDataRecord r)
        {
            T retVal = new T();

            for (int i = 0; i < _count; i++)
            {
                _setters[i].Set(ref retVal, r);
            }

            return retVal;
        }
        #endregion
    }

    struct SetHelper<T>
    {
        #region Field Members
        private int _index;
        private Set<T, object> _set;
        #endregion

        #region Public Members
        public static SetHelper<T> Create(int index, ISetter<T> setter)
        {
            return new SetHelper<T>()
            {
                _index = index,
                _set = setter.GetDelegate<object>()
            };
        }

        public void Set(ref T item, IDataRecord r)
        {
            _set(ref item, r.GetValue(_index));
        }
        #endregion
    }
}