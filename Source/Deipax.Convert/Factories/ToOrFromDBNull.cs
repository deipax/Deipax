using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class ToOrFromDBNull : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.ToType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    Expression.Constant(DBNull.Value));

                return args
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }
            else if (args.FromType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    args.DefaultExpression);

                return args
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }
        #endregion
    }
}