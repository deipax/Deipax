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
            var tmp = _dbConnection.AsEnumerable<MultipleFieldClass>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsClass_Async()
        {
            var tmp = _dbConnection.AsEnumerableAsync<MultipleFieldClass>(_sql).Result;
        }

        [Benchmark]
        public void AllFieldsAsStruct()
        {
            var tmp = _dbConnection.AsEnumerable<MultipleFieldStruct>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsStruct_Async()
        {
            var tmp = _dbConnection.AsEnumerableAsync<MultipleFieldStruct>(_sql).Result;
        }

        [Benchmark]
        public void DynamicList()
        {
            var tmp = _dbConnection.AsEnumerable(_sql);
        }

        [Benchmark]
        public void DynamicList_Async()
        {
            var tmp = _dbConnection.AsEnumerableAsync(_sql).Result;
        }

        [Benchmark]
        public void QueryFirst()
        {
            var tmp = _dbConnection.First(_sql);
        }

        [Benchmark]
        public void QueryFirstOrDefault()
        {
            var tmp = _dbConnection.FirstOrDefault(_sql);
        }

        [Benchmark]
        public void QuerySingle()
        {
            var tmp = _dbConnection.Single(_sql_limit_one);
        }

        [Benchmark]
        public void QuerySingleOrDefault()
        {
            var tmp = _dbConnection.SingleOrDefault(_sql_limit_one);
        }
    }
}