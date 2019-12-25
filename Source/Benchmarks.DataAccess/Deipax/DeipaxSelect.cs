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
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable<MultipleFieldClass>()
                .ToList();
        }

        [Benchmark]
        public void AllFieldsAsClass_Async()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerableAsync<MultipleFieldClass>()
                .Result
                .ToList();
        }

        [Benchmark]
        public void AllFieldsAsStruct()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable<MultipleFieldStruct>()
                .ToList();
        }

        [Benchmark]
        public void AllFieldsAsStruct_Async()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerableAsync<MultipleFieldStruct>()
                .Result
                .ToList();
        }

        [Benchmark]
        public void DynamicList()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable()
                .ToList();
        }

        [Benchmark]
        public void DynamicList_Async()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerableAsync()
                .Result
                .ToList();
        }

        [Benchmark]
        public void QueryFirst()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable()
                .QueryFirst();
        }

        [Benchmark]
        public void QueryFirstOrDefault()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable()
                .QueryFirstOrDefault();
        }

        [Benchmark]
        public void QuerySingle()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql_limit_one)
                .AsEnumerable()
                .QuerySingle();
        }

        [Benchmark]
        public void QuerySingleOrDefault()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql_limit_one)
                .AsEnumerable()
                .QuerySingleOrDefault();
        }
    }
}