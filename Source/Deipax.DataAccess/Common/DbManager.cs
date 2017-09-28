using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Common
{
	public class DbManager
	{
		#region Field Members
		private static Lazy<IReadOnlyDictionary<string, Db>> _connections = new Lazy<IReadOnlyDictionary<string, Db>>(() =>
		{
			return ConfigurationManager
				.ConnectionStrings
				.Cast<ConnectionStringSettings>()
				.Select(x => Db.Create(x.Name, x.ProviderName, x.ConnectionString))
				.Where(x => x != null)
				.ToDictionary(x => x.Name, x => x);
		},
		LazyThreadSafetyMode.ExecutionAndPublication);
		#endregion

		#region Public Members
		public static IDb Get(string name)
		{
			if (_connections.Value.ContainsKey(name))
			{
				return _connections.Value[name];
			}

			return null;
		}

		public static IEnumerable<IDb> GetAll()
		{
			return _connections.Value.Values;
		}
		#endregion
	}
}