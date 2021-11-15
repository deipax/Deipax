using BenchmarkDotNet.Attributes;
using Deipax.Core.Common;

namespace Benchmarks.Core.Deipax
{
    public class SymbolCacheBenchmarks
    {
        [GlobalSetup]
        public void Setup()
        {
            SymbolCache.Get("GetExisting");
        }

        [Benchmark]
        public ISymbol GetNew()
        {
            return SymbolCache.Get("GetNew");
        }

        [Benchmark]
        public ISymbol GetExisting()
        {
            return SymbolCache.Get("GetExisting");
        }
    }
}
