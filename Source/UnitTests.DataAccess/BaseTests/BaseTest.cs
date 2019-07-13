using Deipax.DataAccess.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.DataAccess.BaseTests
{
    [TestClass]
    public abstract class BaseTest
    {
        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            DbConfig.SetDbInitializer(DbHelper.Initialize);
            DbConfig.DbConnectionFactory = DbHelper.CreateDbConnection;
        }
    }
}