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
        #region IConvertFactory Members
        public Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);

            // Avoid calling Convert.ToXXX(object)
            if (!fromType.IsNullable() &&
                fromType != typeof(object))
            {
                Type toType = typeof(TTo);
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

                    GotoExpression returnExpression = underlyingToType == toType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                    BlockExpression block = Expression.Block(
                        toType,
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