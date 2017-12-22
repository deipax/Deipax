using Benchmarks.Cloning.BaseClasses;
using DeepCopy;

namespace Benchmarks.Cloning.DeepCopy
{
    public class StringDeepCopy : StringBase
    {
        protected override X Clone<X>(X source)
        {
            return DeepCopier.Copy(source);
        }
    }
}