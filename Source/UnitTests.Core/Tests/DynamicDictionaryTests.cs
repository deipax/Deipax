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

        private dynamic _dynamic;
        private IDictionary<string, object> _dynamicDict;
        #endregion

        [TestInitialize]
        public void GlobalSetup()
        {
            _dynamic = new DynamicDictionary();
            _dynamicDict = _dynamic;
            _fieldNames.ForEach(x => _dynamicDict.Add(x, RandGen.GenerateInt()));
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
            var tmp0 = _dynamic.Field0;
            var tmp1 = _dynamic.Field1;
            var tmp2 = _dynamic.Field2;
            var tmp3 = _dynamic.Field3;
            var tmp4 = _dynamic.Field4;
            var tmp5 = _dynamic.Field5;
            var tmp6 = _dynamic.Field6;
            var tmp7 = _dynamic.Field7;
            var tmp8 = _dynamic.Field8;
            var tmp9 = _dynamic.Field9;
        }

        [TestMethod]
        public void WriteAsDynamic_DynamicDict()
        {
            _dynamic.Field0 = 10;
            _dynamic.Field1 = 10;
            _dynamic.Field2 = 10;
            _dynamic.Field3 = 10;
            _dynamic.Field4 = 10;
            _dynamic.Field5 = 10;
            _dynamic.Field6 = 10;
            _dynamic.Field7 = 10;
            _dynamic.Field8 = 10;
            _dynamic.Field9 = 10;
        }
    }
}