using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class DoubleSimpleClassBase : Base<DoubleSimpleClass>
    {
        public DoubleSimpleClassBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override DoubleSimpleClass GenerateItem()
        {
            return DoubleSimpleClass.Generate();
        }

        protected override void AssertAreEqual(DoubleSimpleClass source, DoubleSimpleClass target)
        {
            Assert.Same(source.One, source.Two);
            Assert.Same(target.One, target.Two);

            Assert.Equal(source.One.BaseInt, target.One.BaseInt);
            Assert.Equal(source.One.Double, target.One.Double);
            Assert.Equal(source.One.Float, target.One.Float);
            Assert.Equal(source.One.Int, target.One.Int);
            Assert.Equal(source.One.Long, target.One.Long);
            Assert.Equal(source.One.String, target.One.String);
            Assert.Equal(source.One.UInt, target.One.UInt);
            Assert.Equal(source.One.ULong, target.One.ULong);
        }

        protected override void AssertAreSame(DoubleSimpleClass source, DoubleSimpleClass target)
        {
            Assert.Same(source, target);
        }
        #endregion
    }
}