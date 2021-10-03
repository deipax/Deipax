using Deipax.Convert.Common;
using Deipax.Convert.Concretes;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Convert.Factories
{
    public class FromObject : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            // This will only return a func IF TFrom is an object
            // or implements IConvertible and the TTo is supported by 
            // IConvertible.
            if (expBuilder.FromType == typeof(object))
            {
                var methodInfo = typeof(ConvertObject<>)
                    .MakeGenericType(expBuilder.ToType)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == expBuilder.ToType &&
                        x.GetParameters().Length == 2 &&
                        x.GetParameters()[0].ParameterType == typeof(object) &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    Expression callExpression = Expression.Call(
                        methodInfo,
                        expBuilder.Input,
                        expBuilder.GetDefaultProvider());

                    GotoExpression returnExpression = Expression.Return(expBuilder.LabelTarget, callExpression);

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