using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using UnitTests.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbConExtensionsTests
    {
        [Fact]
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

                Assert.Equal("John", parameter.ParameterName);
                Assert.IsType<int>(parameter.Value);
                Assert.Equal(1, (int)parameter.Value);
                Assert.Equal(ParameterDirection.Input, parameter.Direction);
                Assert.Equal(DbType.Int32, parameter.DbType);
                Assert.Equal(10, parameter.Size);
            });
        }

        [Fact]
        public void CreateParameters()
        {
            SetupAndAssertClosedConnection(dbCon =>
            {
                List<object> list = new List<object>()
                {
                    1, 2
                };

                var parameters = dbCon.CreateParameters("MyBaseName", list);

                Assert.NotNull(parameters);
                Assert.Equal(list.Count, parameters.Count());

                for (int i = 0; i < list.Count; i++)
                {
                    var p = parameters.ElementAt(i);

                    Assert.Contains("MyBaseName", p.ParameterName);
                    Assert.Equal(list[i], p.Value);
                }
            });
        }

        [Fact]
        public void AsBatch()
        {
            SetupAndAssert(dbCon =>
            {
                IDbConnection connection = null;

                dbCon.AsBatch(dbBatch =>
                {
                    Assert.NotNull(dbBatch.Connection);
                    Assert.Null(dbBatch.Transaction);
                    Assert.Equal(ConnectionState.Closed, dbBatch.Connection.State);
                    connection = dbBatch.Connection;
                    connection.Open();
                    Assert.Equal(ConnectionState.Open, connection.State);
                });

                Assert.Equal(ConnectionState.Open, connection.State);
            });
        }

        [Fact]
        public void AsBatch_WithReturn()
        {
            SetupAndAssert(dbCon =>
            {
                IDbConnection connection = null;

                var result = dbCon.AsBatch(dbBatch =>
                {
                    Assert.NotNull(dbBatch.Connection);
                    Assert.Null(dbBatch.Transaction);
                    Assert.Equal(ConnectionState.Closed, dbBatch.Connection.State);
                    connection = dbBatch.Connection;
                    connection.Open();
                    Assert.Equal(ConnectionState.Open, connection.State);
                    return 1;
                });

                Assert.Equal(ConnectionState.Open, connection.State);
            });
        }

        [Fact]
        public void AsTransaction()
        {
            SetupAndAssert(dbCon =>
            {
                IDbConnection connection = null;
                IDbTransaction transaction = null;

                dbCon.AsTransaction(dbBatch =>
                {
                    Assert.NotNull(dbBatch.Connection);
                    Assert.NotNull(dbBatch.Transaction);
                    Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                    connection = dbBatch.Connection;
                    transaction = dbBatch.Transaction;

                    Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                    Assert.Same(connection, transaction.Connection);
                });

                Assert.Equal(ConnectionState.Open, connection.State);
                AssertTransactionDisposed(transaction);
            });
        }

        [Fact]
        public void AsTransaction_IsolationLevel()
        {
            SetupAndAssert(dbCon =>
            {
                IDbConnection connection = null;
                IDbTransaction transaction = null;
                IsolationLevel level = IsolationLevel.Unspecified;

                dbCon.AsTransaction(level, dbBatch =>
                {
                    Assert.NotNull(dbBatch.Connection);
                    Assert.NotNull(dbBatch.Transaction);
                    Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                    connection = dbBatch.Connection;
                    transaction = dbBatch.Transaction;

                    // In sqlite, all transactions have an Isolation level of serializable
                    Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                    Assert.Same(connection, transaction.Connection);
                });

                Assert.Equal(ConnectionState.Open, connection.State);
                AssertTransactionDisposed(transaction);
            });
        }

        [Fact]
        public void AsTransaction_WithReturn()
        {
            SetupAndAssert(dbCon =>
            {
                IDbConnection connection = null;
                IDbTransaction transaction = null;

                var result = dbCon.AsTransaction(dbBatch =>
                {
                    Assert.NotNull(dbBatch.Connection);
                    Assert.NotNull(dbBatch.Transaction);
                    Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                    connection = dbBatch.Connection;
                    transaction = dbBatch.Transaction;

                    Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                    Assert.Same(connection, transaction.Connection);
                    return 1;
                });

                Assert.Equal(ConnectionState.Open, connection.State);
                AssertTransactionDisposed(transaction);
                Assert.Equal(1, result);
            });
        }

        [Fact]
        public void AsTransaction_IsolationLevel_WithReturn()
        {
            SetupAndAssert(dbCon =>
            {
                IDbConnection connection = null;
                IDbTransaction transaction = null;
                IsolationLevel level = IsolationLevel.Unspecified;

                var result = dbCon.AsTransaction(level, dbBatch =>
                {
                    Assert.NotNull(dbBatch.Connection);
                    Assert.NotNull(dbBatch.Transaction);
                    Assert.Equal(ConnectionState.Open, dbBatch.Connection.State);
                    connection = dbBatch.Connection;
                    transaction = dbBatch.Transaction;

                    // In sqlite, all transactions have an Isolation level of serializable
                    Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
                    Assert.Same(connection, transaction.Connection);
                    return 1;
                });

                Assert.Equal(ConnectionState.Open, connection.State);
                AssertTransactionDisposed(transaction);
                Assert.Equal(1, result);
            });
        }

        #region Private Members
        private static void SetupAndAssertClosedConnection(Action<IDbCon> act)
        {
            using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
            {
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
                act(dbCon);
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
            }
        }

        private static void SetupAndAssert(Action<IDbCon> act)
        {
            using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
            {
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
                act(dbCon);
            }
        }

        private static void AssertTransactionDisposed(IDbTransaction trans)
        {
            var field = trans.GetType().GetField("disposed", BindingFlags.NonPublic | BindingFlags.Instance);
            var disposed = (bool)field.GetValue(trans);
            Assert.True(disposed);
        }
        #endregion
    }
}