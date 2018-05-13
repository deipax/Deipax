﻿using BenchmarkDotNet.Attributes;
using Dapper;
using Deipax.DataAccess.Interfaces;
using System.Data;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Deipax
{
    public class DeipaxSelect : BaseSelect
    {
        #region Field Members
        private IDbCon _dbCon;
        private IDbConnection _dbConnection;
        #endregion

        [GlobalSetup]
        public void GlobalSetup()
        {
            DbHelper.SetDbInitializer();
            DbHelper.SetDefaultConnectionFactory();
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
                .AsList<MultipleFieldClass>();
        }

        [Benchmark]
        public void AllFieldsAsStruct_Deipax()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldStruct>();
        }

        [Benchmark]
        public void AllFieldsAsClass_Dapper()
        {
            var tmp = _dbConnection.Query<MultipleFieldClass>(_sql);
        }

        [Benchmark]
        public void AllFieldsAsStruct_Dapper()
        {
            var tmp = _dbConnection.Query<MultipleFieldStruct>(_sql);
        }
    }
}