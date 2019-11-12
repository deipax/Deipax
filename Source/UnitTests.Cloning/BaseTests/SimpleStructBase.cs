using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
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
            Assert.Equal(source, target);
            Assert.Equal(source.Int, target.Int);
            Assert.Equal(source.Long, target.Long);
            Assert.Equal(source.UInt, target.UInt);
        }
        #endregion
    }
}