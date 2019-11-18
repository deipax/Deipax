using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ComplexStructBase : Base<ComplexStruct>
    {
        public ComplexStructBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<ComplexStruct> GetItemGenerator()
        {
            return new ItemGenerator<ComplexStruct>(ComplexStruct.Generate, new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<ComplexStruct>
        {
            public bool Equals(ComplexStruct source, ComplexStruct target)
            {
                return ReferenceEquals(source.One, source.One.One) &&
                    ReferenceEquals(target.One, target.One.One) &&
                    source.Int == target.Int &&
                    source.One.Int == target.One.Int;
            }

            public int GetHashCode(ComplexStruct obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}