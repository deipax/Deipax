using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class ComplexClassBase : Base<ComplexClass>
    {
        protected override ComplexClass GenerateItem() => ComplexClass.Generate();
    }
}