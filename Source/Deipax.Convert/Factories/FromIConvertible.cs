using Deipax.Convert.Concretes;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Deipax.Convert.Common;

namespace Deipax.Convert.Factories
{
    public class FromIConvertible : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (typeof(IConvertible).IsAssignableFrom(expBuilder.UnderlyingFromType) &&
                expBuilder.UnderlyingFromType != typeof(object))
            {
                var methodInfo = typeof(IConvertible)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == expBuilder.UnderlyingToType &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    Expression guardedInput = expBuilder.FromType.IsNullable()
                        ? Expression.Property(expBuilder.Input, "Value")
                        : (Expression)expBuilder.Input;

                    var assignConverter = Expression.Assign(
                        converter,
                        Expression.TypeAs(guardedInput, typeof(IConvertible)));

                    var ifConverterNullReturn = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(expBuilder.LabelTarget, expBuilder.DefaultExpression));

                    var callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        expBuilder.GetDefaultProvider());

                    GotoExpression returnExpression = expBuilder.ToType.IsNullable()
                        ? Expression.Return(expBuilder.LabelTarget, Expression.Convert(callExpression, expBuilder.ToType))
                        : Expression.Return(expBuilder.LabelTarget, callExpression);

                    return expBuilder
                        .AddVariable(converter)
                        .AddGuards()
                        .Add(assignConverter)
                        .Add(ifConverterNullReturn)
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