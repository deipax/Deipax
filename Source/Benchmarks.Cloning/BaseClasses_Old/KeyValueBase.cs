using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class KeyValueBase
    {
        [GlobalSetup]
        public void Setup()
        {
            _primitives = new KeyValuePair<int, string>(10, "test");

            _classes = new KeyValuePair<Helper1, Helper1>(
                new Helper1() { PropOne = 1 },
                new Helper1() { PropOne = 2 });

            _structs = new KeyValuePair<HelperStruct1, HelperStruct1>(
                new HelperStruct1() { PropOne = 1 },
                new HelperStruct1() { PropOne = 2 });

            _nulls = new KeyValuePair<Helper1, Helper1>(null, null);
        }

        #region Field Members
        private KeyValuePair<int, string> _primitives;
        private KeyValuePair<Helper1, Helper1> _classes;
        private KeyValuePair<HelperStruct1, HelperStruct1> _structs;
        private KeyValuePair<Helper1, Helper1> _nulls;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public KeyValuePair<int, string> Primitives() => GetClone(_primitives);

        [Benchmark]
        public KeyValuePair<Helper1, Helper1> Classes() => GetClone(_classes);

        [Benchmark]
        public KeyValuePair<HelperStruct1, HelperStruct1> Structs() => GetClone(_structs);

        [Benchmark]
        public KeyValuePair<Helper1, Helper1> Nulls() => GetClone(_nulls);
    }
}