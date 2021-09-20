using Benchmarks.Cloning.BaseClasses_Old;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class ComplexRefTypeDeipax : ComplexRefTypeBase
    {
        protected override T GetClone<T>(T source) => source.GetClone();
    }
}