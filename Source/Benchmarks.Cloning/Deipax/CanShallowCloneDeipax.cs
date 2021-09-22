using BenchmarkDotNet.Attributes;
using Deipax.Cloning.Extensions;
using System;
using UnitTests.Common;

namespace Benchmarks.Cloning.Deipax
{
    public class CanShallowCloneDeipax
    {
        [GlobalSetup]
        public void Setup()
        {
            _decimalType = typeof(decimal);
            _complexStruct = typeof(ComplexStruct);
        }

        #region Field Members
        private Type _decimalType;
        private Type _complexStruct;
        #endregion

        [Benchmark]
        public bool CanShallowClone_Decimal() => _decimalType.CanShallowClone();

        [Benchmark]
        public bool CanShallowClone_ComplexStruct() => _complexStruct.CanShallowClone();
    }
}