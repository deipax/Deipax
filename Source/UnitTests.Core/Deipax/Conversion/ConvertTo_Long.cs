using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Core.BaseClasses.Conversion;

namespace UnitTests.Core.Deipax.Conversion
{
    [TestClass]
    public class ConvertTo_Long : BaseConvertTo<long>
    {
        protected override long ConvertFrom<X>(X from)
        {
            return ConvertTo<long>.From(from);
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
        public override void From_String_Empty()
        {
            base.From_String_Empty();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public override void From_String_Empty_AsObject()
        {
            base.From_String_Empty_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_NonConvertibleClass()
        {
            base.From_NonConvertibleClass();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_NonConvertibleClass_AsObject()
        {
            base.From_NonConvertibleClass_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_NonConvertibleStruct()
        {
            base.From_NonConvertibleStruct();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_NonConvertibleStruct_AsObject()
        {
            base.From_NonConvertibleStruct_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_NonConvertibleStruct_Nullable_WithValue()
        {
            base.From_NonConvertibleStruct_Nullable_WithValue();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_NonConvertibleStruct_Nullable_WithValue_AsObject()
        {
            base.From_NonConvertibleStruct_Nullable_WithValue_AsObject();
        }
    }
}