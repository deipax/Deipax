using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    public class IntTests : IntBase
    {
        public IntTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}