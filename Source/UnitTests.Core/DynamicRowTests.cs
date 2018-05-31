using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class DynamicRowTests
    {
        [TestMethod]
        public void CreateFromEmpty()
        {
            DynamicTable table = new DynamicTable();

            DynamicRow rowOne = new DynamicRow(table);
            dynamic dRowOne = rowOne;

            dRowOne.PropOne = "PropOne";
            dRowOne.PropTwo = 2;

            DynamicRow rowTwo = new DynamicRow(table);
            dynamic dRowTwo = rowTwo;

            Assert.AreEqual(dRowOne.PropOne, "PropOne");
            Assert.AreEqual(dRowOne.PropTwo, 2);

            Assert.AreEqual(dRowTwo.PropOne, default(object));
            Assert.AreEqual(dRowTwo.PropTwo, default(object));
        }
    }
}