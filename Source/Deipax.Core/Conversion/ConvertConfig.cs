using Deipax.Core.Conversion.Factories;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion
{
    public static class ConvertConfig
    {
        static ConvertConfig()
        {
            DefaultProvider = CultureInfo.InvariantCulture;
            Default = new DefaultFactory();
            SafeConvert = false;

            _defaults = new List<IConvertFactory>()
            {
                new NoConvert(),
                new ToEnum(),
                new ToOrFromDBNull(),
                new ToString(),
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
                new ToDateTime(),
                new FromEnum(),
                new FromString(),
                new FromIConvertible(),
                new FromObject(),
            };
        }

        #region Field Members
        private static IReadOnlyList<IConvertFactory> _defaults;
        #endregion

        #region Public Members
        public static bool SafeConvert { get; set; }
        public static IFormatProvider DefaultProvider { get; set; }
        public static IConvertFactory Default { get; set; }

        public static IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            IConvertFactoryResult<TFrom, TTo> result = null;

            foreach (var factory in _defaults)
            {
                result = factory.Get<TFrom, TTo>();

                if (result != null)
                {
                    break;
                }
            }

            result = result ?? Default?.Get<TFrom, TTo>();

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

            return null;
        }
        #endregion

        #region Private Members
        private static Convert<TFrom, TTo> Guard<TFrom, TTo>(Convert<TFrom, TTo> convertFunc)
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);

            ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
            ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
            DefaultExpression defaultValue = Expression.Default(toType);
            LabelTarget returnTarget = Expression.Label(toType);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

            var invokeExpression = Expression.Return(
                returnTarget,
                Expression.Invoke(Expression.Constant(convertFunc), input, provider));

            BlockExpression block = null;

            if (fromType == typeof(object))
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
                return Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile();
            }

            return convertFunc;
        }
        #endregion
    }

    public interface IResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        Convert<TFrom, TTo> Func { get; }
        Convert<TFrom, TTo> GuardedFunc { get; }
        bool GuardCall { get; }
    }

    internal class Result<TFrom, TTo> : IResult<TFrom, TTo>
    {
        public IConvertFactory Factory { get; set; }
        public Convert<TFrom, TTo> Func { get; set; }
        public Convert<TFrom, TTo> GuardedFunc { get; set; }
        public bool GuardCall { get; set; }
    }
}