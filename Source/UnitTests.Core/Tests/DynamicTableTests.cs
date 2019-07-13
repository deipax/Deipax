using System.Linq;
using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class DynamicTableTests
    {
        [TestMethod]
        public void CreateFromNull()
        {
            DynamicTable table = new DynamicTable(null);
            var names = table.GetNames();

            Assert.IsNotNull(names);
            Assert.IsTrue(names.Count() == 0);
            Assert.IsTrue(table.GetFieldCount() == 0);
            Assert.IsTrue(table.GetIndex("tmp") == -1);
            Assert.IsFalse(table.FieldExists("tmp"));
        }

        [TestMethod]
        public void CreateFromEmpty()
        {
            DynamicTable table = new DynamicTable(new string[0]);
            var names = table.GetNames();

            Assert.IsNotNull(names);
            Assert.IsTrue(names.Count() == 0);
            Assert.IsTrue(table.GetFieldCount() == 0);
            Assert.IsTrue(table.GetIndex("tmp") == -1);
            Assert.IsFalse(table.FieldExists("tmp"));
        }

        [TestMethod]
        public void CreateWithOneField()
        {
            DynamicTable table = new DynamicTable(new[] { "tmp" });
            var names = table.GetNames();

            Assert.IsNotNull(names);
            Assert.IsTrue(names.Count() == 1);
            Assert.IsTrue(table.GetFieldCount() == 1);
            Assert.IsTrue(table.GetIndex("tmp") == 0);
            Assert.IsTrue(table.FieldExists("tmp"));
        }

        [TestMethod]
        public void AddField()
        {
            DynamicTable table = new DynamicTable(null);
            var names = table.GetNames();

            Assert.IsNotNull(names);
            Assert.IsTrue(names.Count() == 0);
            Assert.IsTrue(table.GetFieldCount() == 0);
            Assert.IsTrue(table.GetIndex("tmp") == -1);
            Assert.IsFalse(table.FieldExists("tmp"));

            table.AddField("tmp");
            names = table.GetNames();

            Assert.IsNotNull(names);
            Assert.IsTrue(names.Count() == 1);
            Assert.IsTrue(table.GetFieldCount() == 1);
            Assert.IsTrue(table.GetIndex("tmp") == 0);
            Assert.IsTrue(table.FieldExists("tmp"));
        }
    }
}