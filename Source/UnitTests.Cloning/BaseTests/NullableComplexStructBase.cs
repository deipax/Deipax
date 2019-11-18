using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class NullableComplexStructBase : Base<ComplexStruct?>
    {
        public NullableComplexStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<ComplexStruct?> GetItemGenerator()
        {
            return new ItemGenerator<ComplexStruct?>(() => ComplexStruct.Generate(), new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<ComplexStruct?>
        {
            public bool Equals(ComplexStruct? source, ComplexStruct? target)
            {
                if (source.HasValue && target.HasValue)
                {
                    return ReferenceEquals(source.Value.One, source.Value.One.One) &&
                        ReferenceEquals(target.Value.One, target.Value.One.One) &&
                        source.Value.Int == target.Value.Int &&
                        source.Value.One.Int == target.Value.One.Int;
                }

                return !source.HasValue && !target.HasValue;
            }

            public int GetHashCode(ComplexStruct? obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}
