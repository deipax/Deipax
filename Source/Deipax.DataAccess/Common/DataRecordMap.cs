using System;
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
                    tmp.Add(new SetHelper<T>()
                    {
                        Index = i,
                        Set = setter.SetFromRecord
                    });
                }
            }

            return new DataRecordMap<T>(tmp);
        }

        public T From(IDataRecord r)
        {
            T retVal = new T();

            for (int i = 0; i < _count; i++)
            {
                var setter = _setters[i];
                setter.Set(ref retVal, r, setter.Index);
            }

            return retVal;
        }
        #endregion
    }

    struct SetHelper<T>
    {
        public int Index;
        public SetFromRecord<T> Set;
    }
}