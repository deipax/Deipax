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
    public class ToString : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (expBuilder.ToType == typeof(string))
            {
                Expression guardedInput = expBuilder.FromType.IsNullable()
                    ? Expression.Property(expBuilder.Input, "Value")
                    : (Expression)expBuilder.Input;

                var result = GetConvert(expBuilder, guardedInput);

                if (result == null)
                {
                    result = GetEnum(expBuilder, guardedInput);
                }

                if (result == null)
                {
                    result = GetIConvertible<TFrom, TTo>();
                }

                if (result == null)
                {
                    result = GetToString(expBuilder, guardedInput);
                }

                return result;
            }

            return null;
        }
        #endregion

        #region Private Members
        private IConvertResult<TFrom, TTo> GetConvert<TFrom, TTo>(
            ExpBuilder<TFrom, TTo> expBuilder,
            Expression guardedInput)
        {
            var method = typeof(System.Convert)
                .GetRuntimeMethods()
                .Where(x =>
                    x.ReturnType == typeof(string) &&
                    x.GetParameters().Length == 2 &&
                    x.GetParameters()[0].ParameterType == expBuilder.UnderlyingFromType &&
                    x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                .FirstOrDefault();

            if (method != null)
            {
                MethodCallExpression callExpression = Expression.Call(
                    method,
                    guardedInput,
                    expBuilder.GetDefaultProvider());

                GotoExpression returnExpression = Expression.Return(
                    expBuilder.LabelTarget,
                    callExpression);

                return expBuilder
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }

        private static IConvertResult<TFrom, TTo> GetIConvertible<TFrom, TTo>()
        {
            return ConvertConfig
                .DefaultFactories
                .OfType<FromIConvertible>()
                .First()
                .Create<TFrom, TTo>();
        }

        private IConvertResult<TFrom, TTo> GetToString<TFrom, TTo>(
            ExpBuilder<TFrom, TTo> expBuilder,
            Expression guardedInput)
        {
            var method = expBuilder.UnderlyingFromType
                .GetRuntimeMethods()
                .Where(x => x.Name == "ToString")
                .FirstOrDefault();

            if (method != null)
            {
                MethodCallExpression callExpression = Expression.Call(
                    guardedInput,
                    method);

                GotoExpression returnExpression = Expression.Return(
                    expBuilder.LabelTarget,
                    callExpression);

                return expBuilder
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }

        private IConvertResult<TFrom, TTo> GetEnum<TFrom, TTo>(
            ExpBuilder<TFrom, TTo> expBuilder,
            Expression guardedInput)
        {
            if (expBuilder.UnderlyingFromType.IsEnum)
            {
                var callExpression = Expression.Call(
                  typeof(EnumHelper<,>).MakeGenericType(
                      expBuilder.UnderlyingFromType,
                      Enum.GetUnderlyingType(expBuilder.UnderlyingFromType)),
                  "ConvertToString",
                  Array.Empty<Type>(),
                  guardedInput,
                  expBuilder.GetDefaultProvider());

                return expBuilder
                    .AddGuards()
                    .Add(Expression.Return(expBuilder.LabelTarget, callExpression))
                    .Add(expBuilder.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }
        #endregion
    }
}