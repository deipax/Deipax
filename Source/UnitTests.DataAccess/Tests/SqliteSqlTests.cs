using Deipax.DataAccess.Extensions;
using System.Data;
using System.Linq;
using UnitTests.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class SqliteSqlTests
    {
        #region Field Members
        private IDbConnection _dbConnection;
        #endregion

        public SqliteSqlTests()
        {
            _dbConnection = DbHelper.GetNorthwind().Open();
        }

        [Fact]
        public void AllFieldsAsClass()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(SqliteSql.Sql)
                .AsEnumerable<MultipleFieldClass>()
                .ToList();
        }

        [Fact]
        public async void AllFieldsAsClass_Async()
        {
            var tmp = (await _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(SqliteSql.Sql)
                .AsEnumerableAsync<MultipleFieldClass>()
                .ConfigureAwait(false))
                .ToList();
        }

        [Fact]
        public void AllFieldsAsStruct()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(SqliteSql.Sql)
                .AsEnumerable<MultipleFieldStruct>()
                .ToList();
        }

        [Fact]
        public async void AllFieldsAsStruct_Async()
        {
            var tmp = (await _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(SqliteSql.Sql)
                .AsEnumerableAsync<MultipleFieldStruct>()
                .ConfigureAwait(false))
                .ToList();
        }

        [Fact]
        public void AllFieldsAsDynamic()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(SqliteSql.Sql)
                .AsEnumerable()
                .ToList();
        }

        [Fact]
        public async void AllFieldsAsDynamic_Async()
        {
            var tmp = (await _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(SqliteSql.Sql)
                .AsEnumerableAsync()
                .ConfigureAwait(false))
                .ToList();
        }
    }
}