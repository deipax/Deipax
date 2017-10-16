using Deipax.DataAccess.Common;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace Deipax.DataAccess.Interfaces
{
	public static class IDbConnectionExtensions
	{
		public static IDbDataParameter CreateParameter(
			this IDbConnection source,
			string name = null,
			object value = null,
			ParameterDirection? direction = default(ParameterDirection?),
			DbType? dbType = default(DbType?),
			int? size = default(int?))
		{
			using (var cmd = source.CreateCommand())
			{
				var p = cmd.CreateParameter();

				if (!string.IsNullOrEmpty(name))
				{
					p.ParameterName = name;
				}

				if (value != null)
				{
					p.Value = value;
				}

				if (direction.HasValue)
				{
					p.Direction = direction.Value;
				}

				if (dbType.HasValue)
				{
					p.DbType = dbType.Value;
				}

				if (size.HasValue)
				{
					p.Size = size.Value;
				}

				return p;
			}
		}

		public static IEnumerable<IDbDataParameter> CreateParameters(
			this IDbConnection source,
			string baseName,
			IEnumerable<object> values)
		{
			List<IDbDataParameter> list = new List<IDbDataParameter>();

			if (values != null)
			{
				var items = values.Where(x => x != null);

				for (int i = 0; i < items.Count(); i++)
				{
					list.Add(source.CreateParameter(
						baseName + i.ToString(CultureInfo.InvariantCulture),
						items.ElementAtOrDefault(i)));
				}
			}

			return list;
		}

		internal static void OpenSafe(
			this IDbConnection source,
			IDb db)
		{
			if (source.State != ConnectionState.Open)
			{
				lock (source)
				{
					if (source.State != ConnectionState.Open)
					{
						using (var timer = OpenTimer.Create(db))
						{
							source.Open();
						}
					}
				}
			}
		}
	}
}