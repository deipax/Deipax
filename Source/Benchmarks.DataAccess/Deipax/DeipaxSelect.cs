using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Interfaces;
using System.Data;
using UnitTests.Common;
using Dapper;

namespace Benchmarks.DataAccess.Deipax
{
    public class DeipaxSelect : BaseSelect
    {
        #region Field Members
        private IDbCon _dbCon;
        private IDbConnection _dbConnection;
        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            DbHelper.SetDbInitializer();
            DbHelper.SetDefaultConnectionFactory();
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

        //[Benchmark]
        public void SingleFieldAsClass_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<SingleFieldClass>();
        }

        //[Benchmark]
        public void SingleFieldAsStruct_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<SingleFieldStruct>();
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

        //[Benchmark]
        public void SingleFieldAsClass_Dapper()
        {
            var tmp = _dbConnection.Query<SingleFieldClass>(_sql);
        }

        //[Benchmark]
        public void SingleFieldAsStruct_Dapper()
        {
            var tmp = _dbConnection.Query<SingleFieldStruct>(_sql);
        }
    }
}