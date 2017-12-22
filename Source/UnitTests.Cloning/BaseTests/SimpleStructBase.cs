using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class SimpleStructBase : Base<SimpleStruct>
    {
        public SimpleStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Protected Members
        protected override SimpleStruct GenerateItem()
        {
            return SimpleStruct.Generate();
        }

        protected override void AssertAreSame(SimpleStruct source, SimpleStruct target)
        {
            AssertAreEqual(source, target);
        }

        protected override void AssertAreEqual(SimpleStruct source, SimpleStruct target)
        {
            Assert.AreEqual(source, target);
            Assert.AreEqual(source.Int, target.Int);
            Assert.AreEqual(source.Long, target.Long);
            Assert.AreEqual(source.UInt, target.UInt);
        }
        #endregion
    }
}