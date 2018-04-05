using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class ToObjectFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type toType = typeof(TTo);

            if (toType == typeof(object))
            {
                ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                DefaultExpression defaultValue = Expression.Default(toType);
                LabelTarget returnTarget = Expression.Label(toType);
                LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    Expression.Convert(input, typeof(object)),
                    toType);

                var block = Expression.Block(
                    returnExpression,
                    returnLabel);

                return new Result<TFrom, TTo>()
                {
                    Factory = this,
                    GuardCall = false,
                    Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile()
                };
            }

            return null;
        }
        #endregion
    }
}