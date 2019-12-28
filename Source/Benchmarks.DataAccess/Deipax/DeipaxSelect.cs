using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Extensions;
using System.Data;
using System.Linq;
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
            _dbConnection.AsEnumerable<MultipleFieldClass>(_sql).ToList();
        }

        [Benchmark]
        public void AllFieldsAsClass_Async()
        {
            _dbConnection.AsEnumerableAsync<MultipleFieldClass>(_sql).Result.ToList();
        }

        [Benchmark]
        public void AllFieldsAsStruct()
        {
            _dbConnection.AsEnumerable<MultipleFieldStruct>(_sql).ToList();
        }

        [Benchmark]
        public void AllFieldsAsStruct_Async()
        {
            _dbConnection.AsEnumerableAsync<MultipleFieldStruct>(_sql).Result.ToList();
        }

        [Benchmark]
        public void DynamicList()
        {
            _dbConnection.AsEnumerable(_sql).ToList();
        }

        [Benchmark]
        public void DynamicList_Async()
        {
            _dbConnection.AsEnumerableAsync(_sql).Result.ToList();
        }

        [Benchmark]
        public void QueryFirst()
        {
            _dbConnection.First(_sql);
        }

        [Benchmark]
        public void QueryFirstOrDefault()
        {
            _dbConnection.FirstOrDefault(_sql);
        }

        [Benchmark]
        public void QuerySingle()
        {
            _dbConnection.Single(_sql_limit_one);
        }

        [Benchmark]
        public void QuerySingleOrDefault()
        {
            _dbConnection.SingleOrDefault(_sql_limit_one);
        }
    }
}