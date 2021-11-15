using Deipax.Core.Common;
using Xunit;

namespace UnitTests.Core.Tests
{
    public class SymbolCacheTests
    {
        [Fact]
        public void Get()
        {
            var symbol = SymbolCache.Get("Test");
            Assert.NotNull(symbol);
            Assert.True(symbol.Id >= 0);

            var symbol2 = SymbolCache.Get("Test");
            Assert.NotNull(symbol2);
            Assert.True(symbol2.Id >= 0);

            Assert.Same(symbol, symbol2);
            Assert.Equal(symbol.Id, symbol2.Id);
        }
    }
}
