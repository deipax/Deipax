using System;
using Benchmarks.Core.BaseClasses.Conversion;
using Deipax.Core.Conversion;

namespace Benchmarks.Core.Deipax.Conversion
{
    public class ConvertTo_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo<TTo>.From(from);
        }
    }

    #region Bool/BoolNullable
    public class ConvertTo_Bool : ConvertTo_Base<bool>
    {
        public ConvertTo_Bool()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }

    public class ConvertTo_BoolNullable : ConvertTo_Base<bool?>
    {
        public ConvertTo_BoolNullable()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }
    #endregion

    #region Char/CharNullable
    public class ConvertTo_Char : ConvertTo_Base<char>
    {
    }

    public class ConvertTo_CharNullable : ConvertTo_Base<char?>
    {
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertTo_SByte : ConvertTo_Base<sbyte>
    {
    }

    public class ConvertTo_SByteNullable : ConvertTo_Base<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertTo_Byte : ConvertTo_Base<byte>
    {
    }

    public class ConvertTo_ByteNullable : ConvertTo_Base<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertTo_Short : ConvertTo_Base<short>
    {
    }

    public class ConvertTo_ShortNullable : ConvertTo_Base<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertTo_UShort : ConvertTo_Base<ushort>
    {
    }

    public class ConvertTo_UShortNullable : ConvertTo_Base<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    public class ConvertTo_Int : ConvertTo_Base<int>
    {
    }

    public class ConvertTo_IntNullable : ConvertTo_Base<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertTo_UInt : ConvertTo_Base<uint>
    {
    }

    public class ConvertTo_UIntNullable : ConvertTo_Base<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    public class ConvertTo_Long : ConvertTo_Base<long>
    {
    }

    public class ConvertTo_LongNullable : ConvertTo_Base<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertTo_ULong : ConvertTo_Base<ulong>
    {
    }

    public class ConvertTo_ULongNullable : ConvertTo_Base<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertTo_Float : ConvertTo_Base<float>
    {
    }

    public class ConvertTo_FloatNullable : ConvertTo_Base<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertTo_Double : ConvertTo_Base<double>
    {
    }

    public class ConvertTo_DoubleNullable : ConvertTo_Base<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertTo_Decimal : ConvertTo_Base<decimal>
    {
    }

    public class ConvertTo_DecimalNullable : ConvertTo_Base<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertTo_DateTimeBase<TTo> : ConvertTo_Base<TTo>
    {
        public ConvertTo_DateTimeBase()
        {
            _fromString_AsObject = _fromString = DateTime.MinValue.ToString();
        }
    }

    public class ConvertTo_DateTime : ConvertTo_DateTimeBase<DateTime>
    {
    }

    public class ConvertTo_DateTimeNullable : ConvertTo_DateTimeBase<DateTime?>
    {
    }
    #endregion

    #region String
    public class ConvertTo_String : ConvertTo_Base<string>
    {
    }
    #endregion
}