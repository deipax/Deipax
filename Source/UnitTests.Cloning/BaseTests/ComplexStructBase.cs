using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ComplexStructBase : Base<ComplexStruct>
    {
        public ComplexStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ComplexStruct GenerateItem()
        {
            return ComplexStruct.Generate();
        }

        protected override void AssertAreEqual(ComplexStruct source, ComplexStruct target)
        {
            Assert.Same(source.One, source.One.One);
            Assert.Same(target.One, target.One.One);

            Assert.Equal(source.Int, target.Int);
            Assert.Equal(source.One.Int, target.One.Int);
        }

        protected override void AssertAreSame(ComplexStruct source, ComplexStruct target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}