using Deipax.Core.Interfaces;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromConvertibleRefType : IConvertFactory
    {
        public FromConvertibleRefType() : this(CultureInfo.InvariantCulture)
        {
        }

        public FromConvertibleRefType(IFormatProvider provider)
        {
            _provider = provider;
        }

        #region Field Members
        private IFormatProvider _provider;
        #endregion

        #region IConvertFactory Members
        public Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            // This will only return a func IF TFrom is an object
            // or implements IConvertible and the TTo is supported by 
            // IConvertible.
            Type fromType = typeof(TFrom);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (fromType == typeof(object) ||
                (!fromType.IsValueType && typeof(IConvertible).IsAssignableFrom(fromType)))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(IConvertible)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    var isNullOrDbNullExpression = Expression.Or(
                        Expression.Equal(input, Expression.Constant(null, typeof(object))),
                        Expression.Equal(input, Expression.Constant(DBNull.Value, typeof(object))));

                    var ifNullReturnExpression = Expression.IfThen(
                        isNullOrDbNullExpression,
                        Expression.Return(returnTarget, Expression.Default(toType)));

                    Expression returnIfSameAsTargetTypeExpression = Expression.Empty();

                    if (fromType == typeof(object))
                    {
                        if (toType == underlyingToType)
                        {
                            returnIfSameAsTargetTypeExpression = Expression.IfThen(
                                Expression.TypeEqual(input, toType),
                                Expression.Return(returnTarget, Expression.Convert(input, toType)));
                        }
                        else
                        {
                            returnIfSameAsTargetTypeExpression = Expression.IfThen(
                                Expression.TypeEqual(input, underlyingToType),
                                Expression.Return(returnTarget, Expression.Convert(input, toType)));
                        }
                    }

                    var assignConverter = Expression.Assign(converter, Expression.TypeAs(input, typeof(IConvertible)));

                    var ifConverter = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(returnTarget, Expression.Default(toType)));

                    var callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        Expression.Constant(_provider));

                    GotoExpression returnExpression = toType == underlyingToType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                    BlockExpression block = Expression.Block(
                        new[] { converter },
                        ifNullReturnExpression,
                        returnIfSameAsTargetTypeExpression,
                        assignConverter,
                        ifConverter,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }
        #endregion
    }
}