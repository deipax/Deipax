using System;
using UnitTests.Common;
using UnitTests.Convert.BaseClasses;
using Xunit;

namespace UnitTests.Convert
{
    //TODO: Fix all FormatException/InvalidCastException
    #region Bool/BoolNullable
    public class ConvertToBool : BaseConvertTo<bool>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToBoolNullable : BaseConvertTo<bool?>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Char/CharNullable
    public class ConvertToChar : BaseConvertTo<char>
    {
        public override void From_Bool_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToCharNullable : BaseConvertTo<char?>
    {
        public override void From_Bool_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertToSByte : BaseConvertTo<sbyte>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToSByteNullable : BaseConvertTo<sbyte?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertToByte : BaseConvertTo<byte>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToByteNullable : BaseConvertTo<byte?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertToShort : BaseConvertTo<short>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToShortNullable : BaseConvertTo<short?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertToUShort : BaseConvertTo<ushort>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToUShortNullable : BaseConvertTo<ushort?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Int/IntNullable
    public class ConvertToInt : BaseConvertTo<int>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToIntNullable : BaseConvertTo<int?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertToUInt : BaseConvertTo<uint>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToUIntNullable : BaseConvertTo<uint?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Long/LongNullable
    public class ConvertToLong : BaseConvertTo<long>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToLongNullable : BaseConvertTo<long?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertToULong : BaseConvertTo<ulong>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToULongNullable : BaseConvertTo<ulong?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertToFloat : BaseConvertTo<float>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToFloatNullable : BaseConvertTo<float?>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertToDouble : BaseConvertTo<double>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToDoubleNullable : BaseConvertTo<double?>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertToDecimal : BaseConvertTo<decimal>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToDecimalNullable : BaseConvertTo<decimal?>
    {
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertToDateTime : BaseConvertTo<DateTime>
    {
        public override void From_Bool_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
        public override void From_UShort_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UShort_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToDateTimeNullable : BaseConvertTo<DateTime?>
    {
        public override void From_Bool_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input) => Assert.ThrowsAsync<FormatException>(null);
        public override void From_UShort_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UShort_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
    }
    #endregion

    #region String
    public class ConvertToString : BaseConvertTo<string>
    {
    }
    #endregion

    #region Object
    public class ConvertToObject : BaseConvertTo<object>
    {
    }
    #endregion

    #region Enum
    public class ConvertToEnum : BaseConvertTo<TestEnum>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToEnumNullable : BaseConvertTo<TestEnum?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToEnumLong : BaseConvertTo<TestEnumLong>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToEnumLongNullable : BaseConvertTo<TestEnumLong?>
    {
        public override void From_DateTime_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input) => Assert.ThrowsAsync<InvalidCastException>(null);
    }
    #endregion

    #region IParent
    public class ConvertToIParent : BaseConvertTo<IParent>
    {
    }
    #endregion
}