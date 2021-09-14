using System;
using Deipax.Convert.Interfaces;

namespace Deipax.Convert
{
    public static class ConvertTo<TTo, TFrom>
    {
        public static readonly IConvertResult<TFrom, TTo> Result = ConvertConfig.Get<TFrom, TTo>();
        public static readonly ConvertDelegate<TFrom, TTo> From = Result?.Func;
    }

    public static class ConvertTo<TTo>
    {
        public static TTo From<TFrom>(
            TFrom instance,
            IFormatProvider provider = null)
        {
            return ConvertTo<TTo, TFrom>.From(instance, provider);
        }
    }
}