using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromNonNullablePrimitive : IConvertFactory
    {
        public FromNonNullablePrimitive()
        {
            GuardCall = true;
        }

        #region IConvertFactory Members
        public bool GuardCall { get; set; }

        public Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);

            if (!fromType.IsNullable() &&
                fromType != typeof(DateTime) &&
                fromType != typeof(DateTime?) &&
                fromType != typeof(string) &&
                fromType != typeof(object) &&
                toType != typeof(DateTime) &&
                toType != typeof(DateTime?) &&
                toType != typeof(string) &&
                toType != typeof(object))
            {
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == fromType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                    MethodCallExpression callExpression = Expression.Call(
                        methodInfo,
                        input);

                    Expression convertedCall = callExpression;

                    if (toType != underlyingToType)
                    {
                        convertedCall = Expression.Convert(callExpression, toType);
                    }

                    BlockExpression block = Expression.Block(
                        Expression.Return(returnTarget, convertedCall),
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }
        #endregion
    }
}