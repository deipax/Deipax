using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
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
            Assert.AreSame(source.One, source.Two);
            Assert.AreSame(target.One, target.Two);

            Assert.AreEqual(source.One.BaseInt, target.One.BaseInt);
            Assert.AreEqual(source.One.Double, target.One.Double);
            Assert.AreEqual(source.One.Float, target.One.Float);
            Assert.AreEqual(source.One.Int, target.One.Int);
            Assert.AreEqual(source.One.Long, target.One.Long);
            Assert.AreEqual(source.One.String, target.One.String);
            Assert.AreEqual(source.One.UInt, target.One.UInt);
            Assert.AreEqual(source.One.ULong, target.One.ULong);
        }

        protected override void AssertAreSame(DoubleSimpleClass source, DoubleSimpleClass target)
        {
            Assert.AreSame(source, target);
        }
        #endregion
    }
}