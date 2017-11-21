using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Common
{
    public class DataRecordMap<T>
    {
        private DataRecordMap(List<Action<object, IDataRecord>> setters)
        {
            _setters = setters;
        }

        private DataRecordMap()
        {
        }

        #region Field Members
        private static Func<T> _init = ObjectActivator<T>.Create;
        private List<Action<object, IDataRecord>> _setters;
        #endregion

        #region Public Members
        public static DataRecordMap<T> Create(IDataReader r)
        {
            List<Action<object, IDataRecord>> tmp = new List<Action<object, IDataRecord>>();
            var setters = ModelAccess<T>.Setters;
            int fieldCount = r.FieldCount;

            for (var i = 0; i < fieldCount; i++)
            {
                ISetter setter;
                if (setters.TryGetValue(r.GetName(i), out setter) && setter != null)
                {
                    tmp.Add(SetHelper.Create(i, setter).Set);
                }
            }

            return new DataRecordMap<T>(tmp);
        }

        public T From(IDataRecord r)
        {
            object retVal = _init();
            _setters.ForEach(x => x(retVal, r));
            return (T)retVal;
        }
        #endregion
    }

    class SetHelper
    {
        private SetHelper()
        {
        }

        #region Field Members
        private int _index;
        private Action<object, object> _set;
        #endregion

        #region Public Members
        public static SetHelper Create(int index, ISetter setter)
        {
            return new SetHelper()
            {
                _index = index,
                _set = setter.Set
            };
        }

        public void Set(object item, IDataRecord r)
        {
            _set(item, r.GetValue(_index));
        }
        #endregion
    }
}