using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    public class NullableIntTests : NullableIntBase
    {
        public NullableIntTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}