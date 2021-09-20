using Deipax.Convert.Common;
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
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            // This will only return a func IF TFrom is an object
            // or implements IConvertible and the TTo is supported by 
            // IConvertible.
            if (args.FromType == typeof(object))
            {
                var methodInfo = typeof(ConvertObject<>)
                    .MakeGenericType(args.ToType)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == args.ToType &&
                        x.GetParameters().Length == 2 &&
                        x.GetParameters()[0].ParameterType == typeof(object) &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    Expression callExpression = Expression.Call(
                        methodInfo,
                        args.Input,
                        args.GetDefaultProvider());

                    GotoExpression returnExpression = Expression.Return(args.LabelTarget, callExpression);

                    return args
                        .AddGuards()
                        .Add(returnExpression)
                        .Add(args.LabelExpression)
                        .ToResult(this);
                }
            }

            return null;
        }
        #endregion
    }
}