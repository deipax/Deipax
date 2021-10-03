using Deipax.Convert.Concretes;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class NoConvert : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (expBuilder.FromType == expBuilder.ToType)
            {
                GotoExpression returnExpression = Expression.Return(
                    expBuilder.LabelTarget,
                    expBuilder.Input);

                return expBuilder
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }
            else if (expBuilder.UnderlyingToType == expBuilder.UnderlyingFromType)
            {
                Expression guardedInput = expBuilder.FromType.IsNullable()
                    ? Expression.Property(expBuilder.Input, "Value")
                    : (Expression)expBuilder.Input;

                GotoExpression returnExpression = expBuilder.ToType.IsNullable()
                    ? Expression.Return(expBuilder.LabelTarget, Expression.Convert(guardedInput, expBuilder.ToType))
                    : Expression.Return(expBuilder.LabelTarget, guardedInput);

                return expBuilder
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }
            else if (expBuilder.ToType == typeof(object))
            {
                if (expBuilder.FromType.IsNullable())
                {
                    var hasValue = Expression.Property(expBuilder.Input, "HasValue");
                    var value = Expression.Property(expBuilder.Input, "Value");

                    GotoExpression returnValue = Expression.Return(
                        expBuilder.LabelTarget,
                        Expression.Convert(value, expBuilder.ToType));

                    GotoExpression returnDefault = Expression.Return(
                        expBuilder.LabelTarget,
                        expBuilder.DefaultExpression);

                    var ifThenElse = Expression.IfThenElse(
                        hasValue,
                        returnValue,
                        returnDefault);

                    return expBuilder
                        .Add(ifThenElse)
                        .Add(expBuilder.LabelExpression)
                        .ToResult(this);
                }
                else
                {
                    GotoExpression returnExpression = Expression.Return(
                        expBuilder.LabelTarget,
                        Expression.Convert(expBuilder.Input, typeof(object)));

                    return expBuilder
                        .Add(returnExpression)
                        .Add(expBuilder.LabelExpression)
                        .ToResult(this);
                }
            }
            else if (expBuilder.ToType.IsAssignableFrom(expBuilder.FromType))
            {
                GotoExpression returnExpression = Expression.Return(
                    expBuilder.LabelTarget,
                    Expression.Convert(expBuilder.Input, expBuilder.ToType));

                return expBuilder
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }
            else if (expBuilder.ToType.IsAssignableFrom(expBuilder.UnderlyingFromType))
            {
                var value = Expression.Property(expBuilder.Input, "Value");

                GotoExpression returnExpression = Expression.Return(
                    expBuilder.LabelTarget,
                    Expression.Convert(value, expBuilder.ToType));

                return expBuilder
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }
        #endregion
    }
}