using BenchmarkDotNet.Attributes;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class ComplexValueTypeBase
    {
        public ComplexValueTypeBase()
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
        private readonly HelperStruct2 _complexStruct;
        private readonly HelperStruct1 _simpleStruct;
        private readonly HelperStruct1 _nullStruct;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public void ComplexStruct()
        {
            var target = GetClone(_complexStruct);
        }

        [Benchmark]
        public void SimpleStruct()
        {
            var target = GetClone(_simpleStruct);
        }

        [Benchmark]
        public void NullStruct()
        {
            var target = GetClone(_nullStruct);
        }
    }
}