using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromEnumFactory : IConvertFactory
    {
        public FromEnumFactory()
        {
            GuardCall = true;
        }

        #region IConvertFactory Members
        public bool GuardCall { get; set; }

        public Func<TFrom, TTo> Get<TFrom, TTo>()
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
                    .Where(x => x.ReturnType == underlyingToType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    ParameterExpression returnValue = Expression.Variable(toType, "returnValue");

                    var assignExpression = Expression.Assign(
                        returnValue,
                        Expression.Convert(input, toType));

                    BlockExpression block = Expression.Block(
                        new[] { returnValue },
                        assignExpression,
                        Expression.Return(returnTarget, returnValue),
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }
        #endregion
    }
}