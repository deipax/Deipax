using System;

namespace UnitTests.Core.TestClasses
{
    public class ConvertibleClass : IConvertible
    {
        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            AssertProvider(provider);
            return true;
        }

        public byte ToByte(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public char ToChar(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 'c';
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            AssertProvider(provider);
            return DateTime.MinValue;
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public double ToDouble(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public short ToInt16(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public int ToInt32(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public long ToInt64(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public float ToSingle(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public string ToString(IFormatProvider provider)
        {
            AssertProvider(provider);
            return "1";
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            AssertProvider(provider);
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        #region Private Members
        private void AssertProvider(IFormatProvider provider)
        {
            if (provider == null)
            {
                throw new Exception("Provider not set.");
            }
        }
        #endregion
    }

    public class NonConvertibleClass
    {
    }

    public struct ConvertibleStruct : IConvertible
    {
        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            AssertProvider(provider);
            return true;
        }

        public byte ToByte(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public char ToChar(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 'c';
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            AssertProvider(provider);
            return DateTime.MinValue;
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public double ToDouble(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public short ToInt16(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public int ToInt32(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public long ToInt64(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public float ToSingle(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public string ToString(IFormatProvider provider)
        {
            AssertProvider(provider);
            return "1";
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            AssertProvider(provider);
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        #region Private Members
        private void AssertProvider(IFormatProvider provider)
        {
            if (provider == null)
            {
                throw new Exception("Provider not set.");
            }
        }
        #endregion
    }

    public struct NonConvertibleStruct
    {
    }

    public enum TestEnum
    {
        One = 1,
        Two = 2,
        Three = 3,
        NinetyNine = 99,
    }

    public enum TestEnumLong : long
    {
        Min = long.MinValue,
        Max = long.MaxValue
    }

    public interface IParent
    {
    }

    public class ParentClass : IParent
    {
        public bool BoolField;
        public bool BoolProp { get; set; }
        public bool? BoolNullableField;
        public bool? BoolNullableProp { get; set; }

        public char CharField;
        public char CharProp { get; set; }
        public char? CharNullableField;
        public char? CharNullableProp { get; set; }

        public sbyte SbyteField;
        public sbyte SbyteProp { get; set; }
        public sbyte? SbyteNullableField;
        public sbyte? SbyteNullableProp { get; set; }

        public byte ByteField;
        public byte ByteProp { get; set; }
        public byte? ByteNullableField;
        public byte? ByteNullableProp { get; set; }

        public short ShortField;
        public short ShortProp { get; set; }
        public short? ShortNullableField;
        public short? ShortNullableProp { get; set; }

        public ushort UShortField;
        public ushort UShortProp { get; set; }
        public ushort? UShortNullableField;
        public ushort? UShortNullableProp { get; set; }

        public int IntField;
        public int IntProp { get; set; }
        public int? IntNullableField;
        public int? IntNullableProp { get; set; }

        public uint UIntField;
        public uint UIntProp { get; set; }
        public uint? UIntNullableField;
        public uint? UIntNullableProp { get; set; }

        public long LongField;
        public long LongProp { get; set; }
        public long? LongNullableField;
        public long? LongNullableProp { get; set; }

        public ulong ULongField;
        public ulong ULongProp { get; set; }
        public ulong? ULongNullableField;
        public ulong? ULongNullableProp { get; set; }

        public float FloatField;
        public float FloatProp { get; set; }
        public float? FloatNullableField;
        public float? FloatNullableProp { get; set; }

        public double DoubleField;
        public double DoubleProp { get; set; }
        public double? DoubleNullableField;
        public double? DoubleNullableProp { get; set; }

        public decimal DecimalField;
        public decimal DecimalProp { get; set; }
        public decimal? DecimalNullableField;
        public decimal? DecimalNullableProp { get; set; }

        public DateTime DateTimeField;
        public DateTime DateTimeProp { get; set; }
        public DateTime? DateTimeNullableField;
        public DateTime? DateTimeNullableProp { get; set; }

        public string StringField;
        public string StringProp { get; set; }

        public object ObjectField;
        public object ObjectProp { get; set; }

        public TestEnum EnumField;
        public TestEnum EnumProp { get; set; }
        public TestEnum? EnumNullableField;
        public TestEnum? EnumNullableProp { get; set; }
    }

    public struct ParentStruct : IParent
    {
        public bool BoolField;
        public bool BoolProp { get; set; }
        public bool? BoolNullableField;
        public bool? BoolNullableProp { get; set; }

        public char CharField;
        public char CharProp { get; set; }
        public char? CharNullableField;
        public char? CharNullableProp { get; set; }

        public sbyte SbyteField;
        public sbyte SbyteProp { get; set; }
        public sbyte? SbyteNullableField;
        public sbyte? SbyteNullableProp { get; set; }

        public byte ByteField;
        public byte ByteProp { get; set; }
        public byte? ByteNullableField;
        public byte? ByteNullableProp { get; set; }

        public short ShortField;
        public short ShortProp { get; set; }
        public short? ShortNullableField;
        public short? ShortNullableProp { get; set; }

        public ushort UShortField;
        public ushort UShortProp { get; set; }
        public ushort? UShortNullableField;
        public ushort? UShortNullableProp { get; set; }

        public int IntField;
        public int IntProp { get; set; }
        public int? IntNullableField;
        public int? IntNullableProp { get; set; }

        public uint UIntField;
        public uint UIntProp { get; set; }
        public uint? UIntNullableField;
        public uint? UIntNullableProp { get; set; }

        public long LongField;
        public long LongProp { get; set; }
        public long? LongNullableField;
        public long? LongNullableProp { get; set; }

        public ulong ULongField;
        public ulong ULongProp { get; set; }
        public ulong? ULongNullableField;
        public ulong? ULongNullableProp { get; set; }

        public float FloatField;
        public float FloatProp { get; set; }
        public float? FloatNullableField;
        public float? FloatNullableProp { get; set; }

        public double DoubleField;
        public double DoubleProp { get; set; }
        public double? DoubleNullableField;
        public double? DoubleNullableProp { get; set; }

        public decimal DecimalField;
        public decimal DecimalProp { get; set; }
        public decimal? DecimalNullableField;
        public decimal? DecimalNullableProp { get; set; }

        public DateTime DateTimeField;
        public DateTime DateTimeProp { get; set; }
        public DateTime? DateTimeNullableField;
        public DateTime? DateTimeNullableProp { get; set; }

        public string StringField;
        public string StringProp { get; set; }

        public object ObjectField;
        public object ObjectProp { get; set; }

        public TestEnum EnumField;
        public TestEnum EnumProp { get; set; }
        public TestEnum? EnumNullableField;
        public TestEnum? EnumNullableProp { get; set; }
    }
}