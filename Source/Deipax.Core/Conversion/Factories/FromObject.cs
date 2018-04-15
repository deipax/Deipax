using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromObject : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            // This will only return a func IF TFrom is an object
            // or implements IConvertible and the TTo is supported by 
            // IConvertible.
            Type fromType = typeof(TFrom);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (fromType == typeof(object))
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
                    ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    var assignConverter = Expression.Assign(converter, Expression.TypeAs(input, typeof(IConvertible)));

                    var ifConverterNullReturn = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(returnTarget, Expression.Default(toType)));

                    Expression callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        Expression.Coalesce(provider, Expression.Constant(ConvertConfig.DefaultProvider)));

                    GotoExpression returnExpression = toType == underlyingToType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                    Expression block = Expression.Block(
                        new[] { converter },
                        assignConverter,
                        ifConverterNullReturn,
                        returnExpression,
                        returnLabel);

                    if (ConvertConfig.SafeConvert)
                    {
                        ParameterExpression ex = Expression.Parameter(typeof(Exception), "ex");

                        Expression tryCatchExpression = Expression.TryCatch(
                            returnExpression,
                            Expression.Catch(ex, Expression.Return(returnTarget, Expression.Default(toType))));

                        block = Expression.Block(
                            new[] { converter },
                            assignConverter,
                            ifConverterNullReturn,
                            tryCatchExpression,
                            returnLabel);
                    }

                    return new ConvertFactoryResult<TFrom, TTo>()
                    {
                        GuardCall = true,
                        Factory = this,
                        Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                    };
                }
                else
                {
                    // To type is not ICovertible.  Try casting the from object to target type
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                    var returnExpression = Expression.Return(returnTarget, Expression.TypeAs(input, toType));

                    ParameterExpression ex = Expression.Parameter(typeof(Exception), "ex");

                    Expression tryCatchExpression = Expression.TryCatch(
                        returnExpression,
                        Expression.Catch(ex, Expression.Return(returnTarget, Expression.Default(toType))));

                    BlockExpression block = Expression.Block(
                        tryCatchExpression,
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
