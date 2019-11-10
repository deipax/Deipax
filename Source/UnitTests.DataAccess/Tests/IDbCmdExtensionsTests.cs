using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;
using UnitTests.DataAccess.BaseTests;
using UnitTests.DataAccess.Concretes;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbCmdExtensionsTests : BaseTest
    {
        [Fact]
        public void SetCommandType()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.Equal(CommandType.Text, dbCmd.CommandType);
                var dbCmd2 = dbCmd.SetCommandType(CommandType.StoredProcedure);
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
                var dbCmd2 = dbCmd.SetConnection(null);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Null(dbCmd.Connection);
            });
        }

        [Fact]
        public void SetTimeout()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.True(dbCmd.Timeout <= 0);
                var dbCmd2 = dbCmd.SetTimeout(1000);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal(1000, dbCmd.Timeout);
            });
        }

        [Fact]
        public void SetTransaction()
        {
            SetupAndAssert(dbCmd =>
            {
                var trans = new TestTransaction();
                Assert.Null(dbCmd.Transaction);
                var dbCmd2 = dbCmd.SetTransaction(trans);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Same(trans, dbCmd.Transaction);
            });
        }

        [Fact]
        public void SetName()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.True(string.IsNullOrEmpty(dbCmd.Name));
                var dbCmd2 = dbCmd.SetName("Bill");
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal("Bill", dbCmd.Name);
            });
        }

        [Fact]
        public void SetSql()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.True(string.IsNullOrEmpty(dbCmd.Sql));
                var dbCmd2 = dbCmd.SetSql("Bill");
                Assert.Same(dbCmd, dbCmd2);
                Assert.Equal("Bill", dbCmd.Sql);
            });
        }

        [Fact]
        public void AddParameter_Test1()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.NotNull(dbCmd.Parameters);
                Assert.Empty(dbCmd.Parameters);

                var dbCmd2 = dbCmd.AddParameter(
                    "John",
                    1,
                    ParameterDirection.Input,
                    DbType.Int32,
                    10);

                Assert.Same(dbCmd, dbCmd2);
                Assert.NotNull(dbCmd.Parameters);
                Assert.Equal(1, dbCmd.Parameters.Count);

                var parameter = dbCmd.Parameters.ElementAt(0);

                Assert.Equal("John", parameter.ParameterName);
                Assert.IsType<int>(parameter.Value);
                Assert.Equal(1, (int)parameter.Value);
                Assert.Equal(ParameterDirection.Input, parameter.Direction);
                Assert.Equal(DbType.Int32, parameter.DbType);
                Assert.Equal(10, parameter.Size);
            });
        }

        [Fact]
        public void AddParameter_Test2()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.NotNull(dbCmd.Parameters);
                Assert.Empty(dbCmd.Parameters);

                var parameter = dbCmd.Connection.CreateParameter();

                var dbCmd2 = dbCmd.AddParameter(parameter);

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

                var dbCmd2 = dbCmd.AddParameters(list);

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
        public void AddParameters_Test2()
        {
            SetupAndAssert(dbCmd =>
            {
                Assert.NotNull(dbCmd.Parameters);
                Assert.Empty(dbCmd.Parameters);

                List<object> list = new List<object>()
                {
                    1, 2
                };

                var dbCmd2 = dbCmd.AddParameters("MyBaseName", list);

                Assert.Same(dbCmd, dbCmd2);
                Assert.NotNull(dbCmd.Parameters);
                Assert.Equal(list.Count, dbCmd.Parameters.Count);

                for (int i = 0; i < list.Count; i++)
                {
                    var p = dbCmd.Parameters.ElementAt(i);

                    Assert.Contains("MyBaseName", p.ParameterName);
                    Assert.Equal(list[i], p.Value);
                }
            });
        }

        [Fact]
        public void AsDynamicEnumerable()
        {
            SetupAndAssert(dbCmd =>
            {
                IEnumerable<dynamic> result = dbCmd
                .SetCommandType(CommandType.Text)
                .SetSql(@"select * from main.[Category]")
                .AsDynamicEnumerable();

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
                .SetCommandType(CommandType.Text)
                .SetSql(@"select * from main.[Category]")
                .AsDynamicList();

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
                .SetCommandType(CommandType.Text)
                .SetSql(@"select * from main.[Category]")
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
                .SetCommandType(CommandType.Text)
                .SetSql(@"select * from main.[Category]")
                .AsList<CategoryAsStruct>();

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
                var result = dbCmd
                .SetCommandType(CommandType.Text)
                .SetSql(@"
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
                .SetCommandType(CommandType.Text)
                .SetSql(@"select * from main.[Category] order by Id desc")
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
                .SetCommandType(CommandType.Text)
                .SetSql(@"select * from main.[Category] order by Id desc")
                .ExecuteScalar<int>();

                Assert.Equal(8, result);
            });
        }

        [Fact]
        public void ExecuteConnection()
        {
            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                dbCmd.ExecuteConnection(dbConnection =>
                {
                    funcCalled = true;
                });

                Assert.True(funcCalled);
            });
        }

        [Fact]
        public void ExecuteCommand()
        {
            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                dbCmd.ExecuteCommand(dbCommand =>
                {
                    funcCalled = true;
                });

                Assert.True(funcCalled);
            });
        }

        [Fact]
        public void ExecuteConnection_WithReturn()
        {
            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                var result = dbCmd.ExecuteConnection(dbConnection =>
                {
                    funcCalled = true;
                    return 12;
                });

                Assert.Equal(12, result);
                Assert.True(funcCalled);
            });
        }

        [Fact]
        public void ExecuteCommand_WithReturn()
        {
            SetupAndAssert(dbCmd =>
            {
                bool funcCalled = false;

                var result = dbCmd.ExecuteCommand(dbCommand =>
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
            using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
            {
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
                act(dbCon.CreateDbCmd());
            }
        }
        #endregion
    }
}