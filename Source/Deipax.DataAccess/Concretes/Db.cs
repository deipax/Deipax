using System;
using System.Data;
using System.Data.Common;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Concretes
{
	public class Db : IDb
	{
		private Db()
		{
		}

		#region Public Members
		public static IDbConnection CreateDbConnection(IDb db)
		{
			var con = DbProviderFactories
				.GetFactory(db.ProviderName)
				.CreateConnection();
			con.ConnectionString = db.ConnectionString;
			return con;
		}

		public static Db Create(
			string name,
			string providerName,
			string cs,
			Func<IDb, IDbConnection> factory = null)
		{
			return new Db()
			{
				Name = name,
				ProviderName = providerName,
				ConnectionString = cs ?? string.Empty,
				ConnectionFactory = factory ?? CreateDbConnection
			};
		}
		
		public static Db Create(
			IDb db,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(db.Name, db.ProviderName, db.ConnectionString, factory);
		}

		public static Db CreateSqLite(
			string name,
			string cs = null,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, "System.Data.SQLite", cs, factory);
		}

		public static Db CreateSqlServer(
			string name,
			string cs = null,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, "System.Data.SqlClient", cs, factory);
		}

		public static Db CreateOracle(
			string name,
			string cs = null,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, "Oracle.DataAccess.Client", cs, factory);
		}

		public static Db CreateManagedOracle(
			string name,
			string cs = null,
			Func<IDb, IDbConnection> factory = null)
		{
			return Create(name, "Oracle.ManagedDataAccess.Client", cs);
		}
		#endregion

		#region IDb Members
		public string ConnectionString { get; private set; }
		public string Name { get; private set; }
		public string ProviderName { get; private set; }
		public Func<IDb, IDbConnection> ConnectionFactory { get; private set; }

		public IDbCon CreateDbCon()
		{
			return new DbCon(this, this.ConnectionFactory);
		}

		public IDb CreateDb(
			string name = null, 
			string cs = null, 
			string provider = null, 
			Func<IDb, IDbConnection> factory = null)
		{
			return new Db()
			{
				Name = name ?? this.Name,
				ConnectionString = cs ?? this.ConnectionString,
				ProviderName = provider ?? this.ProviderName,
				ConnectionFactory = factory ?? this.ConnectionFactory
			};
		}
		#endregion
	}
}