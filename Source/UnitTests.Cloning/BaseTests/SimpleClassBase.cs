using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
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
            Assert.AreEqual(source.BaseInt, target.BaseInt);
            Assert.AreEqual(source.Double, target.Double);
            Assert.AreEqual(source.Float, target.Float);
            Assert.AreEqual(source.Int, target.Int);
            Assert.AreEqual(source.Long, target.Long);
            Assert.AreEqual(source.String, target.String);
            Assert.AreEqual(source.UInt, target.UInt);
            Assert.AreEqual(source.ULong, target.ULong);
        }

        protected override void AssertAreSame(SimpleClass source, SimpleClass target)
        {
            Assert.AreSame(source, target);
        }
        #endregion
    }
}