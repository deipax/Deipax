using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class NullableComplexStructBase : Base<ComplexStruct?>
    {
        public NullableComplexStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Protected Members
        protected override ComplexStruct? GenerateItem()
        {
            return ComplexStruct.Generate();
        }

        protected override void AssertAreEqual(ComplexStruct? source, ComplexStruct? target)
        {
            if (source.HasValue)
            {
                Assert.Same(source.Value.One, source.Value.One.One);
                Assert.Same(target.Value.One, target.Value.One.One);

                Assert.Equal(source.Value.Int, target.Value.Int);
                Assert.Equal(source.Value.One.Int, target.Value.One.Int);
            }
            else
            {
                Assert.Equal(source, target);
            }
        }

        protected override void AssertAreSame(ComplexStruct? source, ComplexStruct? target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}
