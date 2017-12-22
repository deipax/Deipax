using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    public class StringTests : StringBase
    {
        public StringTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}