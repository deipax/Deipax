using System;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<TTo, TFrom>
    {
        public static readonly Func<TFrom, TTo> From = ConvertFactory.Get<TFrom, TTo>();
    }
}