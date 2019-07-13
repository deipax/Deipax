using Deipax.DataAccess.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.DataAccess.BaseTests
{
    [TestClass]
    public abstract class BaseTest
    {
        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            DbConfig.SetDbInitializer(DbInit.Initialize);
            DbConfig.DbConnectionFactory = DbInit.CreateDbConnection;
        }
    }
}