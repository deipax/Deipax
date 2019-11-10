using Deipax.Convert.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Convert
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
