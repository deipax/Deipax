using BenchmarkDotNet.Attributes;
using Deipax.Core.Common;

namespace Benchmarks.Core.Deipax
{
    public class SymbolCacheBenchmarks
    {
        [GlobalSetup]
        public void Setup()
        {
            SymbolCache.Get(_existingKey);
        }

        private string _newKey = "NewKey";
        private string _existingKey = "ExistingKey";

        [Benchmark]
        public Symbol GetNewSymbol()
        {
            return SymbolCache.Get(_newKey);
        }

        [Benchmark]
        public Symbol GetExistingSymbol()
        {
            return SymbolCache.Get(_existingKey);
        }
    }
}
