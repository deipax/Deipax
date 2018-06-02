using System.Collections.Generic;
using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Core
{
    [TestClass]
    public class DynamicRowTests
    {
        #region Fields
        private static readonly List<string> _fieldNames = new List<string>
        {
            "Field0",
            "Field1",
            "Field2",
            "Field3",
            "Field4",
            "Field5",
            "Field6",
            "Field7",
            "Field8",
            "Field9"
        };

        private dynamic _dynamicRow;
        private IDictionary<string, object> _dynamicRowAsDict;
        #endregion

        [TestInitialize]
        public void GlobalSetup()
        {
            DynamicTable table = new DynamicTable(_fieldNames);
            _dynamicRow = new DynamicRow(table);
            _dynamicRowAsDict = _dynamicRow;
            _fieldNames.ForEach(x => _dynamicRow.Add(x, RandGen.GenerateInt()));
        }

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

        [TestMethod]
        public void ReadAsDictionary_DynamicRow()
        {
            foreach (var field in _fieldNames)
            {
                var value = _dynamicRowAsDict[field];
            }
        }

        [TestMethod]
        public void WriteAsDictionary_DynamicRow()
        {
            foreach (var field in _fieldNames)
            {
                _dynamicRowAsDict[field] = 10;
            }
        }

        [TestMethod]
        public void ReadAsDynamic_DynamicRow()
        {
            var tmp0 = _dynamicRow.Field0;
            var tmp1 = _dynamicRow.Field1;
            var tmp2 = _dynamicRow.Field2;
            var tmp3 = _dynamicRow.Field3;
            var tmp4 = _dynamicRow.Field4;
            var tmp5 = _dynamicRow.Field5;
            var tmp6 = _dynamicRow.Field6;
            var tmp7 = _dynamicRow.Field7;
            var tmp8 = _dynamicRow.Field8;
            var tmp9 = _dynamicRow.Field9;
        }

        [TestMethod]
        public void WriteAsDynamic_DynamicRow()
        {
            _dynamicRow.Field0 = 10;
            _dynamicRow.Field1 = 10;
            _dynamicRow.Field2 = 10;
            _dynamicRow.Field3 = 10;
            _dynamicRow.Field4 = 10;
            _dynamicRow.Field5 = 10;
            _dynamicRow.Field6 = 10;
            _dynamicRow.Field7 = 10;
            _dynamicRow.Field8 = 10;
            _dynamicRow.Field9 = 10;
        }
    }
}