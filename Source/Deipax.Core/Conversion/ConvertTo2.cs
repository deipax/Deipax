using Deipax.Core.Interfaces;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<TTo, TFrom>
    {
        static ConvertTo2()
        {
            Result = ConvertConfig.Get<TFrom, TTo>();
            From = Result?.Func;
        }

        public static readonly Convert<TFrom, TTo> From;
        public static readonly IConvertResult<TFrom, TTo> Result;
    }
}