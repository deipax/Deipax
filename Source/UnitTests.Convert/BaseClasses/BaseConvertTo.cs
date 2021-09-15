using Deipax.Convert;
using System;
using System.Globalization;
using UnitTests.Common;
using UnitTests.Convert.Common;
using Xunit;

namespace UnitTests.Convert.BaseClasses
{
    public abstract class BaseConvertTo<TTo>
    {
        public static TestData<TTo> Data = new TestData<TTo>();
        public static TheoryData<bool, TTo> Bool = Data.Bool();
        public static TheoryData<bool?, TTo> BoolNullable = Data.BoolNullable();
        public static TheoryData<byte, TTo> Byte = Data.Byte();
        public static TheoryData<byte?, TTo> ByteNullable = Data.ByteNullable();
        public static TheoryData<char, TTo> Char = Data.Char();
        public static TheoryData<char?, TTo> CharNullable = Data.CharNullable();
        public static TheoryData<DateTime, TTo> DateTime = Data.DateTime();
        public static TheoryData<DateTime?, TTo> DateTimeNullable = Data.DateTimeNullable();
        public static TheoryData<decimal, TTo> Decimal = Data.Decimal();
        public static TheoryData<decimal?, TTo> DecimalNullable = Data.DecimalNullable();
        public static TheoryData<double, TTo> Double = Data.Double();
        public static TheoryData<double?, TTo> DoubleNullable = Data.DoubleNullable();
        public static TheoryData<short, TTo> Short = Data.Short();
        public static TheoryData<short?, TTo> ShortNullable = Data.ShortNullable();
        public static TheoryData<int, TTo> Int = Data.Int();
        public static TheoryData<int?, TTo> IntNullable = Data.IntNullable();
        public static TheoryData<long, TTo> Long = Data.Long();
        public static TheoryData<long?, TTo> LongNullable = Data.LongNullable();
        public static TheoryData<sbyte, TTo> SByte = Data.SByte();
        public static TheoryData<sbyte?, TTo> SByteNullable = Data.SByteNullable();
        public static TheoryData<float, TTo> Float = Data.Float();
        public static TheoryData<float?, TTo> FloatNullable = Data.FloatNullable();
        public static TheoryData<string, TTo> String = Data.String();
        public static TheoryData<ushort, TTo> UShort = Data.UShort();
        public static TheoryData<ushort?, TTo> UShortNullable = Data.UShortNullable();
        public static TheoryData<uint, TTo> UInt = Data.UInt();
        public static TheoryData<uint?, TTo> UIntNullable = Data.UIntNullable();
        public static TheoryData<ulong, TTo> ULong = Data.ULong();
        public static TheoryData<ulong?, TTo> ULongNullable = Data.ULongNullable();
        public static TheoryData<DBNull, TTo> DbNull = Data.DbNull();
        public static TheoryData<ConvertibleClass, TTo> ConvertibleClass = Data.ConvertibleClass();
        public static TheoryData<NonConvertibleClass, TTo> NonConvertibleClass = Data.NonConvertibleClass();
        public static TheoryData<ConvertibleStruct, TTo> ConvertibleStruct = Data.ConvertibleStruct();
        public static TheoryData<ConvertibleStruct?, TTo> ConvertibleStructNullable = Data.ConvertibleStructNullable();
        public static TheoryData<NonConvertibleStruct, TTo> NonConvertibleStruct = Data.NonConvertibleStruct();
        public static TheoryData<NonConvertibleStruct?, TTo> NonConvertibleStructNullable = Data.NonConvertibleStructNullable();
        public static TheoryData<TestEnum, TTo> Enum = Data.Enum();
        public static TheoryData<TestEnum?, TTo> EnumNullable = Data.EnumNullable();
        public static TheoryData<ParentClass, TTo> ParentClass = Data.ParentClass();
        public static TheoryData<ParentStruct, TTo> ParentStruct = Data.ParentStruct();
        public static TheoryData<ParentStruct?, TTo> ParentStructNullable = Data.ParentStructNullable();

        #region From Bool
        [Theory]
        [MemberData(nameof(Bool))]
        public virtual void From_Bool(bool input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Bool))]
        public virtual void From_Bool_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(BoolNullable))]
        public virtual void From_Bool_Nullable(bool? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(BoolNullable))]
        public virtual void From_Bool_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Byte
        [Theory]
        [MemberData(nameof(Byte))]
        public virtual void From_Byte(byte input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Byte))]
        public virtual void From_Byte_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ByteNullable))]
        public virtual void From_Byte_Nullable(byte? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ByteNullable))]
        public virtual void From_Byte_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Char
        [Theory]
        [MemberData(nameof(Char))]
        public virtual void From_Char(char input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Char))]
        public virtual void From_Char_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(CharNullable))]
        public virtual void From_Char_Nullable(char? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(CharNullable))]
        public virtual void From_Char_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From DateTime
        [Theory]
        [MemberData(nameof(DateTime))]
        public virtual void From_DateTime(DateTime input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DateTime))]
        public virtual void From_DateTime_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DateTimeNullable))]
        public virtual void From_DateTime_Nullable(DateTime? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DateTimeNullable))]
        public virtual void From_DateTime_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Decimal
        [Theory]
        [MemberData(nameof(Decimal))]
        public virtual void From_Decimal(decimal input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Decimal))]
        public virtual void From_Decimal_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DecimalNullable))]
        public virtual void From_Decimal_Nullable(decimal? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DecimalNullable))]
        public virtual void From_Decimal_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Double
        [Theory]
        [MemberData(nameof(Double))]
        public virtual void From_Double(double input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Double))]
        public virtual void From_Double_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DoubleNullable))]
        public virtual void From_Double_Nullable(double? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DoubleNullable))]
        public virtual void From_Double_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Short
        [Theory]
        [MemberData(nameof(Short))]
        public virtual void From_Short(short input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Short))]
        public virtual void From_Short_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ShortNullable))]
        public virtual void From_Short_Nullable(short? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ShortNullable))]
        public virtual void From_Short_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Int
        [Theory]
        [MemberData(nameof(Int))]
        public virtual void From_Int(int input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Int))]
        public virtual void From_Int_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(IntNullable))]
        public virtual void From_Int_Nullable(int? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(IntNullable))]
        public virtual void From_Int_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Long
        [Theory]
        [MemberData(nameof(Long))]
        public virtual void From_Long(long input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Long))]
        public virtual void From_Long_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(LongNullable))]
        public virtual void From_Long_Nullable(long? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(LongNullable))]
        public virtual void From_Long_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From SByte
        [Theory]
        [MemberData(nameof(SByte))]
        public virtual void From_SByte(sbyte input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(SByte))]
        public virtual void From_SByte_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(SByteNullable))]
        public virtual void From_SByte_Nullable(sbyte? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(SByteNullable))]
        public virtual void From_SByte_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Float
        [Theory]
        [MemberData(nameof(Float))]
        public virtual void From_Float(float input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Float))]
        public virtual void From_Float_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(FloatNullable))]
        public virtual void From_Float_Nullable(float? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(FloatNullable))]
        public virtual void From_Float_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From String
        [Theory]
        [MemberData(nameof(String))]
        public virtual void From_String(string input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(String))]
        public virtual void From_String_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From UShort
        [Theory]
        [MemberData(nameof(UShort))]
        public virtual void From_UShort(ushort input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(UShort))]
        public virtual void From_UShort_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(UShortNullable))]
        public virtual void From_UShort_Nullable(ushort? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(UShortNullable))]
        public virtual void From_UShort_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From UInt
        [Theory]
        [MemberData(nameof(UInt))]
        public virtual void From_UInt(uint input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(UInt))]
        public virtual void From_UInt_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(UIntNullable))]
        public virtual void From_UInt_Nullable(uint? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(UIntNullable))]
        public virtual void From_UInt_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From ULong
        [Theory]
        [MemberData(nameof(ULong))]
        public virtual void From_ULong(ulong input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ULong))]
        public virtual void From_ULong_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ULongNullable))]
        public virtual void From_ULong_Nullable(ulong? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ULongNullable))]
        public virtual void From_ULong_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region Null/DbNull
        [Theory]
        [MemberData(nameof(DbNull))]
        public virtual void From_DBNull(DBNull input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(DbNull))]
        public virtual void From_DBNull_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From IConvertible Class
        [Theory]
        [MemberData(nameof(ConvertibleClass))]
        public virtual void From_ConvertibleClass(ConvertibleClass input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ConvertibleClass))]
        public virtual void From_ConvertibleClass_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Non-IConvertible Class
        [Theory]
        [MemberData(nameof(NonConvertibleClass))]
        public virtual void From_NonConvertibleClass(NonConvertibleClass input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(NonConvertibleClass))]
        public virtual void From_NonConvertibleClass_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From IConvertible Struct
        [Theory]
        [MemberData(nameof(ConvertibleStruct))]
        public virtual void From_ConvertibleStruct(ConvertibleStruct input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ConvertibleStruct))]
        public virtual void From_ConvertibleStruct_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ConvertibleStructNullable))]
        public virtual void From_ConvertibleStruct_Nullable(ConvertibleStruct? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ConvertibleStructNullable))]
        public virtual void From_ConvertibleStruct_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Non-IConvertible Structs
        [Theory]
        [MemberData(nameof(NonConvertibleStruct))]
        public virtual void From_NonConvertibleStruct(NonConvertibleStruct input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(NonConvertibleStruct))]
        public virtual void From_NonConvertibleStruct_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(NonConvertibleStructNullable))]
        public virtual void From_NonConvertibleStruct_WithValue(NonConvertibleStruct? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(NonConvertibleStructNullable))]
        public virtual void From_NonConvertibleStruct_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From Enum
        [Theory]
        [MemberData(nameof(Enum))]
        public virtual void From_Enum(TestEnum input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(Enum))]
        public virtual void From_Enum_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(EnumNullable))]
        public virtual void From_Enum_Nullable(TestEnum? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(EnumNullable))]
        public virtual void From_Enum_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From ParentClass
        [Theory]
        [MemberData(nameof(ParentClass))]
        public virtual void From_ParentClass(ParentClass input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ParentClass))]
        public virtual void From_ParentClass_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region From ParentStruct
        [Theory]
        [MemberData(nameof(ParentStruct))]
        public virtual void From_ParentStruct(ParentStruct input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ParentStruct))]
        public virtual void From_ParentStruct_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ParentStructNullable))]
        public virtual void From_ParentStruct_Nullable(ParentStruct? input, TTo expected) => AssertEqual(expected, Convert(input));

        [Theory]
        [MemberData(nameof(ParentStructNullable))]
        public virtual void From_ParentStruct_Nullable_AsObject(object input, TTo expected) => AssertEqual(expected, Convert(input));
        #endregion

        #region Protected Members
        protected virtual TTo Convert<TFrom>(TFrom value)
        {
            return ConvertTo<TTo>.From(value, CultureInfo.InvariantCulture);
        }

        protected virtual void AssertEqual(TTo expected, TTo actual)
        {
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}