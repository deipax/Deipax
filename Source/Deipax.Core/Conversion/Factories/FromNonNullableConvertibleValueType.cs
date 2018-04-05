using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromNonNullableConvertibleValueType : IConvertFactory
    {
        public FromNonNullableConvertibleValueType() : this(CultureInfo.InvariantCulture)
        {
        }

        public FromNonNullableConvertibleValueType(IFormatProvider provider)
        {
            _provider = provider;
        }

        #region Field Members
        private IFormatProvider _provider;
        #endregion

        #region IConvertFactory Members
        public IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (fromType.IsValueType &&
                !fromType.IsNullable() &&
                fromType != typeof(DateTime) &&
                fromType != typeof(DateTime?) &&
                fromType != typeof(string) &&
                fromType != typeof(object) &&
                toType != typeof(DateTime) &&
                toType != typeof(DateTime?) &&
                toType != typeof(string) &&
                toType != typeof(object) &&
                typeof(IConvertible).IsAssignableFrom(underlyingFromType))
            {         
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

                    var assignConverter = Expression.Assign(
                        converter, 
                        Expression.TypeAs(input, typeof(IConvertible)));

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
                        assignConverter,
                        ifConverter,
                        returnExpression,
                        returnLabel);

                    return new Result<TFrom, TTo>()
                    {
                        GuardCall = true,
                        Factory = this,
                        Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile()
                    };
                }
            }

            return null;
        }
        #endregion
    }
}