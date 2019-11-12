﻿using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class NullableIntBase : Base<int?>
    {
        public NullableIntBase(ICloneHelper helper) : base(helper)
        {
        }

        #region Protected Members
        protected override int? GenerateItem()
        {
            return RandGen.GenerateInt();
        }

        protected override void AssertAreEqual(int? source, int? target)
        {
            Assert.Equal(source, target);
        }

        protected override void AssertAreSame(int? source, int? target)
        {
            AssertAreEqual(source, target);
        }
        #endregion
    }
}