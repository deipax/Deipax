using BenchmarkDotNet.Attributes;
using Deipax.Convert;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnitTests.Common;

namespace Benchmarks.Convert.Base
{
    public abstract class BaseConvertTo<TTo>
    {
        #region Field Members
        private const string OBJECT = "Object";
        private const string ENUM = "Enum";
        #endregion

        #region Protected Members
        protected virtual IEnumerable<string> StringValues()
        {
            var list = new List<string>();
            Type type = Nullable.GetUnderlyingType(typeof(TTo)) ?? typeof(TTo);
            var value = type.GetField("MinValue")?.GetValue(null)?.ToString();
            if (!string.IsNullOrEmpty(value)) list.Add(value);
            return list;
        }

        protected abstract TTo Convert<TFrom>(TFrom from);
        #endregion

        #region Data Members
        public IEnumerable<object> Bool()
        {
            yield return true;
        }

        public IEnumerable<object> BoolNullable()
        {
            yield return (bool?)true;
            yield return null;
        }

        public IEnumerable<object> Byte()
        {
            yield return (byte)1;
        }

        public IEnumerable<object> ByteNullable()
        {
            yield return (byte?)1;
            yield return null;
        }

        public IEnumerable<object> Char()
        {
            yield return 'c';
        }

        public IEnumerable<object> CharNullable()
        {
            yield return (char?)'c';
            yield return null;
        }

        public IEnumerable<object> DateTime()
        {
            yield return System.DateTime.MinValue;
        }

        public IEnumerable<object> DateTimeNullable()
        {
            yield return (DateTime?)System.DateTime.MinValue;
            yield return null;
        }

        public IEnumerable<object> Decimal()
        {
            yield return (decimal)1;
        }

        public IEnumerable<object> DecimalNullable()
        {
            yield return (decimal?)1;
            yield return null;
        }

        public IEnumerable<object> Double()
        {
            yield return (double)1;
        }

        public IEnumerable<object> DoubleNullable()
        {
            yield return (double?)1;
            yield return null;
        }

        public IEnumerable<object> Short()
        {
            yield return (short)1;
        }

        public IEnumerable<object> ShortNullable()
        {
            yield return (short?)1;
            yield return null;
        }

        public IEnumerable<object> Int()
        {
            yield return 1;
        }

        public IEnumerable<object> IntNullable()
        {
            yield return (int?)1;
            yield return null;
        }

        public IEnumerable<object> Long()
        {
            yield return (long)1;
        }

        public IEnumerable<object> LongNullable()
        {
            yield return (long?)1;
            yield return null;
        }

        public IEnumerable<object> SByte()
        {
            yield return (sbyte)1;
        }

        public IEnumerable<object> SByteNullable()
        {
            yield return (sbyte?)1;
            yield return null;
        }

        public IEnumerable<object> Float()
        {
            yield return (float)1;
        }

        public IEnumerable<object> FloatNullable()
        {
            yield return (float?)1;
            yield return null;
        }

        public IEnumerable<object> String()
        {
            foreach (var item in StringValues().Where(x => !string.IsNullOrEmpty(x)))
                yield return item;

            yield return string.Empty;
            yield return null;
        }

        public IEnumerable<object> UShort()
        {
            yield return (ushort)1;
        }

        public IEnumerable<object> UShortNullable()
        {
            yield return (ushort?)1;
            yield return null;
        }

        public IEnumerable<object> UInt()
        {
            yield return (uint)1;
        }

        public IEnumerable<object> UIntNullable()
        {
            yield return (uint?)1;
            yield return null;
        }

        public IEnumerable<object> ULong()
        {
            yield return (ulong)1;
        }

        public IEnumerable<object> ULongNullable()
        {
            yield return (ulong?)1;
            yield return null;
        }

        public IEnumerable<object> DbNull()
        {
            yield return DBNull.Value;
            yield return null;
        }

        public IEnumerable<object> ConvertibleClass()
        {
            yield return new ConvertibleClass();
            yield return null;
        }

        public IEnumerable<object> NonConvertibleClass()
        {
            yield return new NonConvertibleClass();
            yield return null;
        }

        public IEnumerable<object> ConvertibleStruct()
        {
            yield return new ConvertibleStruct();
        }

        public IEnumerable<object> ConvertibleStructNullable()
        {
            yield return (ConvertibleStruct?)new ConvertibleStruct();
            yield return null;
        }

        public IEnumerable<object> NonConvertibleStruct()
        {
            yield return new NonConvertibleStruct();
        }

        public IEnumerable<object> NonConvertibleStructNullable()
        {
            yield return (NonConvertibleStruct?)new NonConvertibleStruct();
            yield return null;
        }

        public IEnumerable<object> Enum()
        {
            yield return TestEnum.One;
        }

        public IEnumerable<object> EnumNullable()
        {
            yield return (TestEnum?)TestEnum.One;
            yield return null;
        }

        public IEnumerable<object> ParentClass()
        {
            yield return new ParentClass();
            yield return null;
        }

        public IEnumerable<object> ParentStruct()
        {
            yield return new ParentStruct();
        }

        public IEnumerable<object> ParentStructNullable()
        {
            yield return (ParentStruct?)new ParentStruct();
            yield return null;
        }
        #endregion

        #region From Bool
        [Benchmark]
        [ArgumentsSource(nameof(Bool))]
        public virtual TTo From_Bool(bool input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Bool))]
        public virtual TTo From_Bool_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(BoolNullable))]
        public virtual TTo From_Bool_Nullable(bool? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(BoolNullable))]
        public virtual TTo From_Bool_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Byte
        [Benchmark]
        [ArgumentsSource(nameof(Byte))]
        public virtual TTo From_Byte(byte input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Byte))]
        public virtual TTo From_Byte_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(ByteNullable))]
        public virtual TTo From_Byte_Nullable(byte? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ByteNullable))]
        public virtual TTo From_Byte_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Char
        [Benchmark]
        [ArgumentsSource(nameof(Char))]
        public virtual TTo From_Char(char input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Char))]
        public virtual TTo From_Char_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(CharNullable))]
        public virtual TTo From_Char_Nullable(char? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(CharNullable))]
        public virtual TTo From_Char_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From DateTime
        [Benchmark]
        [ArgumentsSource(nameof(DateTime))]
        public virtual TTo From_DateTime(DateTime input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(DateTime))]
        public virtual TTo From_DateTime_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(DateTimeNullable))]
        public virtual TTo From_DateTime_Nullable(DateTime? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(DateTimeNullable))]
        public virtual TTo From_DateTime_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Decimal
        [Benchmark]
        [ArgumentsSource(nameof(Decimal))]
        public virtual TTo From_Decimal(decimal input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Decimal))]
        public virtual TTo From_Decimal_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(DecimalNullable))]
        public virtual TTo From_Decimal_Nullable(decimal? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(DecimalNullable))]
        public virtual TTo From_Decimal_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Double
        [Benchmark]
        [ArgumentsSource(nameof(Double))]
        public virtual TTo From_Double(double input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Double))]
        public virtual TTo From_Double_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(DoubleNullable))]
        public virtual TTo From_Double_Nullable(double? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(DoubleNullable))]
        public virtual TTo From_Double_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Short
        [Benchmark]
        [ArgumentsSource(nameof(Short))]
        public virtual TTo From_Short(short input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Short))]
        public virtual TTo From_Short_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(ShortNullable))]
        public virtual TTo From_Short_Nullable(short? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ShortNullable))]
        public virtual TTo From_Short_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Int
        [Benchmark]
        [ArgumentsSource(nameof(Int))]
        public virtual TTo From_Int(int input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Int))]
        public virtual TTo From_Int_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(IntNullable))]
        public virtual TTo From_Int_Nullable(int? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(IntNullable))]
        public virtual TTo From_Int_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Long
        [Benchmark]
        [ArgumentsSource(nameof(Long))]
        public virtual TTo From_Long(long input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Long))]
        public virtual TTo From_Long_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(LongNullable))]
        public virtual TTo From_Long_Nullable(long? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(LongNullable))]
        public virtual TTo From_Long_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From SByte
        [Benchmark]
        [ArgumentsSource(nameof(SByte))]
        public virtual TTo From_SByte(sbyte input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(SByte))]
        public virtual TTo From_SByte_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(SByteNullable))]
        public virtual TTo From_SByte_Nullable(sbyte? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(SByteNullable))]
        public virtual TTo From_SByte_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Float
        [Benchmark]
        [ArgumentsSource(nameof(Float))]
        public virtual TTo From_Float(float input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(Float))]
        public virtual TTo From_Float_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(FloatNullable))]
        public virtual TTo From_Float_Nullable(float? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(FloatNullable))]
        public virtual TTo From_Float_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From String
        [Benchmark]
        [ArgumentsSource(nameof(String))]
        public virtual TTo From_String(string input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(String))]
        public virtual TTo From_String_AsObject(object input) => Convert(input);
        #endregion

        #region From UShort
        [Benchmark]
        [ArgumentsSource(nameof(UShort))]
        public virtual TTo From_UShort(ushort input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(UShort))]
        public virtual TTo From_UShort_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(UShortNullable))]
        public virtual TTo From_UShort_Nullable(ushort? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(UShortNullable))]
        public virtual TTo From_UShort_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From UInt
        [Benchmark]
        [ArgumentsSource(nameof(UInt))]
        public virtual TTo From_UInt(uint input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(UInt))]
        public virtual TTo From_UInt_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(UIntNullable))]
        public virtual TTo From_UInt_Nullable(uint? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(UIntNullable))]
        public virtual TTo From_UInt_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From ULong
        [Benchmark]
        [ArgumentsSource(nameof(ULong))]
        public virtual TTo From_ULong(ulong input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ULong))]
        public virtual TTo From_ULong_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(ULongNullable))]
        public virtual TTo From_ULong_Nullable(ulong? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ULongNullable))]
        public virtual TTo From_ULong_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region Null/DbNull
        [Benchmark]
        [ArgumentsSource(nameof(DbNull))]
        public virtual TTo From_DBNull(DBNull input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(DbNull))]
        public virtual TTo From_DBNull_AsObject(object input) => Convert(input);
        #endregion

        #region From IConvertible Classes
        [Benchmark]
        [ArgumentsSource(nameof(ConvertibleClass))]
        public virtual TTo From_ConvertibleClass(ConvertibleClass input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ConvertibleClass))]
        public virtual TTo From_ConvertibleClass_AsObject(object input) => Convert(input);
        #endregion

        #region From Non-IConvertible Classes
        [Benchmark]
        [ArgumentsSource(nameof(NonConvertibleClass))]
        public virtual TTo From_NonConvertibleClass(NonConvertibleClass input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(NonConvertibleClass))]
        public virtual TTo From_NonConvertibleClass_AsObject(object input) => Convert(input);
        #endregion

        #region From IConvertible Structs
        [Benchmark]
        [ArgumentsSource(nameof(ConvertibleStruct))]
        public virtual TTo From_ConvertibleStruct(ConvertibleStruct input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ConvertibleStruct))]
        public virtual TTo From_ConvertibleStruct_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(ConvertibleStructNullable))]
        public virtual TTo From_ConvertibleStruct_Nullable(ConvertibleStruct? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ConvertibleStructNullable))]
        public virtual TTo From_ConvertibleStruct_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Non-IConvertible Structs
        [Benchmark]
        [ArgumentsSource(nameof(NonConvertibleStruct))]
        public virtual TTo From_NonConvertibleStruct(NonConvertibleStruct input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(NonConvertibleStruct))]
        public virtual TTo From_NonConvertibleStruct_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(NonConvertibleStructNullable))]
        public virtual TTo From_NonConvertibleStruct_Nullable(NonConvertibleStruct? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(NonConvertibleStructNullable))]
        public virtual TTo From_NonConvertibleStruct_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From Enums
        [Benchmark]
        [BenchmarkCategory(ENUM)]
        [ArgumentsSource(nameof(Enum))]
        public virtual TTo From_Enum(TestEnum input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT, ENUM)]
        [ArgumentsSource(nameof(Enum))]
        public virtual TTo From_Enum_AsObject(object input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(ENUM)]
        [ArgumentsSource(nameof(EnumNullable))]
        public virtual TTo From_Enum_Nullable(TestEnum? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT, ENUM)]
        [ArgumentsSource(nameof(EnumNullable))]
        public virtual TTo From_Enum_Nullable_AsObject(object input) => Convert(input);
        #endregion

        #region From ParentClass
        [Benchmark]
        [ArgumentsSource(nameof(ParentClass))]
        public virtual TTo From_ParentClass(ParentClass input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ParentClass))]
        public virtual TTo From_ParentClass_AsObject(object input) => Convert(input);
        #endregion

        #region From ParentStruct
        [Benchmark]
        [ArgumentsSource(nameof(ParentStruct))]
        public virtual TTo From_ParentStruct(ParentStruct input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ParentStruct))]
        public virtual TTo From_ParentStruct_AsObject(object input) => Convert(input);

        [Benchmark]
        [ArgumentsSource(nameof(ParentStructNullable))]
        public virtual TTo From_ParentStruct_Nullable(ParentStruct? input) => Convert(input);

        [Benchmark]
        [BenchmarkCategory(OBJECT)]
        [ArgumentsSource(nameof(ParentStructNullable))]
        public virtual TTo From_ParentStruct_Nullable_AsObject(object input) => Convert(input);
        #endregion
    }
}