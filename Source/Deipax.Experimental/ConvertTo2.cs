using System;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<TOut>
    {
        public static TOut From<TIn>(TIn from)
        {
            return Helper<TIn>.From(from);
        }

        static class Helper<TIn>
        {
            public static readonly Func<TIn, TOut> From = ConvertConfig.Get<TIn, TOut>();
        }
    }
}