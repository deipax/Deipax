using Deipax.Convert.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Convert
{
    public static class ConvertTo<TTo, TFrom>
    {
        public static readonly IConvertResult<TFrom, TTo> Result = ConvertConfig.Get<TFrom, TTo>();
        public static readonly ConvertDelegate<TFrom, TTo> From = Result?.Func;
    }
}