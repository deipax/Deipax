using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class ToOrFromDBNull : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type toType = typeof(TTo);
            Type fromType = typeof(TFrom);

            ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
            ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
            DefaultExpression defaultValue = Expression.Default(toType);
            var returnTarget = Expression.Label(toType);
            var returnLabel = Expression.Label(returnTarget, defaultValue);
            BlockExpression block = null;

            if (toType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    Expression.Constant(DBNull.Value),
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (fromType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    defaultValue,
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }

            if (block != null)
            {
                return new ConvertFactoryResult<TFrom, TTo>()
                {
                    Factory = this,
                    GuardCall = false,
                    Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                };
            }

            return null;
        }
        #endregion
    }
}