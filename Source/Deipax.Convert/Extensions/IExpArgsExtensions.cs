using Deipax.Convert.Common;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Deipax.Convert.Extensions
{
    public static class IExpArgsExtensions
    {
        public static BinaryExpression GetDefaultProvider<TFrom, TTo>(
            this IExpArgs<TFrom, TTo> args)
        {
            return Expression.Coalesce(
                args?.Provider,
                Expression.Constant(CultureInfo.InvariantCulture));
        }

        public static IExpArgs<TFrom, TTo> AddGuards<TFrom, TTo>(
            this IExpArgs<TFrom, TTo> args)
        {
            if (args.FromType == typeof(string))
            {
                MethodCallExpression isNullOrEmpty = Expression.Call(
                    typeof(string),
                    "IsNullOrEmpty",
                    null,
                    args.Input);

                var ifNullOrEmptyReturn = Expression.IfThen(
                    isNullOrEmpty,
                    Expression.Return(args.LabelTarget, args.DefaultExpression));

                args.Add(ifNullOrEmptyReturn);
            }
            else if (!args.FromType.IsValueType)
            {
                var ifNullReturnExpression = Expression.IfThen(
                    Expression.Or(
                        Expression.Equal(args.Input, Expression.Constant(null, typeof(object))),
                        Expression.Equal(args.Input, Expression.Constant(DBNull.Value, typeof(object)))),
                    Expression.Return(args.LabelTarget, args.DefaultExpression));

                args.Add(ifNullReturnExpression);

                if (args.FromType == typeof(object))
                {
                    if (args.ToType.IsNullable())
                    {
                        var returnIfSame = Expression.IfThen(
                            Expression.Or(
                                Expression.TypeEqual(args.Input, args.ToType),
                                Expression.TypeEqual(args.Input, args.UnderlyingToType)),
                            Expression.Return(args.LabelTarget, Expression.Convert(args.Input, args.ToType)));

                        args.Add(returnIfSame);
                    }
                    else
                    {
                        var returnIfSame = Expression.IfThen(
                            Expression.TypeEqual(args.Input, args.ToType),
                            Expression.Return(args.LabelTarget, Expression.Convert(args.Input, args.ToType)));

                        args.Add(returnIfSame);
                    }
                }
            }
            else if (args.FromType.IsNullable())
            {
                var ifNoValueReturn = Expression.IfThen(
                    Expression.Not(Expression.Property(args.Input, "HasValue")),
                    Expression.Return(args.LabelTarget, args.DefaultExpression));

                args.Add(ifNoValueReturn);
            }

            return args;
        }

        public static IConvertResult<TFrom, TTo> ToResult<TFrom, TTo>(
            this IExpArgs<TFrom, TTo> args,
            IConvertFactory factory)
        {
            var convertExpression = args?.Create();

            return new ConvertResult<TFrom, TTo>()
            {
                Factory = factory,
                Expression = convertExpression,
                Func = convertExpression?.Compile()
            };
        }
    }
}