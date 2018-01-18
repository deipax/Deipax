using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Deipax.Cloning.Extensions;
using System;
using UnitTests.Common;

namespace Benchmarks.Cloning.Deipax
{
    public class CanShallowCloneDeipax
    {
        #region Field Members
        private static Type _decimalType = typeof(decimal);
        private static Type _complexStruct = typeof(ComplexStruct);
        #endregion

        [Benchmark]
        public void CanShallowClone_Decimal()
        {
            _decimalType.CanShallowClone();
        }

        [Benchmark]
        public void CanShallowClone_ComplexStruct()
        {
            _complexStruct.CanShallowClone();
        }
    }
}