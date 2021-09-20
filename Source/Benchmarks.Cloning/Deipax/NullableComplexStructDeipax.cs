using Benchmarks.Cloning.BaseClasses;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class NullableComplexStructDeipax : NullableComplexStructBase
    {
        protected override X Clone<X>(X source) => source.GetClone();
    }
}