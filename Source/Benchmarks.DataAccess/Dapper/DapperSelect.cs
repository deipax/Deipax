using BenchmarkDotNet.Attributes;
using Benchmarks.DataAccess.BaseClasses;
using Dapper;
using Deipax.DataAccess.Interfaces;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Dapper
{
    public class DapperSelect : BaseSelect
    {
        #region Field Members
        private IDbConnection _dbCon;
        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            DbHelper.SetDbInitializer();
            DbHelper.SetDefaultConnectionFactory();
            _dbCon = DbHelper
                .GetNorthwind()
                .CreateDbCon()
                .GetConnection();
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            _dbCon.Dispose();
        }

        [Benchmark]
        public override void AllFieldsAsClass()
        {
            var tmp = _dbCon.Query<MultipleFieldClass>(_sql);
        }

        [Benchmark]
        public override void AllFieldsAsStruct()
        {
            var tmp = _dbCon.Query<MultipleFieldStruct>(_sql);
        }

        [Benchmark]
        public override void SingleFieldAsClass()
        {
            var tmp = _dbCon.Query<SingleFieldClass>(_sql);
        }

        [Benchmark]
        public override void SingleFieldAsStruct()
        {
            var tmp = _dbCon.Query<SingleFieldStruct>(_sql);
        }
    }
}
