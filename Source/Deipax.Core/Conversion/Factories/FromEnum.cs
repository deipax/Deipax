﻿using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class FromEnum : IConvertFactory
    {
        #region IConvertFactory Members
        public Convert<TFrom, TTo> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.UnderlyingFromType.IsEnum &&
                args.ToType != typeof(string) &&
                args.ToType != typeof(object))
            {
                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == args.UnderlyingToType &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(int))
                    .FirstOrDefault();

                if (methodInfo != null &&
                    args.UnderlyingToType != typeof(DateTime))
                {
                    Expression guardedInput = args.FromType.IsNullable()
                        ? Expression.Property(args.Input, "Value")
                        : (Expression)args.Input;

                    var callExpression = Expression.Call(
                        methodInfo,
                        Expression.Convert(guardedInput, typeof(int)));

                    var returnExpression = Expression.Return(
                        args.LabelTarget,
                        Expression.Convert(callExpression, args.ToType));

                    args.AddGuards();
                    args.Add(returnExpression);
                    args.Add(args.LabelExpression);

                    return args.GetConvertResult();
                }
                else if (args.UnderlyingToType == typeof(DateTime))
                {
                    return ConvertConfig.Default?.Get<TFrom, TTo>(args);
                }
            }

            return null;
        }
        #endregion
    }
}