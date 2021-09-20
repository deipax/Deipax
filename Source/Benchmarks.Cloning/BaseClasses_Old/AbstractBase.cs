using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class AbstractBase
    {
        public AbstractBase()
        {
            _readOnlyListString = RandGen.GenerateStringList(1000, 5);
            _grandChildAsInterface = GrandChildClassHelper.Generate();
            _readOnlyListInterface = new List<MyTmpInterface>()
            {
                new Helper1() { PropOne = RandGen.GenerateInt() },
                new Helper1_1() { PropOne = RandGen.GenerateInt() },
            };
        }

        #region Field Members
        private readonly IReadOnlyList<string> _readOnlyListString;
        private readonly MyInterface _grandChildAsInterface;
        private readonly IReadOnlyList<MyTmpInterface> _readOnlyListInterface;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public IReadOnlyList<string> IRealOnlyList_String() => GetClone(_readOnlyListString);

        [Benchmark]
        public MyInterface GrandChildClass_AsInterface() => GetClone(_grandChildAsInterface);

        [Benchmark]
        public IReadOnlyList<MyTmpInterface> IRealOnlyList_Interface() => GetClone(_readOnlyListInterface);
    }
}