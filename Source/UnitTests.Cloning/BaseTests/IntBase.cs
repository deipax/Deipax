using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class IntBase : Base<int>
    {
        public IntBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<int> GetItemGenerator()
        {
            return new ItemGenerator<int>(() => RandGen.GenerateInt(), new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<int>
        {
            public bool Equals(int source, int target)
            {
                return source == target;
            }

            public int GetHashCode(int obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}