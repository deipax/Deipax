using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Interfaces;
using System.Data;
using System.Linq;
using UnitTests.Common;

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
                .AsEnumerable<MultipleFieldClass>()
                .ToList();
        }

        [Benchmark]
        public void AllFieldsAsStruct_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsEnumerable<MultipleFieldStruct>()
                .ToList();
        }

        [Benchmark]
        public void DynamicList_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsDynamicEnumerable()
                .ToList();
        }
    }
}