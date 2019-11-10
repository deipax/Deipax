using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Reflection;
using UnitTests.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbExtensionsTests
    {
        [Fact]
        public void CreateDb()
        {
            var db1 = DbHelper.GetNorthwind();
            var db2 = db1.CreateDb();

            Assert.NotSame(db1, db2);
            Assert.Equal(db1.Name, db2.Name);
            Assert.Equal(db1.ProviderName, db2.ProviderName);
            Assert.Equal(db1.ConnectionString, db2.ConnectionString);
            Assert.Equal(db1.ConnectionFactory, db2.ConnectionFactory);

            db2 = db1.CreateDb("John");
            Assert.NotSame(db1, db2);
            Assert.NotEqual(db1.Name, db2.Name);
            Assert.Equal("John", db2.Name);
            Assert.Equal(db1.ProviderName, db2.ProviderName);
            Assert.Equal(db1.ConnectionString, db2.ConnectionString);
            Assert.Equal(db1.ConnectionFactory, db2.ConnectionFactory);

            db2 = db1.CreateDb("John", "cs");
            Assert.NotSame(db1, db2);
            Assert.NotEqual(db1.Name, db2.Name);
            Assert.Equal("John", db2.Name);
            Assert.Equal(db1.ProviderName, db2.ProviderName);
            Assert.NotEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.Equal("cs", db2.ConnectionString);
            Assert.Equal(db1.ConnectionFactory, db2.ConnectionFactory);

            db2 = db1.CreateDb("John", "cs", "myProviderName");
            Assert.NotSame(db1, db2);
            Assert.NotEqual(db1.Name, db2.Name);
            Assert.Equal("John", db2.Name);
            Assert.NotEqual(db1.ProviderName, db2.ProviderName);
            Assert.Equal("myProviderName", db2.ProviderName);
            Assert.NotEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.Equal("cs", db2.ConnectionString);
            Assert.Equal(db1.ConnectionFactory, db2.ConnectionFactory);


            Func<IDb, IDbConnection> func = (x) =>
            {
                return null;
            };

            db2 = db1.CreateDb("John", "cs", "myProviderName", func);
            Assert.NotSame(db1, db2);
            Assert.NotEqual(db1.Name, db2.Name);
            Assert.Equal("John", db2.Name);
            Assert.NotEqual(db1.ProviderName, db2.ProviderName);
            Assert.Equal("myProviderName", db2.ProviderName);
            Assert.NotEqual(db1.ConnectionString, db2.ConnectionString);
            Assert.Equal("cs", db2.ConnectionString);
            Assert.NotEqual(db1.ConnectionFactory, db2.ConnectionFactory);
            Assert.Equal(db2.ConnectionFactory, func);
        }

        [Fact]
        public void AsBatch()
        {
            IDbConnection connection = null;

            DbHelper.GetNorthwind().AsBatch(dbBatch =>
            {
                Assert.NotNull(dbBatch.Connection);
                Assert.Null(dbBatch.Transaction);
                Assert.Equal(ConnectionState.Closed, dbBatch.Connection.State);
                connection = dbBatch.Connection;
                connection.Open();
                Assert.Equal(ConnectionState.Open, connection.State);
            });

            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void AsBatch_WithReturn()
        {
            IDbConnection connection = null;

            var result = DbHelper.GetNorthwind().AsBatch(dbBatch =>
            {
                Assert.NotNull(dbBatch.Connection);
                Assert.Null(dbBatch.Transaction);
                Assert.Equal(ConnectionState.Closed, dbBatch.Connection.State);
                connection = dbBatch.Connection;
                connection.Open();
                Assert.Equal(ConnectionState.Open, connection.State);
                return 1;
            });

            Assert.Equal(1, result);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void AsTransaction()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            DbHelper.GetNorthwind().AsTransaction(dbBatch =>
            {
                Assert.NotNull(dbBatch.Connection);
                Assert.NotNull(dbBatch.Transaction);
                Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                connection = dbBatch.Connection;
                transaction = dbBatch.Transaction;

                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
            });

            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void AsTransaction_IsolationLevel()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;
            IsolationLevel level = IsolationLevel.Unspecified;

            DbHelper.GetNorthwind().AsTransaction(level, dbBatch =>
            {
                Assert.NotNull(dbBatch.Connection);
                Assert.NotNull(dbBatch.Transaction);
                Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                connection = dbBatch.Connection;
                transaction = dbBatch.Transaction;

                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
            });

            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void AsTransaction_WithReturn()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            var result = DbHelper.GetNorthwind().AsTransaction(dbBatch =>
            {
                Assert.NotNull(dbBatch.Connection);
                Assert.NotNull(dbBatch.Transaction);
                Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                connection = dbBatch.Connection;
                transaction = dbBatch.Transaction;

                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
                return 10;
            });

            Assert.Equal(10, result);
            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void AsTransaction_IsolationLevel_WithReturn()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;
            IsolationLevel level = IsolationLevel.Unspecified;

            var result = DbHelper.GetNorthwind().AsTransaction(level, dbBatch =>
            {
                Assert.NotNull(dbBatch.Connection);
                Assert.NotNull(dbBatch.Transaction);
                Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                connection = dbBatch.Connection;
                transaction = dbBatch.Transaction;

                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
                return 12;
            });

            Assert.Equal(12, result);
            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        #region Private Members
        private static void AssertTransactionDisposed(IDbTransaction trans)
        {
            var field = trans.GetType().GetField("disposed", BindingFlags.NonPublic | BindingFlags.Instance);
            var disposed = (bool)field.GetValue(trans);
            Assert.True(disposed);
        }

        private static void AssertConnectionDisposed(IDbConnection con)
        {
            var field = con.GetType().GetField("disposed", BindingFlags.NonPublic | BindingFlags.Instance);
            var disposed = (bool)field.GetValue(con);
            Assert.True(disposed);
        }
        #endregion
    }
}