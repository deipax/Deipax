using BenchmarkDotNet.Attributes;
using Benchmarks.Core.TestClasses;
using System;

namespace Benchmarks.Core.BaseClasses
{
    public abstract class BaseConvertTo<TTo>
    {
        public BaseConvertTo()
        {
            Default = default(TTo);

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
        protected TTo Default { get; private set; }
        protected abstract TTo ConvertFrom<X>(X from);

        private const string OBJECT = "Object";
        private const string ENUM = "Enum";
        #endregion

        #region From Bool
        [Benchmark]
        public virtual void From_Bool()
        {
            TTo to = ConvertFrom(_fromBool);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Bool_AsObject()
        {
            TTo to = ConvertFrom(_fromBool_AsObject);
        }

        [Benchmark]
        public virtual void From_Bool_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromBoolNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Bool_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromBoolNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Bool_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromBoolNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Bool_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromBoolNullableNoValue_AsObject);
        }
        #endregion

        #region From Byte
        [Benchmark]
        public virtual void From_Byte()
        {
            TTo to = ConvertFrom(_fromByte);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Byte_AsObject()
        {
            TTo to = ConvertFrom(_fromByte_AsObject);
        }

        [Benchmark]
        public virtual void From_Byte_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromByteNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Byte_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromByteNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Byte_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromByteNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Byte_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromByteNullableNoValue_AsObject);
        }
        #endregion

        #region From Char
        [Benchmark]
        public virtual void From_Char()
        {
            TTo to = ConvertFrom(_fromChar);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Char_AsObject()
        {
            TTo to = ConvertFrom(_fromChar_AsObject);
        }

        [Benchmark]
        public virtual void From_Char_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromCharNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Char_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromCharNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Char_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromCharNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Char_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromCharNullableNoValue_AsObject);
        }
        #endregion

        #region From DateTime
        [Benchmark]
        public virtual void From_DateTime()
        {
            TTo to = ConvertFrom(_fromDateTime);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_DateTime_AsObject()
        {
            TTo to = ConvertFrom(_fromDateTime_AsObject);
        }

        [Benchmark]
        public virtual void From_DateTime_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromDateTimeNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_DateTime_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromDateTimeNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_DateTime_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromDateTimeNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_DateTime_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromDateTimeNullableNoValue_AsObject);
        }
        #endregion

        #region From Decimal
        [Benchmark]
        public virtual void From_Decimal()
        {
            TTo to = ConvertFrom(_fromDecimal);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Decimal_AsObject()
        {
            TTo to = ConvertFrom(_fromDecimal_AsObject);
        }

        [Benchmark]
        public virtual void From_Decimal_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromDecimalNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Decimal_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromDecimalNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Decimal_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromDecimalNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Decimal_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromDecimalNullableNoValue_AsObject);
        }
        #endregion

        #region From Double
        [Benchmark]
        public virtual void From_Double()
        {
            TTo to = ConvertFrom(_fromDouble);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Double_AsObject()
        {
            TTo to = ConvertFrom(_fromDouble_AsObject);
        }

        [Benchmark]
        public virtual void From_Double_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromDoubleNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Double_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromDoubleNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Double_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromDoubleNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Double_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromDoubleNullableNoValue_AsObject);
        }
        #endregion

        #region From Short
        [Benchmark]
        public virtual void From_Short()
        {
            TTo to = ConvertFrom(_fromShort);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Short_AsObject()
        {
            TTo to = ConvertFrom(_fromShort_AsObject);
        }

        [Benchmark]
        public virtual void From_Short_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromShortNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Short_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromShortNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Short_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromShortNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Short_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromShortNullableNoValue_AsObject);
        }
        #endregion

        #region From Int
        [Benchmark]
        public virtual void From_Int()
        {
            TTo to = ConvertFrom(_fromInt);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Int_AsObject()
        {
            TTo to = ConvertFrom(_fromInt_AsObject);
        }

        [Benchmark]
        public virtual void From_Int_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromIntNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Int_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromIntNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Int_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromIntNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Int_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromIntNullableNoValue_AsObject);
        }
        #endregion

        #region From Long
        [Benchmark]
        public virtual void From_Long()
        {
            TTo to = ConvertFrom(_fromLong);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Long_AsObject()
        {
            TTo to = ConvertFrom(_fromLong_AsObject);
        }

        [Benchmark]
        public virtual void From_Long_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromLongNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Long_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromLongNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Long_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromLongNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Long_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromLongNullableNoValue_AsObject);
        }
        #endregion

        #region From SByte
        [Benchmark]
        public virtual void From_SByte()
        {
            TTo to = ConvertFrom(_fromSbyte);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_SByte_AsObject()
        {
            TTo to = ConvertFrom(_fromSbyte_AsObject);
        }

        [Benchmark]
        public virtual void From_SByte_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromSbyteNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_SByte_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromSbyteNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_SByte_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromSbyteNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_SByte_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromSbyteNullableNoValue_AsObject);
        }
        #endregion

        #region From Float
        [Benchmark]
        public virtual void From_Float()
        {
            TTo to = ConvertFrom(_fromFloat);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Float_AsObject()
        {
            TTo to = ConvertFrom(_fromFloat_AsObject);
        }

        [Benchmark]
        public virtual void From_Float_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromFloatNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Float_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromFloatNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_Float_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromFloatNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_Float_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromFloatNullableNoValue_AsObject);
        }
        #endregion

        #region From String
        [Benchmark]
        public virtual void From_String()
        {
            TTo to = ConvertFrom(_fromString);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_String_AsObject()
        {
            TTo to = ConvertFrom(_fromString_AsObject);
        }

        [Benchmark]
        public virtual void From_String_Null()
        {
            TTo to = ConvertFrom(_fromStringNull);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_String_Null_AsObject()
        {
            TTo to = ConvertFrom(_fromStringNull_AsObject);
        }

        [Benchmark]
        public virtual void From_String_Empty()
        {
            TTo to = ConvertFrom(_fromStringEmpty);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_String_Empty_AsObject()
        {
            TTo to = ConvertFrom(_fromStringEmpty_AsObject);
        }
        #endregion

        #region From UShort
        [Benchmark]
        public virtual void From_UShort()
        {
            TTo to = ConvertFrom(_fromUShort);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_UShort_AsObject()
        {
            TTo to = ConvertFrom(_fromUShort_AsObject);
        }

        [Benchmark]
        public virtual void From_UShort_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromUShortNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_UShort_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromUShortNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_UShort_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromUShortNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_UShort_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromUShortNullableNoValue_AsObject);
        }
        #endregion

        #region From UInt
        [Benchmark]
        public virtual void From_UInt()
        {
            TTo to = ConvertFrom(_fromUInt);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_UInt_AsObject()
        {
            TTo to = ConvertFrom(_fromUInt_AsObject);
        }

        [Benchmark]
        public virtual void From_UInt_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromUIntNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_UInt_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromUIntNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_UInt_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromUIntNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_UInt_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromUIntNullableNoValue_AsObject);
        }
        #endregion

        #region From ULong
        [Benchmark]
        public virtual void From_ULong()
        {
            TTo to = ConvertFrom(_fromULong);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ULong_AsObject()
        {
            TTo to = ConvertFrom(_fromULong_AsObject);
        }

        [Benchmark]
        public virtual void From_ULong_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromULongNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ULong_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromULongNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_ULong_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromULongNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ULong_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromULongNullableNoValue_AsObject);
        }
        #endregion

        #region Null/DbNull
        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_NullObject()
        {
            TTo to = ConvertFrom(_nullObject);
        }

        [Benchmark]
        public virtual void From_DBNull()
        {
            TTo to = ConvertFrom(DBNull.Value);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_DBNull_AsObject()
        {
            TTo to = ConvertFrom(_dbNull_AsObject);
        }
        #endregion

        #region From IConvertible Classes
        [Benchmark]
        public virtual void From_ConvertibleClass()
        {
            TTo to = ConvertFrom(_convertibleClass);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ConvertibleClass_AsObject()
        {
            TTo to = ConvertFrom(_convertibleClass_AsObject);
        }

        [Benchmark]
        public virtual void From_ConvertibleClass_NoValue()
        {
            TTo to = ConvertFrom(_convertibleClassNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ConvertibleClass_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_convertibleClassNoValue_AsObject);
        }
        #endregion

        #region From Non-IConvertible Classes
        [Benchmark]
        public virtual void From_NonConvertibleClass()
        {
            TTo to = ConvertFrom(_nonConvertibleClass);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_NonConvertibleClass_AsObject()
        {
            TTo to = ConvertFrom(_nonConvertibleClass_AsObject);
        }

        [Benchmark]
        public virtual void From_NonConvertibleClass_NoValue()
        {
            TTo to = ConvertFrom(_nonConvertibleClassNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_NonConvertibleClass_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_nonConvertibleClassNoValue_AsObject);
        }
        #endregion

        #region From IConvertible Structs
        [Benchmark]
        public virtual void From_ConvertibleStruct()
        {
            TTo to = ConvertFrom(_convertibleStruct);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ConvertibleStruct_AsObject()
        {
            TTo to = ConvertFrom(_convertibleStruct_AsObject);
        }

        [Benchmark]
        public virtual void From_ConvertibleStruct_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_convertibleStructNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_convertibleStructNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_ConvertibleStruct_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_convertibleStructNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ConvertibleStruct_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_convertibleStructNullableNoValue_AsObject);
        }
        #endregion

        #region From Non-IConvertible Structs
        [Benchmark]
        public virtual void From_NonConvertibleStruct()
        {
            TTo to = ConvertFrom(_nonConvertibleStruct);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_NonConvertibleStruct_AsObject()
        {
            TTo to = ConvertFrom(_nonConvertibleStruct_AsObject);
        }

        [Benchmark]
        public virtual void From_NonConvertibleStruct_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_nonConvertibleStructNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_NonConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_nonConvertibleStructNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_NonConvertibleStruct_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_nonConvertibleStructNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_NonConvertibleStruct_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_nonConvertibleStructNullableNoValue_AsObject);
        }
        #endregion

        #region From Enums
        [Benchmark]
        [BenchmarkCategory(ENUM)]
        public virtual void From_Enum()
        {
            TTo to = ConvertFrom(_fromEnum);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT, ENUM)]
        public virtual void From_Enum_AsObject()
        {
            TTo to = ConvertFrom(_fromEnum_AsObject);
        }

        [Benchmark]
        [BenchmarkCategory(ENUM)]
        public virtual void From_Enum_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_fromEnumNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT, ENUM)]
        public virtual void From_Enum_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_fromEnumNullableWithValue_AsObject);
        }

        [Benchmark]
        [BenchmarkCategory(ENUM)]
        public virtual void From_Enum_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_fromEnumNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT, ENUM)]
        public virtual void From_Enum_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_fromEnumNullableNoValue_AsObject);
        }
        #endregion

        #region From ParentClass
        [Benchmark]
        public virtual void From_ParentClass()
        {
            TTo to = ConvertFrom(_parentClass);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ParentClass_AsObject()
        {
            TTo to = ConvertFrom(_parentClass_AsObject);
        }

        [Benchmark]
        public virtual void From_ParentClass_NoValue()
        {
            TTo to = ConvertFrom(_parentClassNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ParentClass_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_parentClassNoValue_AsObject);
        }
        #endregion

        #region From ParentStruct
        [Benchmark]
        public virtual void From_ParentStruct()
        {
            TTo to = ConvertFrom(_parentStruct);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ParentStruct_AsObject()
        {
            TTo to = ConvertFrom(_parentStruct_AsObject);
        }

        [Benchmark]
        public virtual void From_ParentStruct_Nullable_WithValue()
        {
            TTo to = ConvertFrom(_parentStructNullableWithValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TTo to = ConvertFrom(_parentStructNullableWithValue_AsObject);
        }

        [Benchmark]
        public virtual void From_ParentStruct_Nullable_NoValue()
        {
            TTo to = ConvertFrom(_parentStructNullableNoValue);
        }

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        public virtual void From_ParentStruct_Nullable_NoValue_AsObject()
        {
            TTo to = ConvertFrom(_parentStructNullableNoValue_AsObject);
        }
        #endregion
    }
}