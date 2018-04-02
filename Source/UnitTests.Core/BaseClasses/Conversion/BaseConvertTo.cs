using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.BaseClasses.Conversion
{
    [TestClass]
    public abstract class BaseConvertTo<TTo>
    {
        public BaseConvertTo()
        {
            DefaultValue = default(TTo);

            _fromBool_AsObject = _fromBool = true;
            _fromBoolNullableWithValue_AsObject = _fromBoolNullableWithValue = true;
            _fromBoolNullableNoValue_AsObject = _fromBoolNullableNoValue = null;

            _fromByte_AsObject = _fromByte = 1;
            _fromByteNullableWithValue_AsObject = _fromByteNullableWithValue = 1;
            _fromByteNullableNoValue_AsObject = _fromByteNullableNoValue = null;

            _fromChar_AsObject = _fromChar = 'c';
            _fromCharNullableWithValue_AsObject = _fromCharNullableWithValue = 'c';
            _fromCharNullableNoValue_AsObject = _fromCharNullableNoValue = null;

            _fromDateTime_AsObject = _fromDateTime = DateTime.MinValue;
            _fromDateTimeNullableWithValue_AsObject = _fromDateTimeNullableWithValue = DateTime.MinValue;
            _fromDateTimeNullableNoValue_AsObject = _fromDateTimeNullableNoValue = null;

            _fromDecimal_AsObject = _fromDecimal = 1;
            _fromDecimalNullableWithValue_AsObject = _fromDecimalNullableWithValue = 1;
            _fromDecimalNullableNoValue_AsObject = _fromDecimalNullableNoValue = null;

            _fromDouble_AsObject = _fromDouble = 1;
            _fromDoubleNullableWithValue_AsObject = _fromDoubleNullableWithValue = 1;
            _fromDoubleNullableNoValue_AsObject = _fromDoubleNullableNoValue = null;

            _fromShort_AsObject = _fromShort = 1;
            _fromShortNullableWithValue_AsObject = _fromShortNullableWithValue = 1;
            _fromShortNullableNoValue_AsObject = _fromShortNullableNoValue = null;

            _fromInt_AsObject = _fromInt = 1;
            _fromIntNullableWithValue_AsObject = _fromIntNullableWithValue = 1;
            _fromIntNullableNoValue_AsObject = _fromIntNullableNoValue = null;

            _fromLong_AsObject = _fromLong = 1;
            _fromLongNullableWithValue_AsObject = _fromLongNullableWithValue = 1;
            _fromLongNullableNoValue_AsObject = _fromLongNullableNoValue = null;

            _fromSbyte_AsObject = _fromSbyte = 1;
            _fromSbyteNullableWithValue_AsObject = _fromSbyteNullableWithValue = 1;
            _fromSbyteNullableNoValue_AsObject = _fromSbyteNullableNoValue = null;

            _fromFloat_AsObject = _fromFloat = 1;
            _fromFloatNullableWithValue_AsObject = _fromFloatNullableWithValue = 1;
            _fromFloatNullableNoValue_AsObject = _fromFloatNullableNoValue = null;

            _fromString_AsObject = _fromString = "1";
            _fromStringNull_AsObject = _fromStringNull = null;
            _fromStringEmpty_AsObject = _fromStringEmpty = string.Empty;

            _fromUShort_AsObject = _fromUShort = 1;
            _fromUShortNullableWithValue_AsObject = _fromUShortNullableWithValue = 1;
            _fromUShortNullableNoValue_AsObject = _fromUShortNullableNoValue = null;

            _fromUInt_AsObject = _fromUInt = 1;
            _fromUIntNullableWithValue_AsObject = _fromUIntNullableWithValue = 1;
            _fromUIntNullableNoValue_AsObject = _fromUIntNullableNoValue = null;

            _fromULong_AsObject = _fromULong = 1;
            _fromULongNullableWithValue_AsObject = _fromULongNullableWithValue = 1;
            _fromULongNullableNoValue_AsObject = _fromULongNullableNoValue = null;

            _convertibleClass_AsObject = _convertibleClass = new ConvertibleClass();
            _convertibleClassNoValue_AsObject = _convertibleClassNoValue = null;

            _nonConvertibleClass_AsObject = _nonConvertibleClass = new NonConvertibleClass();
            _nonConvertibleClassNoValue_AsObject = _nonConvertibleClassNoValue = null;

            _convertibleStruct_AsObject = _convertibleStruct = new ConvertibleStruct();
            _convertibleStructNullableWithValue_AsObject = _convertibleStructNullableWithValue = new ConvertibleStruct();
            _convertibleStructNullableNoValue_AsObject = _convertibleStructNullableNoValue = null;

            _nonConvertibleStruct_AsObject = _nonConvertibleStruct = new NonConvertibleStruct();
            _nonConvertibleStructNullableWithValue_AsObject = _nonConvertibleStructNullableWithValue = new NonConvertibleStruct();
            _nonConvertibleStructNullableNoValue_AsObject = _nonConvertibleStructNullableNoValue = null;

            _fromEnum_AsObject = _fromEnum = TestEnum.One;
            _fromEnumNullableWithValue_AsObject = _fromEnumNullableWithValue = TestEnum.One; ;
            _fromEnumNullableNoValue_AsObject = _fromEnumNullableNoValue = null;
        }

        #region Field Members
        private bool _fromBool;
        private bool? _fromBoolNullableWithValue;
        private bool? _fromBoolNullableNoValue;
        private object _fromBool_AsObject;
        private object _fromBoolNullableWithValue_AsObject;
        private object _fromBoolNullableNoValue_AsObject;

        private byte _fromByte;
        private byte? _fromByteNullableWithValue;
        private byte? _fromByteNullableNoValue;
        private object _fromByte_AsObject;
        private object _fromByteNullableWithValue_AsObject;
        private object _fromByteNullableNoValue_AsObject;

        private char _fromChar;
        private char? _fromCharNullableWithValue;
        private char? _fromCharNullableNoValue;
        private object _fromChar_AsObject;
        private object _fromCharNullableWithValue_AsObject;
        private object _fromCharNullableNoValue_AsObject;

        private DateTime _fromDateTime;
        private DateTime? _fromDateTimeNullableWithValue;
        private DateTime? _fromDateTimeNullableNoValue;
        private object _fromDateTime_AsObject;
        private object _fromDateTimeNullableWithValue_AsObject;
        private object _fromDateTimeNullableNoValue_AsObject;

        private decimal _fromDecimal;
        private decimal? _fromDecimalNullableWithValue;
        private decimal? _fromDecimalNullableNoValue;
        private object _fromDecimal_AsObject;
        private object _fromDecimalNullableWithValue_AsObject;
        private object _fromDecimalNullableNoValue_AsObject;

        private double _fromDouble;
        private double? _fromDoubleNullableWithValue;
        private double? _fromDoubleNullableNoValue;
        private object _fromDouble_AsObject;
        private object _fromDoubleNullableWithValue_AsObject;
        private object _fromDoubleNullableNoValue_AsObject;

        private short _fromShort;
        private short? _fromShortNullableWithValue;
        private short? _fromShortNullableNoValue;
        private object _fromShort_AsObject;
        private object _fromShortNullableWithValue_AsObject;
        private object _fromShortNullableNoValue_AsObject;

        private int _fromInt;
        private int? _fromIntNullableWithValue;
        private int? _fromIntNullableNoValue;
        private object _fromInt_AsObject;
        private object _fromIntNullableWithValue_AsObject;
        private object _fromIntNullableNoValue_AsObject;

        private long _fromLong;
        private long? _fromLongNullableWithValue;
        private long? _fromLongNullableNoValue;
        private object _fromLong_AsObject;
        private object _fromLongNullableWithValue_AsObject;
        private object _fromLongNullableNoValue_AsObject;

        private sbyte _fromSbyte;
        private sbyte? _fromSbyteNullableWithValue;
        private sbyte? _fromSbyteNullableNoValue;
        private object _fromSbyte_AsObject;
        private object _fromSbyteNullableWithValue_AsObject;
        private object _fromSbyteNullableNoValue_AsObject;

        private float _fromFloat;
        private float? _fromFloatNullableWithValue;
        private float? _fromFloatNullableNoValue;
        private object _fromFloat_AsObject;
        private object _fromFloatNullableWithValue_AsObject;
        private object _fromFloatNullableNoValue_AsObject;

        private string _fromString;
        private string _fromStringNull;
        private string _fromStringEmpty;
        private object _fromString_AsObject;
        private object _fromStringNull_AsObject;
        private object _fromStringEmpty_AsObject;

        private ushort _fromUShort;
        private ushort? _fromUShortNullableWithValue;
        private ushort? _fromUShortNullableNoValue;
        private object _fromUShort_AsObject;
        private object _fromUShortNullableWithValue_AsObject;
        private object _fromUShortNullableNoValue_AsObject;

        private uint _fromUInt;
        private uint? _fromUIntNullableWithValue;
        private uint? _fromUIntNullableNoValue;
        private object _fromUInt_AsObject;
        private object _fromUIntNullableWithValue_AsObject;
        private object _fromUIntNullableNoValue_AsObject;

        private ulong _fromULong;
        private ulong? _fromULongNullableWithValue;
        private ulong? _fromULongNullableNoValue;
        private object _fromULong_AsObject;
        private object _fromULongNullableWithValue_AsObject;
        private object _fromULongNullableNoValue_AsObject;

        private object _nullObject = null;

        private ConvertibleClass _convertibleClass;
        private ConvertibleClass _convertibleClassNoValue;
        private object _convertibleClass_AsObject;
        private object _convertibleClassNoValue_AsObject;

        private NonConvertibleClass _nonConvertibleClass;
        private NonConvertibleClass _nonConvertibleClassNoValue;
        private object _nonConvertibleClass_AsObject;
        private object _nonConvertibleClassNoValue_AsObject;

        private ConvertibleStruct _convertibleStruct;
        private ConvertibleStruct? _convertibleStructNullableWithValue;
        private ConvertibleStruct? _convertibleStructNullableNoValue;
        private object _convertibleStruct_AsObject;
        private object _convertibleStructNullableWithValue_AsObject;
        private object _convertibleStructNullableNoValue_AsObject;

        private NonConvertibleStruct _nonConvertibleStruct;
        private NonConvertibleStruct? _nonConvertibleStructNullableWithValue;
        private NonConvertibleStruct? _nonConvertibleStructNullableNoValue;
        private object _nonConvertibleStruct_AsObject;
        private object _nonConvertibleStructNullableWithValue_AsObject;
        private object _nonConvertibleStructNullableNoValue_AsObject;

        private TestEnum _fromEnum;
        private TestEnum? _fromEnumNullableWithValue;
        private TestEnum? _fromEnumNullableNoValue;
        private object _fromEnum_AsObject;
        private object _fromEnumNullableWithValue_AsObject;
        private object _fromEnumNullableNoValue_AsObject;
        #endregion

        #region Protected Members
        protected TTo DefaultValue { get; private set; }

        protected virtual void TestConvertFrom<X>(
            X from,
            TTo expectedResult)
        {
            TTo actualResult = ConvertFrom(from);
            Assert.AreEqual(expectedResult, actualResult);
        }

        protected virtual void TestConvertFrom<X>(
            X from)
        {
            TTo expectedResult = GetExpected(from);
            TTo actualResult = ConvertFrom(from);
            Assert.AreEqual(expectedResult, actualResult);
        }

        protected abstract TTo ConvertFrom<X>(X from);

        protected virtual TTo GetExpected<TFrom>(TFrom from)
        {
            try
            {
                var toType = typeof(TTo);
                var underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                if (from != null)
                {
                    return (TTo) Convert.ChangeType(from, underlyingToType);
                }
            }
            catch
            {
            }

            return default(TTo);
        }
        #endregion

        #region From Bool
        [TestMethod]
        public virtual void From_Bool()
        {
            TestConvertFrom(_fromBool);
        }

        [TestMethod]
        public virtual void From_Bool_AsObject()
        {
            TestConvertFrom(_fromBool_AsObject);
        }

        [TestMethod]
        public virtual void From_Bool_Nullable_WithValue()
        {
            TestConvertFrom(_fromBoolNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Bool_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromBoolNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Bool_Nullable_NoValue()
        {
            TestConvertFrom(_fromBoolNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Bool_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromBoolNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Byte
        [TestMethod]
        public virtual void From_Byte()
        {
            TestConvertFrom(_fromByte);
        }

        [TestMethod]
        public virtual void From_Byte_AsObject()
        {
            TestConvertFrom(_fromByte_AsObject);
        }

        [TestMethod]
        public virtual void From_Byte_Nullable_WithValue()
        {
            TestConvertFrom(_fromByteNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Byte_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromByteNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Byte_Nullable_NoValue()
        {
            TestConvertFrom(_fromByteNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Byte_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromByteNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Char
        [TestMethod]
        public virtual void From_Char()
        {
            TestConvertFrom(_fromChar);
        }

        [TestMethod]
        public virtual void From_Char_AsObject()
        {
            TestConvertFrom(_fromChar_AsObject);
        }

        [TestMethod]
        public virtual void From_Char_Nullable_WithValue()
        {
            TestConvertFrom(_fromCharNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Char_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromCharNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Char_Nullable_NoValue()
        {
            TestConvertFrom(_fromCharNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Char_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromCharNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From DateTime
        [TestMethod]
        public virtual void From_DateTime()
        {
            TestConvertFrom(_fromDateTime);
        }

        [TestMethod]
        public virtual void From_DateTime_AsObject()
        {
            TestConvertFrom(_fromDateTime_AsObject);
        }

        [TestMethod]
        public virtual void From_DateTime_Nullable_WithValue()
        {
            TestConvertFrom(_fromDateTimeNullableWithValue);
        }

        [TestMethod]
        public virtual void From_DateTime_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromDateTimeNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_DateTime_Nullable_NoValue()
        {
            TestConvertFrom(_fromDateTimeNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_DateTime_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromDateTimeNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Decimal
        [TestMethod]
        public virtual void From_Decimal()
        {
            TestConvertFrom(_fromDecimal);
        }

        [TestMethod]
        public virtual void From_Decimal_AsObject()
        {
            TestConvertFrom(_fromDecimal_AsObject);
        }

        [TestMethod]
        public virtual void From_Decimal_Nullable_WithValue()
        {
            TestConvertFrom(_fromDecimalNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Decimal_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromDecimalNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Decimal_Nullable_NoValue()
        {
            TestConvertFrom(_fromDecimalNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Decimal_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromDecimalNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Double
        [TestMethod]
        public virtual void From_Double()
        {
            TestConvertFrom(_fromDouble);
        }

        [TestMethod]
        public virtual void From_Double_AsObject()
        {
            TestConvertFrom(_fromDouble_AsObject);
        }

        [TestMethod]
        public virtual void From_Double_Nullable_WithValue()
        {
            TestConvertFrom(_fromDoubleNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Double_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromDoubleNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Double_Nullable_NoValue()
        {
            TestConvertFrom(_fromDoubleNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Double_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromDoubleNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Short
        [TestMethod]
        public virtual void From_Short()
        {
            TestConvertFrom(_fromShort);
        }

        [TestMethod]
        public virtual void From_Short_AsObject()
        {
            TestConvertFrom(_fromShort_AsObject);
        }

        [TestMethod]
        public virtual void From_Short_Nullable_WithValue()
        {
            TestConvertFrom(_fromShortNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Short_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromShortNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Short_Nullable_NoValue()
        {
            TestConvertFrom(_fromShortNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Short_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromShortNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Int
        [TestMethod]
        public virtual void From_Int()
        {
            TestConvertFrom(_fromInt);
        }

        [TestMethod]
        public virtual void From_Int_AsObject()
        {
            TestConvertFrom(_fromInt_AsObject);
        }

        [TestMethod]
        public virtual void From_Int_Nullable_WithValue()
        {
            TestConvertFrom(_fromIntNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Int_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromIntNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Int_Nullable_NoValue()
        {
            TestConvertFrom(_fromIntNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Int_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromIntNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Long
        [TestMethod]
        public virtual void From_Long()
        {
            TestConvertFrom(_fromLong);
        }

        [TestMethod]
        public virtual void From_Long_AsObject()
        {
            TestConvertFrom(_fromLong_AsObject);
        }

        [TestMethod]
        public virtual void From_Long_Nullable_WithValue()
        {
            TestConvertFrom(_fromLongNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Long_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromLongNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Long_Nullable_NoValue()
        {
            TestConvertFrom(_fromLongNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Long_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromLongNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From SByte
        [TestMethod]
        public virtual void From_SByte()
        {
            TestConvertFrom(_fromSbyte);
        }

        [TestMethod]
        public virtual void From_SByte_AsObject()
        {
            TestConvertFrom(_fromSbyte_AsObject);
        }

        [TestMethod]
        public virtual void From_SByte_Nullable_WithValue()
        {
            TestConvertFrom(_fromSbyteNullableWithValue);
        }

        [TestMethod]
        public virtual void From_SByte_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromSbyteNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_SByte_Nullable_NoValue()
        {
            TestConvertFrom(_fromSbyteNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_SByte_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromSbyteNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Float
        [TestMethod]
        public virtual void From_Float()
        {
            TestConvertFrom(_fromFloat);
        }

        [TestMethod]
        public virtual void From_Float_AsObject()
        {
            TestConvertFrom(_fromFloat_AsObject);
        }

        [TestMethod]
        public virtual void From_Float_Nullable_WithValue()
        {
            TestConvertFrom(_fromFloatNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Float_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromFloatNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Float_Nullable_NoValue()
        {
            TestConvertFrom(_fromFloatNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_Float_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromFloatNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From String
        [TestMethod]
        public virtual void From_String()
        {
            TestConvertFrom(_fromString);
        }

        [TestMethod]
        public virtual void From_String_AsObject()
        {
            TestConvertFrom(_fromString_AsObject);
        }

        [TestMethod]
        public virtual void From_String_Null()
        {
            TestConvertFrom(_fromStringNull, DefaultValue);
        }

        [TestMethod]
        public virtual void From_String_Null_AsObject()
        {
            TestConvertFrom(_fromStringNull_AsObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_String_Empty()
        {
            TestConvertFrom(_fromStringEmpty, DefaultValue);
        }

        [TestMethod]
        public virtual void From_String_Empty_AsObject()
        {
            TestConvertFrom(_fromStringEmpty_AsObject, DefaultValue);
        }
        #endregion

        #region From UShort
        [TestMethod]
        public virtual void From_UShort()
        {
            TestConvertFrom(_fromUShort);
        }

        [TestMethod]
        public virtual void From_UShort_AsObject()
        {
            TestConvertFrom(_fromUShort_AsObject);
        }

        [TestMethod]
        public virtual void From_UShort_Nullable_WithValue()
        {
            TestConvertFrom(_fromUShortNullableWithValue);
        }

        [TestMethod]
        public virtual void From_UShort_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromUShortNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_UShort_Nullable_NoValue()
        {
            TestConvertFrom(_fromUShortNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_UShort_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromUShortNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From UInt
        [TestMethod]
        public virtual void From_UInt()
        {
            TestConvertFrom(_fromUInt);
        }

        [TestMethod]
        public virtual void From_UInt_AsObject()
        {
            TestConvertFrom(_fromUInt_AsObject);
        }

        [TestMethod]
        public virtual void From_UInt_Nullable_WithValue()
        {
            TestConvertFrom(_fromUIntNullableWithValue);
        }

        [TestMethod]
        public virtual void From_UInt_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromUIntNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_UInt_Nullable_NoValue()
        {
            TestConvertFrom(_fromUIntNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_UInt_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromUIntNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From ULong
        [TestMethod]
        public virtual void From_ULong()
        {
            TestConvertFrom(_fromULong);
        }

        [TestMethod]
        public virtual void From_ULong_AsObject()
        {
            TestConvertFrom(_fromULong_AsObject);
        }

        [TestMethod]
        public virtual void From_ULong_Nullable_WithValue()
        {
            TestConvertFrom(_fromULongNullableWithValue);
        }

        [TestMethod]
        public virtual void From_ULong_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromULongNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_ULong_Nullable_NoValue()
        {
            TestConvertFrom(_fromULongNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ULong_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromULongNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region Null/DbNull
        [TestMethod]
        public virtual void From_NullObject()
        {
            TestConvertFrom(_nullObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_DBNull()
        {
            TestConvertFrom(DBNull.Value, DefaultValue);
        }
        #endregion

        #region From IConvertible Classes
        [TestMethod]
        public virtual void From_ConvertibleClass()
        {
            TestConvertFrom(_convertibleClass);
        }

        [TestMethod]
        public virtual void From_ConvertibleClass_AsObject()
        {
            TestConvertFrom(_convertibleClass_AsObject);
        }

        [TestMethod]
        public virtual void From_ConvertibleClass_NoValue()
        {
            TestConvertFrom(_convertibleClassNoValue);
        }

        [TestMethod]
        public virtual void From_ConvertibleClass_NoValue_AsObject()
        {
            TestConvertFrom(_convertibleClassNoValue_AsObject);
        }
        #endregion

        #region From Non-IConvertible Classes
        [TestMethod]
        public virtual void From_NonConvertibleClass()
        {
            TestConvertFrom(_nonConvertibleClass, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleClass_AsObject()
        {
            TestConvertFrom(_nonConvertibleClass_AsObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleClass_NoValue()
        {
            TestConvertFrom(_nonConvertibleClassNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleClass_NoValue_AsObject()
        {
            TestConvertFrom(_nonConvertibleClassNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From IConvertible Structs
        [TestMethod]
        public virtual void From_ConvertibleStruct()
        {
            TestConvertFrom(_convertibleStruct);
        }

        [TestMethod]
        public virtual void From_ConvertibleStruct_AsObject()
        {
            TestConvertFrom(_convertibleStruct_AsObject);
        }

        [TestMethod]
        public virtual void From_ConvertibleStruct_Nullable_WithValue()
        {
            TestConvertFrom(_convertibleStructNullableWithValue);
        }

        [TestMethod]
        public virtual void From_ConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_convertibleStructNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_ConvertibleStruct_Nullable_NoValue()
        {
            TestConvertFrom(_convertibleStructNullableNoValue);
        }

        [TestMethod]
        public virtual void From_ConvertibleStruct_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_convertibleStructNullableNoValue_AsObject);
        }
        #endregion

        #region From Non-IConvertible Structs
        [TestMethod]
        public virtual void From_NonConvertibleStruct()
        {
            TestConvertFrom(_nonConvertibleStruct, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleStruct_AsObject()
        {
            TestConvertFrom(_nonConvertibleStruct_AsObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleStruct_Nullable_WithValue()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue_AsObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleStruct_Nullable_NoValue()
        {
            TestConvertFrom(_nonConvertibleStructNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_NonConvertibleStruct_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_nonConvertibleStructNullableNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From Enums
        [TestMethod]
        public virtual void From_Enum()
        {
            TestConvertFrom(_fromEnum);
        }

        [TestMethod]
        public virtual void From_Enum_AsObject()
        {
            TestConvertFrom(_fromEnum_AsObject);
        }

        [TestMethod]
        public virtual void From_Enum_Nullable_WithValue()
        {
            TestConvertFrom(_fromEnumNullableWithValue);
        }

        [TestMethod]
        public virtual void From_Enum_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_fromEnumNullableWithValue_AsObject);
        }

        [TestMethod]
        public virtual void From_Enum_Nullable_NoValue()
        {
            TestConvertFrom(_fromEnumNullableNoValue);
        }

        [TestMethod]
        public virtual void From_Enum_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_fromEnumNullableNoValue_AsObject);
        }
        #endregion
    }
}