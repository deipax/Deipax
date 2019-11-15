using Deipax.Convert.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class ToOrFromDBNull : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<ConvertDelegate<TFrom, TTo>> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.ToType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    Expression.Constant(DBNull.Value));

                args.Add(returnExpression);
                args.Add(args.LabelExpression);
            }
            else if (args.FromType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    args.DefaultExpression);

                args.Add(returnExpression);
                args.Add(args.LabelExpression);
            }

            return args.Create();
        }
        #endregion
    }
}