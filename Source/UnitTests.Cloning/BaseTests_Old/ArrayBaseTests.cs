using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class ArrayBaseTests
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [TestMethod]
        public void NullIntArray()
        {
            int[] source = null;
            var dest = GetClone(source, 0);
            Assert.IsNull(dest);
        }

        [TestMethod]
        public void EmptyIntArray()
        {
            int[] source = new int[0];
            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Length, source.Length);
        }

        [TestMethod]
        public void IntArray()
        {
            int[] source = new[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Length, source.Length);
            Assert.AreEqual(dest[0], source[0]);
        }

        [TestMethod]
        public void StringArray()
        {
            string[] source = new[] { "first string", string.Empty, null };

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Length, source.Length);
            Assert.AreEqual(dest[0], source[0]);
            Assert.AreEqual(dest[1], source[1]);
            Assert.AreEqual(dest[2], source[2]);
        }

        [TestMethod]
        public void ByteArray()
        {
            var source = RandGen.GenerateByteArray(1000);

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Length, source.Length);

            for (int i = 0; i < dest.Length; i++)
            {
                Assert.AreNotSame(dest, source);
                Assert.AreEqual(dest[i], source[i]);
            }
        }

        [TestMethod]
        public void ArrayOfStringArrays()
        {
            string[][] source = new string[][]
            {
                new string [] { "one", "two" },
                new string [] { "three", "four" }
            };

            var dest = GetClone(source, 3);

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Length, source.Length);
            Assert.AreNotEqual(dest[0], source[0]);
            Assert.AreNotEqual(dest[1], source[1]);
            Assert.AreEqual(dest[0][0], source[0][0]);
            Assert.AreEqual(dest[0][1], source[0][1]);
            Assert.AreEqual(dest[1][0], source[1][0]);
            Assert.AreEqual(dest[1][1], source[1][1]);
        }

        [TestMethod]
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

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Length, source.Length);

            var firstItem = dest[0];

            for (int i = 0; i < dest.Length; i++)
            {
                Assert.AreNotSame(source[i], dest[i]);
                Assert.AreSame(firstItem, dest[i]);
                Assert.AreEqual(source[i].Length, dest[i].Length);

                for (int j = 0; j < dest[i].Length; j++)
                {
                    Assert.AreEqual(source[i][j], dest[i][j]);
                }
            }
        }

        [TestMethod]
        public void ArrayOfStringArrays_Null()
        {
            string[][] source = null;
            var dest = GetClone(source, 0);
            Assert.IsNull(dest);
        }

        [TestMethod]
        public void ArrayOfNullableInts()
        {
            Nullable<int>[] source = new Nullable<int>[]
            {
                new Nullable<int>(10),
                new Nullable<int>(5),
                null
            };

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Length, source.Length);
            Assert.AreEqual(dest[0], source[0]);
            Assert.AreEqual(dest[1], source[1]);
            Assert.AreEqual(dest[2], source[2]);
            Assert.IsTrue(!dest[2].HasValue);
        }

        [TestMethod]
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

            Assert.IsTrue(dest != null);
            Assert.IsTrue(dest.Length == source.Length);

            for (int i = 0; i < dest.Length; i++)
            {
                Assert.AreNotSame(dest[i], source[i]);
                Assert.AreNotSame(dest[i].PropOne, source[i].PropOne);
                Assert.AreEqual(dest[i].PropOne, source[i].PropOne);
            }
        }
    }
}