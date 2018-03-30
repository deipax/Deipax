using System;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<TTo, TFrom>
    {
        static ConvertTo2()
        {
            From = ConvertConfig.Get<TFrom, TTo>()?.Converter;
        }

        public static readonly Func<TFrom, TTo> From;
    }
}