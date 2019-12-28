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
            _dbConnection.Query<MultipleFieldClass>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsClass_Async()
        {
            _ = _dbConnection.QueryAsync<MultipleFieldClass>(_sql).Result;
        }

        [Benchmark]
        public void AllFieldsAsStruct()
        {
            _dbConnection.Query<MultipleFieldStruct>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsStruct_Async()
        {
            _ = _dbConnection.QueryAsync<MultipleFieldStruct>(_sql).Result;
        }

        [Benchmark]
        public void DynamicList()
        {
            _dbConnection.Query(_sql);
        }

        [Benchmark]
        public void DynamicList_Async()
        {
            _ = _dbConnection.QueryAsync(_sql).Result;
        }

        [Benchmark]
        public void QueryFirst()
        {
            _dbConnection.QueryFirst(_sql);
        }

        [Benchmark]
        public void QueryFirstOrDefault()
        {
            _dbConnection.QueryFirstOrDefault(_sql);
        }

        [Benchmark]
        public void QuerySingle()
        {
            _dbConnection.QuerySingle(_sql_limit_one);
        }

        [Benchmark]
        public void QuerySingleOrDefault()
        {
            _dbConnection.QuerySingleOrDefault(_sql_limit_one);
        }
    }
}
