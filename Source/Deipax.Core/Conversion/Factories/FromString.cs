using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromString : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);

            if (fromType == typeof(string) &&
                toType != typeof(object))
            {
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 2 &&
                        x.GetParameters()[0].ParameterType == fromType &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                    MethodCallExpression isNullOrEmpty = Expression.Call(
                        typeof(string),
                        "IsNullOrEmpty",
                        null,
                        input);

                    MethodCallExpression convertExpression = Expression.Call(
                        methodInfo,
                        input,
                        Expression.Coalesce(provider, Expression.Constant(ConvertConfig.DefaultProvider)));

                    GotoExpression returnExpression = toType == underlyingToType
                        ? Expression.Return(returnTarget, convertExpression)
                        : Expression.Return(returnTarget, Expression.Convert(convertExpression, toType));

                    var ifThenElse = Expression.IfThenElse(
                        isNullOrEmpty,
                        Expression.Return(returnTarget, Expression.Default(toType)),
                        returnExpression);

                    BlockExpression block = Expression.Block(
                        toType,
                        ifThenElse,
                        returnLabel);

                    return new ConvertFactoryResult<TFrom, TTo>()
                    {
                        Factory = this,
                        GuardCall = false,
                        Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                    };
                }
            }

            return null;
        }
        #endregion
    }
}