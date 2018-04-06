using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class ToString : IConvertFactory
    {
        #region IConvertFactory Members
        public IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type toType = typeof(TTo);

            if (toType == typeof(string))
            {
                ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                var returnTarget = Expression.Label(toType);
                var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                MethodCallExpression callExpression = Expression.Call(
                    typeof(object),
                    "ToString",
                    null,
                    input);

                BlockExpression block = Expression.Block(
                    toType,
                    Expression.Return(returnTarget, callExpression),
                    returnLabel);

                return new Result<TFrom, TTo>()
                {
                    Factory = this,
                    GuardCall = true,
                    Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile()
                };
            }

            return null;
        }
        #endregion
    }
}