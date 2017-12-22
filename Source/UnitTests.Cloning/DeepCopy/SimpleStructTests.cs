using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    public class SimpleStructTests : SimpleStructBase
    {
        public SimpleStructTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}