using BenchmarkDotNet.Attributes;
using Dapper;
using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using System.Data;
using UnitTests.Common;
using UnitTests.NetCore;

namespace Benchmarks.DataAccess.Deipax
{
    public class DeipaxSelect : SqliteSql
    {
        #region Field Members

        private IDbCon _dbCon;
        private IDbConnection _dbConnection;

        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            DbConfig.SetDbInitializer(DbInit.Initialize);
            DbConfig.DbConnectionFactory = DbInit.CreateDbConnection;
            _dbCon = DbHelper.GetNorthwind().CreateDbCon();
            _dbConnection = _dbCon.GetConnection();
            _dbConnection.Open();
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            _dbCon.Dispose();
        }

        [Benchmark]
        public void AllFieldsAsClass_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldClass>();
        }

        [Benchmark]
        public void AllFieldsAsStruct_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldStruct>();
        }

        [Benchmark]
        public void DynamicList_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsDynamicList();
        }

        [Benchmark]
        public void AllFieldsAsClass_Dapper()
        {
            var tmp = _dbConnection.Query<MultipleFieldClass>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsStruct_Dapper()
        {
            var tmp = _dbConnection.Query<MultipleFieldStruct>(_sql);
        }

        [Benchmark]
        public void DynamicList_Dapper()
        {
            var tmp = _dbConnection.Query(_sql);
        }
    }
}