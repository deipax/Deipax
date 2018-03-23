using BenchmarkDotNet.Attributes;
using Deipax.Core.Conversion;
using System;

namespace Benchmarks.Core
{
    public class AdHoc
    {
        #region Field Members
        private static int _source = int.MaxValue;
        private static object _sourceAsObject = _source;
        #endregion

        //[Benchmark]
        public void ConvertTo_FromIntToLong()
        {
            long value = ConvertTo<long>.From(_source);
        }

        //[Benchmark]
        public void Convert_FromIntToLong()
        {
            long value = Convert.ToInt64(_source);
        }

        //[Benchmark]
        public void Convert_FromIntObjectToLong()
        {
            long value = Convert.ToInt64(_sourceAsObject);
        }

        //[Benchmark]
        public void ConvertTo_FromIntObjectToLong()
        {
            long value = ConvertTo<long>.From(_sourceAsObject);
        }

        //[Benchmark]
        public void Convert_FromNullIntObjectToLong()
        {
            long value = Convert.ToInt64(null);
        }

        //[Benchmark]
        public void ConvertTo_FromNullIntObjectToLong()
        {
            long value = ConvertTo<long>.From(null);
        }

        //[Benchmark]
        public void Convert_FromDbNullIntObjectToLong()
        {
            long value = Convert.ToInt64(DBNull.Value);
        }

        //[Benchmark]
        public void ConvertTo_FromDbNullIntObjectToLong()
        {
            long value = ConvertTo<long>.From(DBNull.Value);
        }
    }
}