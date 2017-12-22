using Benchmarks.Cloning.BaseClasses;
using DeepCopy;

namespace Benchmarks.Cloning.DeepCopy
{
    // DeepCopy Note:
    // The Array Copier Checks for the instance
    // of the item and records it.  So does the copy
    // logic for the item itself.  This unnecessarily doubles
    // the number of context access needed.

    public class ComplexClassDeepCopy : ComplexClassBase
    {
        protected override X Clone<X>(X source)
        {
            return DeepCopier.Copy(source);
        }
    }
}