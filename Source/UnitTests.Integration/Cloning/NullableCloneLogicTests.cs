using System.Collections.Generic;
using Deipax.Cloning.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Common;
using Deipax.Cloning.Factories;

namespace Integration.Cloning
{
    [TestClass]
    public class NullableCloneLogicTests
    {
        [TestMethod]
        public void NullableCloneLogicTests_Int()
        {
            int? source = (int?)10;
            var dest = GetClone(source);

            Assert.IsNotNull(dest);
            Assert.AreNotSame(dest, source);
            Assert.AreEqual(dest, source);
        }

        [TestMethod]
        public void NullableCloneLogicTests_NullInt()
        {
            int? source = null;
            var dest = GetClone(source);

            Assert.IsNull(dest);
            Assert.IsTrue(!dest.HasValue);
        }

        [TestMethod]
        public void NullableCloneLogicTests_Struct()
        {
            Nullable<HelperStruct1> source = new HelperStruct1()
            {
                PropOne = RandGen.GenerateInt()
            };

            var dest = GetClone(source);

            Assert.IsNotNull(dest);
            Assert.AreNotSame(source, dest);
            Assert.AreEqual(source, dest);
            Assert.AreEqual(source.Value, dest.Value);
            Assert.AreEqual(source.Value.PropOne, dest.Value.PropOne);
        }

        #region Private Members
        private T GetClone<T>(T source)
        {
            var expression = CloneExpressionFactory<T>.Get();
            Assert.IsTrue(expression.CloneLogic is NullableCloneLogic);
            return expression.Clone(source, new Dictionary<object, object>());
        }
        #endregion
    }
}