using System;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Common
{
	public class DynamicMap
	{
		private DynamicMap()
		{
		}

		private Dictionary<int, string> FieldMap;

		#region Public Members
		public static DynamicMap Create(IDataReader r)
		{
			DynamicMap map = new DynamicMap()
			{
				FieldMap = new Dictionary<int, string>(r.FieldCount)
			};

			for (int i = 0; i < r.FieldCount; i++)
			{
				map.FieldMap.Add(i, r.GetName(i));
			}

			return map;
		}

		public dynamic From(IDataRecord r)
		{
			DynamicDictionary d = new DynamicDictionary(FieldMap.Keys.Count);

			foreach (var key in FieldMap.Keys)
			{
				var value = r.GetValue(key);
				value = DBNull.Value.Equals(value) ? null : value;
				d.Add(FieldMap[key], value);
			}

			return d;
		}
		#endregion
	}
}