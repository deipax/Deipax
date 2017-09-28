using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace Performance.Cloning
{
    [TestClass]
    public class PrimitiveListCloneLogicTests : BaseTest
    {
        [TestMethod]
        public void PrimitiveListCloneLogicTests_ListOfStrings()
        {
            List<string> source = RandGen.GenerateStringList(1000, 5);

            var result = TestingHelper.ComparePerformance(source, 100000, 100000);

            WriteLine(result.GetReport());
        }

        [TestMethod]
        public void PrimitiveListCloneLogicTests_ListOfBytes()
        {
            List<byte> source = RandGen
                .GenerateByteArray(100000000)
                .ToList();

            var result = TestingHelper.ComparePerformance(source, 10, 10);

            WriteLine(result.GetReport());
        }

        [TestMethod]
        public void PrimitiveListCloneLogicTests_ListOfInts()
        {
            List<int> source = RandGen.GenerateIntList(1000);

            var result = TestingHelper.ComparePerformance(source, 100000, 100000);

            WriteLine(result.GetReport());
        }

        [TestMethod]
        public void PrimitiveListCloneLogicTests_ListOfTimeSpan()
        {
            var source = new List<TimeSpan>()
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

            var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

            WriteLine(result.GetReport());
        }

        [TestMethod]
        public void PrimitiveListCloneLogicTests_ListOfDateTime()
        {
            var source = new List<DateTime>()
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

            var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

            WriteLine(result.GetReport());
        }

        [TestMethod]
        public void PrimitiveListCloneLogicTests_ListOfDelegate()
        {
            Func<string> func = () =>
            {
                return string.Empty;
            };

            var source = new List<Func<string>>()
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

            var result = TestingHelper.ComparePerformance(source, 2000000, 2000000);

            WriteLine(result.GetReport());
        }
    }
}