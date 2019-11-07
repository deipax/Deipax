using Deipax.Convert.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Convert
{
    public static class ConvertTo<TTo, TFrom>
    {
        static ConvertTo()
        {
            var result = ConvertConfig.Get<TFrom, TTo>();
            From = result?.Func;
            Factory = result?.Factory;
            Expression = result?.Expression;
        }

        public static readonly Convert<TFrom, TTo> From;
        public static readonly IConvertFactory Factory;
        public static readonly Expression<Convert<TFrom, TTo>> Expression;
    }
}