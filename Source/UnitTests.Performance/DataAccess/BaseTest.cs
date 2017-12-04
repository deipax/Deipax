using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Common;

namespace Performance.DataAccess
{
    [TestClass]
    public abstract class BaseTest
    {
        #region Field Members
        private static readonly string _outDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        #endregion

        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext testContext)
        {
            DbHelper.SetDbInitializer();
            DbHelper.SetDefaultConnectionFactory();
        }
    }
}