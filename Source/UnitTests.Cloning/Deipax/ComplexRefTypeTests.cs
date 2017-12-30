using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Deipax.Cloning.Common;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
    public class ComplexRefTypeTests : ComplexRefTypeBase
    {
        protected override T GetClone<T>(T source, int expectedCount)
        {
            CopyContext c = new CopyContext();
            T target = source.GetClone(c);
            Assert.AreEqual(expectedCount, c.GetCount(), "Cache count incorrect.");
            return target;
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public override void Anon()
        {
            base.Anon();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public override void NoDefaultConstructor_Class()
        {
            base.NoDefaultConstructor_Class();
        }
    }
}