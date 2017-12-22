using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class IntBase : Base<int>
    {
        protected override int GenerateItem()
        {
            return RandGen.GenerateInt();
        }
    }
}