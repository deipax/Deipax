using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromEnum : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;
            Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

            if (underlyingFromType.IsEnum &&
                toType != typeof(string) &&
                toType != typeof(object))
            {
                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x => 
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(int))
                    .FirstOrDefault();

                if (methodInfo != null &&
                    underlyingToType != typeof(DateTime))
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                    var callExpression = Expression.Call(
                        methodInfo,
                        Expression.Convert(input, typeof(int)));

                    BlockExpression block = Expression.Block(
                        Expression.Return(returnTarget, Expression.Convert(callExpression, toType)),
                        returnLabel);

                    return new ConvertFactoryResult<TFrom, TTo>()
                    {
                        GuardCall = true,
                        Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile(),
                        Factory = this
                    };
                }
                else if (underlyingToType == typeof(DateTime))
                {
                    return ConvertConfig.Default?.Get<TFrom, TTo>();
                }
            }

            return null;
        }
        #endregion
    }
}