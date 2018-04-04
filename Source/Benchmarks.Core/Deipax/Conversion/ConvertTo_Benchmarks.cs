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

    #region Byte/ByteNullable
    public class ConvertTo_Byte : ConvertTo_Base<byte>
    {
    }

    public class ConvertTo_ByteNullable : ConvertTo_Base<byte?>
    {
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

    #region Long/LongNullable
    public class ConvertTo_Long : ConvertTo_Base<long>
    {
    }

    public class ConvertTo_LongNullable : ConvertTo_Base<long?>
    {
    }
    #endregion
}