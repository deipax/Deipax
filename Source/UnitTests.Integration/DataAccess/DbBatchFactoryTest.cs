using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using UnitTests.Common;

namespace Integration.DataAccess
{
	[TestClass]
	public class DbBatchFactoryTest
	{
		[TestMethod]
		public void Create()
		{
			DbBatchFactory.Override = null;
			var dbBatch = DbBatchFactory.Create(DbHelper.GetNorthwind());
			Assert.IsNotNull(dbBatch);
		}

		[TestMethod]
		public void Override()
		{
			try
			{
				DbConFactory.Override = null;
				var dbBatch = DbBatchFactory.Create(DbHelper.GetNorthwind());
				Assert.IsNotNull(dbBatch);
				Assert.IsNotInstanceOfType(dbBatch, typeof(DbBatchHelperClass));

				DbBatchFactory.Override = (db) =>
				{
					return new DbBatchHelperClass()
					{
						Db = db
					};
				};

				var dbBatch2 = DbBatchFactory.Create(DbHelper.GetNorthwind());

				Assert.IsNotNull(dbBatch2);
				Assert.IsInstanceOfType(dbBatch2, typeof(DbBatchHelperClass));
			}
			finally
			{
				DbConFactory.Override = null;
			}
		}

		#region Helpers
		class DbBatchHelperClass : IDbBatch
		{
			public IDbConnection Connection { get; set; }
			public IDb Db { get; set; }
			public IDbTransaction Transaction { get; set; }
		}
		#endregion
	}
}
