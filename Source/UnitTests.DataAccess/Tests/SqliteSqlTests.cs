using Deipax.DataAccess.Interfaces;
using System.Data;
using UnitTests.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class SqliteSqlTests : SqliteSql
    {
        #region Field Members
        private IDbCon _dbCon;
        private IDbConnection _dbConnection;
        #endregion

        public SqliteSqlTests()
        {
            _dbCon = DbHelper.GetNorthwind().CreateDbCon();
            _dbConnection = _dbCon.GetConnection();
            _dbConnection.Open();
        }

        [Fact]
        public void AllFieldsAsClass()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldClass>();
        }

        [Fact]
        public void AllFieldsAsStruct()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldStruct>();
        }

        [Fact]
        public void AllFieldsAsDynamic()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsDynamicList();
        }
    }
}