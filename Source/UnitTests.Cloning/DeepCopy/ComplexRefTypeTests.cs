using DeepCopy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    public class ComplexRefTypeTests : ComplexRefTypeBase
    {
        protected override T GetClone<T>(T source, int expectedCount)
        {
            return DeepCopier.Copy(source);
        }

        [Ignore]
        [TestMethod]
        public override void Anon()
        {
            base.Anon();
        }

        [Ignore]
        [TestMethod]
        public override void DictionaryOfClasses()
        {
            base.DictionaryOfClasses();
        }
    }
}