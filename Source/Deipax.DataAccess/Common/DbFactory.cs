using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Data.Common;

namespace Deipax.DataAccess.Common
{
	public delegate IDb CreateDbDelegate(
		string name,
		string cs,
		string provider,
		Func<IDb, IDbConnection> factory = null);

	public static class DbFactory
	{
		public static CreateDbDelegate Override { get; set; }

		public static IDb Create(
			string name,
			string cs,
			string provider,
			Func<IDb, IDbConnection> factory = null)
		{
			if (Override != null)
			{
				return Override(
					name ?? string.Empty,
					cs ?? string.Empty,
					provider ?? string.Empty,
					factory ?? CreateDbConnection);
			}

			return new Db(
				name ?? string.Empty,
				cs ?? string.Empty,
				provider ?? string.Empty,
				factory ?? CreateDbConnection);
		}

		public static IDb CreateSqLite(
			string name,
			string cs,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, cs, "System.Data.SQLite", factory);
		}

		public static IDb CreateSqlServer(
			string name,
			string cs,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, cs, "System.Data.SqlClient", factory);
		}

		public static IDb CreateOracle(
			string name,
			string cs,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, cs, "Oracle.DataAccess.Client", factory);
		}

		public static IDb CreateManagedOracle(
			string name,
			string cs,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, cs, "Oracle.ManagedDataAccess.Client", factory);
		}

		#region Private Members
		private static IDbConnection CreateDbConnection(IDb db)
		{
			var con = DbProviderFactories
				.GetFactory(db.ProviderName)
				.CreateConnection();
			con.ConnectionString = db.ConnectionString;
			return con;
		}
		#endregion
	}
}