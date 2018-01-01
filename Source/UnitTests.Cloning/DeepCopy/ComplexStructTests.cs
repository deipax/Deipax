using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    [Ignore]
    public class ComplexStructTests : ComplexStructBase
    {
        public ComplexStructTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}