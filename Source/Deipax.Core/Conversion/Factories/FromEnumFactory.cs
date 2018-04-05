using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromEnumFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (underlyingFromType.IsEnum &&
                toType != typeof(string) &&
                toType != typeof(object) &&
                fromType != typeof(DateTime) &&
                fromType != typeof(DateTime?) &&
                toType != typeof(DateTime) &&
                toType != typeof(DateTime?))
            {
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x => 
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(int))
                    .FirstOrDefault();

                if (methodInfo != null)
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

                    return new Result<TFrom, TTo>()
                    {
                        GuardCall = true,
                        Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile(),
                        Factory = this
                    };
                }
            }

            return null;
        }
        #endregion
    }
}