using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class NullableSimpleStructBase : Base<SimpleStruct?>
    {
        protected override SimpleStruct? GenerateItem()
        {
            return SimpleStruct.Generate();
        }
    }
}