using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class ShallowCloneListBase
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [TestMethod]
        public void ListOfStrings()
        {
            List<string> source = RandGen.GenerateStringList(1000, 10);

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreEqual(dest.Count, source.Count);

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.AreEqual(dest[i], source[i]);
            }

            source.Clear();

            Assert.AreNotEqual(source.Count, dest.Count);
        }

        [TestMethod]
        public void ListOfBytes()
        {
            List<byte> source = RandGen
                .GenerateByteArray(1000)
                .ToList();

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreEqual(dest.Count, source.Count);

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.AreEqual(dest[i], source[i]);
            }

            source.Clear();

            Assert.AreNotEqual(source.Count, dest.Count);
        }

        [TestMethod]
        public void ListOfInts()
        {
            List<int> source = RandGen.GenerateIntList(1000);

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreEqual(dest.Count, source.Count);

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.AreEqual(dest[i], source[i]);
            }

            source.Clear();

            Assert.AreNotEqual(source.Count, dest.Count);
        }

        [TestMethod]
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

            Assert.IsNotNull(dest);
            Assert.AreNotEqual(dest, source);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Count, source.Count);

            var firstItem = dest[0];

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.AreNotSame(source[i], dest[i]);
                Assert.AreSame(firstItem, dest[i]);
                Assert.AreEqual(source[i].Count, dest[i].Count);

                for (int j = 0; j < dest[i].Count; j++)
                {
                    Assert.AreEqual(source[i][j], dest[i][j]);
                }
            }

            source.Clear();

            Assert.AreNotEqual(source.Count, dest.Count);
        }
    }
}