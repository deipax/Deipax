using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Globalization;
using UnitTests.Common;

namespace Benchmarks.DataAccess
{
    public class AdHoc : BaseSelect
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
            var dbCmd = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql);

            _reader = dbCmd.CreateCommand().ExecuteReader();
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
        #endregion

        #region Public Members
        [Benchmark]
        public void IsDbNullAndGetString()
        {
            var y = _record.IsDBNull(_index);
            var x = _record.GetString(_index);
        }

        [Benchmark]
        public void GetStringAsObject()
        {
            var x = _record.GetValue(_index);
        }
        #endregion
    }
}