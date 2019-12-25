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
        public void QueryFirst()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category]")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.QueryFirst();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QueryFirst_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.QueryFirst());

                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QueryFirstOrDefault()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category]")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.QueryFirstOrDefault();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QueryFirstOrDefault_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.QueryFirstOrDefault();

                Assert.Null(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QuerySingle()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 1")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.QuerySingle();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QuerySingle_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.QuerySingle());

                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QuerySingle_ManyResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category]")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.QuerySingle());

                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QuerySingleOrDefault()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 1")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.QuerySingleOrDefault();

                Assert.NotNull(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QuerySingleOrDefault_NoResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                var tmp = result.QuerySingleOrDefault();

                Assert.Null(tmp);
                Assert.True(enumerable.Diposed);
            });
        }

        [Fact]
        public void QuerySingleOrDefault_ManyResults()
        {
            SetupAndAssert(dbCmd =>
            {
                IManagedEnumerable<dynamic> result = dbCmd
                    .CommandType(CommandType.Text)
                    .CommandText(@"select * from main.[Category] where Id = 20")
                    .AsEnumerable();

                ManagedEnumerable enumerable = result as ManagedEnumerable;
                Assert.False(enumerable.Diposed);

                Assert.ThrowsAny<InvalidOperationException>(() => result.QuerySingle());

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
