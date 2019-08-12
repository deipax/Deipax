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
            var enumValues = EnumCache.GetEnumValues<TestEnum>();
            var nullableEnumValues = EnumCache.GetEnumValues<TestEnum?>();
            Assert.AreSame(enumValues, nullableEnumValues);
        }

        [TestMethod]
        public void StringValuesAreShared()
        {
            var stringValues = EnumCache.GetStringValues<TestEnum>();
            var nullableStringValues = EnumCache.GetStringValues<TestEnum?>();
            Assert.AreSame(stringValues, nullableStringValues);
        }
    }
}
