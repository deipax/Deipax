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

                var result = new FromIConvertible().Get(args);

                if (result != null)
                {
                    return result;
                }

                method = args.UnderlyingFromType
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
            }

            return null;
        }
        #endregion
    }
}