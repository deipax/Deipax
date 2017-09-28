using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Deipax.Core.Common;
using Deipax.Core.Interfaces;

namespace Deipax.DataAccess.Common
{
	public class DataRecordMap<T>
	{
		static DataRecordMap()
		{
			_init = ObjectActivator<T>.Create;
		}

		private DataRecordMap()
		{
		}

		#region Field Members
		private static Func<T> _init;
		#endregion

		private List<Action<object, IDataRecord>> Setters;

		#region Public Members
		public static DataRecordMap<T> Create(IDataReader r)
		{
			DataRecordMap<T> map = new DataRecordMap<T>()
			{
				Setters = new List<Action<object, IDataRecord>>()
			};

			var setters = ModelAccess<T>.Setters;

			for (var i = 0; i < r.FieldCount; i++)
			{
				var columnName = setters
					.Keys
					.Where(x => string.Equals(x, r.GetName(i), StringComparison.OrdinalIgnoreCase))
					.FirstOrDefault();

				if (!string.IsNullOrEmpty(columnName))
				{
					map.Setters.Add(SetHelper.Create(i, setters[columnName]).Set);
				}
			}

			return map;
		}

		public T From(IDataRecord r)
		{
			object retVal = _init();
			this.Setters.ForEach(x => x(retVal, r));
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