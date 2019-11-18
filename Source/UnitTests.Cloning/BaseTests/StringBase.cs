using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class StringBase : Base<string>
    {
        public StringBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<string> GetItemGenerator()
        {
            return new ItemGenerator<string>(() => RandGen.GenerateString(10), new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string source, string target)
            {
                return source == target;
            }

            public int GetHashCode(string obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}
