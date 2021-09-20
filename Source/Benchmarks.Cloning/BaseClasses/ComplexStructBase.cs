using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class ComplexStructBase : Base<ComplexStruct>
    {
        protected override ComplexStruct GenerateItem() => ComplexStruct.Generate();
    }
}