using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ShallowCloneListBase
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [Fact]
        public void ListOfStrings()
        {
            List<string> source = RandGen.GenerateStringList(1000, 10);

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.Equal(dest.Count, source.Count);

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.Equal(dest[i], source[i]);
            }

            source.Clear();

            Assert.NotEqual(source.Count, dest.Count);
        }

        [Fact]
        public void ListOfBytes()
        {
            List<byte> source = RandGen
                .GenerateByteArray(1000)
                .ToList();

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.Equal(dest.Count, source.Count);

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.Equal(dest[i], source[i]);
            }

            source.Clear();

            Assert.NotEqual(source.Count, dest.Count);
        }

        [Fact]
        public void ListOfInts()
        {
            List<int> source = RandGen.GenerateIntList(1000);

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.Equal(dest.Count, source.Count);

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.Equal(dest[i], source[i]);
            }

            source.Clear();

            Assert.NotEqual(source.Count, dest.Count);
        }

        [Fact]
        public void ListOfStringList_DuplicateReuse()
        {
            var helper = RandGen.GenerateStringList(20, 5);

            List<List<string>> source = new List<List<string>>()
            {
                helper,
                helper,
                helper,
                helper
            };

            var dest = GetClone(source, 2);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Count, source.Count);

            var firstItem = dest[0];

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.NotSame(source[i], dest[i]);
                Assert.Same(firstItem, dest[i]);
                Assert.Equal(source[i].Count, dest[i].Count);

                for (int j = 0; j < dest[i].Count; j++)
                {
                    Assert.Equal(source[i][j], dest[i][j]);
                }
            }

            source.Clear();

            Assert.NotEqual(source.Count, dest.Count);
        }
    }
}