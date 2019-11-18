using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class SimpleClassBase : Base<SimpleClass>
    {
        public SimpleClassBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Private Member
        protected override ItemGenerator<SimpleClass> GetItemGenerator()
        {
            return new ItemGenerator<SimpleClass>(SimpleClass.Generate, new EqualityComparer());
        }
        #endregion

        #region Helpers
        private class EqualityComparer : IEqualityComparer<SimpleClass>
        {
            public bool Equals(SimpleClass source, SimpleClass target)
            {
                return source.BaseInt == target.BaseInt &&
                    source.Double == target.Double &&
                    source.Float == target.Float &&
                    source.Int == target.Int &&
                    source.Long == target.Long &&
                    source.String == target.String &&
                    source.UInt == target.UInt &&
                    source.ULong == target.ULong;
            }

            public int GetHashCode(SimpleClass obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}