using System;
using System.Collections.Generic;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class TupleBase
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [Fact]
        public void Primitives()
        {
            var source = new Tuple<int, string, int, int, int, int, int, Tuple<int>>(
                RandGen.GenerateInt(),
                RandGen.GenerateString(10),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                RandGen.GenerateInt(),
                new Tuple<int>(RandGen.GenerateInt()));

            var target = GetClone(source, 2);
            Assert.Equal(source, target);
            Assert.NotSame(source, target);
            Assert.Equal(source.Item1, target.Item1);
            Assert.Equal(source.Item2, target.Item2);
            Assert.Same(source.Item2, target.Item2);
            Assert.Equal(source.Item3, target.Item3);
            Assert.Equal(source.Item4, target.Item4);
            Assert.Equal(source.Item5, target.Item5);
            Assert.Equal(source.Item6, target.Item6);
            Assert.Equal(source.Item7, target.Item7);
            Assert.Equal(source.Rest, target.Rest);
            Assert.NotSame(source.Rest, target.Rest);
        }

        [Fact]
        public void Class()
        {
            var source = new Tuple<Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Helper1, Tuple<Helper1>>(
                new Helper1() { PropOne = 1 },
                new Helper1() { PropOne = 2 },
                new Helper1() { PropOne = 3 },
                new Helper1() { PropOne = 4 },
                new Helper1() { PropOne = 5 },
                new Helper1() { PropOne = 6 },
                new Helper1() { PropOne = 7 },
                new Tuple<Helper1>(new Helper1() { PropOne = 8 }));

            var target = GetClone(source, 10);

            Assert.NotSame(source, target);

            Assert.NotSame(source.Item1, target.Item1);
            Assert.Equal(source.Item1.PropOne, target.Item1.PropOne);

            Assert.NotSame(source.Item2, target.Item2);
            Assert.Equal(source.Item2.PropOne, target.Item2.PropOne);

            Assert.NotSame(source.Item3, target.Item3);
            Assert.Equal(source.Item3.PropOne, target.Item3.PropOne);

            Assert.NotSame(source.Item4, target.Item4);
            Assert.Equal(source.Item4.PropOne, target.Item4.PropOne);

            Assert.NotSame(source.Item5, target.Item5);
            Assert.Equal(source.Item5.PropOne, target.Item5.PropOne);

            Assert.NotSame(source.Item6, target.Item6);
            Assert.Equal(source.Item6.PropOne, target.Item6.PropOne);

            Assert.NotSame(source.Item7, target.Item7);
            Assert.Equal(source.Item7.PropOne, target.Item7.PropOne);

            Assert.NotSame(source.Rest, target.Rest);
            Assert.NotSame(source.Rest.Item1, target.Rest.Item1);
            Assert.Equal(source.Rest.Item1.PropOne, target.Rest.Item1.PropOne);
        }

        [Fact]
        public void Struct()
        {
            var source = new Tuple<HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, HelperStruct1, Tuple<HelperStruct1>>(
                new HelperStruct1() { PropOne = 1 },
                new HelperStruct1() { PropOne = 2 },
                new HelperStruct1() { PropOne = 3 },
                new HelperStruct1() { PropOne = 4 },
                new HelperStruct1() { PropOne = 5 },
                new HelperStruct1() { PropOne = 6 },
                new HelperStruct1() { PropOne = 7 },
                new Tuple<HelperStruct1>(new HelperStruct1() { PropOne = 8 }));

            var target = GetClone(source, 2);

            Assert.NotSame(source, target);

            Assert.Equal(source.Item1, target.Item1);
            Assert.Equal(source.Item1.PropOne, target.Item1.PropOne);

            Assert.Equal(source.Item2, target.Item2);
            Assert.Equal(source.Item2.PropOne, target.Item2.PropOne);

            Assert.Equal(source.Item3, target.Item3);
            Assert.Equal(source.Item3.PropOne, target.Item3.PropOne);

            Assert.Equal(source.Item4, target.Item4);
            Assert.Equal(source.Item4.PropOne, target.Item4.PropOne);

            Assert.Equal(source.Item5, target.Item5);
            Assert.Equal(source.Item5.PropOne, target.Item5.PropOne);

            Assert.Equal(source.Item6, target.Item6);
            Assert.Equal(source.Item6.PropOne, target.Item6.PropOne);

            Assert.Equal(source.Item7, target.Item7);
            Assert.Equal(source.Item7.PropOne, target.Item7.PropOne);

            Assert.NotSame(source.Rest, target.Rest);
            Assert.Equal(source.Rest.Item1, target.Rest.Item1);
            Assert.Equal(source.Rest.Item1.PropOne, target.Rest.Item1.PropOne);
        }

        [Fact]
        public void NullInt()
        {
            var source = (Tuple<int>)null;
            var target = GetClone(source, 0);
            Assert.Null(target);
        }

        [Fact]
        public void DuplicateReuse()
        {
            Tuple<int> helper = new Tuple<int>(1);
            List<Tuple<int>> source = new List<Tuple<int>>()
            {
                helper,
                helper
            };

            var target = GetClone(source, 2);

            Assert.NotSame(source, target);
            Assert.Equal(source.Count, target.Count);
            Assert.NotSame(source[0], target[0]);
            Assert.NotSame(source[1], target[1]);

            Assert.Same(target[0], target[1]);
        }
    }
}
