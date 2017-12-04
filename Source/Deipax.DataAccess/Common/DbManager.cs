using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Deipax.DataAccess.Common
{
    public static class DbManager
	{
		static DbManager()
		{
            SetInitializer(DbConfig.DbInitializer);
        }

		#region Field Members
		private static Lazy<IReadOnlyDictionary<string, IDb>> _connections;
		#endregion

		#region Public Members
		public static void Clear()
		{
            SetInitializer(DbConfig.DbInitializer);
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
        public static void SetInitializer(Func<IReadOnlyDictionary<string, IDb>> init)
        {
            _connections = new Lazy<IReadOnlyDictionary<string, IDb>>(init, LazyThreadSafetyMode.ExecutionAndPublication);
        }
		#endregion
	}
}