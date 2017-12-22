using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    public class NullableSimpleStructTests : NullableSimpleStructBase
    {
        public NullableSimpleStructTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}