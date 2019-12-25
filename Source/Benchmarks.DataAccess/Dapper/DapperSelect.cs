using BenchmarkDotNet.Attributes;
using Dapper;
using Deipax.DataAccess.Extensions;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Dapper
{
    public class DapperSelect : SqliteSql
    {
        #region Field Members
        private IDbConnection _dbConnection;
        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            _dbConnection = DbHelper.GetNorthwind().Open();
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            _dbConnection.Dispose();
        }

        [Benchmark]
        public void AllFieldsAsClass()
        {
            var tmp = _dbConnection.Query<MultipleFieldClass>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsClass_Async()
        {
            var tmp = _dbConnection.QueryAsync<MultipleFieldClass>(_sql).Result;
        }

        [Benchmark]
        public void AllFieldsAsStruct()
        {
            var tmp = _dbConnection.Query<MultipleFieldStruct>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsStruct_Async()
        {
            var tmp = _dbConnection.QueryAsync<MultipleFieldStruct>(_sql).Result;
        }

        [Benchmark]
        public void DynamicList()
        {
            var tmp = _dbConnection.Query(_sql);
        }

        [Benchmark]
        public void DynamicList_Async()
        {
            var tmp = _dbConnection.QueryAsync(_sql).Result;
        }

        [Benchmark]
        public void QueryFirst()
        {
            var tmp = _dbConnection.QueryFirst(_sql);
        }

        [Benchmark]
        public void QueryFirstOrDefault()
        {
            var tmp = _dbConnection.QueryFirstOrDefault(_sql);
        }

        [Benchmark]
        public void QuerySingle()
        {
            var tmp = _dbConnection.QuerySingle(_sql_limit_one);
        }

        [Benchmark]
        public void QuerySingleOrDefault()
        {
            var tmp = _dbConnection.QuerySingleOrDefault(_sql_limit_one);
        }
    }
}
