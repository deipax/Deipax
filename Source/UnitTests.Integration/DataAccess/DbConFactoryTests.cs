using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using UnitTests.Common;

namespace Integration.DataAccess
{
	[TestClass]
	public class DbConFactoryTests
	{
		[TestMethod]
		public void Create()
		{
			DbConFactory.Override = null;
			var dbCon = DbConFactory.Create(DbHelper.GetNorthwind());
			Assert.IsNotNull(dbCon);
		}

		[TestMethod]
		public void Override()
		{
			try
			{
				DbConFactory.Override = null;
				var dbCon1 = DbConFactory.Create(DbHelper.GetNorthwind());
				Assert.IsNotNull(dbCon1);
				Assert.IsNotInstanceOfType(dbCon1, typeof(DbConHelperClass));

				DbConFactory.Override = (db) =>
				{
					return new DbConHelperClass()
					{
						Db = db
					};
				};

				var dbCon2 = DbConFactory.Create(DbHelper.GetNorthwind());

				Assert.IsNotNull(dbCon2);
				Assert.IsInstanceOfType(dbCon2, typeof(DbConHelperClass));
			}
			finally
			{
				DbConFactory.Override = null;
			}
		}

		#region Helper
		class DbConHelperClass : IDbCon
		{
			public IDb Db { get; set; }

			public void Dispose()
			{
				throw new NotImplementedException();
			}

			public IDbConnection GetConnection()
			{
				throw new NotImplementedException();
			}
		}
		#endregion
	}
}
