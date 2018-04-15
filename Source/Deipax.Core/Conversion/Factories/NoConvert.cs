﻿using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class NoConvert : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
            ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
            DefaultExpression defaultValue = Expression.Default(toType);
            LabelTarget returnTarget = Expression.Label(toType);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

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
                var assignDefault = Expression.Assign(returnValue, defaultValue);

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
            else if (toType == typeof(object))
            {
                if (!fromType.IsNullable())
                {
                    GotoExpression returnExpression = Expression.Return(
                        returnTarget,
                        Expression.Convert(input, typeof(object)),
                        toType);

                    block = Expression.Block(
                        returnExpression,
                        returnLabel);
                }
                else
                {             
                    var hasValue = Expression.Property(input, "HasValue");
                    var value = Expression.Property(input, "Value");

                    GotoExpression returnValue = Expression.Return(
                        returnTarget,
                        Expression.Convert(value, toType),
                        toType);

                    GotoExpression returnDefault = Expression.Return(
                        returnTarget,
                        Expression.Default(toType),
                        toType);

                    var ifThenElse = Expression.IfThenElse(
                        hasValue,
                        returnValue,
                        returnDefault);

                    block = Expression.Block(
                        ifThenElse,
                        returnLabel);
                }
            }
            else if (toType.IsAssignableFrom(fromType))
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    Expression.Convert(input, toType),
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (toType.IsAssignableFrom(underlyingFromType))
            {
                var hasValue = Expression.Property(input, "HasValue");
                var value = Expression.Property(input, "Value");

                GotoExpression returnValue = Expression.Return(
                    returnTarget,
                    Expression.Convert(input, toType),
                    toType);

                GotoExpression returnDefault = Expression.Return(
                    returnTarget,
                    Expression.Default(toType),
                    toType);

                var ifThenElse = Expression.IfThenElse(
                    hasValue,
                    returnValue,
                    returnDefault);

                block = Expression.Block(
                    ifThenElse,
                    returnLabel);
            }

            if (block != null)
            {
                return new ConvertFactoryResult<TFrom, TTo>()
                {
                    Factory = this,
                    GuardCall = false,
                    Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                };
            }

            return null;
        }
        #endregion
    }
}