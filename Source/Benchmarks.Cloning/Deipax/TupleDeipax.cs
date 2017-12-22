using Benchmarks.Cloning.BaseClasses_Old;
using Deipax.Cloning.Extensions;

namespace Benchmarks.Cloning.Deipax
{
    public class TupleDeipax : TupleBase
    {
        protected override T GetClone<T>(T source)
        {
            return source.GetClone();
        }
    }
}