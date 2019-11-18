using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class DoubleSimpleClassBase : Base<DoubleSimpleClass>
    {
        public DoubleSimpleClassBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<DoubleSimpleClass> GetItemGenerator()
        {
            return new ItemGenerator<DoubleSimpleClass>(DoubleSimpleClass.Generate, new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<DoubleSimpleClass>
        {
            public bool Equals(DoubleSimpleClass source, DoubleSimpleClass target)
            {
                return ReferenceEquals(source.One, source.Two) &&
                    ReferenceEquals(target.One, target.Two) &&
                    source.One.BaseInt == target.One.BaseInt &&
                    source.One.Double == target.One.Double &&
                    source.One.Float == target.One.Float &&
                    source.One.Int == target.One.Int &&
                    source.One.Long == target.One.Long &&
                    source.One.String == target.One.String &&
                    source.One.UInt == target.One.UInt &&
                    source.One.ULong == target.One.ULong;
            }

            public int GetHashCode(DoubleSimpleClass obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}