using Deipax.Core.Common;
using Deipax.DataAccess.Extensions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Common
{
    public class DynamicMap2
    {
        static DynamicMap2()
        {
            _cache = new ConcurrentDictionary<int, List<string>>();
        }

        #region Field Members
        private static ConcurrentDictionary<int, List<string>> _cache;
        #endregion

        #region Public Members
        public static Func<IDataRecord, DynamicRow> Create(IDataReader r)
        {
            var header = _cache.GetOrAdd(r.GetColumnHash(), x => CreateHeaders(r));
            return new Helper(new DynamicTable(header)).Create;
        }
        #endregion

        #region Private Members
        private static List<string> CreateHeaders(IDataReader r)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < r.FieldCount; i++)
            {
                list.Add(r.GetName(i));
            }

            return list;
        }
        #endregion

        #region Helpers
        class Helper
        {
            public Helper(DynamicTable table)
            {
                _table = table;
                _fieldCount = table.GetFieldCount();
            }

            private DynamicTable _table;
            private int _fieldCount;

            public DynamicRow Create(IDataRecord r)
            {
                object[] values = new object[_fieldCount];
                r.GetValues(values);
                return new DynamicRow(_table, values);
            }
        }
        #endregion
    }
}