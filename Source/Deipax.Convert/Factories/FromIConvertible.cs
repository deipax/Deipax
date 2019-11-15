using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Convert.Factories
{
    public class FromIConvertible : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<ConvertDelegate<TFrom, TTo>> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (typeof(IConvertible).IsAssignableFrom(args.UnderlyingFromType) &&
                args.UnderlyingFromType != typeof(object))
            {
                var methodInfo = typeof(IConvertible)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == args.UnderlyingToType &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    Expression guardedInput = args.FromType.IsNullable()
                        ? Expression.Property(args.Input, "Value")
                        : (Expression)args.Input;

                    var assignConverter = Expression.Assign(
                        converter,
                        Expression.TypeAs(guardedInput, typeof(IConvertible)));

                    var ifConverterNullReturn = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(args.LabelTarget, args.DefaultExpression));

                    var callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        args.GetDefaultProvider());

                    GotoExpression returnExpression = args.ToType.IsNullable()
                        ? Expression.Return(args.LabelTarget, Expression.Convert(callExpression, args.ToType))
                        : Expression.Return(args.LabelTarget, callExpression);

                    args.AddVariable(converter);
                    args.AddGuards();
                    args.Add(assignConverter);
                    args.Add(ifConverterNullReturn);
                    args.Add(returnExpression);
                    args.Add(args.LabelExpression);

                    return args.Create();
                }
            }

            return null;
        }
        #endregion
    }
}