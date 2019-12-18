using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;
using UnitTests.DataAccess.Concretes;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbCmdExtensionsTests
    {
        [Fact]
        public void SetCommandType()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.Null(dbCmd.CommandType);
                IDbCmd dbCmd2 = dbCmd.CommandType(CommandType.StoredProcedure);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal(CommandType.StoredProcedure, dbCmd.CommandType);
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
        public void SetTimeout()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.Null(dbCmd.CommandTimeout);
                IDbCmd dbCmd2 = dbCmd.CommandTimeout(1000);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal(1000, dbCmd.CommandTimeout);
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
            });
        }

        [Fact]
        public void AddParameter_Test2()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.NotNull(dbCmd.Parameters);
                Assert.Empty(dbCmd.Parameters);

                IDbDataParameter parameter = dbCmd.Connection.CreateParameter();

                IDbCmd dbCmd2 = dbCmd.AddParameter(parameter);

                Assert.Same(dbCmd, dbCmd2);
                Assert.NotNull(dbCmd.Parameters);
                Assert.Equal(1, dbCmd.Parameters.Count);
                Assert.Same(parameter, dbCmd.Parameters.ElementAt(0));
            });
        }

        [Fact]
        public void AddParameters_Test1()
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
            });
        }

        [Fact]
        public void AsDynamicEnumerable()
        {
            SetupAndAssert(dbCmd =>
            {
                IEnumerable<dynamic> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerable();

                Assert.NotNull(result);
                Assert.True(result.Count() > 0);

                foreach (dynamic item in result)
                {
                    Assert.IsType<long>(item.Id);
                    Assert.IsType<string>(item.CategoryName);
                    Assert.IsType<string>(item.Description);

                    Assert.True(item.Id >= 0);
                    Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                    Assert.True(!string.IsNullOrEmpty(item.Description));
                }
            });
        }

        [Fact]
        public void AsDynamicList()
        {
            SetupAndAssert(dbCmd =>
            {
                List<dynamic> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerable()
                .ToList();

                Assert.NotNull(result);
                Assert.True(result.Count() > 0);

                foreach (dynamic item in result)
                {
                    Assert.IsType<long>(item.Id);
                    Assert.IsType<string>(item.CategoryName);
                    Assert.IsType<string>(item.Description);

                    Assert.True(item.Id >= 0);
                    Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                    Assert.True(!string.IsNullOrEmpty(item.Description));
                }
            });
        }

        [Fact]
        public void AsEnumerable()
        {
            SetupAndAssert(dbCmd =>
            {
                IEnumerable<CategoryAsClass> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerable<CategoryAsClass>();

                Assert.NotNull(result);
                Assert.True(result.Count() > 0);

                foreach (CategoryAsClass item in result)
                {
                    Assert.True(item.Id >= 0);
                    Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                    Assert.True(!string.IsNullOrEmpty(item.Description));
                }
            });
        }

        [Fact]
        public void AsList()
        {
            SetupAndAssert(dbCmd =>
            {
                IEnumerable<CategoryAsStruct> result = dbCmd
                .CommandType(CommandType.Text)
                .CommandText(@"select * from main.[Category]")
                .AsEnumerable<CategoryAsStruct>()
                .ToList();

                Assert.NotNull(result);
                Assert.True(result.Count() > 0);

                foreach (CategoryAsStruct item in result)
                {
                    Assert.True(item.Id >= 0);
                    Assert.True(!string.IsNullOrEmpty(item.CategoryName));
                    Assert.True(!string.IsNullOrEmpty(item.Description));
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
            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                dbCmd.Execute(dbCommand =>
                {
                    funcCalled = true;
                });

                Assert.True(funcCalled);
            });
        }

        [Fact]
        public void ExecuteCommand_WithReturn()
        {
            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                int result = dbCmd.Execute(dbCommand =>
                {
                    funcCalled = true;
                    return 12;
                });

                Assert.Equal(12, result);
                Assert.True(funcCalled);
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