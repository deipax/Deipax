using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class KeyValueBase
    {
        public KeyValueBase()
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
        private readonly KeyValuePair<int, string> _primitives;
        private readonly KeyValuePair<Helper1, Helper1> _classes;
        private readonly KeyValuePair<HelperStruct1, HelperStruct1> _structs;
        private readonly KeyValuePair<Helper1, Helper1> _nulls;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public void Primitives()
        {
            var target = GetClone(_primitives);
        }

        [Benchmark]
        public void Classes()
        {
            var target = GetClone(_classes);
        }

        [Benchmark]
        public void Structs()
        {
            var target = GetClone(_structs);
        }

        [Benchmark]
        public void Nulls()
        {
            var target = GetClone(_nulls);
        }
    }
}