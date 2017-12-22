using DeepCopy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    [TestClass]
    public class ArrayTests : ArrayBaseTests
    {
        protected override T GetClone<T>(T source, int expectedCount)
        {
            return DeepCopier.Copy(source);
        }
    }
}