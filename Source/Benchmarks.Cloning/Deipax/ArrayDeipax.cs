using Benchmarks.Cloning.BaseClasses_Old;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class ArrayDeipax : ArrayBase
    {
        protected override T GetClone<T>(T source) => source.GetClone();
    }
}