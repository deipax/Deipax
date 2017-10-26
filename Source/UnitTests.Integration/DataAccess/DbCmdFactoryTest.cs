using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data;
using UnitTests.Common;

namespace Integration.DataAccess
{
	[TestClass]
	public class DbCmdFactoryTest
	{
		[TestMethod]
		public void Create()
		{
			DbCmdFactory.Override = null;
			var dbCmd = DbCmdFactory.Create(DbHelper.GetNorthwind());
			Assert.IsNotNull(dbCmd);
		}

		[TestMethod]
		public void Override()
		{
			try
			{
				DbConFactory.Override = null;
				var dbCmd = DbCmdFactory.Create(DbHelper.GetNorthwind());
				Assert.IsNotNull(dbCmd);
				Assert.IsNotInstanceOfType(dbCmd, typeof(DbCmdHelperClass));

				DbCmdFactory.Override = (db) =>
				{
					return new DbCmdHelperClass()
					{
						Db = db
					};
				};

				var dbCmd2 = DbCmdFactory.Create(DbHelper.GetNorthwind());

				Assert.IsNotNull(dbCmd2);
				Assert.IsInstanceOfType(dbCmd2, typeof(DbCmdHelperClass));
			}
			finally
			{
			    DbCmdFactory.Override = null;
			}
		}

		#region Helpers
		class DbCmdHelperClass : IDbCmd
		{
			public CommandType CommandType { get; set; }
			public IDbConnection Connection { get; set; }
			public IDb Db { get; set; }
			public string Name { get; set; }
			public ICollection<IDbDataParameter> Parameters { get; set; }
			public string Sql { get; set; }
			public int Timeout { get; set; }
			public IDbTransaction Transaction { get; set; }
		}
		#endregion
	}
}
