using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;
using UnitTests.Integration.Concretes;

namespace Integration.DataAccess
{
	[TestClass]
	public class IDbBatchExtensionsTests
	{
		[TestMethod]
		public void SetTransaction()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				var trans = new TestTransaction();
				Assert.IsTrue(dbCmd.Transaction == null);
				var dbCmd2 = dbCmd.SetTransaction(trans);
				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Transaction == trans);
			});
		}

		[TestMethod]
		public void SetConnection()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(dbCmd.Connection != null);
				var dbCmd2 = dbCmd.SetConnection(null);
				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Connection == null);
			});
		}

		[TestMethod]
		public void CreateParameter()
		{
			SetupAndAssertClosedConnection(dbBatch =>
			{
				var parameter = dbBatch.CreateParameter(
					"John",
					1,
					ParameterDirection.Input,
					DbType.Int32,
					10);

				Assert.IsTrue(parameter.ParameterName == "John");
				Assert.IsTrue(parameter.Value is int);
				Assert.IsTrue(((int)parameter.Value) == 1);
				Assert.IsTrue(parameter.Direction == ParameterDirection.Input);
				Assert.IsTrue(parameter.DbType == DbType.Int32);
				Assert.IsTrue(parameter.Size == 10);
			});
		}

		[TestMethod]
		public void CreateParameters()
		{
			SetupAndAssertClosedConnection(dbBatch =>
			{
				List<object> list = new List<object>()
				{
					1, 2
				};

				var parameters = dbBatch.CreateParameters("MyBaseName", list);

				Assert.IsTrue(parameters != null);
				Assert.IsTrue(parameters.Count() == list.Count);

				for (int i = 0; i < list.Count; i++)
				{
					var p = parameters.ElementAt(i);

					Assert.IsTrue(p.ParameterName.IndexOf("MyBaseName") >= 0);
					Assert.IsTrue(p.Value == list[i]);
				}
			});
		}

		#region Private Members
		private static void SetupAndAssertClosedConnection(Action<IDbBatch> act)
		{
			using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
			{
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
				act(dbCon.CreateDbBatch());
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
			}
		}

		private static void SetupAndAssert(Action<IDbBatch> act)
		{
			using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
			{
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
				act(dbCon.CreateDbBatch());
			}
		}
		#endregion
	}
}
