using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class SimpleClassBase : Base<SimpleClass>
    {
        public SimpleClassBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override SimpleClass GenerateItem()
        {
            return SimpleClass.Generate();
        }

        protected override void AssertAreEqual(SimpleClass source, SimpleClass target)
        {
            Assert.Equal(source.BaseInt, target.BaseInt);
            Assert.Equal(source.Double, target.Double);
            Assert.Equal(source.Float, target.Float);
            Assert.Equal(source.Int, target.Int);
            Assert.Equal(source.Long, target.Long);
            Assert.Equal(source.String, target.String);
            Assert.Equal(source.UInt, target.UInt);
            Assert.Equal(source.ULong, target.ULong);
        }

        protected override void AssertAreSame(SimpleClass source, SimpleClass target)
        {
            Assert.Same(source, target);
        }
        #endregion
    }
}