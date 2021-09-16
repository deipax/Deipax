using Deipax.Convert;
using System;
using System.Globalization;
using Deipax.Core.Extensions;
using UnitTests.Common;
using UnitTests.Convert.Common;
using Xunit;

namespace UnitTests.Convert.BaseClasses
{
    public abstract class BaseConvertTo<TTo>
    {
        #region From Bool
        [Theory]
        [MemberData(nameof(TestData.Bool), MemberType = typeof(TestData))]
        public virtual void From_Bool(bool input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Bool), MemberType = typeof(TestData))]
        public virtual void From_Bool_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.BoolNullable), MemberType = typeof(TestData))]
        public virtual void From_Bool_Nullable(bool? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.BoolNullable), MemberType = typeof(TestData))]
        public virtual void From_Bool_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Byte
        [Theory]
        [MemberData(nameof(TestData.Byte), MemberType = typeof(TestData))]
        public virtual void From_Byte(byte input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Byte), MemberType = typeof(TestData))]
        public virtual void From_Byte_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ByteNullable), MemberType = typeof(TestData))]
        public virtual void From_Byte_Nullable(byte? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ByteNullable), MemberType = typeof(TestData))]
        public virtual void From_Byte_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Char
        [Theory]
        [MemberData(nameof(TestData.Char), MemberType = typeof(TestData))]
        public virtual void From_Char(char input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Char), MemberType = typeof(TestData))]
        public virtual void From_Char_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.CharNullable), MemberType = typeof(TestData))]
        public virtual void From_Char_Nullable(char? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.CharNullable), MemberType = typeof(TestData))]
        public virtual void From_Char_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From DateTime
        [Theory]
        [MemberData(nameof(TestData.DateTime), MemberType = typeof(TestData))]
        public virtual void From_DateTime(DateTime input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DateTime), MemberType = typeof(TestData))]
        public virtual void From_DateTime_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DateTimeNullable), MemberType = typeof(TestData))]
        public virtual void From_DateTime_Nullable(DateTime? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DateTimeNullable), MemberType = typeof(TestData))]
        public virtual void From_DateTime_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Decimal
        [Theory]
        [MemberData(nameof(TestData.Decimal), MemberType = typeof(TestData))]
        public virtual void From_Decimal(decimal input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Decimal), MemberType = typeof(TestData))]
        public virtual void From_Decimal_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DecimalNullable), MemberType = typeof(TestData))]
        public virtual void From_Decimal_Nullable(decimal? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DecimalNullable), MemberType = typeof(TestData))]
        public virtual void From_Decimal_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Double
        [Theory]
        [MemberData(nameof(TestData.Double), MemberType = typeof(TestData))]
        public virtual void From_Double(double input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Double), MemberType = typeof(TestData))]
        public virtual void From_Double_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DoubleNullable), MemberType = typeof(TestData))]
        public virtual void From_Double_Nullable(double? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DoubleNullable), MemberType = typeof(TestData))]
        public virtual void From_Double_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Short
        [Theory]
        [MemberData(nameof(TestData.Short), MemberType = typeof(TestData))]
        public virtual void From_Short(short input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Short), MemberType = typeof(TestData))]
        public virtual void From_Short_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ShortNullable), MemberType = typeof(TestData))]
        public virtual void From_Short_Nullable(short? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ShortNullable), MemberType = typeof(TestData))]
        public virtual void From_Short_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Int
        [Theory]
        [MemberData(nameof(TestData.Int), MemberType = typeof(TestData))]
        public virtual void From_Int(int input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Int), MemberType = typeof(TestData))]
        public virtual void From_Int_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.IntNullable), MemberType = typeof(TestData))]
        public virtual void From_Int_Nullable(int? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.IntNullable), MemberType = typeof(TestData))]
        public virtual void From_Int_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Long
        [Theory]
        [MemberData(nameof(TestData.Long), MemberType = typeof(TestData))]
        public virtual void From_Long(long input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Long), MemberType = typeof(TestData))]
        public virtual void From_Long_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.LongNullable), MemberType = typeof(TestData))]
        public virtual void From_Long_Nullable(long? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.LongNullable), MemberType = typeof(TestData))]
        public virtual void From_Long_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From SByte
        [Theory]
        [MemberData(nameof(TestData.SByte), MemberType = typeof(TestData))]
        public virtual void From_SByte(sbyte input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.SByte), MemberType = typeof(TestData))]
        public virtual void From_SByte_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.SByteNullable), MemberType = typeof(TestData))]
        public virtual void From_SByte_Nullable(sbyte? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.SByteNullable), MemberType = typeof(TestData))]
        public virtual void From_SByte_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Float
        [Theory]
        [MemberData(nameof(TestData.Float), MemberType = typeof(TestData))]
        public virtual void From_Float(float input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Float), MemberType = typeof(TestData))]
        public virtual void From_Float_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.FloatNullable), MemberType = typeof(TestData))]
        public virtual void From_Float_Nullable(float? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.FloatNullable), MemberType = typeof(TestData))]
        public virtual void From_Float_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From String
        [Theory]
        [MemberData(nameof(TestData.String), MemberType = typeof(TestData))]
        public virtual void From_String(string input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.String), MemberType = typeof(TestData))]
        public virtual void From_String_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From UShort
        [Theory]
        [MemberData(nameof(TestData.UShort), MemberType = typeof(TestData))]
        public virtual void From_UShort(ushort input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.UShort), MemberType = typeof(TestData))]
        public virtual void From_UShort_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.UShortNullable), MemberType = typeof(TestData))]
        public virtual void From_UShort_Nullable(ushort? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.UShortNullable), MemberType = typeof(TestData))]
        public virtual void From_UShort_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From UInt
        [Theory]
        [MemberData(nameof(TestData.UInt), MemberType = typeof(TestData))]
        public virtual void From_UInt(uint input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.UInt), MemberType = typeof(TestData))]
        public virtual void From_UInt_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.UIntNullable), MemberType = typeof(TestData))]
        public virtual void From_UInt_Nullable(uint? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.UIntNullable), MemberType = typeof(TestData))]
        public virtual void From_UInt_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From ULong
        [Theory]
        [MemberData(nameof(TestData.ULong), MemberType = typeof(TestData))]
        public virtual void From_ULong(ulong input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ULong), MemberType = typeof(TestData))]
        public virtual void From_ULong_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ULongNullable), MemberType = typeof(TestData))]
        public virtual void From_ULong_Nullable(ulong? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ULongNullable), MemberType = typeof(TestData))]
        public virtual void From_ULong_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region Null/DbNull
        [Theory]
        [MemberData(nameof(TestData.DbNull), MemberType = typeof(TestData))]
        public virtual void From_DBNull(DBNull input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.DbNull), MemberType = typeof(TestData))]
        public virtual void From_DBNull_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From IConvertible Class
        [Theory]
        [MemberData(nameof(TestData.ConvertibleClass), MemberType = typeof(TestData))]
        public virtual void From_ConvertibleClass(ConvertibleClass input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ConvertibleClass), MemberType = typeof(TestData))]
        public virtual void From_ConvertibleClass_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Non-IConvertible Class
        [Theory]
        [MemberData(nameof(TestData.NonConvertibleClass), MemberType = typeof(TestData))]
        public virtual void From_NonConvertibleClass(NonConvertibleClass input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.NonConvertibleClass), MemberType = typeof(TestData))]
        public virtual void From_NonConvertibleClass_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From IConvertible Struct
        [Theory]
        [MemberData(nameof(TestData.ConvertibleStruct), MemberType = typeof(TestData))]
        public virtual void From_ConvertibleStruct(ConvertibleStruct input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ConvertibleStruct), MemberType = typeof(TestData))]
        public virtual void From_ConvertibleStruct_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ConvertibleStructNullable), MemberType = typeof(TestData))]
        public virtual void From_ConvertibleStruct_Nullable(ConvertibleStruct? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ConvertibleStructNullable), MemberType = typeof(TestData))]
        public virtual void From_ConvertibleStruct_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Non-IConvertible Structs
        [Theory]
        [MemberData(nameof(TestData.NonConvertibleStruct), MemberType = typeof(TestData))]
        public virtual void From_NonConvertibleStruct(NonConvertibleStruct input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.NonConvertibleStruct), MemberType = typeof(TestData))]
        public virtual void From_NonConvertibleStruct_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.NonConvertibleStructNullable), MemberType = typeof(TestData))]
        public virtual void From_NonConvertibleStruct_WithValue(NonConvertibleStruct? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.NonConvertibleStructNullable), MemberType = typeof(TestData))]
        public virtual void From_NonConvertibleStruct_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From Enum
        [Theory]
        [MemberData(nameof(TestData.Enum), MemberType = typeof(TestData))]
        public virtual void From_Enum(TestEnum input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.Enum), MemberType = typeof(TestData))]
        public virtual void From_Enum_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.EnumNullable), MemberType = typeof(TestData))]
        public virtual void From_Enum_Nullable(TestEnum? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.EnumNullable), MemberType = typeof(TestData))]
        public virtual void From_Enum_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From ParentClass
        [Theory]
        [MemberData(nameof(TestData.ParentClass), MemberType = typeof(TestData))]
        public virtual void From_ParentClass(ParentClass input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ParentClass), MemberType = typeof(TestData))]
        public virtual void From_ParentClass_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region From ParentStruct
        [Theory]
        [MemberData(nameof(TestData.ParentStruct), MemberType = typeof(TestData))]
        public virtual void From_ParentStruct(ParentStruct input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ParentStruct), MemberType = typeof(TestData))]
        public virtual void From_ParentStruct_AsObject(object input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ParentStructNullable), MemberType = typeof(TestData))]
        public virtual void From_ParentStruct_Nullable(ParentStruct? input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [MemberData(nameof(TestData.ParentStructNullable), MemberType = typeof(TestData))]
        public virtual void From_ParentStruct_Nullable_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
        #endregion

        #region Protected Members
        protected TTo GetExpected<TFrom>(TFrom value)
        {
            if (value == null)
            {
                return default;
            }

            var toType = typeof(TTo);
            var fromType = typeof(TFrom);
            var underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            var underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;
            var runtimeFromType = value?.GetType();
            var underlyingRuntimeType = runtimeFromType != null ? Nullable.GetUnderlyingType(runtimeFromType) : runtimeFromType;

            try
            {
                if (underlyingToType == underlyingFromType ||
                    runtimeFromType == underlyingToType ||
                    underlyingRuntimeType == underlyingToType ||
                    underlyingToType == typeof(object) ||
                    underlyingFromType.CanBeAssignedTo(underlyingToType) ||
                    runtimeFromType.CanBeAssignedTo(underlyingToType))
                {
                    return (TTo)(object)value;
                }

                if (toType.IsEnum || underlyingToType.IsEnum)
                {
                    if (fromType == typeof(string))
                    {
                        return (TTo)System.Enum.Parse(underlyingToType, value as string, true);
                    }
                    else
                    {
                        var intValue = System.Convert.ChangeType(value, typeof(int), CultureInfo.InvariantCulture);
                        return (TTo)System.Enum.Parse(underlyingToType, intValue.ToString(), true);
                    }
                }

                if (toType == typeof(string) && runtimeFromType == typeof(DBNull))
                {
                    return default;
                }

                return (TTo)System.Convert.ChangeType(value, underlyingToType, CultureInfo.InvariantCulture);
            }
            catch
            {
            }

            // TODO:  Fix this.  A non-convertable should return default TTo
            if (toType == typeof(string) && value != null)
            {
                return (TTo)(object)value.ToString();
            }

            return default;
        }

        protected TTo Convert<TFrom>(TFrom value)
        {
            return ConvertTo<TTo>.From(value, CultureInfo.InvariantCulture);
        }

        protected void AssertEqual<TFrom>(TFrom input, Func<TFrom, TTo> expectedFunc, Func<TFrom, TTo> actualFunc)
        {
            TTo expected = expectedFunc(input);
            TTo actual = actualFunc(input);
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}