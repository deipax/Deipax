using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class StringBase : Base<string>
    {
        protected override string GenerateItem() => RandGen.GenerateString(10);
    }
}