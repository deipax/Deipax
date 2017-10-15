using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;

namespace Integration.DataAccess
{
	[TestClass]
	public class IDbConnectionExtensionsTests
	{
		[TestMethod]
		public void CreateParameter()
		{
			SetupAndAssertClosedConnection(dbCon =>
			{
				var parameter = dbCon.CreateParameter(
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
			SetupAndAssertClosedConnection(dbCon =>
			{
				List<object> list = new List<object>()
				{
					1, 2
				};

				var parameters = dbCon.CreateParameters("MyBaseName", list);

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
		private static void SetupAndAssertClosedConnection(Action<IDbConnection> act)
		{
			using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
			{
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
				act(dbCon.GetConnection());
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
			}
		}
		#endregion
	}
}
