using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Extensions;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Deipax
{
    public class DeipaxSelect : SqliteSql
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
            var tmp = _dbConnection.Execute<MultipleFieldClass>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsClass_Async()
        {
            var tmp = _dbConnection.ExecuteAsync<MultipleFieldClass>(_sql).Result;
        }

        [Benchmark]
        public void AllFieldsAsStruct()
        {
            var tmp = _dbConnection.Execute<MultipleFieldStruct>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsStruct_Async()
        {
            var tmp = _dbConnection.ExecuteAsync<MultipleFieldStruct>(_sql).Result;
        }

        [Benchmark]
        public void DynamicList()
        {
            var tmp = _dbConnection.Execute(_sql);
        }

        [Benchmark]
        public void DynamicList_Async()
        {
            var tmp = _dbConnection.ExecuteAsync(_sql).Result;
        }

        [Benchmark]
        public void QueryFirst()
        {
            var tmp = _dbConnection.ExecuteFirst(_sql);
        }

        [Benchmark]
        public void QueryFirstOrDefault()
        {
            var tmp = _dbConnection.ExecuteFirstOrDefault(_sql);
        }

        [Benchmark]
        public void QuerySingle()
        {
            var tmp = _dbConnection.ExecuteSingle(_sql_limit_one);
        }

        [Benchmark]
        public void QuerySingleOrDefault()
        {
            var tmp = _dbConnection.ExecuteSingleOrDefault(_sql_limit_one);
        }
    }
}