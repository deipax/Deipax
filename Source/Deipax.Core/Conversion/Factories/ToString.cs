using Deipax.Core.Common;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class ToString : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
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
                    result = GetIConvertible(args, guardedInput);
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
        private static Expression<Convert<TFrom, TTo>> GetConvert<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args,
            Expression guardedInput)
        {
            var method = typeof(Convert)
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

                args.AddGuards();
                args.Add(returnExpression);
                args.Add(args.LabelExpression);
                return args.Get();
            }

            return null;
        }

        private static Expression<Convert<TFrom, TTo>> GetIConvertible<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args,
            Expression guardedInput)
        {
            return new FromIConvertible().Get(args);
        }

        private static Expression<Convert<TFrom, TTo>> GetToString<TFrom, TTo>(
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

                args.AddGuards();
                args.Add(returnExpression);
                args.Add(args.LabelExpression);
                return args.Get();
            }

            return null;
        }

        private static Expression<Convert<TFrom, TTo>> GetEnum<TFrom, TTo>(
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
                  new Type [] { },
                  guardedInput,
                  args.GetDefaultProvider());

                args.AddGuards();
                args.Add(Expression.Return(args.LabelTarget, callExpression));
                args.Add(args.LabelExpression);

                return args.Get();
            }

            return null;
        }
        #endregion
    }
}