using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class SimpleStructBase : Base<SimpleStruct>
    {
        public SimpleStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<SimpleStruct> GetItemGenerator()
        {
            return new ItemGenerator<SimpleStruct>(SimpleStruct.Generate, new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<SimpleStruct>
        {
            public bool Equals(SimpleStruct source, SimpleStruct target)
            {
                return source.Int == target.Int &&
                    source.Long == target.Long &&
                    source.UInt == target.UInt;
            }

            public int GetHashCode(SimpleStruct obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}