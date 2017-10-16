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
	}
}
