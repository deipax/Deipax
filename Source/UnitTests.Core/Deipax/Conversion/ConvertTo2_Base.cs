using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Core.BaseClasses.Conversion;

namespace UnitTests.Core.Deipax.Conversion
{
    [TestClass]
    public class ConvertTo2_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo2<TTo, TFrom>.From(from);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_DateTime()
        {
            base.From_DateTime();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_DateTime_AsObject()
        {
            base.From_DateTime_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_DateTime_Nullable_WithValue()
        {
            base.From_DateTime_Nullable_WithValue();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_DateTime_Nullable_WithValue_AsObject()
        {
            base.From_DateTime_Nullable_WithValue_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public override void From_String_Empty_AsObject()
        {
            base.From_String_Empty_AsObject();
        }
    }
}