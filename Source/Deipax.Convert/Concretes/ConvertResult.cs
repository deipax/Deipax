using Deipax.Convert.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Convert.Concretes
{
    public class ConvertResult<TFrom, TTo> : IConvertResult<TFrom, TTo>
    {
        public IConvertFactory Factory { get; set; }
        public ConvertDelegate<TFrom, TTo> Func { get; set; }
        public Expression<ConvertDelegate<TFrom, TTo>> Expression { get; set; }
    }
}
