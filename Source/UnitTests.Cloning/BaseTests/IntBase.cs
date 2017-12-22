using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class IntBase : Base<int>
    {
        public IntBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Protected Members
        protected override int GenerateItem()
        {
            return RandGen.GenerateInt();
        }

        protected override void AssertAreEqual(int source, int target)
        {
            Assert.AreEqual(source, target);
        }

        protected override void AssertAreSame(int source, int target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}