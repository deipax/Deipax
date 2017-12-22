using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses_Old
{
    public abstract class PrimitiveBase
    {
        public PrimitiveBase()
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
        private readonly int _int;
        private readonly string _string;
        private readonly List<string> _listOfStrings;
        private readonly List<byte> _listOfBytes;
        private readonly List<int> _listOfInts;
        private readonly List<TimeSpan> _listOfTimeSpans;
        private readonly List<DateTime> _listOfDateTimes;
        private readonly List<Func<string>> _listOfDelegates;
        #endregion

        protected abstract T GetClone<T>(T source);

        [Benchmark]
        public void Int()
        {
            var target = GetClone(_int);
        }

        [Benchmark]
        public void String()
        {
            var target = GetClone(_string);
        }

        [Benchmark]
        public void ListOfStrings()
        {
            var target = GetClone(_listOfStrings);
        }

        [Benchmark]
        public void ListOfBytes()
        {
            var target = GetClone(_listOfBytes);
        }

        [Benchmark]
        public void ListOfInts()
        {
            var target = GetClone(_listOfInts);
        }

        [Benchmark]
        public void ListOfTimeSpan()
        {
            var target = GetClone(_listOfTimeSpans);
        }

        [Benchmark]
        public void ListOfDateTime()
        {
            var target = GetClone(_listOfDateTimes);
        }

        [Benchmark]
        public void ListOfDelegate()
        {
            var target = GetClone(_listOfDelegates);
        }
    }
}