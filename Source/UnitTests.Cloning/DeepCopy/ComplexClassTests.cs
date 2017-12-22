using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    /// <summary>
    /// KeyValue tests have issues.  Not sure why, investigate.
    /// </summary>
    [TestClass]
    [Ignore]
    public class ComplexClassTests : ComplexClassBase
    {
        public ComplexClassTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}