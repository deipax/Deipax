using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Core
{
    [TestClass]
    public class DynamicDictionaryTests
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

        private static dynamic _dynamicDict;
        #endregion

        [TestInitialize]
        public void GlobalSetup()
        {
            _dynamicDict = new DynamicDictionary();

            IDictionary<string, object> dict = _dynamicDict;

            _fieldNames.ForEach(x => dict.Add(x, RandGen.GenerateInt()));
        }

        [TestMethod]
        public void ReadAsDictionary_DynamicDict()
        {
            foreach (var field in _fieldNames)
            {
                var value = _dynamicDict[field];
            }
        }

        [TestMethod]
        public void WriteAsDictionary_DynamicDict()
        {
            foreach (var field in _fieldNames)
            {
                _dynamicDict[field] = 10;
            }
        }

        [TestMethod]
        public void ReadAsDynamic_DynamicDict()
        {
            var tmp0 = _dynamicDict.Field0;
            var tmp1 = _dynamicDict.Field1;
            var tmp2 = _dynamicDict.Field2;
            var tmp3 = _dynamicDict.Field3;
            var tmp4 = _dynamicDict.Field4;
            var tmp5 = _dynamicDict.Field5;
            var tmp6 = _dynamicDict.Field6;
            var tmp7 = _dynamicDict.Field7;
            var tmp8 = _dynamicDict.Field8;
            var tmp9 = _dynamicDict.Field9;
        }

        [TestMethod]
        public void WriteAsDynamic_DynamicDict()
        {
            _dynamicDict.Field0 = 10;
            _dynamicDict.Field1 = 10;
            _dynamicDict.Field2 = 10;
            _dynamicDict.Field3 = 10;
            _dynamicDict.Field4 = 10;
            _dynamicDict.Field5 = 10;
            _dynamicDict.Field6 = 10;
            _dynamicDict.Field7 = 10;
            _dynamicDict.Field8 = 10;
            _dynamicDict.Field9 = 10;
        }
    }
}