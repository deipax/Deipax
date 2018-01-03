using BenchmarkDotNet.Attributes;
using Deipax.DataAccess.Common;
using System.Collections.Generic;
using UnitTests.Common;

namespace Benchmarks.DataAccess.Deipax
{
    public class DynamicBench
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

        [GlobalSetup]
        public void GlobalSetup()
        {
            _dynamicDict = new DynamicDictionary<object>();
            _fieldNames.ForEach(x => _dynamicDict.Add(x, RandGen.GenerateInt()));
        }

        [Benchmark]
        public void ReadAsDictionary_DynamicDict()
        {
            foreach (var field in _fieldNames)
            {
                var value = _dynamicDict[field];
            }
        }

        [Benchmark]
        public void WriteAsDictionary_DynamicDict()
        {
            foreach (var field in _fieldNames)
            {
                _dynamicDict[field] = 10;
            }
        }

        [Benchmark]
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

        [Benchmark]
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