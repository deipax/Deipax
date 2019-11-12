using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
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
            Assert.Equal(source, target);

            if (source.HasValue)
            {
                Assert.Equal(source.Value.Int, target.Value.Int);
                Assert.Equal(source.Value.Long, target.Value.Long);
                Assert.Equal(source.Value.UInt, target.Value.UInt);
            }
        }

        protected override void AssertAreSame(SimpleStruct? source, SimpleStruct? target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}