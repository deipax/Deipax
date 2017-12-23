using Deipax.DataAccess.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTests.DataAccess
{
    [TestClass]
    public class DbManagerTests
    {
        [TestMethod]
        public void Get()
        {
            var db1 = DbManager.Get("Northwind");
            Assert.IsTrue(db1 != null);

            var db2 = DbManager.Get("BogusName");
            Assert.IsTrue(db2 == null);

            var db3 = DbManager.Get("Northwind");
            Assert.AreSame(db1, db3);
        }

        [TestMethod]
        public void GetAll()
        {
            var dbs = DbManager.GetAll();

            Assert.IsTrue(dbs != null);
            Assert.IsTrue(dbs.Count() > 0);
        }

        [TestMethod]
        public void Clear()
        {
            var db1 = DbManager.Get("Northwind");
            DbManager.Clear();
            var db2 = DbManager.Get("Northwind");
            Assert.IsNotNull(db1);
            Assert.IsNotNull(db2);
            Assert.AreNotSame(db1, db2);
        }
    }
}