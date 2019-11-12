using Deipax.Cloning;
using Deipax.Cloning.Common;
using UnitTests.Cloning.BaseTests;
using Xunit;

namespace UnitTests.Cloning
{
    public class ArrayTests : ArrayBaseTests
    {
        protected override T GetClone<T>(T source, int expectedCount)
        {
            CopyContext c = new CopyContext();
            T target = Cloner<T>.Get(source, c);
            Assert.Equal(expectedCount, c.GetCount());
            return target;
        }
    }
}