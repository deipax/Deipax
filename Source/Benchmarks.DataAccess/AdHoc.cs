using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Globalization;
using UnitTests.Common;

namespace Benchmarks.DataAccess
{
    public class AdHoc : SqliteSql
    {
        #region Field Members
        private IDbCon _dbCon;
        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            DbHelper.SetDbInitializer();
            DbHelper.SetDefaultConnectionFactory();
            _dbCon = DbHelper.GetNorthwind().CreateDbCon();
            _dbCmd = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql);

            _reader = _dbCmd.CreateCommand().ExecuteReader();
            _reader.Read();
            _record = _reader;
            _index = _reader.GetOrdinal("CustomerPhone");
            _instance = new MultipleFieldClass();
            _provider = CultureInfo.InvariantCulture;
        }

        #region Field Member
        private IDataReader _reader;
        private IDataRecord _record;
        private int _index;
        private MultipleFieldClass _instance;
        private IFormatProvider _provider;
        private IDbCmd _dbCmd;
        #endregion

        #region Public Members
        //[Benchmark]
        public void IsDbNullAndGetString()
        {
            var y = _record.IsDBNull(_index);
            var x = _record.GetString(_index);
        }

        //[Benchmark]
        public void GetStringAsObject()
        {
            var x = _record.GetValue(_index);
        }

        [Benchmark]
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

        [Benchmark]
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

        [Benchmark]
        public void ReadBulkRead()
        {
            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                var fieldCount = reader.FieldCount;
                object[] objects = new Object[fieldCount];

                while (reader.Read())
                {
                    reader.GetValues(objects);
                }
            }
        }
        #endregion
    }
}