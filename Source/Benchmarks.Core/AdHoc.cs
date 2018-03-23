using BenchmarkDotNet.Attributes;
using Deipax.Core.Conversion;
using System;

namespace Benchmarks.Core
{
    public class AdHoc
    {
        #region Field Members
        private int _source = int.MaxValue;
        #endregion

        [Benchmark]
        public void ConvertTo_FromIntToLong()
        {
            long value = ConvertTo<long>.From(_source);
        }

        [Benchmark]
        public void Convert_FromIntToLong()
        {
            long value = Convert.ToInt64(_source);
        }
    }
}