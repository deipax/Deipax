using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    public class ConvertTo2_BoolBase<TTo> : ConvertTo2_Base<TTo>
    {
        public ConvertTo2_BoolBase()
        {
            _fromString_AsObject = _fromString = "true";
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_AsObject()
        {
            base.From_Char_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_Nullable_WithValue_AsObject()
        {
            base.From_Char_Nullable_WithValue_AsObject();
        }
    }

    [TestClass]
    public class ConvertTo2_Bool : ConvertTo2_BoolBase<bool>
    {
    }

    [TestClass]
    public class ConvertTo2_BoolNullable : ConvertTo2_BoolBase<bool?>
    {
    }
    #endregion

    #region Char/CharNullable
    [TestClass]
    public class ConvertTo2_CharBase<TTo> : ConvertTo2_Base<TTo>
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Bool_AsObject()
        {
            base.From_Bool_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Bool_Nullable_WithValue_AsObject()
        {
            base.From_Bool_Nullable_WithValue_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Decimal_AsObject()
        {
            base.From_Decimal_AsObject();
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Decimal_Nullable_WithValue_AsObject()
        {
            base.From_Decimal_Nullable_WithValue_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Double_AsObject()
        {
            base.From_Double_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Double_Nullable_WithValue_AsObject()
        {
            base.From_Double_Nullable_WithValue_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Float_AsObject()
        {
            base.From_Float_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Float_Nullable_WithValue_AsObject()
        {
            base.From_Float_Nullable_WithValue_AsObject();
        }
    }

    [TestClass]
    public class ConvertTo2_Char : ConvertTo2_CharBase<char>
    {
    }

    [TestClass]
    public class ConvertTo2_CharNullable : ConvertTo2_CharBase<char?>
    {
    }
    #endregion

    #region SByte/SByteNullable
    [TestClass]
    public class ConvertTo2_SByte : ConvertTo2_Base<sbyte>
    {
    }

    [TestClass]
    public class ConvertTo2_SByteNullable : ConvertTo2_Base<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    [TestClass]
    public class ConvertTo2_Byte : ConvertTo2_Base<byte>
    {
    }

    [TestClass]
    public class ConvertTo2_ByteNullable : ConvertTo2_Base<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    [TestClass]
    public class ConvertTo2_Short : ConvertTo2_Base<short>
    {
    }

    [TestClass]
    public class ConvertTo2_ShortNullable : ConvertTo2_Base<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    [TestClass]
    public class ConvertTo2_UShort : ConvertTo2_Base<ushort>
    {
    }

    [TestClass]
    public class ConvertTo2_UShortNullable : ConvertTo2_Base<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    [TestClass]
    public class ConvertTo2_Int : ConvertTo2_Base<int>
    {
    }

    [TestClass]
    public class ConvertTo2_IntNullable : ConvertTo2_Base<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    [TestClass]
    public class ConvertTo2_UInt : ConvertTo2_Base<uint>
    {
    }

    [TestClass]
    public class ConvertTo2_UIntNullable : ConvertTo2_Base<uint?>
    {
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

    #region ULong/ULongNullable
    [TestClass]
    public class ConvertTo2_ULong : ConvertTo2_Base<ulong>
    {
    }

    [TestClass]
    public class ConvertTo2_ULongNullable : ConvertTo2_Base<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    [TestClass]
    public class ConvertTo2_FloatBase<TTo> : ConvertTo2_Base<TTo>
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_AsObject()
        {
            base.From_Char_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_Nullable_WithValue_AsObject()
        {
            base.From_Char_Nullable_WithValue_AsObject();
        }
    }

    [TestClass]
    public class ConvertTo2_Float : ConvertTo2_FloatBase<float>
    {
    }

    [TestClass]
    public class ConvertTo2_FloatNullable : ConvertTo2_FloatBase<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    [TestClass]
    public class ConvertTo2_DoubleBase<TTo> : ConvertTo2_Base<TTo>
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_AsObject()
        {
            base.From_Char_AsObject();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public override void From_Char_Nullable_WithValue_AsObject()
        {
            base.From_Char_Nullable_WithValue_AsObject();
        }
    }

    [TestClass]
    public class ConvertTo2_Double : ConvertTo2_DoubleBase<double>
    {
    }

    [TestClass]
    public class ConvertTo2_DoubleNullable : ConvertTo2_DoubleBase<double?>
    {
    }
    #endregion
}