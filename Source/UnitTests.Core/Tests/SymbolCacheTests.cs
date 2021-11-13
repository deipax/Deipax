using Deipax.Core.Common;
using Xunit;

namespace UnitTests.Core
{
    public class SymbolCacheTests
    {
        private readonly string _key = "Test";

        [Fact]
        public void Get()
        {
            var symbol = SymbolCache.Get(_key);
            Assert.NotNull(symbol);
            var symbol2 = SymbolCache.Get(_key);
        }
    }
}
