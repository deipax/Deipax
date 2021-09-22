using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class PrimitiveBase
    {
        [GlobalSetup]
        public void Setup()
        {
            _int = RandGen.GenerateInt();

            _string = RandGen.GenerateString(100);

            _listOfStrings = RandGen.GenerateStringList(1000, 5);

            _listOfBytes = RandGen
                .GenerateByteArray(100000000)
                .ToList();

            _listOfInts = RandGen.GenerateIntList(1000);

            _listOfTimeSpans = new List<TimeSpan>()
            {
                new TimeSpan(0),
                new TimeSpan(1),
                new TimeSpan(2),
                new TimeSpan(3),
                new TimeSpan(4),
                new TimeSpan(5),
                new TimeSpan(6),
                new TimeSpan(7),
                new TimeSpan(8),
                new TimeSpan(9),
            };

            _listOfDateTimes = new List<DateTime>()
            {
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
            };

            Func<string> func = () =>
            {
                return string.Empty;
            };

            _listOfDelegates = new List<Func<string>>()
            {
                func,
                func,
                func,
                func,
                func,
                func,
                func,
                func,
                func,
                func,
            };
        }

        #region Field Members
        private int _int;
        private string _string;
        private List<string> _listOfStrings;
        private List<byte> _listOfBytes;
        private List<int> _listOfInts;
        private List<TimeSpan> _listOfTimeSpans;
        private List<DateTime> _listOfDateTimes;
        private List<Func<string>> _listOfDelegates;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public int Int() => GetClone(_int);

        [Benchmark]
        public string String() => GetClone(_string);

        [Benchmark]
        public List<string> ListOfStrings() => GetClone(_listOfStrings);

        [Benchmark]
        public List<byte> ListOfBytes() => GetClone(_listOfBytes);

        [Benchmark]
        public List<int> ListOfInts() => GetClone(_listOfInts);

        [Benchmark]
        public List<TimeSpan> ListOfTimeSpan() => GetClone(_listOfTimeSpans);

        [Benchmark]
        public List<DateTime> ListOfDateTime() => GetClone(_listOfDateTimes);

        [Benchmark]
        public List<Func<string>> ListOfDelegate() => GetClone(_listOfDelegates);
    }
}