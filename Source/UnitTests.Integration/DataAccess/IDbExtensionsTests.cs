using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Reflection;
using UnitTests.Common;

namespace Integration.DataAccess
{
	[TestClass]
	public class IDbExtensionsTests
	{
		[TestMethod]
		public void AsBatch()
		{
			IDbConnection connection = null;

			DbHelper.GetNorthwind().AsBatch(dbBatch =>
			{
				Assert.IsTrue(dbBatch.Connection != null);
				Assert.IsTrue(dbBatch.Transaction == null);
				Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Closed);
				connection = dbBatch.Connection;
				connection.Open();
				Assert.IsTrue(connection.State == ConnectionState.Open);
			});

			AssertConnectionDisposed(connection);
		}
		
		[TestMethod]
		public void AsBatch_WithReturn()
		{
			IDbConnection connection = null;

			var result = DbHelper.GetNorthwind().AsBatch(dbBatch =>
			{
				Assert.IsTrue(dbBatch.Connection != null);
				Assert.IsTrue(dbBatch.Transaction == null);
				Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Closed);
				connection = dbBatch.Connection;
				connection.Open();
				Assert.IsTrue(connection.State == ConnectionState.Open);
				return 1;
			});

			Assert.IsTrue(result == 1);
			AssertConnectionDisposed(connection);
		}
		
		[TestMethod]
		public void AsTransaction()
		{
			IDbConnection connection = null;
			IDbTransaction transaction = null;

			DbHelper.GetNorthwind().AsTransaction(dbBatch =>
			{
				Assert.IsTrue(dbBatch.Connection != null);
				Assert.IsTrue(dbBatch.Transaction != null);
				Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
				connection = dbBatch.Connection;
				transaction = dbBatch.Transaction;

				Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
				Assert.IsTrue(transaction.Connection == connection);
			});

			AssertTransactionDisposed(transaction);
			AssertConnectionDisposed(connection);
		}
		
		[TestMethod]
		public void AsTransaction_IsolationLevel()
		{
			IDbConnection connection = null;
			IDbTransaction transaction = null;
			IsolationLevel level = IsolationLevel.Unspecified;

			DbHelper.GetNorthwind().AsTransaction(level, dbBatch =>
			{
				Assert.IsTrue(dbBatch.Connection != null);
				Assert.IsTrue(dbBatch.Transaction != null);
				Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
				connection = dbBatch.Connection;
				transaction = dbBatch.Transaction;

				Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
				Assert.IsTrue(transaction.Connection == connection);
			});

			AssertTransactionDisposed(transaction);
			AssertConnectionDisposed(connection);
		}
		
		[TestMethod]
		public void AsTransaction_WithReturn()
		{
			IDbConnection connection = null;
			IDbTransaction transaction = null;

			var result = DbHelper.GetNorthwind().AsTransaction(dbBatch =>
			{
				Assert.IsTrue(dbBatch.Connection != null);
				Assert.IsTrue(dbBatch.Transaction != null);
				Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
				connection = dbBatch.Connection;
				transaction = dbBatch.Transaction;

				Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
				Assert.IsTrue(transaction.Connection == connection);
				return 10;
			});

			Assert.IsTrue(result == 10);
			AssertTransactionDisposed(transaction);
			AssertConnectionDisposed(connection);
		}
		
		[TestMethod]
		public void AsTransaction_IsolationLevel_WithReturn()
		{
			IDbConnection connection = null;
			IDbTransaction transaction = null;
			IsolationLevel level = IsolationLevel.Unspecified;

			var result = DbHelper.GetNorthwind().AsTransaction(level, dbBatch =>
			{
				Assert.IsTrue(dbBatch.Connection != null);
				Assert.IsTrue(dbBatch.Transaction != null);
				Assert.IsTrue(dbBatch.Connection.State == ConnectionState.Open);
				connection = dbBatch.Connection;
				transaction = dbBatch.Transaction;

				Assert.IsTrue(transaction.IsolationLevel == IsolationLevel.Serializable);
				Assert.IsTrue(transaction.Connection == connection);
				return 12;
			});

			Assert.IsTrue(result == 12);
			AssertTransactionDisposed(transaction);
			AssertConnectionDisposed(connection);
		}

		#region Private Members
		private static void AssertTransactionDisposed(IDbTransaction trans)
		{
			var field = trans.GetType().GetField("disposed", BindingFlags.NonPublic | BindingFlags.Instance);
			var disposed = (bool)field.GetValue(trans);
			Assert.IsTrue(disposed);
		}

		private static void AssertConnectionDisposed(IDbConnection con)
		{
			var field = con.GetType().GetField("disposed", BindingFlags.NonPublic | BindingFlags.Instance);
			var disposed = (bool)field.GetValue(con);
			Assert.IsTrue(disposed);
		}
		#endregion
	}
}
