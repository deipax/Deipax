using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
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
        public void AsEnumerable_Typed_Sync()
        {
            SetupConnection(con =>
            {
                IEnumerable<CategoryAsClass> result = con.AsEnumerable<CategoryAsClass>(@"select * from main.[Category]").ToList();
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.AsEnumerable<CategoryAsClass>(@"select * from main.[Category]");
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void AsEnumerable_Typed_Async()
        {
            SetupConnection(con =>
            {
                IEnumerable<CategoryAsClass> result = con.AsEnumerableAsync<CategoryAsClass>(@"select * from main.[Category]").Result.ToList();
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.AsEnumerableAsync<CategoryAsClass>(@"select * from main.[Category]").Result;
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void AsEnumerable_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                IEnumerable<dynamic> result = con.AsEnumerable(@"select * from main.[Category]").ToList();
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.AsEnumerable(@"select * from main.[Category]");
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void AsEnumerable_Dynamic_Async()
        {
            SetupConnection(con =>
            {
                IEnumerable<dynamic> result = con.AsEnumerableAsync(@"select * from main.[Category]").Result.ToList();
                Assert.Equal(8, result.Count());
                Assert.Equal(8, result.Count()); // Assert twice to test result is buffered

                result = con.AsEnumerableAsync(@"select * from main.[Category]").Result;
                Assert.Equal(8, result.Count());
                // Command and Reader should be cleaned up at this point.
                Assert.ThrowsAny<NullReferenceException>(() => result.Count());
            });
        }

        [Fact]
        public void First_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.First<CategoryAsClass>(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void First_Typed_Async()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.FirstAsync<CategoryAsClass>(@"select * from main.[Category]").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void First_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.First(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void First_Dynamic_Async()
        {
            SetupConnection(con =>
            {
                dynamic result = con.FirstAsync(@"select * from main.[Category]").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void FirstOrDefault_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.FirstOrDefault<CategoryAsClass>(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void FirstOrDefault_Typed_Async()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.FirstOrDefaultAsync<CategoryAsClass>(@"select * from main.[Category]").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void FirstOrDefault_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.FirstOrDefault(@"select * from main.[Category]");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void FirstOrDefault_Dynamic_Async()
        {
            SetupConnection(con =>
            {
                dynamic result = con.FirstOrDefaultAsync(@"select * from main.[Category]").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void Single_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.Single<CategoryAsClass>(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void Single_Typed_Async()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.SingleAsync<CategoryAsClass>(@"select * from main.[Category] where Id = 1").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void Single_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.Single(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void Single_Dynamic_Async()
        {
            SetupConnection(con =>
            {
                dynamic result = con.SingleAsync(@"select * from main.[Category] where Id = 1").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void SingleOrDefault_Typed_Sync()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.SingleOrDefault<CategoryAsClass>(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void SingleOrDefault_Typed_Async()
        {
            SetupConnection(con =>
            {
                CategoryAsClass result = con.SingleOrDefaultAsync<CategoryAsClass>(@"select * from main.[Category] where Id = 1").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void SingleOrDefault_Dynamic_Sync()
        {
            SetupConnection(con =>
            {
                dynamic result = con.SingleOrDefault(@"select * from main.[Category] where Id = 1");
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void SingleOrDefault_Dynamic_Async()
        {
            SetupConnection(con =>
            {
                dynamic result = con.SingleOrDefaultAsync(@"select * from main.[Category] where Id = 1").Result;
                Assert.NotNull(result);
            });
        }

        [Fact]
        public void ExecuteNonQuery()
        {
            SetupConnection(con =>
            {
                var result = con.ExecuteNonQuery(@"update main.[Category] set CategoryName = 'Beverages' where Id = 1");
                Assert.Equal(1, result);
            });
        }

        [Fact]
        public void ExecuteNonQueryAsync()
        {
            SetupConnection(con =>
            {
                var result = con.ExecuteNonQueryAsync(@"update main.[Category] set CategoryName = 'Beverages' where Id = 1").Result;
                Assert.Equal(1, result);
            });
        }

        [Fact]
        public void ExecuteScalar_Object()
        {
            SetupConnection(con =>
            {
                var result = con.ExecuteScalar(@"select Id from main.[Category] where Id = 1");
                Assert.IsType<long>(result);
                Assert.Equal(1L, result);
            });
        }

        [Fact]
        public void ExecuteScalar_Object_Async()
        {
            SetupConnection(con =>
            {
                var result = con.ExecuteScalarAsync(@"select Id from main.[Category] where Id = 1").Result;
                Assert.IsType<long>(result);
                Assert.Equal(1L, result);
            });
        }

        [Fact]
        public void ExecuteScalar_T()
        {
            SetupConnection(con =>
            {
                var result = con.ExecuteScalar<int>(@"select Id from main.[Category] where Id = 1");
                Assert.IsType<int>(result);
                Assert.Equal(1, result);
            });
        }

        [Fact]
        public void ExecuteScalar_T_Async()
        {
            SetupConnection(con =>
            {
                var result = con.ExecuteScalarAsync<int>(@"select Id from main.[Category] where Id = 1").Result;
                Assert.IsType<int>(result);
                Assert.Equal(1, result);
            });
        }

        [Fact]
        public void Execute()
        {
            int count = 0;
            IDbCommand command = null;

            Action<IDbCommand> action = (dbCommand) =>
            {
                command = dbCommand;
                count++;
            };

            SetupConnection(con =>
            {
                con.Execute(@"select Id from main.[Category] where Id = 1", action);
            });

            Assert.Equal(1, count);
            Assert.NotNull(command);
            AssertCommandDisposed(command);
        }

        [Fact]
        public void Execute_Async()
        {
            int count = 0;
            DbCommand command = null;

            Action<DbCommand> action = (dbCommand) =>
            {
                command = dbCommand;
                count++;
            };

            SetupConnection(con =>
            {
                con.ExecuteAsync(@"select Id from main.[Category] where Id = 1", action);
            });

            Assert.Equal(1, count);
            Assert.NotNull(command);
            AssertCommandDisposed(command);
        }

        [Fact]
        public void Execute_T()
        {
            int count = 0;
            IDbCommand command = null;

            Func<IDbCommand, int> func = (dbCommand) =>
            {
                command = dbCommand;
                count++;
                return 1;
            };

            SetupConnection(con =>
            {
                var result = con.Execute(@"select Id from main.[Category] where Id = 1", func);
            });

            Assert.Equal(1, count);
            Assert.NotNull(command);
            AssertCommandDisposed(command);
        }

        [Fact]
        public void Execute_T_Async()
        {
            int count = 0;
            IDbCommand command = null;

            Func<DbCommand, int> func = (dbCommand) =>
            {
                command = dbCommand;
                count++;
                return 1;
            };

            SetupConnection(con =>
            {
                var result = con.ExecuteAsync(@"select Id from main.[Category] where Id = 1", func).Result;
            });

            Assert.Equal(1, count);
            Assert.NotNull(command);
            AssertCommandDisposed(command);
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

        private static void AssertCommandDisposed(IDbCommand cmd)
        {
            var field = cmd.GetType().GetField("disposed", BindingFlags.NonPublic | BindingFlags.Instance);
            var disposed = (bool)field.GetValue(cmd);
            Assert.True(disposed);
        }
        #endregion
    }
}