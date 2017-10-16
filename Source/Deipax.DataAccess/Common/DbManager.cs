using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;

namespace Deipax.DataAccess.Common
{
	public static class DbManager
	{
		static DbManager()
		{
			_connections = Initialize();
		}

		#region Field Members
		private static Lazy<IReadOnlyDictionary<string, IDb>> _connections;
		#endregion

		#region Public Members
		public static void Clear()
		{
			_connections = Initialize();
		}

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

		#region Private Members
		private static Lazy<IReadOnlyDictionary<string, IDb>> Initialize()
		{
			return new Lazy<IReadOnlyDictionary<string, IDb>>(() =>
			{
				return ConfigurationManager
					.ConnectionStrings
					.Cast<ConnectionStringSettings>()
					.Select(x => DbFactory.Create(x.Name, x.ConnectionString, x.ProviderName))
					.Where(x => x != null)
					.ToDictionary(x => x.Name, x => x);
			},
			LazyThreadSafetyMode.ExecutionAndPublication);
		}
		#endregion
	}
}