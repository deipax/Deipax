using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class NoConvertFactory : IConvertFactory
    {
        public Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);

            ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
            DefaultExpression defaultOut = Expression.Default(toType);
            LabelTarget returnTarget = Expression.Label(toType);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultOut);

            BlockExpression block = null;

            if (fromType == toType)
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    input,
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (!fromType.IsNullable() &&
                     toType.IsNullable() &&
                     fromType == Nullable.GetUnderlyingType(toType))
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    Expression.Convert(input, toType),
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (fromType.IsNullable() &&
                     !toType.IsNullable() &&
                     Nullable.GetUnderlyingType(fromType) == toType)
            {
                var returnValue = Expression.Variable(toType, "returnValue");
                var hasValue = Expression.Property(input, "HasValue");
                var assignDefault = Expression.Assign(returnValue, defaultOut);

                var ifThen = Expression.IfThen(
                    hasValue,
                    Expression.Assign(returnValue, Expression.Convert(input, toType)));

                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    returnValue,
                    toType);

                block = Expression.Block(
                    new[] { returnValue },
                    assignDefault,
                    ifThen,
                    returnExpression,
                    returnLabel);
            }

            if (block != null)
            {
                return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
            }

            return null;
        }
    }
}