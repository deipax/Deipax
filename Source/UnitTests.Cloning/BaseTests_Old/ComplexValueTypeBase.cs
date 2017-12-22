using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class ComplexValueTypeBase
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [TestMethod]
        public void SimpleStruct()
        {
            HelperStruct2 source = new HelperStruct2()
            {
                Helper = new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt()
                }
            };

            HelperStruct2 target = GetClone(source, 0);

            Assert.AreNotEqual(target, null);
            Assert.AreNotEqual(target.Helper, null);
            Assert.AreNotSame(source.Helper, target.Helper);
            Assert.AreEqual(source.Helper.PropOne, target.Helper.PropOne);
            Assert.AreNotSame(source.Helper.PropOne, target.Helper.PropOne);
        }

        [TestMethod]
        public void InheritList_Struct()
        {
            var source = new Helper3<HelperStruct1>()
            {
                new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt()
                }
            };

            source.PropOne = RandGen.GenerateInt();

            var target = GetClone(source, 1);

            Assert.AreNotSame(source, target);
            Assert.AreEqual(source.Count, target.Count);
            Assert.AreNotSame(source[0], target[0]);
            Assert.AreEqual(source[0].PropOne, target[0].PropOne);
            Assert.AreNotSame(source.PropOne, target.PropOne);
            Assert.AreEqual(source.PropOne, target.PropOne);
        }

        [TestMethod]
        public void DefaultStruct()
        {
            HelperStruct1 source = default(HelperStruct1);
            var dest = GetClone(source, 0);
            Assert.IsNotNull(dest);
            Assert.AreEqual(source, dest);
            Assert.AreNotSame(source, dest);
        }
    }
}