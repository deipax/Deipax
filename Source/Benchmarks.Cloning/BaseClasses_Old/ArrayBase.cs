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
        public void IntArray()
        {
            var target = GetClone(_intArray);
        }

        [Benchmark]
        public void ByteArray()
        {
            var target = GetClone(_byteArray);
        }

        [Benchmark]
        public void StringArray()
        {
            var target = GetClone(_stringArray);
        }

        [Benchmark]
        public void TimeSpanArray()
        {
            var target = GetClone(_timeSpanArray);
        }

        [Benchmark]
        public void DateTimeArray()
        {
            var target = GetClone(_dateTimeArray);
        }

        [Benchmark]
        public void DelegateArray()
        {
            var target = GetClone(_delegateArray);
        }

        [Benchmark]
        public void ArrayOfStringArrays()
        {
            var target = GetClone(_arrayOfStringArrays);
        }

        [Benchmark]
        public void ArrayOfClasses()
        {
            var target = GetClone(_arrayOfClasses);
        }

        [Benchmark]
        public void ArrayOfStruct()
        {
            var target = GetClone(_arrayOfStructs);
        }
    }
}