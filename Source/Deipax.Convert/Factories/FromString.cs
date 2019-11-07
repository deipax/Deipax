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
        public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.FromType == typeof(string) &&
                args.ToType != typeof(object))
            {
                var methodInfo = typeof(System.Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == args.UnderlyingToType &&
                        x.GetParameters().Count() == 2 &&
                        x.GetParameters()[0].ParameterType == args.FromType &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    MethodCallExpression convertExpression = Expression.Call(
                        methodInfo,
                        args.Input,
                        args.GetDefaultProvider());

                    GotoExpression returnExpression = args.ToType.IsNullable()
                        ? Expression.Return(args.LabelTarget, Expression.Convert(convertExpression, args.ToType))
                        : Expression.Return(args.LabelTarget, convertExpression);

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