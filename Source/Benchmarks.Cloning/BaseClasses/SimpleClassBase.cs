using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class SimpleClassBase : Base<SimpleClass>
    {
        protected override SimpleClass GenerateItem()
        {
            return SimpleClass.Generate();
        }
    }
}