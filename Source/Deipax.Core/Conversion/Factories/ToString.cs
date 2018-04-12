using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class ToString : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type toType = typeof(TTo);
            Type fromType = typeof(TFrom);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (toType == typeof(string))
            {
                var method = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == typeof(string) &&
                        x.GetParameters().Length == 2 &&
                        x.GetParameters()[0].ParameterType == underlyingFromType &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (method != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                    Expression guardedInput = fromType != underlyingFromType
                        ? Expression.Property(input, "Value")
                        : (Expression)input;

                    MethodCallExpression callExpression = Expression.Call(
                        method,
                        guardedInput,
                        Expression.Coalesce(provider, Expression.Constant(ConvertConfig.DefaultProvider)));

                    GotoExpression returnExpression = Expression.Return(returnTarget, callExpression);

                    BlockExpression block = Expression.Block(
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