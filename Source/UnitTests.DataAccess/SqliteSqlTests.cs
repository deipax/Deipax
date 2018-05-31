using Dapper;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using UnitTests.Common;

namespace UnitTests.DataAccess
{
    [TestClass]
    public class SqliteSqlTests : SqliteSql
    {
        #region Field Members
        private IDbCon _dbCon;
        private IDbConnection _dbConnection;
        #endregion

        [TestInitialize]
        public void Init()
        {
            _dbCon = DbHelper.GetNorthwind().CreateDbCon();
            _dbConnection = _dbCon.GetConnection();
            _dbConnection.Open();

            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldClass>();

            var tmp2 = _dbConnection.Query<MultipleFieldClass>(_sql);

            var tmp3 = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsDynamicList();

            var tmp4 = _dbConnection.Query(_sql);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _dbCon.Dispose();
        }

        [TestMethod]
        public void AllFieldsAsClass()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldClass>();
        }

        [TestMethod]
        public void AllFieldsAsStruct()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldStruct>();
        }

        [TestMethod]
        public void AllFieldsAsDynamic()
        {
            for (int i = 0; i < 100; i++)
            {
                var tmp = _dbCon
                    .CreateDbCmd()
                    .SetCommandType(CommandType.Text)
                    .SetSql(_sql)
                    .AsDynamicList();
            }
        }

        //[TestMethod]
        public void AllFieldsAsClass_Dapper()
        {
            var tmp = _dbConnection.Query<MultipleFieldClass>(_sql);
        }

        //[TestMethod]
        public void AllFieldsAsStruct_Dapper()
        {
            var tmp = _dbConnection.Query<MultipleFieldStruct>(_sql);
        }

        [TestMethod]
        public void AllFieldsAsDynamic_Dapper()
        {
            for (int i = 0; i < 100; i++)
            {
                var tmp = _dbConnection.Query(_sql);
            }
        }
    }
}