using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ComplexClassBase : Base<ComplexClass>
    {
        public ComplexClassBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<ComplexClass> GetItemGenerator()
        {
            return new ItemGenerator<ComplexClass>(ComplexClass.Generate, new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<ComplexClass>
        {
            public bool Equals(ComplexClass source, ComplexClass target)
            {
                return !ReferenceEquals(source, target) &&
                    !ReferenceEquals(source.One, target.One) &&
                    ReferenceEquals(target, target.One) &&
                    ReferenceEquals(source, source.One) &&
                    source.Int == target.Int &&
                    source.One.Int == target.One.Int;
            }

            public int GetHashCode(ComplexClass obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}