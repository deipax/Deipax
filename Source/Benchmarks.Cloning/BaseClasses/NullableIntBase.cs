using UnitTests.Common;

namespace Benchmarks.Cloning.BaseClasses
{
    public abstract class NullableIntBase : Base<int?>
    {
        #region Protected Members
        protected override int? GenerateItem()
        {
            return RandGen.GenerateInt();
        }
        #endregion
    }
}