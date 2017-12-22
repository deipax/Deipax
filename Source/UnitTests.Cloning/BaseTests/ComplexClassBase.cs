using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class ComplexClassBase : Base<ComplexClass>
    {
        public ComplexClassBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override void AssertAreEqual(ComplexClass source, ComplexClass target)
        {
            Assert.AreNotSame(source, target);
            Assert.AreNotSame(source.One, target.One);

            Assert.AreSame(target, target.One);

            Assert.AreEqual(source.Int, target.Int);
            Assert.AreEqual(source.One.Int, target.One.Int);
        }

        protected override void AssertAreSame(ComplexClass source, ComplexClass target)
        {
            Assert.AreSame(source, target);
        }

        protected override ComplexClass GenerateItem()
        {
            return ComplexClass.Generate();
        }
        #endregion
    }
}