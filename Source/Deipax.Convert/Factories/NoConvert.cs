using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class NoConvert : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.FromType == args.ToType)
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    args.Input);

                return args
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }
            else if (args.UnderlyingToType == args.UnderlyingFromType)
            {
                Expression guardedInput = args.FromType.IsNullable()
                    ? Expression.Property(args.Input, "Value")
                    : (Expression)args.Input;

                GotoExpression returnExpression = args.ToType.IsNullable()
                    ? Expression.Return(args.LabelTarget, Expression.Convert(guardedInput, args.ToType))
                    : Expression.Return(args.LabelTarget, guardedInput);

                return args
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }
            else if (args.ToType == typeof(object))
            {
                if (args.FromType.IsNullable())
                {
                    var hasValue = Expression.Property(args.Input, "HasValue");
                    var value = Expression.Property(args.Input, "Value");

                    GotoExpression returnValue = Expression.Return(
                        args.LabelTarget,
                        Expression.Convert(value, args.ToType));

                    GotoExpression returnDefault = Expression.Return(
                        args.LabelTarget,
                        args.DefaultExpression);

                    var ifThenElse = Expression.IfThenElse(
                        hasValue,
                        returnValue,
                        returnDefault);

                    return args
                        .Add(ifThenElse)
                        .Add(args.LabelExpression)
                        .ToResult(this);
                }
                else
                {
                    GotoExpression returnExpression = Expression.Return(
                        args.LabelTarget,
                        Expression.Convert(args.Input, typeof(object)));

                    return args
                        .Add(returnExpression)
                        .Add(args.LabelExpression)
                        .ToResult(this);
                }
            }
            else if (args.ToType.IsAssignableFrom(args.FromType))
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    Expression.Convert(args.Input, args.ToType));

                return args
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }
            else if (args.ToType.IsAssignableFrom(args.UnderlyingFromType))
            {
                var value = Expression.Property(args.Input, "Value");

                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    Expression.Convert(value, args.ToType));

                return args
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }
        #endregion
    }
}