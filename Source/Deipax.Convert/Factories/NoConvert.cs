using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class NoConvert : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.FromType == args.ToType)
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    args.Input);

                args.Add(returnExpression);
                args.Add(args.LabelExpression);
            }
            else if (args.UnderlyingToType == args.UnderlyingFromType)
            {
                Expression guardedInput = args.FromType.IsNullable()
                    ? Expression.Property(args.Input, "Value")
                    : (Expression)args.Input;

                GotoExpression returnExpression = args.ToType.IsNullable()
                    ? Expression.Return(args.LabelTarget, Expression.Convert(guardedInput, args.ToType))
                    : Expression.Return(args.LabelTarget, guardedInput);

                args.AddGuards();
                args.Add(returnExpression);
                args.Add(args.LabelExpression);
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
                        args.Default);

                    var ifThenElse = Expression.IfThenElse(
                        hasValue,
                        returnValue,
                        returnDefault);

                    args.Add(ifThenElse);
                    args.Add(args.LabelExpression);
                }
                else
                {
                    GotoExpression returnExpression = Expression.Return(
                        args.LabelTarget,
                        Expression.Convert(args.Input, typeof(object)));

                    args.Add(returnExpression);
                    args.Add(args.LabelExpression);
                }
            }
            else if (args.ToType.IsAssignableFrom(args.FromType))
            {
                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    Expression.Convert(args.Input, args.ToType));

                args.Add(returnExpression);
                args.Add(args.LabelExpression);
            }
            else if (args.ToType.IsAssignableFrom(args.UnderlyingFromType))
            {
                var value = Expression.Property(args.Input, "Value");

                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    Expression.Convert(value, args.ToType));

                args.AddGuards();
                args.Add(returnExpression);
                args.Add(args.LabelExpression);
            }

            return args.Get();
        }
        #endregion
    }
}