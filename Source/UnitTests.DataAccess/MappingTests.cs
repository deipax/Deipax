using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using UnitTests.Common;

namespace UnitTests.DataAccess
{
    [TestClass]
    public class MappingTests : BaseSelect
    {
        #region Field Members
        private IDbCon _dbCon;
        #endregion

        [TestInitialize]
        public void Init()
        {
            _dbCon = DbHelper.GetNorthwind().CreateDbCon();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _dbCon.Dispose();
        }

        [TestMethod]
        public override void AllFieldsAsClass()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldClass>();
        }

        [TestMethod]
        public override void AllFieldsAsStruct()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<MultipleFieldStruct>();
        }

        [TestMethod]
        public override void SingleFieldAsClass()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<SingleFieldClass>();
        }

        [TestMethod]
        public override void SingleFieldAsStruct()
        {
            var tmp = _dbCon
                .CreateDbCmd()
                .SetCommandType(CommandType.Text)
                .SetSql(_sql)
                .AsList<SingleFieldStruct>();
        }
    }
}