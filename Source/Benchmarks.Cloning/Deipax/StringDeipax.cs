using Benchmarks.Cloning.BaseClasses;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class StringDeipax : StringBase
    {
        protected override X Clone<X>(X source) => source.GetClone();
    }
}