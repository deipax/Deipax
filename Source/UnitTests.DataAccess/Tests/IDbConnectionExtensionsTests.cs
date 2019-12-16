using Deipax.DataAccess.Extensions;
using System;
using System.Data;
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

        #region Private Members
        private static void SetupAndAssertClosedConnection(Action<IDbConnection> act)
        {
            using (IDbConnection connection = DbHelper.GetNorthwind().CreateConnection())
            {
                Assert.Equal(ConnectionState.Closed, connection.State);
                act(connection);
                Assert.Equal(ConnectionState.Closed, connection.State);
            }
        }
        #endregion
    }
}