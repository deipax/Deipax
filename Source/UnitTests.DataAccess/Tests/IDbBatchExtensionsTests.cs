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
    public class IDbBatchExtensionsTests
    {
        [Fact]
        public void SetTransaction()
        {
            SetupAndAssertClosedConnection(dbCmd =>
            {
                var trans = new TestTransaction();
                Assert.Null(dbCmd.Transaction);
                var dbCmd2 = dbCmd.SetTransaction(trans);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Same(trans, dbCmd.Transaction);
            });
        }

        [Fact]
        public void SetConnection()
        {
            SetupAndAssertClosedConnection(dbCmd =>
            {
                Assert.NotNull(dbCmd.Connection);
                var dbCmd2 = dbCmd.SetConnection(null);
                Assert.Same(dbCmd, dbCmd2);
                Assert.Null(dbCmd.Connection);
            });
        }

        [Fact]
        public void CreateParameter()
        {
            SetupAndAssertClosedConnection(dbBatch =>
            {
                var parameter = dbBatch.CreateParameter(
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
            SetupAndAssertClosedConnection(dbBatch =>
            {
                List<object> list = new List<object>()
                {
                    1, 2
                };

                var parameters = dbBatch.CreateParameters("MyBaseName", list);

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
        private static void SetupAndAssertClosedConnection(Action<IDbBatch> act)
        {
            using (IDbCon dbCon = DbHelper.GetNorthwind().CreateDbCon())
            {
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
                act(dbCon.CreateDbBatch());
                Assert.Equal(ConnectionState.Closed, dbCon.GetConnection().State);
            }
        }
        #endregion
    }
}