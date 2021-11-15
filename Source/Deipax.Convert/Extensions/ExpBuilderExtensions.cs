using Deipax.Convert.Common;
using Deipax.Convert.Concretes;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Deipax.Convert.Extensions
{
    public static class ExpBuilderExtensions
    {
        public static BinaryExpression GetDefaultProvider<TFrom, TTo>(
            this ExpBuilder<TFrom, TTo> expBuilder)
        {
            return Expression.Coalesce(
                expBuilder?.Provider,
                Expression.Constant(CultureInfo.InvariantCulture));
        }

        public static ExpBuilder<TFrom, TTo> AddGuards<TFrom, TTo>(
            this ExpBuilder<TFrom, TTo> expBuilder)
        {
            if (expBuilder.FromType == typeof(string))
            {
                MethodCallExpression isNullOrEmpty = Expression.Call(
                    typeof(string),
                    "IsNullOrEmpty",
                    null,
                    expBuilder.Input);

                var ifNullOrEmptyReturn = Expression.IfThen(
                    isNullOrEmpty,
                    Expression.Return(expBuilder.LabelTarget, expBuilder.DefaultExpression));

                expBuilder.Add(ifNullOrEmptyReturn);
            }
            else if (!expBuilder.FromType.IsValueType)
            {
                var ifNullReturnExpression = Expression.IfThen(
                    Expression.Or(
                        Expression.Equal(expBuilder.Input, Expression.Constant(null, typeof(object))),
                        Expression.Equal(expBuilder.Input, Expression.Constant(DBNull.Value, typeof(object)))),
                    Expression.Return(expBuilder.LabelTarget, expBuilder.DefaultExpression));

                expBuilder.Add(ifNullReturnExpression);

                if (expBuilder.FromType == typeof(object))
                {
                    if (expBuilder.ToType.IsNullable())
                    {
                        var returnIfSame = Expression.IfThen(
                            Expression.Or(
                                Expression.TypeEqual(expBuilder.Input, expBuilder.ToType),
                                Expression.TypeEqual(expBuilder.Input, expBuilder.UnderlyingToType)),
                            Expression.Return(expBuilder.LabelTarget, Expression.Convert(expBuilder.Input, expBuilder.ToType)));

                        expBuilder.Add(returnIfSame);
                    }
                    else
                    {
                        var returnIfSame = Expression.IfThen(
                            Expression.TypeEqual(expBuilder.Input, expBuilder.ToType),
                            Expression.Return(expBuilder.LabelTarget, Expression.Convert(expBuilder.Input, expBuilder.ToType)));

                        expBuilder.Add(returnIfSame);
                    }
                }
            }
            else if (expBuilder.FromType.IsNullable())
            {
                var ifNoValueReturn = Expression.IfThen(
                    Expression.Not(Expression.Property(expBuilder.Input, "HasValue")),
                    Expression.Return(expBuilder.LabelTarget, expBuilder.DefaultExpression));

                expBuilder.Add(ifNoValueReturn);
            }

            return expBuilder;
        }

        public static IConvertResult<TFrom, TTo> ToResult<TFrom, TTo>(
            this ExpBuilder<TFrom, TTo> expBuilder,
            IConvertFactory factory)
        {
            var convertExpression = expBuilder?.Create();

            return new ConvertResult<TFrom, TTo>()
            {
                Factory = factory,
                Expression = convertExpression,
                Func = convertExpression?.Compile()
            };
        }
    }
}