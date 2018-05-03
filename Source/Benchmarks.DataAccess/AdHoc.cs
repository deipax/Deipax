using System.Data;
using BenchmarkDotNet.Attributes;
using Benchmarks.DataAccess.BaseClasses;
using Deipax.DataAccess.Interfaces;
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
            var cmd = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql);

            _reader = CreateCommand(cmd).ExecuteReader();
            _reader.Read();
            _index = _reader.GetOrdinal("EmployeeId");
        }

        #region Field Member
        private IDataReader _reader;
        private int _index;
        #endregion

        #region Public Members
        [Benchmark]
        public void ReadAsInt()
        {
            int x = _reader.GetInt32(_index);
        }

        [Benchmark]
        public void ReadAsObject()
        {
            object x = _reader.GetValue(_index);
        }

        public override void AllFieldsAsClass()
        {
            throw new System.NotImplementedException();
        }

        public override void AllFieldsAsStruct()
        {
            throw new System.NotImplementedException();
        }

        public override void SingleFieldAsClass()
        {
            throw new System.NotImplementedException();
        }

        public override void SingleFieldAsStruct()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Private Members
        private static IDbCommand CreateCommand(
           IDbCmd source)
        {
            var cmd = source.Connection.CreateCommand();

            var prop = cmd.GetType().GetProperty("BindByName");

            if (prop != null)
            {
                prop.SetValue(cmd, true);
            }

            if (source.Timeout > 0)
            {
                cmd.CommandTimeout = source.Timeout;
            }

            cmd.Transaction = source.Transaction;
            cmd.CommandText = source.Sql;
            cmd.CommandType = source.CommandType;
            cmd.Parameters.Clear();

            foreach (var p in source.Parameters)
            {
                cmd.Parameters.Add(p);
            }

            return cmd;
        }
        #endregion
    }
}