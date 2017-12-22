using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
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
            Assert.AreSame(source.One, source.One.One);
            Assert.AreSame(target.One, target.One.One);

            Assert.AreEqual(source.Int, target.Int);
            Assert.AreEqual(source.One.Int, target.One.Int);
        }

        protected override void AssertAreSame(ComplexStruct source, ComplexStruct target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}