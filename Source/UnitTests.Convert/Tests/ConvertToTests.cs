using System;
using UnitTests.Common;
using UnitTests.Convert.Base;
using Xunit;

namespace UnitTests.Convert
{
    public abstract class BaseConvertToString<TTo> : BaseConvertTo<TTo>
    {
        [Theory]
        [InlineData("1")]
        public override void From_String(string input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [InlineData("1")]
        public override void From_String_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
    }

    #region Bool/BoolNullable
    public class ConvertToBool : BaseConvertTo<bool>
    {
        [Theory]
        [InlineData("true")]
        [InlineData("false")]
        public override void From_String(string input) =>  AssertEqual(input, GetExpected, Convert);

        [Theory]
        [InlineData("true")]
        [InlineData("false")]
        public override void From_String_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
    }

    public class ConvertToBoolNullable : BaseConvertTo<bool?>
    {
        [Theory]
        [InlineData("true")]
        [InlineData("false")]
        public override void From_String(string input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [InlineData("true")]
        [InlineData("false")]
        public override void From_String_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
    }
    #endregion

    #region Char/CharNullable
    public class ConvertToChar : BaseConvertTo<char>
    {
        [Theory]
        [InlineData("c")]
        public override void From_String(string input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [InlineData("c")]
        public override void From_String_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
    }

    public class ConvertToCharNullable : BaseConvertTo<char?>
    {
        [Theory]
        [InlineData("c")]
        public override void From_String(string input) => AssertEqual(input, GetExpected, Convert);

        [Theory]
        [InlineData("c")]
        public override void From_String_AsObject(object input) => AssertEqual(input, GetExpected, Convert);
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertToSByte : BaseConvertToString<sbyte>
    {
    }

    public class ConvertToSByteNullable : BaseConvertToString<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertToByte : BaseConvertToString<byte>
    {
    }

    public class ConvertToByteNullable : BaseConvertToString<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertToShort : BaseConvertToString<short>
    {
    }

    public class ConvertToShortNullable : BaseConvertToString<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertToUShort : BaseConvertToString<ushort>
    {
    }

    public class ConvertToUShortNullable : BaseConvertToString<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    public class ConvertToInt : BaseConvertToString<int>
    {
    }

    public class ConvertToIntNullable : BaseConvertToString<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertToUInt : BaseConvertToString<uint>
    {
    }

    public class ConvertToUIntNullable : BaseConvertToString<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    public class ConvertToLong : BaseConvertToString<long>
    {
    }

    public class ConvertToLongNullable : BaseConvertToString<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertToULong : BaseConvertToString<ulong>
    {
    }

    public class ConvertToULongNullable : BaseConvertToString<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertToFloat : BaseConvertToString<float>
    {
    }

    public class ConvertToFloatNullable : BaseConvertToString<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertToDouble : BaseConvertToString<double>
    {
    }

    public class ConvertToDoubleNullable : BaseConvertToString<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertToDecimal : BaseConvertToString<decimal>
    {
    }

    public class ConvertToDecimalNullable : BaseConvertToString<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertToDateTime : BaseConvertTo<DateTime>
    {
    }

    public class ConvertToDateTimeNullable : BaseConvertTo<DateTime?>
    {
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
    public class ConvertToEnum : BaseConvertToString<TestEnum>
    {
    }

    public class ConvertToEnumNullable : BaseConvertToString<TestEnum?>
    {
    }

    public class ConvertToEnumLong : BaseConvertTo<TestEnumLong>
    {
    }

    public class ConvertToEnumLongNullable : BaseConvertTo<TestEnumLong?>
    {
    }
    #endregion

    #region IParent
    public class ConvertToIParent : BaseConvertTo<IParent>
    {
    }
    #endregion
}