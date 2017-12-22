using Benchmarks.Cloning.BaseClasses;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class ComplexClassDeipax : ComplexClassBase
    {
        protected override X Clone<X>(X source)
        {
            return source.GetClone();
        }
    }
}