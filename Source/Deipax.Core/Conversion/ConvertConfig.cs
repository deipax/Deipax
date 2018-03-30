using Deipax.Core.Conversion.Factories;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Deipax.Core.Extensions;

namespace Deipax.Core.Conversion
{
    public static class ConvertConfig
    {
        static ConvertConfig()
        {
            _defaults = new List<IConvertFactory>()
            {
                new FromStringFactory(),
                new FromNonNullablePrimitive(),
                new FromNullablePrimitive(),
                new FromConvertibleRefType(),
                new FromConvertibleValueType(),
                new DefaultFactory()
            };
        }

        #region Field Members
        private static IReadOnlyList<IConvertFactory> _defaults;
        #endregion

        #region Public Members
        public static IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            foreach (var factory in _defaults)
            {
                var func = factory.Get<TFrom, TTo>();

                if (func != null)
                {
                    return new Result<TFrom, TTo>()
                    {
                        Factory = factory,
                        Converter = Guard(func)
                    };
                }
            }

            return null;
        }
        #endregion

        #region Private Members
        private static Func<TFrom, TTo> Guard<TFrom, TTo>(Func<TFrom, TTo> convertFunc)
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);

            ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
            DefaultExpression defaultValue = Expression.Default(toType);
            LabelTarget returnTarget = Expression.Label(toType);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

            var invokeExpression = Expression.Return(
                returnTarget,
                Expression.Invoke(Expression.Constant(convertFunc), input));

            BlockExpression block = null;

            if (toType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    Expression.Constant(DBNull.Value),
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (fromType == typeof(DBNull))
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    defaultValue,
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (fromType == toType)
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
            else if (fromType == typeof(object))
            {
                var isNullOrDbNullExpression = Expression.Or(
                    Expression.Equal(input, Expression.Constant(null, typeof(object))),
                    Expression.Equal(input, Expression.Constant(DBNull.Value, typeof(object))));

                var ifNullReturnExpression = Expression.IfThen(
                    isNullOrDbNullExpression,
                    Expression.Return(returnTarget, defaultValue));

                var returnIfSameAsTargetTypeExpression = Expression.IfThen(
                    Expression.TypeEqual(input, toType),
                    Expression.Return(returnTarget, Expression.Convert(input, toType)));

                if (toType.IsNullable())
                {
                    var underlyingType = Nullable.GetUnderlyingType(toType);

                    var returnIfSameAsUnderlyingTypeExpression = Expression.IfThen(
                        Expression.TypeEqual(input, underlyingType),
                        Expression.Return(returnTarget, Expression.Convert(input, toType)));

                    block = Expression.Block(
                        toType,
                        ifNullReturnExpression,
                        returnIfSameAsTargetTypeExpression,
                        returnIfSameAsUnderlyingTypeExpression,
                        invokeExpression,
                        returnLabel);
                }
                else
                {
                    block = Expression.Block(
                        toType,
                        ifNullReturnExpression,
                        returnIfSameAsTargetTypeExpression,
                        invokeExpression,
                        returnLabel);
                }
            }
            else if (!fromType.IsValueType)
            {
                var isNullOrDbNullExpression = Expression.Or(
                    Expression.Equal(input, Expression.Constant(null, typeof(object))),
                    Expression.Equal(input, Expression.Constant(DBNull.Value, typeof(object))));

                var ifNullReturnExpression = Expression.IfThen(
                    isNullOrDbNullExpression,
                    Expression.Return(returnTarget, defaultValue));

                block = Expression.Block(
                    toType,
                    ifNullReturnExpression,
                    invokeExpression,
                    returnLabel);
            }

            if (block != null)
            {
                return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
            }

            return convertFunc;
        }
        #endregion

        #region Helpers
        class Result<TFrom, TTo> : IResult<TFrom, TTo>
        {
            public IConvertFactory Factory { get; set; }
            public Func<TFrom, TTo> Converter { get; set; }
        }
        #endregion
    }
}