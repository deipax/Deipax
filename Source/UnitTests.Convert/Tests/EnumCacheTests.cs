using Deipax.Convert.Common;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Convert
{
    public class EnumCacheTests
    {
        [Fact]
        public void EnumValuesAreShared()
        {
            var enumValues = EnumCache.GetEnumValues<TestEnum, int>();
            var nullableEnumValues = EnumCache.GetEnumValues<TestEnum?, int>();
            Assert.Same(enumValues, nullableEnumValues);
        }

        [Fact]
        public void StringValuesAreShared()
        {
            var stringValues = EnumCache.GetStringValues<TestEnum, int>();
            var nullableStringValues = EnumCache.GetStringValues<TestEnum?, int>();
            Assert.Same(stringValues, nullableStringValues);
        }
    }
}
