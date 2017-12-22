using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class SimpleStructBase : Base<SimpleStruct>
    {
        protected override SimpleStruct GenerateItem()
        {
            return SimpleStruct.Generate();
        }
    }
}