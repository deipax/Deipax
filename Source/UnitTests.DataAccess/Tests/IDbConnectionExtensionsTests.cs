using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using UnitTests.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class IDbConnectionExtensionsTests
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

        #region Private Members
        private static void SetupAndAssertClosedConnection(Action<DbConnection> act)
        {
            using (var dbCon = DbHelper.GetNorthwind().CreateDbCon())
            {
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
                act(dbCon.GetConnection());
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
            }
        }
        #endregion
    }
}