using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class NullableSimpleStructBase : Base<SimpleStruct?>
    {
        public NullableSimpleStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Protected Members
        protected override SimpleStruct? GenerateItem()
        {
            return SimpleStruct.Generate();
        }

        protected override void AssertAreEqual(SimpleStruct? source, SimpleStruct? target)
        {
            Assert.AreEqual(source, target);

            if (source.HasValue)
            {
                Assert.AreEqual(source.Value.Int, target.Value.Int);
                Assert.AreEqual(source.Value.Long, target.Value.Long);
                Assert.AreEqual(source.Value.UInt, target.Value.UInt);
            }
        }

        protected override void AssertAreSame(SimpleStruct? source, SimpleStruct? target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}