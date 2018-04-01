﻿using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromNullablePrimitive : IConvertFactory
    {
        public FromNullablePrimitive()
        {
            GuardCall = true;
        }

        #region IConvertFactory Members
        public bool GuardCall { get; set; }

        public Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);

            if (fromType.IsNullable() &&
                fromType != typeof(object) &&
                fromType != typeof(string) &&
                fromType != typeof(DateTime) &&
                fromType != typeof(DateTime?) &&
                toType != typeof(DateTime) &&
                toType != typeof(DateTime?))
            {             
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

                    MethodCallExpression callExpression = Expression.Call(
                        methodInfo,
                        Expression.Property(input, "Value"));

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
