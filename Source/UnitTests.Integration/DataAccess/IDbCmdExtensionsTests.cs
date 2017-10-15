using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;
using UnitTests.Integration.Concretes;
using UnitTests.Integration.DataAccess;

namespace Integration.DataAccess
{
	[TestClass]
	public class IDbCmdExtensionsTests
	{
		[TestMethod]
		public void SetCommandType()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(dbCmd.CommandType == CommandType.Text);
				var dbCmd2 = dbCmd.SetCommandType(CommandType.StoredProcedure);
				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.CommandType == CommandType.StoredProcedure);
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
		public void SetTimeout()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(dbCmd.Timeout <= 0);
				var dbCmd2 = dbCmd.SetTimeout(1000);
				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Timeout == 1000);
			});
		}

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
		public void SetName()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(string.IsNullOrEmpty(dbCmd.Name));
				var dbCmd2 = dbCmd.SetName("Bill");
				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Name == "Bill");
			});
		}

		[TestMethod]
		public void SetSql()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(string.IsNullOrEmpty(dbCmd.Sql));
				var dbCmd2 = dbCmd.SetSql("Bill");
				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Sql == "Bill");
			});
		}

		[TestMethod]
		public void AddParameter_Test1()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == 0);

				var dbCmd2 = dbCmd.AddParameter(
					"John",
					1,
					ParameterDirection.Input,
					DbType.Int32,
					10);

				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == 1);

				var parameter = dbCmd.Parameters.ElementAt(0);

				Assert.IsTrue(parameter.ParameterName == "John");
				Assert.IsTrue(parameter.Value is int);
				Assert.IsTrue(((int)parameter.Value) == 1);
				Assert.IsTrue(parameter.Direction == ParameterDirection.Input);
				Assert.IsTrue(parameter.DbType == DbType.Int32);
				Assert.IsTrue(parameter.Size == 10);
			});
		}

		[TestMethod]
		public void AddParameter_Test2()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == 0);

				var parameter = dbCmd.Connection.CreateParameter();

				var dbCmd2 = dbCmd.AddParameter(parameter);

				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == 1);

				Assert.IsTrue(dbCmd.Parameters.ElementAt(0) == parameter);
			});
		}

		[TestMethod]
		public void AddParameters_Test1()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == 0);

				List<IDbDataParameter> list = new List<IDbDataParameter>()
				{
					dbCmd.Connection.CreateParameter(),
					dbCmd.Connection.CreateParameter(),
				};

				var dbCmd2 = dbCmd.AddParameters(list);

				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == list.Count);

				for (int i = 0; i < list.Count; i++)
				{
					Assert.IsTrue(dbCmd.Parameters.ElementAt(i) == list[i]);
				}
			});
		}

		[TestMethod]
		public void AddParameters_Test2()
		{
			SetupAndAssertClosedConnection(dbCmd =>
			{
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == 0);

				List<object> list = new List<object>()
				{
					1, 2
				};

				var dbCmd2 = dbCmd.AddParameters("MyBaseName", list);

				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Parameters != null);
				Assert.IsTrue(dbCmd.Parameters.Count == list.Count);

				for (int i = 0; i < list.Count; i++)
				{
					var p = dbCmd.Parameters.ElementAt(i);

					Assert.IsTrue(p.ParameterName.IndexOf("MyBaseName") >= 0);
					Assert.IsTrue(p.Value == list[i]);
				}
			});
		}

		[TestMethod]
		public void Open()
		{
			SetupAndAssert(dbCmd =>
			{
				Assert.IsTrue(dbCmd.Connection.State == ConnectionState.Closed);
				var dbCmd2 = dbCmd.Open();
				Assert.IsTrue(dbCmd == dbCmd2);
				Assert.IsTrue(dbCmd.Connection.State == ConnectionState.Open);
			});
		}

		[TestMethod]
		public void AsDynamicEnumerable()
		{
			SetupAndAssert(dbCmd =>
			{
				IEnumerable<dynamic> result = dbCmd
				.SetCommandType(CommandType.Text)
				.SetSql(@"select * from main.[Category]")
				.AsDynamicEnumerable();

				Assert.IsTrue(result != null);
				Assert.IsTrue(result.Count() > 0);

				foreach (dynamic item in result)
				{
					Assert.IsTrue(item.Id is Int64);
					Assert.IsTrue(item.CategoryName is string);
					Assert.IsTrue(item.Description is string);

					Assert.IsTrue(item.Id >= 0);
					Assert.IsTrue(!string.IsNullOrEmpty(item.CategoryName));
					Assert.IsTrue(!string.IsNullOrEmpty(item.Description));
				}
			});
		}

		[TestMethod]
		public void AsDynamicList()
		{
			SetupAndAssert(dbCmd =>
			{
				List<dynamic> result = dbCmd
				.SetCommandType(CommandType.Text)
				.SetSql(@"select * from main.[Category]")
				.AsDynamicList();

				Assert.IsTrue(result != null);
				Assert.IsTrue(result.Count() > 0);

				foreach (dynamic item in result)
				{
					Assert.IsTrue(item.Id is Int64);
					Assert.IsTrue(item.CategoryName is string);
					Assert.IsTrue(item.Description is string);

					Assert.IsTrue(item.Id >= 0);
					Assert.IsTrue(!string.IsNullOrEmpty(item.CategoryName));
					Assert.IsTrue(!string.IsNullOrEmpty(item.Description));
				}
			});
		}

		[TestMethod]
		public void AsEnumerable()
		{
			SetupAndAssert(dbCmd =>
			{
				IEnumerable<CategoryAsClass> result = dbCmd
				.SetCommandType(CommandType.Text)
				.SetSql(@"select * from main.[Category]")
				.AsEnumerable<CategoryAsClass>();

				Assert.IsTrue(result != null);
				Assert.IsTrue(result.Count() > 0);

				foreach (CategoryAsClass item in result)
				{
					Assert.IsTrue(item.Id >= 0);
					Assert.IsTrue(!string.IsNullOrEmpty(item.CategoryName));
					Assert.IsTrue(!string.IsNullOrEmpty(item.Description));
				}
			});
		}

		[TestMethod]
		public void AsList()
		{
			SetupAndAssert(dbCmd =>
			{
				IEnumerable<CategoryAsStruct> result = dbCmd
				.SetCommandType(CommandType.Text)
				.SetSql(@"select * from main.[Category]")
				.AsList<CategoryAsStruct>();

				Assert.IsTrue(result != null);
				Assert.IsTrue(result.Count() > 0);

				foreach (CategoryAsStruct item in result)
				{
					Assert.IsTrue(item.Id >= 0);
					Assert.IsTrue(!string.IsNullOrEmpty(item.CategoryName));
					Assert.IsTrue(!string.IsNullOrEmpty(item.Description));
				}
			});
		}

		[TestMethod]
		public void ExecuteNonQuery()
		{
			SetupAndAssert(dbCmd =>
			{
				var result = dbCmd
				.SetCommandType(CommandType.Text)
				.SetSql(@"
				update main.[Category] SET
					CategoryName = 'RandomName'
				where Id = 5000")
				.ExecuteNonQuery();

				Assert.IsTrue(result == 0);
			});
		}

		[TestMethod]
		public void ExecuteScalar()
		{
			SetupAndAssert(dbCmd =>
			{
				object result = dbCmd
				.SetCommandType(CommandType.Text)
				.SetSql(@"select * from main.[Category] order by Id desc")
				.ExecuteScalar();

				Assert.IsTrue(result != null);
				Assert.IsTrue(result is Int64);
				Assert.IsTrue(((Int64)result) == 8);
			});
		}

		[TestMethod]
		public void ExecuteScalarAsInt()
		{
			SetupAndAssert(dbCmd =>
			{
				int result = dbCmd
				.SetCommandType(CommandType.Text)
				.SetSql(@"select * from main.[Category] order by Id desc")
				.ExecuteScalar<int>();

				Assert.IsTrue(result == 8);
			});
		}

		#region Private Members
		private static void SetupAndAssertClosedConnection(Action<IDbCmd> act)
		{
			using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
			{
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
				act(dbCon.CreateDbCmd());
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
			}
		}

		private static void SetupAndAssert(Action<IDbCmd> act)
		{
			using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
			{
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
				act(dbCon.CreateDbCmd());
			}
		}
		#endregion
	}
}