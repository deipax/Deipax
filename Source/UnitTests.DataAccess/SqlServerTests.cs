using Dapper;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using UnitTests.Common;

namespace UnitTests.DataAccess
{
    [TestClass]
    public class SqlServerTests : SqlServer
    {
        #region Field Members
        private IDbCon _dbCon;
        private IDbCmd _dbCmd;
        private IDbConnection _dbConnection;
        #endregion

        [TestInitialize]
        public void Init()
        {
            _dbCon = DbHelper.GetNorthwindAzure().CreateDbCon();

            _dbConnection = _dbCon.GetConnection();

            _dbCmd = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _dbCon.Dispose();
        }

        //[TestMethod]
        public void DeipaxAsAClass()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<SqlServerClass>();
        }

        //[TestMethod]
        public void DapperAsAClass()
        {
            var tmp = _dbConnection.Query<SqlServerClass>(_sql);
        }

        //[TestMethod]
        public void ReadEntireFieldRead()
        {
            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                var fieldCount = reader.FieldCount;

                while (reader.Read())
                {
                    for (int i = 0; i < fieldCount; i++)
                    {
                        object value = reader.GetValue(i);
                    }
                }
            }
        }

        //[TestMethod]
        public void ReadSingleFieldRead()
        {
            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                var fieldCount = reader.FieldCount;

                while (reader.Read())
                {
                    object value = reader.GetValue(0);
                }
            }
        }

        //[TestMethod]
        public void ReadBulkRead()
        {
            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                var fieldCount = reader.FieldCount;
                object[] objects = new object[fieldCount];

                while (reader.Read())
                {
                    reader.GetValues(objects);
                }
            }
        }
    }
}
