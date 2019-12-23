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
        public void AllFieldsAsClass_Deipax()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable<MultipleFieldClass>()
                .ToList();
        }


        [Benchmark]
        public void AllFieldsAsStruct_Deipax()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable<MultipleFieldStruct>()
                .ToList();
        }

        [Benchmark]
        public void DynamicList_Deipax()
        {
            var tmp = _dbConnection
                .CommandType(CommandType.Text)
                .CommandText(_sql)
                .AsEnumerable()
                .ToList();
        }
    }
}