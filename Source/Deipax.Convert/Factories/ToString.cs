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
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.ToType == typeof(string))
            {
                Expression guardedInput = args.FromType.IsNullable()
                    ? Expression.Property(args.Input, "Value")
                    : (Expression)args.Input;

                var result = GetConvert(args, guardedInput);

                if (result == null)
                {
                    result = GetEnum(args, guardedInput);
                }

                if (result == null)
                {
                    result = GetIConvertible(args);
                }

                if (result == null)
                {
                    result = GetToString(args, guardedInput);
                }

                return result;
            }

            return null;
        }
        #endregion

        #region Private Members
        private IConvertResult<TFrom, TTo> GetConvert<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args,
            Expression guardedInput)
        {
            var method = typeof(System.Convert)
                .GetRuntimeMethods()
                .Where(x =>
                    x.ReturnType == typeof(string) &&
                    x.GetParameters().Length == 2 &&
                    x.GetParameters()[0].ParameterType == args.UnderlyingFromType &&
                    x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                .FirstOrDefault();

            if (method != null)
            {
                MethodCallExpression callExpression = Expression.Call(
                    method,
                    guardedInput,
                    args.GetDefaultProvider());

                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    callExpression);

                return args
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }

        private static IConvertResult<TFrom, TTo> GetIConvertible<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            return ConvertConfig
                .DefaultFactories
                .OfType<FromIConvertible>()
                .First()
                .Create(args);
        }

        private IConvertResult<TFrom, TTo> GetToString<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args,
            Expression guardedInput)
        {
            var method = args.UnderlyingFromType
                .GetRuntimeMethods()
                .Where(x => x.Name == "ToString")
                .FirstOrDefault();

            if (method != null)
            {
                MethodCallExpression callExpression = Expression.Call(
                    guardedInput,
                    method);

                GotoExpression returnExpression = Expression.Return(
                    args.LabelTarget,
                    callExpression);

                return args
                    .AddGuards()
                    .Add(returnExpression)
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }

        private IConvertResult<TFrom, TTo> GetEnum<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args,
            Expression guardedInput)
        {
            if (args.UnderlyingFromType.IsEnum)
            {
                var callExpression = Expression.Call(
                  typeof(EnumHelper<,>).MakeGenericType(
                      args.UnderlyingFromType,
                      Enum.GetUnderlyingType(args.UnderlyingFromType)),
                  "ConvertToString",
                  Array.Empty<Type>(),
                  guardedInput,
                  args.GetDefaultProvider());

                return args
                    .AddGuards()
                    .Add(Expression.Return(args.LabelTarget, callExpression))
                    .Add(args.LabelExpression)
                    .ToResult(this);
            }

            return null;
        }
        #endregion
    }
}