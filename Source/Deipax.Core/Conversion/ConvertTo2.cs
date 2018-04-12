using System;
using System.Globalization;
using System.Reflection.Emit;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<TTo, TFrom>
    {
        static ConvertTo2()
        {
            Result = ConvertConfig.Get<TFrom, TTo>();
            From = Result?.GuardedFunc;
        }

        public static readonly Convert<TFrom, TTo> From;
        public static readonly IResult<TFrom, TTo> Result;
    }

    public delegate TTo Convert<TFrom, TTo>(TFrom from, IFormatProvider provider = null);
}