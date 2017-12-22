using BenchmarkDotNet.Attributes;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class NullableBase
    {
        public NullableBase()
        {
            _nullableInt = RandGen.GenerateInt();
            _nullInt = null;
            _struct = new HelperStruct1();
        }

        #region Field Members
        private readonly int? _nullableInt;
        private readonly int? _nullInt;
        private readonly HelperStruct1? _struct;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public void Int()
        {
            var target = GetClone(_nullableInt);
        }

        [Benchmark]
        public void NullInt()
        {
            var target = GetClone(_nullInt);
        }

        [Benchmark]
        public void Struct()
        {
            var target = GetClone(_struct);
        }
    }
}