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
    public class FromString : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (expBuilder.FromType == typeof(string) &&
                expBuilder.ToType != typeof(object))
            {
                var methodInfo = typeof(System.Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == expBuilder.UnderlyingToType &&
                        x.GetParameters().Length == 2 &&
                        x.GetParameters()[0].ParameterType == expBuilder.FromType &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    MethodCallExpression convertExpression = Expression.Call(
                        methodInfo,
                        expBuilder.Input,
                        expBuilder.GetDefaultProvider());

                    GotoExpression returnExpression = expBuilder.ToType.IsNullable()
                        ? Expression.Return(expBuilder.LabelTarget, Expression.Convert(convertExpression, expBuilder.ToType))
                        : Expression.Return(expBuilder.LabelTarget, convertExpression);

                    return expBuilder
                        .AddGuards()
                        .Add(returnExpression)
                        .Add(expBuilder.LabelExpression)
                        .ToResult(this);
                }
            }

            return null;
        }
        #endregion
    }
}