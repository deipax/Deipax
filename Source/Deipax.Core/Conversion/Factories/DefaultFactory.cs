using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        public DefaultFactory()
        {
            GuardCall = true;
        }

        #region IConvertFactory Members
        public bool GuardCall { get; set; }

        public Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            var fromType = typeof(TFrom);
            var toType = typeof(TTo);
            var input = Expression.Parameter(fromType, "input");
            var returnTarget = Expression.Label(toType);
            var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
            return Expression.Lambda<Func<TFrom, TTo>>(returnLabel, input).Compile();
        }
        #endregion
    }
}