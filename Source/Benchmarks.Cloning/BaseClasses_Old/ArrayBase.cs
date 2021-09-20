using BenchmarkDotNet.Attributes;
using System;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class ArrayBase
    {
        public ArrayBase()
        {
            _intArray = new[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            _byteArray = RandGen.GenerateByteArray(1000);

            _stringArray = Enumerable
                .Range(0, 10)
                .Select(x => RandGen.GenerateString(10))
                .ToArray();

            _timeSpanArray = Enumerable
                .Range(0, 10)
                .Select(x => new TimeSpan(x))
                .ToArray();

            _dateTimeArray = Enumerable
                .Range(0, 10)
                .Select(x => DateTime.Now)
                .ToArray();

            Func<string> func = () =>
            {
                return string.Empty;
            };

            _delegateArray = Enumerable
                .Range(0, 10)
                .Select(x => func)
                .ToArray();

            _arrayOfStringArrays = new string[][]
            {
                new string [] { "one", "two" },
                new string [] { "three", "four" }
            };

            _arrayOfClasses = Enumerable
                .Range(0, 100)
                .Select(x => new Helper1()
                {
                    PropOne = RandGen.GenerateInt()
                })
                .ToArray();

            _arrayOfStructs = Enumerable
                .Range(0, 100)
                .Select(x => new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt()
                })
                .ToArray();
        }

        #region Field Members
        private readonly int[] _intArray;
        private readonly byte[] _byteArray;
        private readonly string[] _stringArray;
        private readonly TimeSpan[] _timeSpanArray;
        private readonly DateTime[] _dateTimeArray;
        private readonly Func<string>[] _delegateArray;
        private readonly string[][] _arrayOfStringArrays;
        private readonly Helper1[] _arrayOfClasses;
        private readonly HelperStruct1[] _arrayOfStructs;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public int[] IntArray() => GetClone(_intArray);

        [Benchmark]
        public byte[] ByteArray() => GetClone(_byteArray);

        [Benchmark]
        public string[] StringArray() => GetClone(_stringArray);

        [Benchmark]
        public TimeSpan[] TimeSpanArray() => GetClone(_timeSpanArray);

        [Benchmark]
        public DateTime[] DateTimeArray() => GetClone(_dateTimeArray);

        [Benchmark]
        public Func<string>[] DelegateArray() => GetClone(_delegateArray);

        [Benchmark]
        public string[][] ArrayOfStringArrays() => GetClone(_arrayOfStringArrays);

        [Benchmark]
        public Helper1[] ArrayOfClasses() => GetClone(_arrayOfClasses);

        [Benchmark]
        public HelperStruct1[] ArrayOfStruct() => GetClone(_arrayOfStructs);
    }
}