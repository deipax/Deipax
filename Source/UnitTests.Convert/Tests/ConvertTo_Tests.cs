using Deipax.Convert;
using System;
using System.Globalization;
using UnitTests.Common;
using UnitTests.Convert.BaseClasses;
using Xunit;

namespace UnitTests.Convert
{
    //TODO: Fix all FormatException/InvalidCastException
    public abstract class ConvertTo_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo<TTo, TFrom>.From(from, CultureInfo.InvariantCulture);
        }
    }

    #region Bool/BoolNullable
    public class ConvertToBool : ConvertTo_Base<bool>
    {
        public override void From_Char_AsObject(object input, bool expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, bool expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, bool expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, bool expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, bool expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToBoolNullable : ConvertTo_Base<bool?>
    {
        public override void From_Char_AsObject(object input, bool? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, bool? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, bool? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, bool? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, bool? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Char/CharNullable
    public class ConvertToChar : ConvertTo_Base<char>
    {
        public override void From_Bool_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input, char expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, char expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToCharNullable : ConvertTo_Base<char?>
    {
        public override void From_Bool_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input, char? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, char? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertToSByte : ConvertTo_Base<sbyte>
    {
        public override void From_DateTime_AsObject(object input, sbyte expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, sbyte expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, sbyte expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToSByteNullable : ConvertTo_Base<sbyte?>
    {
        public override void From_DateTime_AsObject(object input, sbyte? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, sbyte? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, sbyte? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertToByte : ConvertTo_Base<byte>
    {
        public override void From_DateTime_AsObject(object input, byte expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, byte expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, byte expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToByteNullable : ConvertTo_Base<byte?>
    {
        public override void From_DateTime_AsObject(object input, byte? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, byte? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, byte? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertToShort : ConvertTo_Base<short>
    {
        public override void From_DateTime_AsObject(object input, short expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, short expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, short expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToShortNullable : ConvertTo_Base<short?>
    {
        public override void From_DateTime_AsObject(object input, short? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, short? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, short? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertToUShort : ConvertTo_Base<ushort>
    {
        public override void From_DateTime_AsObject(object input, ushort expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, ushort expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, ushort expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToUShortNullable : ConvertTo_Base<ushort?>
    {
        public override void From_DateTime_AsObject(object input, ushort? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, ushort? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, ushort? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Int/IntNullable
    public class ConvertToInt : ConvertTo_Base<int>
    {
        public override void From_DateTime_AsObject(object input, int expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, int expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, int expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToIntNullable : ConvertTo_Base<int?>
    {
        public override void From_DateTime_AsObject(object input, int? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, int? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, int? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertToUInt : ConvertTo_Base<uint>
    {
        public override void From_DateTime_AsObject(object input, uint expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, uint expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, uint expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToUIntNullable : ConvertTo_Base<uint?>
    {
        public override void From_DateTime_AsObject(object input, uint? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, uint? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, uint? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Long/LongNullable
    public class ConvertToLong : ConvertTo_Base<long>
    {
        public override void From_DateTime_AsObject(object input, long expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, long expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, long expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToLongNullable : ConvertTo_Base<long?>
    {
        public override void From_DateTime_AsObject(object input, long? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, long? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, long? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertToULong : ConvertTo_Base<ulong>
    {
        public override void From_DateTime_AsObject(object input, ulong expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, ulong expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, ulong expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToULongNullable : ConvertTo_Base<ulong?>
    {
        public override void From_DateTime_AsObject(object input, ulong? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, ulong? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, ulong? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertToFloat : ConvertTo_Base<float>
    {
        public override void From_Char_AsObject(object input, float expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, float expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, float expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, float expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, float expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToFloatNullable : ConvertTo_Base<float?>
    {
        public override void From_Char_AsObject(object input, float? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, float? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, float? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, float? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, float? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertToDouble : ConvertTo_Base<double>
    {
        public override void From_Char_AsObject(object input, double expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, double expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, double expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, double expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, double expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToDoubleNullable : ConvertTo_Base<double?>
    {
        public override void From_Char_AsObject(object input, double? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, double? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, double? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, double? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, double? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertToDecimal : ConvertTo_Base<decimal>
    {
        public override void From_Char_AsObject(object input, decimal expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, decimal expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, decimal expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, decimal expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, decimal expected) => Assert.ThrowsAsync<FormatException>(null);
    }

    public class ConvertToDecimalNullable : ConvertTo_Base<decimal?>
    {
        public override void From_Char_AsObject(object input, decimal? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, decimal? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_AsObject(object input, decimal? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, decimal? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, decimal? expected) => Assert.ThrowsAsync<FormatException>(null);
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertToDateTime : ConvertTo_Base<DateTime>
    {
        public override void From_Bool_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<FormatException>(null);
        public override void From_UShort_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UShort_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_Nullable_AsObject(object input, DateTime expected) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToDateTimeNullable : ConvertTo_Base<DateTime?>
    {
        public override void From_Bool_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Bool_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Byte_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Char_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Decimal_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Double_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Short_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Int_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Long_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_SByte_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Float_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_String_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<FormatException>(null);
        public override void From_UShort_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UShort_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_UInt_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_ULong_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_Enum_Nullable_AsObject(object input, DateTime? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
    }
    #endregion

    #region String
    public class ConvertToString : ConvertTo_Base<string>
    {
    }
    #endregion

    #region Object
    public class ConvertToObject : ConvertTo_Base<object>
    {
    }
    #endregion

    #region Enum
    public class ConvertToEnum : ConvertTo_Base<TestEnum>
    {
        public override void From_DateTime_AsObject(object input, TestEnum expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, TestEnum expected) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToEnumNullable : ConvertTo_Base<TestEnum?>
    {
        public override void From_DateTime_AsObject(object input, TestEnum? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, TestEnum? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToEnumLong : ConvertTo_Base<TestEnumLong>
    {
        public override void From_DateTime_AsObject(object input, TestEnumLong expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, TestEnumLong expected) => Assert.ThrowsAsync<InvalidCastException>(null);
    }

    public class ConvertToEnumLongNullable : ConvertTo_Base<TestEnumLong?>
    {
        public override void From_DateTime_AsObject(object input, TestEnumLong? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
        public override void From_DateTime_Nullable_AsObject(object input, TestEnumLong? expected) => Assert.ThrowsAsync<InvalidCastException>(null);
    }
    #endregion

    #region IParent
    public class ConvertToIParent : ConvertTo_Base<IParent>
    {
    }
    #endregion
}