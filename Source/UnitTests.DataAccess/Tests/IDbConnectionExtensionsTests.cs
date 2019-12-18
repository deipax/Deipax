using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using UnitTests.Common;
using UnitTests.DataAccess.Concretes;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbConnectionExtensionsTests
    {
        [Fact]
        public void CreateParameter()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);

                var parameter = dbCon.CreateParameter(
                    "John",
                    1,
                    ParameterDirection.Input,
                    DbType.Int32,
                    10,
                    12,
                    13,
                    DataRowVersion.Proposed,
                    "Widget");

                Assert.Equal("John", parameter.ParameterName);
                Assert.IsType<int>(parameter.Value);
                Assert.Equal(1, (int)parameter.Value);
                Assert.Equal(ParameterDirection.Input, parameter.Direction);
                Assert.Equal(DbType.Int32, parameter.DbType);
                Assert.Equal(10, parameter.Size);
                // TODO: Fix these asserts.
                //Assert.Equal(12, parameter.Scale);
                //Assert.Equal(13, parameter.Precision);
                Assert.Equal(DataRowVersion.Proposed, parameter.SourceVersion);
                Assert.Equal("Widget", parameter.SourceColumn);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        [Fact]
        public void EnsureOpen()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                var connection = dbCon.EnsureOpen();
                Assert.Same(dbCon, connection);
                Assert.Equal(ConnectionState.Open, dbCon.State);
            });
        }

        [Fact]
        public void EnsureOpenAsync()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                var connection = dbCon.EnsureOpenAsync().Result;
                Assert.Same(dbCon, connection);
                Assert.Equal(ConnectionState.Open, dbCon.State);
            });
        }

        [Fact]
        public void SetCommandBehavior()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                IDbCmd cmd = dbCon.CommandBehavior(CommandBehavior.CloseConnection);
                Assert.NotNull(cmd);
                Assert.Equal(CommandBehavior.CloseConnection, cmd.CommandBehavior);
                Assert.Same(dbCon, cmd.Connection);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        [Fact]
        public void SetTransaction()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                var trans = new TestTransaction();
                IDbCmd cmd = dbCon.Transaction(trans);
                Assert.NotNull(cmd);
                Assert.Same(trans, cmd.Transaction);
                Assert.Same(dbCon, cmd.Connection);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        [Fact]
        public void SetCommandText()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                IDbCmd cmd = dbCon.CommandText("TestText");
                Assert.NotNull(cmd);
                Assert.Equal("TestText", cmd.CommandText);
                Assert.Same(dbCon, cmd.Connection);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        [Fact]
        public void SetCommandType()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                IDbCmd cmd = dbCon.CommandType(CommandType.TableDirect);
                Assert.NotNull(cmd);
                Assert.Equal(CommandType.TableDirect, cmd.CommandType);
                Assert.Same(dbCon, cmd.Connection);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        [Fact]
        public void SetCommandTimeout()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                IDbCmd cmd = dbCon.CommandTimeout(21);
                Assert.NotNull(cmd);
                Assert.Equal(21, cmd.CommandTimeout);
                Assert.Same(dbCon, cmd.Connection);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        [Fact]
        public void SetCancellationToken()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                var token = new CancellationToken();
                IDbCmd cmd = dbCon.CancellationToken(token);
                Assert.NotNull(cmd);
                Assert.Equal(token, cmd.CancellationToken);
                Assert.Same(dbCon, cmd.Connection);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        [Fact]
        public void SetAddParameter()
        {
            SetupConnection(dbCon =>
            {
                Assert.Equal(ConnectionState.Closed, dbCon.State);
                var p1 = dbCon.CreateParameter();
                var p2 = dbCon.CreateParameter();
                IDbDataParameter p3 = null;
                IDbCmd cmd = dbCon.AddParameter(p1, p2, p3);
                Assert.NotNull(cmd);
                Assert.Equal(2, cmd.Parameters.Count);
                Assert.Equal(p1, cmd.Parameters.ElementAt(0));
                Assert.Equal(p2, cmd.Parameters.ElementAt(1));
                Assert.Same(dbCon, cmd.Connection);
                Assert.Equal(ConnectionState.Closed, dbCon.State);
            });
        }

        #region Private Members
        private static void SetupConnection(Action<IDbConnection> act)
        {
            // TODO: Mock Connection
            using (IDbConnection connection = DbHelper.GetNorthwind().CreateConnection())
            {
                act(connection);
            }
        }
        #endregion
    }
}