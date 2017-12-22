using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class DoubleSimpleClassBase : Base<DoubleSimpleClass>
    {
        protected override DoubleSimpleClass GenerateItem()
        {
            return DoubleSimpleClass.Generate();
        }
    }
}