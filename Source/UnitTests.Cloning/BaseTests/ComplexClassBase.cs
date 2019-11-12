using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ComplexClassBase : Base<ComplexClass>
    {
        public ComplexClassBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override void AssertAreEqual(ComplexClass source, ComplexClass target)
        {
            Assert.NotSame(source, target);
            Assert.NotSame(source.One, target.One);

            Assert.Same(target, target.One);

            Assert.Equal(source.Int, target.Int);
            Assert.Equal(source.One.Int, target.One.Int);
        }

        protected override void AssertAreSame(ComplexClass source, ComplexClass target)
        {
            Assert.Same(source, target);
        }

        protected override ComplexClass GenerateItem()
        {
            return ComplexClass.Generate();
        }
        #endregion
    }
}