using Deipax.Convert.Common;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class ToOrFromDBNull : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (expBuilder.ToType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    expBuilder.LabelTarget,
                    Expression.Constant(DBNull.Value));

                return expBuilder
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }
            else if (expBuilder.FromType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    expBuilder.LabelTarget,
                    expBuilder.DefaultExpression);

                return expBuilder
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }
        #endregion
    }
}