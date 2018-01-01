using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    [Ignore]
    public class DoubleSimpleClassTests : DoubleSimpleClassBase
    {
        public DoubleSimpleClassTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}