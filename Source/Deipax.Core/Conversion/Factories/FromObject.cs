using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromObject : IConvertFactory
    {
        #region IConvertFactory Members
        public Convert<TFrom, TTo> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            // This will only return a func IF TFrom is an object
            // or implements IConvertible and the TTo is supported by 
            // IConvertible.
            if (args.FromType == typeof(object))
            {
                var methodInfo = typeof(IConvertible)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == args.UnderlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    var assignConverter = Expression.Assign(
                        converter,
                        Expression.TypeAs(args.Input, typeof(IConvertible)));

                    var ifConverterNullReturn = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(args.LabelTarget, args.Default));

                    Expression callExpression = Expression.Call(
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
                    return args.GetConvertResult();
                }
                else
                {
                    // To type is not ICovertible.  Try casting the from object to target type
                    var returnExpression = Expression.Return(
                        args.LabelTarget,
                        Expression.TypeAs(args.Input, args.ToType));

                    ParameterExpression ex = Expression.Parameter(typeof(Exception), "ex");

                    Expression tryCatchExpression = Expression.TryCatch(
                        returnExpression,
                        Expression.Catch(ex, Expression.Return(args.LabelTarget, args.Default)));

                    args.AddGuards();
                    args.Add(tryCatchExpression);
                    args.Add(args.LabelExpression);
                    return args.GetConvertResult();
                }
            }

            return null;
        }
        #endregion
    }
}