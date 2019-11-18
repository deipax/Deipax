using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class NullableIntBase : Base<int?>
    {
        public NullableIntBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<int?> GetItemGenerator()
        {
            return new ItemGenerator<int?>(() => RandGen.GenerateInt(), new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<int?>
        {
            public bool Equals(int? source, int? target)
            {
                if (source.HasValue && target.HasValue)
                {
                    return source.Value == target.Value;
                }

                return !source.HasValue && !target.HasValue;
            }

            public int GetHashCode(int? obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}