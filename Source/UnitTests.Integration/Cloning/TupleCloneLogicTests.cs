using Deipax.Cloning.Common;
using Deipax.Cloning.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace Integration.Cloning
{
    [TestClass]
    public class TupleCloneLogicTests
    {
        [TestMethod]
        public void TupleCloneLogicTests_Primitives()
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
            Assert.AreEqual(source, target);
            Assert.AreNotSame(source, target);
            Assert.AreEqual(source.Item1, target.Item1);
            Assert.AreNotSame(source.Item1, target.Item1);
            Assert.AreEqual(source.Item2, target.Item2);
            Assert.AreSame(source.Item2, target.Item2);
            Assert.AreEqual(source.Item3, target.Item3);
            Assert.AreNotSame(source.Item3, target.Item3);
            Assert.AreEqual(source.Item4, target.Item4);
            Assert.AreNotSame(source.Item4, target.Item4);
            Assert.AreEqual(source.Item5, target.Item5);
            Assert.AreNotSame(source.Item5, target.Item5);
            Assert.AreEqual(source.Item6, target.Item6);
            Assert.AreNotSame(source.Item6, target.Item6);
            Assert.AreEqual(source.Item7, target.Item7);
            Assert.AreNotSame(source.Item7, target.Item7);
            Assert.AreEqual(source.Rest, target.Rest);
            Assert.AreNotSame(source.Rest, target.Rest);
        }

        [TestMethod]
        public void TupleCloneLogicTests_Class()
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

            Assert.AreNotSame(source, target);

            Assert.AreNotSame(source.Item1, target.Item1);
            Assert.AreNotSame(source.Item1.PropOne, target.Item1.PropOne);
            Assert.AreEqual(source.Item1.PropOne, target.Item1.PropOne);

            Assert.AreNotSame(source.Item2, target.Item2);
            Assert.AreNotSame(source.Item2.PropOne, target.Item2.PropOne);
            Assert.AreEqual(source.Item2.PropOne, target.Item2.PropOne);

            Assert.AreNotSame(source.Item3, target.Item3);
            Assert.AreNotSame(source.Item3.PropOne, target.Item3.PropOne);
            Assert.AreEqual(source.Item3.PropOne, target.Item3.PropOne);

            Assert.AreNotSame(source.Item4, target.Item4);
            Assert.AreNotSame(source.Item4.PropOne, target.Item4.PropOne);
            Assert.AreEqual(source.Item4.PropOne, target.Item4.PropOne);

            Assert.AreNotSame(source.Item5, target.Item5);
            Assert.AreNotSame(source.Item5.PropOne, target.Item5.PropOne);
            Assert.AreEqual(source.Item5.PropOne, target.Item5.PropOne);

            Assert.AreNotSame(source.Item6, target.Item6);
            Assert.AreNotSame(source.Item6.PropOne, target.Item6.PropOne);
            Assert.AreEqual(source.Item6.PropOne, target.Item6.PropOne);

            Assert.AreNotSame(source.Item7, target.Item7);
            Assert.AreNotSame(source.Item7.PropOne, target.Item7.PropOne);
            Assert.AreEqual(source.Item7.PropOne, target.Item7.PropOne);

            Assert.AreNotSame(source.Rest, target.Rest);
            Assert.AreNotSame(source.Rest.Item1, target.Rest.Item1);
            Assert.AreNotSame(source.Rest.Item1.PropOne, target.Rest.Item1.PropOne);
            Assert.AreEqual(source.Rest.Item1.PropOne, target.Rest.Item1.PropOne);
        }

        [TestMethod]
        public void TupleCloneLogicTests_Struct()
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

            Assert.AreNotSame(source, target);

            Assert.AreNotSame(source.Item1, target.Item1);
            Assert.AreNotSame(source.Item1.PropOne, target.Item1.PropOne);
            Assert.AreEqual(source.Item1.PropOne, target.Item1.PropOne);

            Assert.AreNotSame(source.Item2, target.Item2);
            Assert.AreNotSame(source.Item2.PropOne, target.Item2.PropOne);
            Assert.AreEqual(source.Item2.PropOne, target.Item2.PropOne);

            Assert.AreNotSame(source.Item3, target.Item3);
            Assert.AreNotSame(source.Item3.PropOne, target.Item3.PropOne);
            Assert.AreEqual(source.Item3.PropOne, target.Item3.PropOne);

            Assert.AreNotSame(source.Item4, target.Item4);
            Assert.AreNotSame(source.Item4.PropOne, target.Item4.PropOne);
            Assert.AreEqual(source.Item4.PropOne, target.Item4.PropOne);

            Assert.AreNotSame(source.Item5, target.Item5);
            Assert.AreNotSame(source.Item5.PropOne, target.Item5.PropOne);
            Assert.AreEqual(source.Item5.PropOne, target.Item5.PropOne);

            Assert.AreNotSame(source.Item6, target.Item6);
            Assert.AreNotSame(source.Item6.PropOne, target.Item6.PropOne);
            Assert.AreEqual(source.Item6.PropOne, target.Item6.PropOne);

            Assert.AreNotSame(source.Item7, target.Item7);
            Assert.AreNotSame(source.Item7.PropOne, target.Item7.PropOne);
            Assert.AreEqual(source.Item7.PropOne, target.Item7.PropOne);

            Assert.AreNotSame(source.Rest, target.Rest);
            Assert.AreNotSame(source.Rest.Item1, target.Rest.Item1);
            Assert.AreNotSame(source.Rest.Item1.PropOne, target.Rest.Item1.PropOne);
            Assert.AreEqual(source.Rest.Item1.PropOne, target.Rest.Item1.PropOne);
        }

        [TestMethod]
        public void TupleCloneLogicTests_Null()
        {
            var source = (Tuple<int>)null;
            var target = GetClone(source, 0);
            Assert.IsNull(target);
        }

        [TestMethod]
        public void TupleCloneLogicTests_DuplicateReuse()
        {
            Tuple<int> helper = new Tuple<int>(1);
            List<Tuple<int>> source = new List<Tuple<int>>()
            {
                helper,
                helper
            };

            var target = GetClone(source, 2, false);

            Assert.AreNotSame(source, target);
            Assert.AreEqual(source.Count, target.Count);
            Assert.AreNotSame(source[0], target[0]);
            Assert.AreNotSame(source[1], target[1]);

            Assert.AreSame(target[0], target[1]);
        }

        #region Private Members
        private T GetClone<T>(T source, int dictCount, bool assertLogicClass = true)
        {
            var expression = CloneExpressionFactory<T>.Get();

            if (assertLogicClass)
            {
                Assert.IsTrue(expression.CloneLogic is TupleCloneLogic);
            }

            var dictionary = new Dictionary<object, object>();
            var item = expression.Clone(source, dictionary);
            Assert.AreEqual(dictCount, dictionary.Count);
            return item;
        }
        #endregion
    }
}