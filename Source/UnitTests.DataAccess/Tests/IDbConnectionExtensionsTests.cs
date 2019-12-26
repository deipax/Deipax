using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
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

        [Fact]
        public void Execute_Typed_Sync()
        {
            SetupConnection(con =>
            {
                IEnumerable<CategoryAsClass> result = con.Execute<CategoryAsClass>(@"select * from main.[Category]");
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.Execute<CategoryAsClass>(@"select * from main.[Category]", buffered: false);
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void Execute_Typed_Async()
        {
            SetupConnection(async con =>
            {
                IEnumerable<CategoryAsClass> result = await con.ExecuteAsync<CategoryAsClass>(@"select * from main.[Category]").ConfigureAwait(false);
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.Execute<CategoryAsClass>(@"select * from main.[Category]", buffered: false);
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void Execute_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                IEnumerable<dynamic> result = con.Execute(@"select * from main.[Category]");
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.Execute(@"select * from main.[Category]", buffered: false);
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void Execute_Dynamic_Async()
        {
            SetupConnection(async con =>
            {
                IEnumerable<dynamic> result = await con.ExecuteAsync(@"select * from main.[Category]").ConfigureAwait(false);
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.Execute(@"select * from main.[Category]", buffered: false);
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void ExecuteFirst_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.ExecuteFirst<CategoryAsClass>(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteFirst_Typed_Async()
        {
            SetupConnection(async con =>
            {
                CategoryAsClass result = await con.ExecuteFirstAsync<CategoryAsClass>(@"select * from main.[Category]").ConfigureAwait(false);
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteFirst_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.ExecuteFirst(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteFirst_Dynamic_Async()
        {
            SetupConnection(async con =>
            {
                dynamic result = await con.ExecuteFirstAsync(@"select * from main.[Category]").ConfigureAwait(false);
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteFirstOrDefault_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.ExecuteFirstOrDefault<CategoryAsClass>(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteFirstOrDefault_Typed_Async()
        {
            SetupConnection(async con =>
            {
                CategoryAsClass result = await con.ExecuteFirstOrDefaultAsync<CategoryAsClass>(@"select * from main.[Category]").ConfigureAwait(false);
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteFirstOrDefault_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.ExecuteFirstOrDefault(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteFirstOrDefault_Dynamic_Async()
        {
            SetupConnection(async con =>
            {
                dynamic result = await con.ExecuteFirstOrDefaultAsync(@"select * from main.[Category]").ConfigureAwait(false);
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingle_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.ExecuteSingle<CategoryAsClass>(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingle_Typed_Async()
        {
            SetupConnection(async con =>
            {
                CategoryAsClass result = await con.ExecuteSingleAsync<CategoryAsClass>(@"select * from main.[Category] where Id = 1").ConfigureAwait(false);
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingle_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.ExecuteSingle(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingle_Dynamic_Async()
        {
            SetupConnection(async con =>
            {
                dynamic result = await con.ExecuteSingleAsync(@"select * from main.[Category] where Id = 1").ConfigureAwait(false);
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingleOrDefault_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.ExecuteSingleOrDefault<CategoryAsClass>(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingleOrDefault_Typed_Async()
        {
            SetupConnection(async con =>
            {
                CategoryAsClass result = await con.ExecuteSingleOrDefaultAsync<CategoryAsClass>(@"select * from main.[Category] where Id = 1").ConfigureAwait(false);
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingleOrDefault_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.ExecuteSingleOrDefault(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteSingleOrDefault_Dynamic_Async()
        {
            SetupConnection(async con =>
            {
                dynamic result = await con.ExecuteSingleOrDefaultAsync(@"select * from main.[Category] where Id = 1").ConfigureAwait(false);
                Assert.NotNull(result);
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