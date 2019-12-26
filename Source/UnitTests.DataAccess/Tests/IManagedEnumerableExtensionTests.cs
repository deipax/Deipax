using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using UnitTests.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IManagedEnumerableExtensionTests
    {
        [Fact]
        public void ExecuteFirst()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category]")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.ExecuteFirst();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteFirst_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.ExecuteFirst());

                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteFirstOrDefault()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category]")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.ExecuteFirstOrDefault();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteFirstOrDefault_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.ExecuteFirstOrDefault();

                Assert.Null(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteSingle()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 1")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.ExecuteSingle();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteSingle_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.ExecuteSingle());

                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteSingle_ManyResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category]")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.ExecuteSingle());

                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteSingleOrDefault()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 1")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.ExecuteSingleOrDefault();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteSingleOrDefault_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.ExecuteSingleOrDefault();

                Assert.Null(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void ExecuteSingleOrDefault_ManyResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.ExecuteSingle());

                Assert.True(enumerable.Diposed);
            });
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
        #endregion
    }
}
