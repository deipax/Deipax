using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromNullablePrimitive : IConvertFactory
    {
        #region IConvertFactory Members
        public Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);

            // Avoid calling Convert.ToXXX(object)
            if (fromType.IsNullable() &&
                fromType != typeof(object))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
                Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == underlyingFromType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    var returnValue = Expression.Variable(underlyingToType, "returnValue");

                    MethodCallExpression callExpression = Expression.Call(
                        methodInfo,
                        Expression.Property(input, "Value"));

                    var ifThenElse = Expression.IfThenElse(
                        Expression.Property(input, "HasValue"),
                        Expression.Assign(returnValue, callExpression),
                        Expression.Assign(returnValue, Expression.Default(underlyingToType)));

                    GotoExpression returnExpression = underlyingToType == toType
                        ? Expression.Return(returnTarget, returnValue)
                        : Expression.Return(returnTarget, Expression.Convert(returnValue, toType));

                    BlockExpression block = Expression.Block(
                        new[] { returnValue },
                        ifThenElse,
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
