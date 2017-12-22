using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    [TestClass]
    public abstract class NullableComplexStructBase : Base<ComplexStruct?>
    {
        public NullableComplexStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Protected Members
        protected override ComplexStruct? GenerateItem()
        {
            return ComplexStruct.Generate();
        }

        protected override void AssertAreEqual(ComplexStruct? source, ComplexStruct? target)
        {
            if (source.HasValue)
            {
                Assert.AreSame(source.Value.One, source.Value.One.One);
                Assert.AreSame(target.Value.One, target.Value.One.One);

                Assert.AreEqual(source.Value.Int, target.Value.Int);
                Assert.AreEqual(source.Value.One.Int, target.Value.One.Int);
            }
            else
            {
                Assert.AreEqual(source, target);
            }
        }

        protected override void AssertAreSame(ComplexStruct? source, ComplexStruct? target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}
