using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    [Ignore]
    public class NullableComplexStructTests : NullableComplexStructBase
    {
        public NullableComplexStructTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}