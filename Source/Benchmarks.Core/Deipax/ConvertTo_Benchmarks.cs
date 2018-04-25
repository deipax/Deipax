using Benchmarks.Core.TestClasses;
using Deipax.Core.Conversion;
using System;
using Benchmarks.Core.BaseClasses;

namespace Benchmarks.Core.Deipax
{
    public class ConvertTo_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo<TTo, TFrom>.From(from, ConvertConfig.DefaultProvider);
        }
    }

    #region Bool/BoolNullable
    public class ConvertToBool : ConvertTo_Base<bool>
    {
        public ConvertToBool()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }

    public class ConvertToBoolNullable : ConvertTo_Base<bool?>
    {
        public ConvertToBoolNullable()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }
    #endregion

    #region Char/CharNullable
    public class ConvertToChar : ConvertTo_Base<char>
    {
    }

    public class ConvertToCharNullable : ConvertTo_Base<char?>
    {
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertToSByte : ConvertTo_Base<sbyte>
    {
    }

    public class ConvertToSByteNullable : ConvertTo_Base<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertToByte : ConvertTo_Base<byte>
    {
    }

    public class ConvertToByteNullable : ConvertTo_Base<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertToShort : ConvertTo_Base<short>
    {
    }

    public class ConvertToShortNullable : ConvertTo_Base<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertToUShort : ConvertTo_Base<ushort>
    {
    }

    public class ConvertToUShortNullable : ConvertTo_Base<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    public class ConvertToInt : ConvertTo_Base<int>
    {
    }

    public class ConvertToIntNullable : ConvertTo_Base<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertToUInt : ConvertTo_Base<uint>
    {
    }

    public class ConvertToUIntNullable : ConvertTo_Base<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    public class ConvertToLong : ConvertTo_Base<long>
    {
    }

    public class ConvertToLongNullable : ConvertTo_Base<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertToULong : ConvertTo_Base<ulong>
    {
    }

    public class ConvertToULongNullable : ConvertTo_Base<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertToFloat : ConvertTo_Base<float>
    {
    }

    public class ConvertToFloatNullable : ConvertTo_Base<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertToDouble : ConvertTo_Base<double>
    {
    }

    public class ConvertToDoubleNullable : ConvertTo_Base<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertToDecimal : ConvertTo_Base<decimal>
    {
    }

    public class ConvertToDecimalNullable : ConvertTo_Base<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertToDateTimeBase<TTo> : ConvertTo_Base<TTo>
    {
        public ConvertToDateTimeBase()
        {
            _fromString_AsObject = _fromString = DateTime.MinValue.ToString();
        }
    }

    public class ConvertToDateTime : ConvertToDateTimeBase<DateTime>
    {
    }

    public class ConvertToDateTimeNullable : ConvertToDateTimeBase<DateTime?>
    {
    }
    #endregion

    #region String
    public class ConvertToString : ConvertTo_Base<string>
    {
    }
    #endregion

    #region Object
    public class ConvertToObject : ConvertTo_Base<object>
    {
    }
    #endregion

    #region Enum
    public class ConvertToEnum : ConvertTo_Base<TestEnum>
    {
    }
    #endregion

    #region IParent
    public class ConvertToIParent : ConvertTo_Base<IParent>
    {
    }
    #endregion
}