using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core
{
    [TestClass]
    public class EnumCacheTests
    {
        [TestMethod]
        public void EnumValuesAreShared()
        {
            var enumValues = EnumCache.GetEnumValues<TestEnum, int>();
            var nullableEnumValues = EnumCache.GetEnumValues<TestEnum?, int>();
            Assert.AreSame(enumValues, nullableEnumValues);
        }

        [TestMethod]
        public void StringValuesAreShared()
        {
            var stringValues = EnumCache.GetStringValues<TestEnum, int>();
            var nullableStringValues = EnumCache.GetStringValues<TestEnum?, int>();
            Assert.AreSame(stringValues, nullableStringValues);
        }
    }
}
