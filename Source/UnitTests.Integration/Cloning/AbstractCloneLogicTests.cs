using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.Common;

namespace Integration.Cloning
{
    [TestClass]
    public class AbstractCloneLogicTests
    {
        [TestMethod]
        public void AbstractCloneLogicTests_IRealOnlyList_String()
        {
            IReadOnlyList<string> source = new List<string>()
            {
                RandGen.GenerateString(10)
            };

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest.Count, source.Count);
            Assert.AreEqual(dest[0], source[0]);
        }

        [TestMethod]
        public void AbstractCloneLogicTests_GrandChildClass_AsInterface()
        {
            MyInterface source = TestingHelper.GetRandomGrandChild();

            var dest = GetClone(source, 1);

            Assert.IsNotNull(dest);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(source.Parent_Public_GetSet_AutoProp, dest.Parent_Public_GetSet_AutoProp);
            Assert.AreEqual(source.Parent_Public_Get_AutoProp, dest.Parent_Public_Get_AutoProp);
        }

        [TestMethod]
        public void AbstractCloneLogicTests_Struct_AsInterface()
        {
            MyTmpInterface source = new HelperStruct3()
            {
                PropOne = RandGen.GenerateInt()
            };

            var dest = GetClone(source, 0);

            Assert.IsNotNull(dest);
            Assert.AreNotSame(dest, source);

            Assert.AreEqual(source.PropOne, dest.PropOne);
            Assert.AreNotSame(source.PropOne, dest.PropOne);
        }

        [TestMethod]
        public void AbstractCloneLogicTests_IRealOnlyList_Interface()
        {
            IReadOnlyList<MyTmpInterface> source = new List<MyTmpInterface>()
            {
                new Helper1() { PropOne = RandGen.GenerateInt() },
                new Helper1_1() { PropOne = RandGen.GenerateInt() },
                new HelperStruct3() {  PropOne = RandGen.GenerateInt() }
            };

            var dest = GetClone(source, 3);

            Assert.IsNotNull(dest);
            Assert.AreNotSame(dest, source);

            Assert.IsTrue(dest[0] is Helper1);
            Assert.IsTrue(dest[1] is Helper1_1);
            Assert.IsTrue(dest[2] is HelperStruct3);

            Assert.AreEqual(source[0].PropOne, dest[0].PropOne);
            Assert.AreNotSame(source[0].PropOne, dest[0].PropOne);

            Assert.AreEqual(source[1].PropOne, dest[1].PropOne);
            Assert.AreNotSame(source[1].PropOne, dest[1].PropOne);

            Assert.AreEqual(source[2].PropOne, dest[2].PropOne);
            Assert.AreNotSame(source[2].PropOne, dest[2].PropOne);
        }

        [TestMethod]
        public void AbstractCloneLogicTests_ListOfClasses_DuplicateReuse()
        {
            Helper1 tmp = new Helper1();

            IReadOnlyList<Helper1> source = new List<Helper1>()
            {
                tmp,
                tmp,
                tmp
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
            }
        }

        #region Private Members
        private T GetClone<T>(T source, int dictCount)
        {
            var dictionary = new Dictionary<object, object>();
            var expression = CloneExpressionFactory<T>.Get();
            Assert.IsTrue(expression.CloneLogic is AbstractCloneLogic);
            T clonedItem = expression.Clone(source, dictionary);
            Assert.AreEqual(dictCount, dictionary.Count);
            return clonedItem;
        }
        #endregion
    }
}