using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class StringBase : Base<string>
    {
        public StringBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Protected Members
        protected override string GenerateItem()
        {
            return RandGen.GenerateString(10);
        }

        protected override void AssertAreEqual(string source, string target)
        {
            Assert.AreEqual(source, target);
        }

        protected override void AssertAreSame(string source, string target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}
