using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class NullableComplexStructBase : Base<ComplexStruct?>
    {
        protected override ComplexStruct? GenerateItem() => ComplexStruct.Generate();
    }
}