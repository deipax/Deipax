using Deipax.Core.Conversion.Factories;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion
{
    public static class ConvertConfig
    {
        static ConvertConfig()
        {
            Default = new DefaultFactory();

            _defaults = new List<IConvertFactory>()
            {
                new ToObject(),
                new ToString(),
                new ToOrFromDBNull(),
                new ToBool(),
                new ToChar(),
                new ToByte(),
                new ToSByte(),
                new ToShort(),
                new ToUShort(),
                new ToInt(),
                new ToUInt(),
                new ToLong(),
                new ToULong(),
                new ToFloat(),
                new ToDouble(),
                new ToDecimal(),
                new FromEnumFactory(),
                new FromStringFactory(),
                new FromIConvertible(),
                new FromObjectFactory(),
            };
        }

        #region Field Members
        private static IReadOnlyList<IConvertFactory> _defaults;
        #endregion

        #region Public Members
        public static IConvertFactory Default { get; private set; }

        public static IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            foreach (var factory in _defaults)
            {
                var result = factory.Get<TFrom, TTo>();

                if (result != null)
                {
                    return new Result<TFrom, TTo>()
                    {
                        Factory = result.Factory,
                        GuardCall = result.GuardCall,
                        Func = result.Func,
                        GuardedFunc = result.GuardCall
                            ? Guard(result.Func)
                            : result.Func
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
            else if (fromType.IsNullable())
            {
                var hasValue = Expression.Property(input, "HasValue");

                var ifThenElse = Expression.IfThenElse(
                    hasValue,
                    invokeExpression,
                    Expression.Return(returnTarget, defaultValue));

                block = Expression.Block(
                    toType,
                    ifThenElse,
                    returnLabel);
            }

            if (block != null)
            {
                return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
            }

            return convertFunc;
        }
        #endregion
    }

    public interface IResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        Func<TFrom, TTo> Func { get; }
        Func<TFrom, TTo> GuardedFunc { get; }
        bool GuardCall { get; }
    }

    internal class Result<TFrom, TTo> : IResult<TFrom, TTo>
    {
        public IConvertFactory Factory { get; set; }
        public Func<TFrom, TTo> Func { get; set; }
        public Func<TFrom, TTo> GuardedFunc { get; set; }
        public bool GuardCall { get; set; }
    }
}