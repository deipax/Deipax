using BenchmarkDotNet.Attributes;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class NullableBase
    {
        [GlobalSetup]
        public void Setup()
        {
            _nullableInt = RandGen.GenerateInt();
            _nullInt = null;
            _struct = new HelperStruct1();
        }

        #region Field Members
        private int? _nullableInt;
        private int? _nullInt;
        private HelperStruct1? _struct;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public int? Int() => GetClone(_nullableInt);

        [Benchmark]
        public int? NullInt() => GetClone(_nullInt);

        [Benchmark]
        public HelperStruct1? Struct() => GetClone(_struct);
    }
}