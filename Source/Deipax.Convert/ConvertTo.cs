using Deipax.Convert.Interfaces;
using System;

namespace Deipax.Convert
{
    public static class ConvertTo<TFrom, TTo>
    {
        public static readonly ConvertDelegate<TFrom, TTo> From = ConvertConfig.Get<TFrom, TTo>().Func;
    }

    public static class ConvertTo<TTo>
    {
        public static TTo From<TFrom>(
            TFrom source,
            IFormatProvider provider = null)
        {
            return ConvertTo<TFrom, TTo>.From(source, provider);
        }
    }
}