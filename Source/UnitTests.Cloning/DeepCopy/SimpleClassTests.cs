using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    [Ignore]
    public class SimpleClassTests : SimpleClassBase
    {
        public SimpleClassTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}