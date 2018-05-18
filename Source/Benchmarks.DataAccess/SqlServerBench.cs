using BenchmarkDotNet.Attributes;
using Dapper;
using Deipax.DataAccess.Interfaces;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess
{
    public class SqlServerBench : SqlServer
    {
        #region Field Members
        private IDbCon _dbCon;
        private IDbCmd _dbCmd;
        private IDbConnection _dbConnection;
        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            DbHelper.SetDbInitializer();
            DbHelper.SetDefaultConnectionFactory();
            _dbCon = DbHelper.GetNorthwindAzure().CreateDbCon();

            _dbCmd = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql);

            _dbConnection = _dbCon.GetConnection();
        }

        //[Benchmark]
        public void DeipaxAsClass()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<SqlServerClass>();
        }

        //[Benchmark]
        public void DapperAsClass()
        {
            var tmp = _dbConnection.Query<SqlServerClass>(_sql);
        }

        //[Benchmark]
        public void ReadEntireFieldRead()
        {
            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                var fieldCount = reader.FieldCount;

                while (reader.Read())
                {
                    for (int i = 0; i < fieldCount; i++)
                    {
                        object value = reader.GetValue(i);
                    }
                }
            }
        }

        //[Benchmark]
        public void ReadSingleFieldRead()
        {
            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                var fieldCount = reader.FieldCount;

                while (reader.Read())
                {
                    object value = reader.GetValue(0);
                }
            }
        }

        //[Benchmark]
        public void ReadBulkRead()
        {
            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                var fieldCount = reader.FieldCount;
                object[] objects = new object[fieldCount];

                while (reader.Read())
                {
                    reader.GetValues(objects);
                }
            }
        }
    }
}