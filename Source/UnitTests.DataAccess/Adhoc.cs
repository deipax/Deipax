using Deipax.DataAccess.Extensions;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using UnitTests.Common;

namespace UnitTests.DataAccess
{
    [TestClass]
    public class Adhoc : SqliteSql
    {
        #region Field Members
        private IDbCon _dbCon;
        private IDbCmd _dbCmd;
        #endregion

        [TestInitialize]
        public void Init()
        {
            _dbCon = DbHelper.GetNorthwind().CreateDbCon();

            _dbCmd = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql);
        }

        //[TestMethod]
        public void Tmp()
        {
            IReadOnlyDictionary<string, Type> fieldInfo;

            using (var reader = _dbCmd.CreateCommand().ExecuteReader())
            {
                fieldInfo = reader.GetFieldInfo();
            }
        }
    }
}