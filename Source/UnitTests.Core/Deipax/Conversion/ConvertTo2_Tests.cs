using System;
using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Core.BaseClasses.Conversion;

namespace UnitTests.Core.Deipax.Conversion.ConvertTo2
{
    [TestClass]
    public class ConvertTo2_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo2<TTo, TFrom>.From(from);
        }
    }

    #region Bool/BoolNullable
    [TestClass]
    public class ConvertTo2_Bool : ConvertTo2_Base<bool>
    {
        public ConvertTo2_Bool()
        {
            _fromString_AsObject = _fromString = "true";
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char()
        {
            base.From_Char();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_AsObject()
        {
            base.From_Char_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_Nullable_WithValue()
        {
            base.From_Char_Nullable_WithValue();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_Nullable_WithValue_AsObject()
        {
            base.From_Char_Nullable_WithValue_AsObject();
        }
    }

    [TestClass]
    public class ConvertTo2_BoolNullable : ConvertTo2_Base<bool?>
    {
        public ConvertTo2_BoolNullable()
        {
            _fromString_AsObject = _fromString = "true";
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char()
        {
            base.From_Char();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_AsObject()
        {
            base.From_Char_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_Nullable_WithValue()
        {
            base.From_Char_Nullable_WithValue();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_Nullable_WithValue_AsObject()
        {
            base.From_Char_Nullable_WithValue_AsObject();
        }
    }
    #endregion

    #region Long/LongNullable
    [TestClass]
    public class ConvertTo2_Long : ConvertTo2_Base<long>
    {
    }

    [TestClass]
    public class ConvertTo2_LongNullable : ConvertTo2_Base<long?>
    {
    }
    #endregion
}