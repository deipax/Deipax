using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Reflection;
using UnitTests.Common;

namespace UnitTests.DataAccess
{
    [TestClass]
    public class IDbExtensionsTests
    {
        [TestMethod]
        public void CreateDb()
        {
            var db1 = DbHelper.GetNorthwind();
            var db2 = db1.CreateDb();

            Assert.AreNotSame(db1, db2);
            Assert.AreEqual(db1.Name, db2.Name);
            Assert.AreEqual(db1.ProviderName, db2.ProviderName);
            Assert.AreEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.AreEqual(db1.ConnectionFactory, db2.ConnectionFactory);

            db2 = db1.CreateDb("John");
            Assert.AreNotSame(db1, db2);
            Assert.AreNotEqual(db1.Name, db2.Name);
            Assert.AreEqual(db2.Name, "John");
            Assert.AreEqual(db1.ProviderName, db2.ProviderName);
            Assert.AreEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.AreEqual(db1.ConnectionFactory, db2.ConnectionFactory);

            db2 = db1.CreateDb("John", "cs");
            Assert.AreNotSame(db1, db2);
            Assert.AreNotEqual(db1.Name, db2.Name);
            Assert.AreEqual(db2.Name, "John");
            Assert.AreEqual(db1.ProviderName, db2.ProviderName);
            Assert.AreNotEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.AreEqual(db2.ConnectionString, "cs");
            Assert.AreEqual(db1.ConnectionFactory, db2.ConnectionFactory);

            db2 = db1.CreateDb("John", "cs", "myProviderName");
            Assert.AreNotSame(db1, db2);
            Assert.AreNotEqual(db1.Name, db2.Name);
            Assert.AreEqual(db2.Name, "John");
            Assert.AreNotEqual(db1.ProviderName, db2.ProviderName);
            Assert.AreEqual(db2.ProviderName, "myProviderName");
            Assert.AreNotEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.AreEqual(db2.ConnectionString, "cs");
            Assert.AreEqual(db1.ConnectionFactory, db2.ConnectionFactory);


            Func<IDb, IDbConnection> func = (x) =>
            {
                return (IDbConnection)null;
            };

            db2 = db1.CreateDb("John", "cs", "myProviderName", func);
            Assert.AreNotSame(db1, db2);
            Assert.AreNotEqual(db1.Name, db2.Name);
            Assert.AreEqual(db2.Name, "John");
            Assert.AreNotEqual(db1.ProviderName, db2.ProviderName);
            Assert.AreEqual(db2.ProviderName, "myProviderName");
            Assert.AreNotEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.AreEqual(db2.ConnectionString, "cs");
            Assert.AreNotEqual(db1.ConnectionFactory, db2.ConnectionFactory);
            Assert.AreEqual(db2.ConnectionFactory, func);
        }

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