using BenchmarkDotNet.Attributes;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class ComplexValueTypeBase
    {
        [GlobalSetup]
        public void Setup()
        {
            _complexStruct = new HelperStruct2()
            {
                Helper = new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt(),
                    PropTwo = RandGen.GenerateInt(),
                    PropThree = RandGen.GenerateInt()
                }
            };

            _simpleStruct = new HelperStruct1()
            {
                PropOne = RandGen.GenerateInt(),
                PropTwo = RandGen.GenerateInt(),
                PropThree = RandGen.GenerateInt()
            };

            _nullStruct = default;
        }

        #region Field Members
        private HelperStruct2 _complexStruct;
        private HelperStruct1 _simpleStruct;
        private HelperStruct1 _nullStruct;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public HelperStruct2 ComplexStruct() => GetClone(_complexStruct);

        [Benchmark]
        public HelperStruct1 SimpleStruct() => GetClone(_simpleStruct);

        [Benchmark]
        public HelperStruct1 NullStruct() => GetClone(_nullStruct);
    }
}