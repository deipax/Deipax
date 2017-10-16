using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Integration.DataAccess
{
	[TestClass]
	public class DbFactoryTests
	{
		[TestMethod]
		public void Override()
		{
			try
			{
				DbFactory.Override = null;

				var db1 = DbFactory.Create("jon", "cs", "pro");

				Assert.IsNotNull(db1);

				DbFactory.Override = (name, cs, provider, func) =>
				{
					return new DbHelperClass()
					{
						Name = name,
						ConnectionFactory = func,
						ConnectionString = cs,
						ProviderName = provider
					};
				};

				var db2 = DbFactory.Create("jon", "cs", "pro");

				Assert.IsInstanceOfType(db2, typeof(DbHelperClass));
				Assert.AreEqual(db2.Name, "jon");
				Assert.AreEqual(db2.ConnectionFactory, db1.ConnectionFactory);
				Assert.AreEqual(db2.ConnectionString, "cs");
				Assert.AreEqual(db2.ProviderName, "pro");
			}
			finally
			{
				DbFactory.Override = null;
			}
		}

		[TestMethod]
		public void Create()
		{
			Func<IDb, IDbConnection> func = ConnectionFactory;

			var db = DbFactory.Create(
				"name",
				"cs",
				"provider",
				func);

			Assert.IsTrue(db.Name == "name");
			Assert.IsTrue(db.ProviderName == "provider");
			Assert.IsTrue(db.ConnectionString == "cs");
			Assert.AreSame(db.ConnectionFactory, func);
		}

		[TestMethod]
		public void CreateManagedOracle()
		{
			Func<IDb, IDbConnection> func = ConnectionFactory;

			var db = DbFactory.CreateManagedOracle(
				"name",
				"cs",
				func);

			Assert.IsTrue(db.Name == "name");
			Assert.IsTrue(db.ProviderName == "Oracle.ManagedDataAccess.Client");
			Assert.IsTrue(db.ConnectionString == "cs");
			Assert.AreSame(db.ConnectionFactory, func);
		}

		[TestMethod]
		public void CreateOracle()
		{
			Func<IDb, IDbConnection> func = ConnectionFactory;

			var db = DbFactory.CreateOracle(
				"name",
				"cs",
				func);

			Assert.IsTrue(db.Name == "name");
			Assert.IsTrue(db.ProviderName == "Oracle.DataAccess.Client");
			Assert.IsTrue(db.ConnectionString == "cs");
			Assert.AreSame(db.ConnectionFactory, func);
		}

		[TestMethod]
		public void CreateSqLite()
		{
			Func<IDb, IDbConnection> func = ConnectionFactory;

			var db = DbFactory.CreateSqLite(
				"name",
				"cs",
				func);

			Assert.IsTrue(db.Name == "name");
			Assert.IsTrue(db.ProviderName == "System.Data.SQLite");
			Assert.IsTrue(db.ConnectionString == "cs");
			Assert.AreSame(db.ConnectionFactory, func);
		}

		[TestMethod]
		public void CreateSqlServer()
		{
			Func<IDb, IDbConnection> func = ConnectionFactory;

			var db = DbFactory.CreateSqlServer(
				"name",
				"cs",
				func);

			Assert.IsTrue(db.Name == "name");
			Assert.IsTrue(db.ProviderName == "System.Data.SqlClient");
			Assert.IsTrue(db.ConnectionString == "cs");
			Assert.AreSame(db.ConnectionFactory, func);
		}

		#region Private Members
		private IDbConnection ConnectionFactory(IDb db)
		{
			return null;
		}
		#endregion

		#region Helper
		class DbHelperClass : IDb
		{
			public Func<IDb, IDbConnection> ConnectionFactory { get; set; }
			public string ConnectionString { get; set; }
			public string Name { get; set; }
			public string ProviderName { get; set; }
		}
		#endregion
	}
}
