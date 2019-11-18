using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class NullableSimpleStructBase : Base<SimpleStruct?>
    {
        public NullableSimpleStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<SimpleStruct?> GetItemGenerator()
        {
            return new ItemGenerator<SimpleStruct?>(() => SimpleStruct.Generate(), new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<SimpleStruct?>
        {
            public bool Equals(SimpleStruct? source, SimpleStruct? target)
            {
                if (source.HasValue && target.HasValue)
                {
                    return source.Value.Int == target.Value.Int &&
                        source.Value.Long == target.Value.Long &&
                        source.Value.UInt == target.Value.UInt;
                }

                return !source.HasValue && !target.HasValue;
            }

            public int GetHashCode(SimpleStruct? obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}