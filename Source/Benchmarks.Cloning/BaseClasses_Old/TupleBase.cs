using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class TupleBase
    {
        public TupleBase()
        {
            _primitives = new Tuple<int, string, int, int, int, int, int, Tuple<int>>(
                RandGen.GenerateInt(),
                RandGen.GenerateString(10),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                new Tuple<int>(RandGen.GenerateInt()));

            _classes = new Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>(
                new Helper1() { PropOne = 1 },
                new Helper1() { PropOne = 2 },
                new Helper1() { PropOne = 3 },
                new Helper1() { PropOne = 4 },
                new Helper1() { PropOne = 5 },
                new Helper1() { PropOne = 6 },
                new Helper1() { PropOne = 7 },
                new Tuple<Helper1>(new Helper1() { PropOne = 8 }));

            _structs = new Tuple<HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, Tuple<HelperStruct1>>(
                new HelperStruct1() { PropOne = 1 },
                new HelperStruct1() { PropOne = 2 },
                new HelperStruct1() { PropOne = 3 },
                new HelperStruct1() { PropOne = 4 },
                new HelperStruct1() { PropOne = 5 },
                new HelperStruct1() { PropOne = 6 },
                new HelperStruct1() { PropOne = 7 },
                new Tuple<HelperStruct1>(new HelperStruct1() { PropOne = 8 }));

            var helper = new Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>(
                new Helper1(),
                new Helper1(),
                new Helper1(),
                new Helper1(),
                new Helper1(),
                new Helper1(),
                new Helper1(),
                new Tuple<Helper1>(new Helper1()));

            _duplicates = new List<Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>>();

            for (int i = 0; i < 10000; i++)
            {
                _duplicates.Add(helper);
            }
        }

        #region Field Members
        private readonly Tuple<int, string, int, int, int, int, int, Tuple<int>> _primitives;
        private readonly Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>> _classes;
        private readonly Tuple<HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, Tuple<HelperStruct1>> _structs;
        private readonly Tuple<int> _null;
        private readonly List<Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>> _duplicates;
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
        public void Null()
        {
            var target = GetClone(_null);
        }

        [Benchmark]
        public void TupleCloneLogicTests_List_TupleOfClasses_Duplicates()
        {
            var target = GetClone(_duplicates);
        }
    }
}