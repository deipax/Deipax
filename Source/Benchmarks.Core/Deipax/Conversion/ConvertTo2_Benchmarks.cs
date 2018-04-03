using Benchmarks.Core.BaseClasses.Conversion;
using Deipax.Core.Conversion;

namespace Benchmarks.Core.Deipax.Conversion
{
    public class ConvertTo2_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo2<TTo, TFrom>.From(from);
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

    #region Long/LongNullable
    public class ConvertTo2_Long : ConvertTo2_Base<long>
    {
    }

    public class ConvertTo2_LongNullable : ConvertTo2_Base<long?>
    {
    }
    #endregion
}