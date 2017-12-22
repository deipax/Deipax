using Benchmarks.Cloning.BaseClasses;
using DeepCopy;

namespace Benchmarks.Cloning.DeepCopy
{
    public class DoubleSimpleClassDeepCopy : DoubleSimpleClassBase
    {
        protected override X Clone<X>(X source)
        {
            return DeepCopier.Copy(source);
        }
    }
}