using Deipax.Core.Interfaces;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromIConvertible : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;
            Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

            if (typeof(IConvertible).IsAssignableFrom(underlyingFromType) &&
                underlyingFromType != typeof(object))
            {
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
                    ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    Expression guardedInput = fromType != underlyingFromType
                        ? Expression.Property(input, "Value")
                        : (Expression)input;

                    var assignConverter = Expression.Assign(
                        converter,
                        Expression.TypeAs(guardedInput, typeof(IConvertible)));

                    var ifConverter = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(returnTarget, Expression.Default(toType)));

                    var callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        Expression.Coalesce(provider, Expression.Constant(ConvertConfig.DefaultProvider)));

                    GotoExpression returnExpression = toType == underlyingToType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                    BlockExpression block = Expression.Block(
                        new[] { converter },
                        assignConverter,
                        ifConverter,
                        returnExpression,
                        returnLabel);

                    return new ConvertFactoryResult<TFrom, TTo>()
                    {
                        GuardCall = true,
                        Factory = this,
                        Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                    };
                }
            }

            return null;
        }
        #endregion
    }
}