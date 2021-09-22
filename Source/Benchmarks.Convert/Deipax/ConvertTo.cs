using Benchmarks.Convert.Base;
using Deipax.Convert;
using System;
using System.Collections.Generic;
using System.Globalization;
using UnitTests.Common;

namespace Benchmarks.Convert.Deipax
{
    public class BaseDeipax<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo Convert<TFrom>(TFrom from)
        {
            return ConvertTo<TFrom, TTo>.From(from, CultureInfo.InvariantCulture);
        }
    }

    #region Bool/BoolNullable
    public class ConvertToBool : BaseDeipax<bool>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return bool.TrueString;
        }
    }

    public class ConvertToBoolNullable : BaseDeipax<bool?>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return bool.TrueString;
        }
    }
    #endregion

    #region Char/CharNullable
    public class ConvertToChar : BaseDeipax<char>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return "c";
        }
    }

    public class ConvertToCharNullable : BaseDeipax<char?>
    {
        protected override IEnumerable<string> StringValues()
        {
            yield return "c";
        }
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertToSByte : BaseDeipax<sbyte>
    {
    }

    public class ConvertToSByteNullable : BaseDeipax<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertToByte : BaseDeipax<byte>
    {
    }

    public class ConvertToByteNullable : BaseDeipax<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertToShort : BaseDeipax<short>
    {
    }

    public class ConvertToShortNullable : BaseDeipax<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertToUShort : BaseDeipax<ushort>
    {
    }

    public class ConvertToUShortNullable : BaseDeipax<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    public class ConvertToInt : BaseDeipax<int>
    {
    }

    public class ConvertToIntNullable : BaseDeipax<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertToUInt : BaseDeipax<uint>
    {
    }

    public class ConvertToUIntNullable : BaseDeipax<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    public class ConvertToLong : BaseDeipax<long>
    {
    }

    public class ConvertToLongNullable : BaseDeipax<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertToULong : BaseDeipax<ulong>
    {
    }

    public class ConvertToULongNullable : BaseDeipax<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertToFloat : BaseDeipax<float>
    {
    }

    public class ConvertToFloatNullable : BaseDeipax<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertToDouble : BaseDeipax<double>
    {
    }

    public class ConvertToDoubleNullable : BaseDeipax<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertToDecimal : BaseDeipax<decimal>
    {
    }

    public class ConvertToDecimalNullable : BaseDeipax<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertToDateTimeBase<TTo> : BaseDeipax<TTo>
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
    public class ConvertToString : BaseDeipax<string>
    {
    }
    #endregion

    #region Object
    public class ConvertToObject : BaseDeipax<object>
    {
    }
    #endregion

    #region Enum
    public class ConvertToEnum : BaseDeipax<TestEnum>
    {
    }

    public class ConvertToEnumNullable : BaseDeipax<TestEnum?>
    {
    }
    #endregion

    #region IParent
    public class ConvertToIParent : BaseDeipax<IParent>
    {
    }
    #endregion
}