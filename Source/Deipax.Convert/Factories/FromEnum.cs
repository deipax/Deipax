using Deipax.Convert.Common;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Convert.Factories
{
    public class FromEnum : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (expBuilder.UnderlyingFromType.IsEnum &&
                expBuilder.ToType != typeof(string) &&
                expBuilder.ToType != typeof(object))
            {
                var methodInfo = typeof(System.Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == expBuilder.UnderlyingToType &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(int))
                    .FirstOrDefault();

                if (methodInfo != null &&
                    expBuilder.UnderlyingToType != typeof(DateTime))
                {
                    Expression guardedInput = expBuilder.FromType.IsNullable()
                        ? Expression.Property(expBuilder.Input, "Value")
                        : (Expression)expBuilder.Input;

                    var callExpression = Expression.Call(
                        methodInfo,
                        Expression.Convert(guardedInput, typeof(int)));

                    var returnExpression = Expression.Return(
                        expBuilder.LabelTarget,
                        Expression.Convert(callExpression, expBuilder.ToType));

                    return expBuilder
                        .AddGuards()
                        .Add(returnExpression)
                        .Add(expBuilder.LabelExpression)
                        .ToResult(this);
                }
                else if (expBuilder.UnderlyingToType == typeof(DateTime))
                {
                    return expBuilder
                        .Add(expBuilder.LabelExpression)
                        .ToResult(this);
                }
            }

            return null;
        }
        #endregion
    }
}