using Deipax.Core.Interfaces;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo<TTo, TFrom>
    {
        static ConvertTo()
        {
            Result = ConvertConfig.Get<TFrom, TTo>();
            From = Result?.Func;
        }

        public static readonly Convert<TFrom, TTo> From;
        public static readonly IConvertResult<TFrom, TTo> Result;
    }
}