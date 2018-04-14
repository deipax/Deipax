using System;
using Benchmarks.Core.BaseClasses.Conversion;
using Deipax.Core.Conversion;

namespace Benchmarks.Core.Deipax.Conversion
{
    public class ConvertTo2_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo2<TTo, TFrom>.From(from, ConvertConfig.DefaultProvider);
        }
    }

    #region Bool/BoolNullable
    public class ConvertTo2_Bool : ConvertTo2_Base<bool>
    {
        public ConvertTo2_Bool()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }

    public class ConvertTo2_BoolNullable : ConvertTo2_Base<bool?>
    {
        public ConvertTo2_BoolNullable()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }
    #endregion

    #region Char/CharNullable
    public class ConvertTo2_Char : ConvertTo2_Base<char>
    {
    }

    public class ConvertTo2_CharNullable : ConvertTo2_Base<char?>
    {
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertTo2_SByte : ConvertTo2_Base<sbyte>
    {
    }

    public class ConvertTo2_SByteNullable : ConvertTo2_Base<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertTo2_Byte : ConvertTo2_Base<byte>
    {
    }

    public class ConvertTo2_ByteNullable : ConvertTo2_Base<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertTo2_Short : ConvertTo2_Base<short>
    {
    }

    public class ConvertTo2_ShortNullable : ConvertTo2_Base<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertTo2_UShort : ConvertTo2_Base<ushort>
    {
    }

    public class ConvertTo2_UShortNullable : ConvertTo2_Base<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    public class ConvertTo2_Int : ConvertTo2_Base<int>
    {
    }

    public class ConvertTo2_IntNullable : ConvertTo2_Base<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertTo2_UInt : ConvertTo2_Base<uint>
    {
    }

    public class ConvertTo2_UIntNullable : ConvertTo2_Base<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    public class ConvertTo2_Long : ConvertTo2_Base<long>
    {
    }

    public class ConvertTo2_LongNullable : ConvertTo2_Base<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertTo2_ULong : ConvertTo2_Base<ulong>
    {
    }

    public class ConvertTo2_ULongNullable : ConvertTo2_Base<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    public class ConvertTo2_Float : ConvertTo2_Base<float>
    {
    }

    public class ConvertTo2_FloatNullable : ConvertTo2_Base<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    public class ConvertTo2_Double : ConvertTo2_Base<double>
    {
    }

    public class ConvertTo2_DoubleNullable : ConvertTo2_Base<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    public class ConvertTo2_Decimal : ConvertTo2_Base<decimal>
    {
    }

    public class ConvertTo2_DecimalNullable : ConvertTo2_Base<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class ConvertTo2_DateTimeBase<TTo> : ConvertTo2_Base<TTo>
    {
        public ConvertTo2_DateTimeBase()
        {
            _fromString_AsObject = _fromString = DateTime.MinValue.ToString();
        }
    }

    public class ConvertTo2_DateTime : ConvertTo2_DateTimeBase<DateTime>
    {
    }

    public class ConvertTo2_DateTimeNullable : ConvertTo2_DateTimeBase<DateTime?>
    {
    }
    #endregion

    #region String
    public class ConvertTo2_String : ConvertTo2_Base<string>
    {
    }
    #endregion

    #region Object
    public class ConvertTo2_Object : ConvertTo2_Base<object>
    {
    }
    #endregion
}