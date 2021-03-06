﻿using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using System.Data;
using System.Reflection;
using UnitTests.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbExtensionsTests
    {
        #region Field Members
        // TODO: Replace with mock
        private IDb _db = DbHelper.GetNorthwind();
        #endregion

        [Fact]
        public void Execute()
        {
            IDbConnection connection = null;

            _db.Execute(x =>
            {
                connection = x;
                Assert.NotNull(connection);
                Assert.Equal(ConnectionState.Open, connection.State);
            });

            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void Execute_WithReturn()
        {
            IDbConnection connection = null;

            var result = _db.Execute(x =>
            {
                connection = x;
                Assert.NotNull(connection);
                Assert.Equal(ConnectionState.Open, connection.State);
                return 1;
            });

            Assert.Equal(1, result);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void Execute_WithTrans()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            _db.Execute((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
            });

            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void Execute_WithTrans_IsolationLevel()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            _db.Execute((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.ReadCommitted, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
            },
            IsolationLevel.ReadCommitted);

            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void Execute_WithTrans_WithReturn()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            var result = _db.Execute((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
                return 10;
            });

            Assert.Equal(10, result);
            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void Execute_WithTrans_IsolationLevel_WithReturn()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            var result = _db.Execute((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
                return 12;
            },
            IsolationLevel.Unspecified);

            Assert.Equal(12, result);
            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void ExecuteAsync()
        {
            IDbConnection connection = null;

            _db.ExecuteAsync(x =>
            {
                connection = x;
                Assert.NotNull(connection);
                Assert.Equal(ConnectionState.Open, connection.State);
            });

            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void ExecuteAsync_WithReturn()
        {
            IDbConnection connection = null;

            var result = _db.ExecuteAsync(x =>
            {
                connection = x;
                Assert.NotNull(connection);
                Assert.Equal(ConnectionState.Open, connection.State);
                return 1;
            }).Result;

            Assert.Equal(1, result);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void ExecuteAsync_WithTrans()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            _db.ExecuteAsync((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
            });

            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void ExecuteAsync_WithTrans_IsolationLevel()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            _db.ExecuteAsync((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.ReadCommitted, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
            },
            isolationLevel: IsolationLevel.ReadCommitted);

            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void ExecuteAsync_WithTrans_WithReturn()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            var result = _db.ExecuteAsync((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
                return 10;
            }).Result;

            Assert.Equal(10, result);
            AssertTransactionDisposed(transaction);
            AssertConnectionDisposed(connection);
        }

        [Fact]
        public void ExecuteAsync_WithTrans_IsolationLevel_WithReturn()
        {
            IDbConnection connection = null;
            IDbTransaction transaction = null;

            var result = _db.ExecuteAsync((x, y) =>
            {
                connection = x;
                transaction = y;

                Assert.NotNull(connection);
                Assert.NotNull(transaction);
                Assert.Equal(ConnectionState.Open, connection.State);
                Assert.Equal(IsolationLevel.ReadCommitted, transaction.IsolationLevel);
                Assert.Same(connection, transaction.Connection);
                return 12;
            },
            isolationLevel: IsolationLevel.ReadCommitted).Result;

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