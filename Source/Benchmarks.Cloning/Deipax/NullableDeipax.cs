using Benchmarks.Cloning.BaseClasses_Old;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class NullableDeipax : NullableBase
    {
        protected override T GetClone<T>(T source)
        {
            return source.GetClone();
        }
    }
}