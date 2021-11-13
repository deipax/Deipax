using Deipax.Core.Common;
using Xunit;

namespace UnitTests.Core
{
    public class SymbolCacheTests
    {
        [Fact]
        public void Get()
        {
            var symbol = SymbolCache.Get("10");
            Assert.NotNull(symbol);
            var symbol2 = SymbolCache.Get("10");
            Assert.Same(symbol, symbol2);
            Assert.True(SymbolCache.Count == 1);
        }
    }
}
