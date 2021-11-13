using BenchmarkDotNet.Attributes;
using Deipax.Core.Common;

namespace Benchmarks.Core.Deipax
{
    public class SymbolCacheBenchmarks
    {
        [GlobalSetup]
        public void Setup()
        {
            SymbolCache.Get("ExistingKey");
        }

        [Benchmark]
        public Symbol GetNewSymbol()
        {
            return SymbolCache.Get("NewKey");
        }

        [Benchmark]
        public Symbol GetExistingSymbol()
        {
            return SymbolCache.Get("ExistingKey");
        }
    }
}
