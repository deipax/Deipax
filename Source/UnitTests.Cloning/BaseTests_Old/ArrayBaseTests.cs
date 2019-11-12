using System;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ArrayBaseTests
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [Fact]
        public void NullIntArray()
        {
            int[] source = null;
            var dest = GetClone(source, 0);
            Assert.Null(dest);
        }

        [Fact]
        public void EmptyIntArray()
        {
            int[] source = new int[0];
            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Length, source.Length);
        }

        [Fact]
        public void IntArray()
        {
            int[] source = new[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Length, source.Length);
            Assert.Equal(dest[0], source[0]);
        }

        [Fact]
        public void StringArray()
        {
            string[] source = new[] { "first string", string.Empty, null };

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Length, source.Length);
            Assert.Equal(dest[0], source[0]);
            Assert.Equal(dest[1], source[1]);
            Assert.Equal(dest[2], source[2]);
        }

        [Fact]
        public void ByteArray()
        {
            var source = RandGen.GenerateByteArray(1000);

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Length, source.Length);

            for (int i = 0; i < dest.Length; i++)
            {
                Assert.NotSame(dest, source);
                Assert.Equal(dest[i], source[i]);
            }
        }

        [Fact]
        public void ArrayOfStringArrays()
        {
            string[][] source = new string[][]
            {
                new string [] { "one", "two" },
                new string [] { "three", "four" }
            };

            var dest = GetClone(source, 3);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Length, source.Length);
            Assert.NotSame(dest[0], source[0]);
            Assert.NotSame(dest[1], source[1]);
            Assert.Equal(dest[0][0], source[0][0]);
            Assert.Equal(dest[0][1], source[0][1]);
            Assert.Equal(dest[1][0], source[1][0]);
            Assert.Equal(dest[1][1], source[1][1]);
        }

        [Fact]
        public void ArrayOfStringArrays_DuplicateReuse()
        {
            string[] helper = new string[] { "one", "two" };

            string[][] source = new string[][]
            {
                helper,
                helper,
                helper,
                helper
            };

            var dest = GetClone(source, 2);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Length, source.Length);

            var firstItem = dest[0];

            for (int i = 0; i < dest.Length; i++)
            {
                Assert.NotSame(source[i], dest[i]);
                Assert.Same(firstItem, dest[i]);
                Assert.Equal(source[i].Length, dest[i].Length);

                for (int j = 0; j < dest[i].Length; j++)
                {
                    Assert.Equal(source[i][j], dest[i][j]);
                }
            }
        }

        [Fact]
        public void ArrayOfStringArrays_Null()
        {
            string[][] source = null;
            var dest = GetClone(source, 0);
            Assert.Null(dest);
        }

        [Fact]
        public void ArrayOfNullableInts()
        {
            int?[] source = new int?[]
            {
                new int?(10),
                new int?(5),
                null
            };

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Length, source.Length);
            Assert.Equal(dest[0], source[0]);
            Assert.Equal(dest[1], source[1]);
            Assert.Equal(dest[2], source[2]);
            Assert.True(!dest[2].HasValue);
        }

        [Fact]
        public void ArrayOfClasses()
        {
            Helper1[] source = new Helper1[1000];

            for (int i = 0; i < source.Length; i++)
            {
                source[i] = new Helper1()
                {
                    PropOne = RandGen.GenerateInt()
                };
            }

            var dest = GetClone(source, 1001);

            Assert.NotNull(dest);
            Assert.Equal(dest.Length, source.Length);

            for (int i = 0; i < dest.Length; i++)
            {
                Assert.NotSame(dest[i], source[i]);
                Assert.Equal(dest[i].PropOne, source[i].PropOne);
            }
        }
    }
}