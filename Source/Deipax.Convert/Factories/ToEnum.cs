using Deipax.Convert.Common;
using Deipax.Convert.Concretes;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class ToEnum : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (expBuilder.UnderlyingToType.IsEnum)
            {
                MethodCallExpression callExpression;

                if (expBuilder.FromType == typeof(string))
                {
                    callExpression = Expression.Call(
                        typeof(EnumHelper<,>).MakeGenericType(
                            expBuilder.ToType,
                            Enum.GetUnderlyingType(expBuilder.UnderlyingToType)),
                        "ConvertFromString",
                        Array.Empty<Type>(),
                        expBuilder.Input,
                        expBuilder.GetDefaultProvider());
                }
                else if (expBuilder.FromType == typeof(object))
                {
                    callExpression = Expression.Call(
                        typeof(EnumHelper<,>).MakeGenericType(
                            expBuilder.ToType,
                            Enum.GetUnderlyingType(expBuilder.UnderlyingToType)),
                        "ConvertFromObject",
                        Array.Empty<Type>(),
                        expBuilder.Input,
                        expBuilder.GetDefaultProvider());
                }
                else
                {
                    Expression guardedInput = expBuilder.FromType.IsNullable()
                        ? Expression.Property(expBuilder.Input, "Value")
                        : (Expression)expBuilder.Input;

                    callExpression = Expression.Call(
                        typeof(EnumHelper<,>).MakeGenericType(
                            expBuilder.ToType,
                            Enum.GetUnderlyingType(expBuilder.UnderlyingToType)),
                        "Convert",
                        new[] { expBuilder.UnderlyingFromType },
                        guardedInput,
                        expBuilder.GetDefaultProvider());
                }

                GotoExpression returnExpression = expBuilder.ToType.IsNullable()
                    ? Expression.Return(expBuilder.LabelTarget, Expression.Convert(callExpression, expBuilder.ToType))
                    : Expression.Return(expBuilder.LabelTarget, callExpression);

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