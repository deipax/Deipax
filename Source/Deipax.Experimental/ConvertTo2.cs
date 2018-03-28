using System;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<TTo>
    {
        public static TTo From<TFrom>(TFrom from)
        {
            return ConvertTo2<TTo, TFrom>.From(from);
        }
    }

    public static class ConvertTo2<TTo, TFrom>
    {
        public static readonly Func<TFrom, TTo> From = ConvertConfig.Get<TFrom, TTo>();
    }
}