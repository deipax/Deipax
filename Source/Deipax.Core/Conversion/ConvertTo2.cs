using System;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<TTo, TFrom>
    {
        static ConvertTo2()
        {
            Result = ConvertConfig.Get<TFrom, TTo>();
            From = Result?.GuardedFunc;
        }

        public static readonly Func<TFrom, TTo> From;
        public static readonly IResult<TFrom, TTo> Result;
    }
}