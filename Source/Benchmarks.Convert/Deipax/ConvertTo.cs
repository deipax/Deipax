using Benchmarks.Convert.Base;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace Benchmarks.Convert.Deipax
{
    #region Bool/BoolNullable
    public class ConvertToBool : BaseConvertTo<bool>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return bool.TrueString;
        }
    }

    public class ConvertToBoolNullable : BaseConvertTo<bool?>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return bool.TrueString;
        }
    }
    #endregion

    #region Char/CharNullable
    public class ConvertToChar : BaseConvertTo<char>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return "c";
        }
    }

    public class ConvertToCharNullable : BaseConvertTo<char?>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return "c";
        }
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertToSByte : BaseConvertTo<sbyte>
    {
    }

    public class ConvertToSByteNullable : BaseConvertTo<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertToByte : BaseConvertTo<byte>
    {
    }

    public class ConvertToByteNullable : BaseConvertTo<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertToShort : BaseConvertTo<short>
    {
    }

    public class ConvertToShortNullable : BaseConvertTo<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertToUShort : BaseConvertTo<ushort>
    {
    }

    public class ConvertToUShortNullable : BaseConvertTo<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    public class ConvertToInt : BaseConvertTo<int>
    {
    }

    public class ConvertToIntNullable : BaseConvertTo<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertToUInt : BaseConvertTo<uint>
    {
    }

    public class ConvertToUIntNullable : BaseConvertTo<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    public class ConvertToLong : BaseConvertTo<long>
    {
    }

    public class ConvertToLongNullable : BaseConvertTo<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertToULong : BaseConvertTo<ulong>
    {
    }

    public class ConvertToULongNullable : BaseConvertTo<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertToFloat : BaseConvertTo<float>
    {
    }

    public class ConvertToFloatNullable : BaseConvertTo<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertToDouble : BaseConvertTo<double>
    {
    }

    public class ConvertToDoubleNullable : BaseConvertTo<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertToDecimal : BaseConvertTo<decimal>
    {
    }

    public class ConvertToDecimalNullable : BaseConvertTo<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertToDateTimeBase<TTo> : BaseConvertTo<TTo>
    {
    }

    public class ConvertToDateTime : ConvertToDateTimeBase<DateTime>
    {
    }

    public class ConvertToDateTimeNullable : ConvertToDateTimeBase<DateTime?>
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
    public class ConvertToEnum : BaseConvertTo<TestEnum>
    {
    }

    public class ConvertToEnumNullable : BaseConvertTo<TestEnum?>
    {
    }
    #endregion

    #region IParent
    public class ConvertToIParent : BaseConvertTo<IParent>
    {
    }
    #endregion
}