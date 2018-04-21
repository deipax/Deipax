using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.BaseClasses.Conversion
{
    [TestClass]
    public abstract class BaseConvertTo<TTo>
    {
        public BaseConvertTo()
        {
            DefaultValue = default(TTo);

            _dbNull_AsObject = DBNull.Value;

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

            _parentClass_AsObject = _parentClass = new ParentClass();
            _parentClassNoValue_AsObject = _parentClassNoValue_AsObject = null;

            _parentStruct_AsObject = _parentStruct = new ParentStruct();
            _parentStructNullableWithValue_AsObject = _parentStructNullableWithValue = new ParentStruct();
            _parentStructNullableNoValue_AsObject = _parentStructNullableNoValue = null;
        }

        #region Field Members
        protected bool _fromBool;
        protected bool? _fromBoolNullableWithValue;
        protected bool? _fromBoolNullableNoValue;
        protected object _fromBool_AsObject;
        protected object _fromBoolNullableWithValue_AsObject;
        protected object _fromBoolNullableNoValue_AsObject;

        protected byte _fromByte;
        protected byte? _fromByteNullableWithValue;
        protected byte? _fromByteNullableNoValue;
        protected object _fromByte_AsObject;
        protected object _fromByteNullableWithValue_AsObject;
        protected object _fromByteNullableNoValue_AsObject;

        protected char _fromChar;
        protected char? _fromCharNullableWithValue;
        protected char? _fromCharNullableNoValue;
        protected object _fromChar_AsObject;
        protected object _fromCharNullableWithValue_AsObject;
        protected object _fromCharNullableNoValue_AsObject;

        protected DateTime _fromDateTime;
        protected DateTime? _fromDateTimeNullableWithValue;
        protected DateTime? _fromDateTimeNullableNoValue;
        protected object _fromDateTime_AsObject;
        protected object _fromDateTimeNullableWithValue_AsObject;
        protected object _fromDateTimeNullableNoValue_AsObject;

        protected decimal _fromDecimal;
        protected decimal? _fromDecimalNullableWithValue;
        protected decimal? _fromDecimalNullableNoValue;
        protected object _fromDecimal_AsObject;
        protected object _fromDecimalNullableWithValue_AsObject;
        protected object _fromDecimalNullableNoValue_AsObject;

        protected double _fromDouble;
        protected double? _fromDoubleNullableWithValue;
        protected double? _fromDoubleNullableNoValue;
        protected object _fromDouble_AsObject;
        protected object _fromDoubleNullableWithValue_AsObject;
        protected object _fromDoubleNullableNoValue_AsObject;

        protected short _fromShort;
        protected short? _fromShortNullableWithValue;
        protected short? _fromShortNullableNoValue;
        protected object _fromShort_AsObject;
        protected object _fromShortNullableWithValue_AsObject;
        protected object _fromShortNullableNoValue_AsObject;

        protected int _fromInt;
        protected int? _fromIntNullableWithValue;
        protected int? _fromIntNullableNoValue;
        protected object _fromInt_AsObject;
        protected object _fromIntNullableWithValue_AsObject;
        protected object _fromIntNullableNoValue_AsObject;

        protected long _fromLong;
        protected long? _fromLongNullableWithValue;
        protected long? _fromLongNullableNoValue;
        protected object _fromLong_AsObject;
        protected object _fromLongNullableWithValue_AsObject;
        protected object _fromLongNullableNoValue_AsObject;

        protected sbyte _fromSbyte;
        protected sbyte? _fromSbyteNullableWithValue;
        protected sbyte? _fromSbyteNullableNoValue;
        protected object _fromSbyte_AsObject;
        protected object _fromSbyteNullableWithValue_AsObject;
        protected object _fromSbyteNullableNoValue_AsObject;

        protected float _fromFloat;
        protected float? _fromFloatNullableWithValue;
        protected float? _fromFloatNullableNoValue;
        protected object _fromFloat_AsObject;
        protected object _fromFloatNullableWithValue_AsObject;
        protected object _fromFloatNullableNoValue_AsObject;

        protected string _fromString;
        protected string _fromStringNull;
        protected string _fromStringEmpty;
        protected object _fromString_AsObject;
        protected object _fromStringNull_AsObject;
        protected object _fromStringEmpty_AsObject;

        protected ushort _fromUShort;
        protected ushort? _fromUShortNullableWithValue;
        protected ushort? _fromUShortNullableNoValue;
        protected object _fromUShort_AsObject;
        protected object _fromUShortNullableWithValue_AsObject;
        protected object _fromUShortNullableNoValue_AsObject;

        protected uint _fromUInt;
        protected uint? _fromUIntNullableWithValue;
        protected uint? _fromUIntNullableNoValue;
        protected object _fromUInt_AsObject;
        protected object _fromUIntNullableWithValue_AsObject;
        protected object _fromUIntNullableNoValue_AsObject;

        protected ulong _fromULong;
        protected ulong? _fromULongNullableWithValue;
        protected ulong? _fromULongNullableNoValue;
        protected object _fromULong_AsObject;
        protected object _fromULongNullableWithValue_AsObject;
        protected object _fromULongNullableNoValue_AsObject;

        protected object _nullObject = null;
        protected object _dbNull_AsObject;

        protected ConvertibleClass _convertibleClass;
        protected ConvertibleClass _convertibleClassNoValue;
        protected object _convertibleClass_AsObject;
        protected object _convertibleClassNoValue_AsObject;

        protected NonConvertibleClass _nonConvertibleClass;
        protected NonConvertibleClass _nonConvertibleClassNoValue;
        protected object _nonConvertibleClass_AsObject;
        protected object _nonConvertibleClassNoValue_AsObject;

        protected ConvertibleStruct _convertibleStruct;
        protected ConvertibleStruct? _convertibleStructNullableWithValue;
        protected ConvertibleStruct? _convertibleStructNullableNoValue;
        protected object _convertibleStruct_AsObject;
        protected object _convertibleStructNullableWithValue_AsObject;
        protected object _convertibleStructNullableNoValue_AsObject;

        protected NonConvertibleStruct _nonConvertibleStruct;
        protected NonConvertibleStruct? _nonConvertibleStructNullableWithValue;
        protected NonConvertibleStruct? _nonConvertibleStructNullableNoValue;
        protected object _nonConvertibleStruct_AsObject;
        protected object _nonConvertibleStructNullableWithValue_AsObject;
        protected object _nonConvertibleStructNullableNoValue_AsObject;

        protected TestEnum _fromEnum;
        protected TestEnum? _fromEnumNullableWithValue;
        protected TestEnum? _fromEnumNullableNoValue;
        protected object _fromEnum_AsObject;
        protected object _fromEnumNullableWithValue_AsObject;
        protected object _fromEnumNullableNoValue_AsObject;

        protected ParentClass _parentClass;
        protected ParentClass _parentClassNoValue;
        protected object _parentClass_AsObject;
        protected object _parentClassNoValue_AsObject;

        protected ParentStruct _parentStruct;
        protected ParentStruct? _parentStructNullableWithValue;
        protected ParentStruct? _parentStructNullableNoValue;
        protected object _parentStruct_AsObject;
        protected object _parentStructNullableWithValue_AsObject;
        protected object _parentStructNullableNoValue_AsObject;
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
                var fromType = typeof(TFrom);
                var underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
                var underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;
                var runtimeType = from?.GetType();
                var underlyingRuntimeType = Nullable.GetUnderlyingType(runtimeType) ?? runtimeType;

                if (underlyingToType == underlyingFromType ||
                    runtimeType == underlyingToType ||
                    underlyingRuntimeType == underlyingToType)
                {
                    return (TTo)((object)from);
                }

                if (from != null)
                {
                    if (toType.IsEnum)
                    {
                        if (fromType == typeof(string))
                        {
                            return (TTo)Enum.Parse(toType, from as string, true);
                        }
                        else
                        {
                            var intValue = Convert.ChangeType(from, typeof(int), CultureInfo.InvariantCulture);

                            if (Enum.IsDefined(toType, intValue))
                            {
                                return (TTo)intValue;
                            }
                        }
                    }

                    return (TTo)Convert.ChangeType(from, underlyingToType, CultureInfo.InvariantCulture);
                }
            }
            catch
            {
            }

            return DefaultValue;
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
            TestConvertFrom(_fromStringEmpty, GetExpected(_fromStringEmpty));
        }

        [TestMethod]
        public virtual void From_String_Empty_AsObject()
        {
            TestConvertFrom(_fromStringEmpty_AsObject, GetExpected(_fromStringEmpty_AsObject));
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

        [TestMethod]
        public virtual void From_DBNull_AsObject()
        {
            TestConvertFrom(_dbNull_AsObject, DefaultValue);
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

        #region From ParentClass
        [TestMethod]
        public virtual void From_ParentClass()
        {
            TestConvertFrom(_parentClass, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentClass_AsObject()
        {
            TestConvertFrom(_parentClass_AsObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentClass_NoValue()
        {
            TestConvertFrom(_parentClassNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentClass_NoValue_AsObject()
        {
            TestConvertFrom(_parentClassNoValue_AsObject, DefaultValue);
        }
        #endregion

        #region From ParentStruct
        [TestMethod]
        public virtual void From_ParentStruct()
        {
            TestConvertFrom(_parentStruct, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentStruct_AsObject()
        {
            TestConvertFrom(_parentStruct_AsObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentStruct_Nullable_WithValue()
        {
            TestConvertFrom(_parentStructNullableWithValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableWithValue_AsObject, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentStruct_Nullable_NoValue()
        {
            TestConvertFrom(_parentStructNullableNoValue, DefaultValue);
        }

        [TestMethod]
        public virtual void From_ParentStruct_Nullable_NoValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableNoValue_AsObject, DefaultValue);
        }
        #endregion
    }
}