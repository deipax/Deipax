using Benchmarks.Cloning.BaseClasses_Old;
using DeepCopy;

namespace Benchmarks.Cloning.DeepCopy
{
    public class KeyValueDeepCopy : KeyValueBase
    {
        protected override T GetClone<T>(T source)
        {
            return DeepCopier.Copy(source);
        }
    }
}