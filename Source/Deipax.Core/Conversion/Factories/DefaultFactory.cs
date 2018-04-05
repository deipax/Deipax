using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            var fromType = typeof(TFrom);
            var toType = typeof(TTo);
            var input = Expression.Parameter(fromType, "input");
            var returnTarget = Expression.Label(toType);
            var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

            return new Result<TFrom, TTo>()
            {
                GuardCall = false,
                Factory = this,
                Func = Expression.Lambda<Func<TFrom, TTo>>(returnLabel, input).Compile()
            };
        }
        #endregion
    }
}