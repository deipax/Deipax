using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    [Ignore]
    public class ComplexClassTests : ComplexClassBase
    {
        public ComplexClassTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}