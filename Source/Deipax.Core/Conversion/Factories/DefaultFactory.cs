using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            var fromType = typeof(TFrom);
            var toType = typeof(TTo);
            var input = Expression.Parameter(fromType, "input");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");
            var returnTarget = Expression.Label(toType);
            var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

            return new ConvertFactoryResult<TFrom, TTo>()
            {
                GuardCall = false,
                Factory = this,
                Func = Expression.Lambda<Convert<TFrom, TTo>>(returnLabel, input, provider).Compile()
            };
        }
        #endregion
    }
}