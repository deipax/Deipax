using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using UnitTests.Common;
using UnitTests.DataAccess.Concretes;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbCmdExtensionsTests
    {
        [Fact]
        public void SetCommandBehavior()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.Null(dbCmd.CommandBehavior);
                IDbCmd dbCmd2 = dbCmd.CommandBehavior(CommandBehavior.SingleRow);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal(CommandBehavior.SingleRow, dbCmd.CommandBehavior);
                dbCmd.CommandBehavior(null);
                Assert.Null(dbCmd.CommandBehavior);
            });
        }

        [Fact]
        public void SetConnection()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.NotNull(dbCmd.Connection);
                IDbCmd dbCmd2 = dbCmd.Connection(null);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Null(dbCmd.Connection);
            });
        }

        [Fact]
        public void SetTransaction()
        {
            SetupAndAssert(dbCmd =>
            {
                TestTransaction trans = new TestTransaction();
                Assert.Null(dbCmd.Transaction);
                IDbCmd dbCmd2 = dbCmd.Transaction(trans);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Same(trans, dbCmd.Transaction);
                dbCmd.Transaction(null);
                Assert.Null(dbCmd.Transaction);
            });
        }

        [Fact]
        public void SetCommandText()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.True(string.IsNullOrEmpty(dbCmd.CommandText));
                IDbCmd dbCmd2 = dbCmd.CommandText("Bill");
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal("Bill", dbCmd.CommandText);
                dbCmd.CommandText(null);
                Assert.Null(dbCmd.CommandText);
            });
        }

        [Fact]
        public void SetCommandType()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.Null(dbCmd.CommandType);
                IDbCmd dbCmd2 = dbCmd.CommandType(CommandType.StoredProcedure);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal(CommandType.StoredProcedure, dbCmd.CommandType);
                dbCmd.CommandType(null);
                Assert.Null(dbCmd.CommandType);
            });
        }

        [Fact]
        public void SetCommandTimeout()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.Null(dbCmd.CommandTimeout);
                IDbCmd dbCmd2 = dbCmd.CommandTimeout(1000);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal(1000, dbCmd.CommandTimeout);
                dbCmd.CommandTimeout(null);
                Assert.Null(dbCmd.CommandTimeout);
            });
        }

        [Fact]
        public void SetCancellationToken()
        {
            SetupAndAssert(dbCmd =>
            {
                var token = new CancellationToken();
                Assert.Null(dbCmd.CancellationToken);
                IDbCmd dbCmd2 = dbCmd.CancellationToken(token);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal(token, dbCmd.CancellationToken);
                dbCmd.CancellationToken(null);
                Assert.Null(dbCmd.CancellationToken);
            });
        }

        [Fact]
        public void AddParameters()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.NotNull(dbCmd.Parameters);
                Assert.Empty(dbCmd.Parameters);

                List<IDbDataParameter> list = new List<IDbDataParameter>()
                {
                    dbCmd.Connection.CreateParameter(),
                    dbCmd.Connection.CreateParameter(),
                };

                IDbCmd dbCmd2 = dbCmd.AddParameter(list.ToArray());

                Assert.Same(dbCmd, dbCmd2);
                Assert.NotNull(dbCmd.Parameters);
                Assert.Equal(list.Count, dbCmd.Parameters.Count);

                for (int i = 0; i < list.Count; i++)
                {
                    Assert.Same(list[i], dbCmd.Parameters.ElementAt(i));
                }

                dbCmd.Parameters.Clear();
                Assert.Empty(dbCmd.Parameters);
            });
        }

        [Fact]
        public void AsDynamicEnumerable()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (dynamic item in result)
                    {
                        count++;
                        Assert.IsType<long>(item.Id);
                        Assert.IsType<string>(item.CategoryName);
                        Assert.IsType<string>(item.Description);

                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                    }

                    Assert.Equal(8, count);

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void AsDynamicEnumerable_Cancel()
        {
            SetupAndAssert(dbCmd =>
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;

                IManagedEnumerable<dynamic> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .CancellationToken(token)
                .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (dynamic item in result)
                    {
                        count++;
                        Assert.IsType<long>(item.Id);
                        Assert.IsType<string>(item.CategoryName);
                        Assert.IsType<string>(item.Description);

                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                        cts.Cancel();
                    }

                    Assert.Equal(1, count);

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void AsTypedEnumerable()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<CategoryAsClass> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerable<CategoryAsClass>();

                ManagedEnumerable<CategoryAsClass> enumerable = result as ManagedEnumerable<CategoryAsClass>;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (CategoryAsClass item in result)
                    {
                        count++;
                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                    }

                    Assert.Equal(8, count);

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void AsTypedEnumerable_Cancel()
        {
            SetupAndAssert(dbCmd =>
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;

                IManagedEnumerable<CategoryAsClass> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .CancellationToken(token)
                .AsEnumerable<CategoryAsClass>();

                ManagedEnumerable<CategoryAsClass> enumerable = result as ManagedEnumerable<CategoryAsClass>;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (CategoryAsClass item in result)
                    {
                        count++;
                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                        cts.Cancel();
                    }

                    Assert.Equal(1, count); ;

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void ExecuteNonQuery()
        {
            SetupAndAssert(dbCmd =>
            {
                int result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"
				update main.[Category] SET
					CategoryName = 'RandomName'
				where Id = 5000")
                .ExecuteNonQuery();

                Assert.True(result == 0);
            });
        }

        [Fact]
        public void ExecuteScalar()
        {
            SetupAndAssert(dbCmd =>
            {
                object result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category] order by Id desc")
                .ExecuteScalar();

                Assert.NotNull(result);
                Assert.IsType<long>(result);
                Assert.Equal(8, (long)result);
            });
        }

        [Fact]
        public void ExecuteScalarAsInt()
        {
            SetupAndAssert(dbCmd =>
            {
                int result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category] order by Id desc")
                .ExecuteScalar<int>();

                Assert.Equal(8, result);
            });
        }

        [Fact]
        public void ExecuteCommand()
        {
            IDbCommand command = null;

            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                dbCmd.Execute(dbCommand =>
                {
                    command = dbCommand;
                    funcCalled = true;
                });

                Assert.True(funcCalled);
            });

            AssertCommandDisposed(command);
        }

        [Fact]
        public void ExecuteCommand_WithReturn()
        {
            IDbCommand command = null;

            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                int result = dbCmd.Execute(dbCommand =>
                {
                    command = dbCommand;
                    funcCalled = true;
                    return 12;
                });

                Assert.Equal(12, result);
                Assert.True(funcCalled);
            });

            AssertCommandDisposed(command);
        }

        [Fact]
        public void AsDynamicEnumerableAsync()
        {
            SetupAndAssert(async dbCmd =>
            {
                IManagedEnumerable<dynamic> result = await dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerableAsync()
                .ConfigureAwait(false);

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (dynamic item in result)
                    {
                        count++;
                        Assert.IsType<long>(item.Id);
                        Assert.IsType<string>(item.CategoryName);
                        Assert.IsType<string>(item.Description);

                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                    }

                    Assert.Equal(8, count);

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void AsDynamicEnumerableAsync_Cancel()
        {
            SetupAndAssert(async dbCmd =>
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;

                IManagedEnumerable<dynamic> result = await dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .CancellationToken(token)
                .AsEnumerableAsync()
                .ConfigureAwait(false);

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (dynamic item in result)
                    {
                        count++;
                        Assert.IsType<long>(item.Id);
                        Assert.IsType<string>(item.CategoryName);
                        Assert.IsType<string>(item.Description);

                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                        cts.Cancel();
                    }

                    Assert.Equal(1, count);

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void AsTypedEnumerableAsync()
        {
            SetupAndAssert(async dbCmd =>
            {
                IManagedEnumerable<CategoryAsClass> result = await dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerableAsync<CategoryAsClass>()
                .ConfigureAwait(false);

                ManagedEnumerable<CategoryAsClass> enumerable = result as ManagedEnumerable<CategoryAsClass>;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (CategoryAsClass item in result)
                    {
                        count++;
                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                    }

                    Assert.Equal(8, count);

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void AsTypedEnumerableAsync_Cancel()
        {
            SetupAndAssert(async dbCmd =>
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;

                IManagedEnumerable<CategoryAsClass> result = await dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .CancellationToken(token)
                .AsEnumerableAsync<CategoryAsClass>()
                .ConfigureAwait(false);

                ManagedEnumerable<CategoryAsClass> enumerable = result as ManagedEnumerable<CategoryAsClass>;
                Assert.False(enumerable.Diposed);

                using (result)
                {
                    Assert.NotNull(result);
                    int count = 0;

                    foreach (CategoryAsClass item in result)
                    {
                        count++;
                        Assert.True(item.Id >= 0);
                        Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                        Assert.True(!string.IsNullOrEmpty(item.Description));
                        cts.Cancel();
                    }

                    Assert.Equal(1, count);

                    // Command and Reader should be cleaned up at this point.
                    Assert.ThrowsAny<NullReferenceException>(() => result.Count());
                    Assert.True(enumerable.Diposed);
                }
            });
        }

        [Fact]
        public void ExecuteNonQueryAsync()
        {
            SetupAndAssert(dbCmd =>
            {
                int result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"
				update main.[Category] SET
					CategoryName = 'RandomName'
				where Id = 5000")
                .ExecuteNonQueryAsync()
                .Result;

                Assert.True(result == 0);
            });
        }

        [Fact]
        public void ExecuteScalarAsync()
        {
            SetupAndAssert(dbCmd =>
            {
                object result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category] order by Id desc")
                .ExecuteScalarAsync()
                .Result;

                Assert.NotNull(result);
                Assert.IsType<long>(result);
                Assert.Equal(8, (long)result);
            });
        }

        [Fact]
        public void ExecuteScalarAsIntAsync()
        {
            SetupAndAssert(dbCmd =>
            {
                int result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category] order by Id desc")
                .ExecuteScalarAsync<int>()
                .Result;

                Assert.Equal(8, result);
            });
        }

        [Fact]
        public void ExecuteCommandAsync()
        {
            IDbCommand command = null;

            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                dbCmd.ExecuteAsync(dbCommand =>
                {
                    command = dbCommand;
                    funcCalled = true;
                });

                Assert.True(funcCalled);
            });

            AssertCommandDisposed(command);
        }

        [Fact]
        public void ExecuteCommandAsync_WithReturn()
        {
            IDbCommand command = null;

            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                int result = dbCmd.ExecuteAsync(dbCommand =>
                {
                    command = dbCommand;
                    funcCalled = true;
                    return 12;
                }).Result;

                Assert.Equal(12, result);
                Assert.True(funcCalled);
            });

            AssertCommandDisposed(command);
        }

        #region Private Members
        private static void SetupAndAssert(Action<IDbCmd> act)
        {
            using (IDbConnection connection = DbHelper.GetNorthwind().CreateConnection())
            {
                Assert.Equal(ConnectionState.Closed, connection.State);
                act(connection.CommandType(null));
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