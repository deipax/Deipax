using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using UnitTests.Common;

namespace Integration.DataAccess
{
	[TestClass]
	public class IDbConExtensionsTests
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

		[TestMethod]
		public void AsBatch()
		{
			SetupAndAssert(dbCon =>
			{
				IDbConnection connection = null;

				dbCon.AsBatch(dbBatch =>
				{
					Assert.IsTrue(dbBatch.Connection != null);
					Assert.IsTrue(dbBatch.Transaction == null);
					Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Closed);
					connection = dbBatch.Connection;
					connection.Open();
					Assert.IsTrue(connection.State == ConnectionState.Open);
				});

				Assert.IsTrue(connection.State == ConnectionState.Open);
			});
		}

		[TestMethod]
		public void AsBatch_WithReturn()
		{
			SetupAndAssert(dbCon =>
			{
				IDbConnection connection = null;

				var result = dbCon.AsBatch(dbBatch =>
				{
					Assert.IsTrue(dbBatch.Connection != null);
					Assert.IsTrue(dbBatch.Transaction == null);
					Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Closed);
					connection = dbBatch.Connection;
					connection.Open();
					Assert.IsTrue(connection.State == ConnectionState.Open);
					return 1;
				});

				Assert.IsTrue(connection.State == ConnectionState.Open);
			});
		}

		[TestMethod]
		public void AsTransaction()
		{
			SetupAndAssert(dbCon =>
			{
				IDbConnection connection = null;
				IDbTransaction transaction = null;

				dbCon.AsTransaction(dbBatch =>
				{
					Assert.IsTrue(dbBatch.Connection != null);
					Assert.IsTrue(dbBatch.Transaction != null);
					Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
					connection = dbBatch.Connection;
					transaction = dbBatch.Transaction;

					Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
					Assert.IsTrue(transaction.Connection == connection);
				});
	
				Assert.IsTrue(connection.State == ConnectionState.Open);
				AssertTransactionDisposed(transaction);
			});
		}

		[TestMethod]
		public void AsTransaction_IsolationLevel()
		{
			SetupAndAssert(dbCon =>
			{
				IDbConnection connection = null;
				IDbTransaction transaction = null;
				IsolationLevel level = IsolationLevel.Unspecified;

				dbCon.AsTransaction(level, dbBatch =>
				{
					Assert.IsTrue(dbBatch.Connection != null);
					Assert.IsTrue(dbBatch.Transaction != null);
					Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
					connection = dbBatch.Connection;
					transaction = dbBatch.Transaction;

					// In sqlite, all transactions have an Isolation level of serializable
					Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
					Assert.IsTrue(transaction.Connection == connection);
				});

				Assert.IsTrue(connection.State == ConnectionState.Open);
				AssertTransactionDisposed(transaction);
			});
		}

		[TestMethod]
		public void AsTransaction_WithReturn()
		{
			SetupAndAssert(dbCon =>
			{
				IDbConnection connection = null;
				IDbTransaction transaction = null;

				var result = dbCon.AsTransaction(dbBatch =>
				{
					Assert.IsTrue(dbBatch.Connection != null);
					Assert.IsTrue(dbBatch.Transaction != null);
					Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
					connection = dbBatch.Connection;
					transaction = dbBatch.Transaction;

					Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
					Assert.IsTrue(transaction.Connection == connection);
					return 1;
				});

				Assert.IsTrue(connection.State == ConnectionState.Open);
				AssertTransactionDisposed(transaction);
				Assert.IsTrue(result == 1);
			});
		}

		[TestMethod]
		public void AsTransaction_IsolationLevel_WithReturn()
		{
			SetupAndAssert(dbCon =>
			{
				IDbConnection connection = null;
				IDbTransaction transaction = null;
				IsolationLevel level = IsolationLevel.Unspecified;

				var result = dbCon.AsTransaction(level, dbBatch =>
				{
					Assert.IsTrue(dbBatch.Connection != null);
					Assert.IsTrue(dbBatch.Transaction != null);
					Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
					connection = dbBatch.Connection;
					transaction = dbBatch.Transaction;

					// In sqlite, all transactions have an Isolation level of serializable
					Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
					Assert.IsTrue(transaction.Connection == connection);
					return 1;
				});

				Assert.IsTrue(connection.State == ConnectionState.Open);
				AssertTransactionDisposed(transaction);
				Assert.IsTrue(result == 1);
			});
		}

		#region Private Members
		private static void SetupAndAssertClosedConnection(Action<IDbCon> act)
		{
			using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
			{
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
				act(dbCon);
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
			}
		}

		private static void SetupAndAssert(Action<IDbCon> act)
		{
			using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
			{
				Assert.IsTrue(dbCon.GetConnection().State == ConnectionState.Closed);
				act(dbCon);
			}
		}

		private static void AssertTransactionDisposed(IDbTransaction trans)
		{
			var field = trans.GetType().GetField("disposed", BindingFlags.NonPublic | BindingFlags.Instance);
			var disposed = (bool)field.GetValue(trans);
			Assert.IsTrue(disposed);
		}
		#endregion
	}
}
