using Deipax.Cloning.Concretes;
using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
    public class TupleTests : TupleBase
    {
        protected override T GetClone<T>(T source, int expectedCount)
        {
            CopyContext c = new CopyContext();
            T target = source.GetClone(c);
            Assert.AreEqual(expectedCount, c.GetCount(), "Cache count incorrect.");
            return target;
        }
    }
}