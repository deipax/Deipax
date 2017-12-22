using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    // DeepCopy Note:
    // The property One and Two are determined to not be tracked.  As a result
    // they are not added to the Context nor is the Context checked before they are cloned.
    // One and Two are intentially set to the same object, which displays this bug.
    [TestClass]
    [Ignore]
    public class DoubleSimpleClassTests : DoubleSimpleClassBase
    {
        public DoubleSimpleClassTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}