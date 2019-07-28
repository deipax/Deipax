using Deipax.Core.Common;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion.Factories
{
    public class ToEnum : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.UnderlyingToType.IsEnum)
            {
                MethodCallExpression callExpression = null;

                if (args.FromType == typeof(string))
                {
                    callExpression = Expression.Call(
                        typeof(EnumHelper<>).MakeGenericType(args.ToType),
                        "ConvertFromString",
                        new Type [] { },
                        args.Input,
                        args.GetDefaultProvider());
                }
                else if (args.FromType == typeof(object))
                {
                    callExpression = Expression.Call(
                        typeof(EnumHelper<>).MakeGenericType(args.ToType),
                        "ConvertFromObject",
                        new Type [] { },
                        args.Input,
                        args.GetDefaultProvider());
                }
                else
                {
                    Expression guardedInput = args.FromType.IsNullable()
                        ? Expression.Property(args.Input, "Value")
                        : (Expression)args.Input;

                    callExpression = Expression.Call(
                        typeof(EnumHelper<>).MakeGenericType(args.ToType),
                        "Convert",
                        new[] { args.UnderlyingFromType },
                        guardedInput,
                        args.GetDefaultProvider());
                }

                GotoExpression returnExpression = args.ToType.IsNullable()
                    ? Expression.Return(args.LabelTarget, Expression.Convert(callExpression, args.ToType))
                    : Expression.Return(args.LabelTarget, callExpression);

                args.AddGuards();
                args.Add(returnExpression);
                args.Add(args.LabelExpression);

                return args.Get();
            }

            return null;
        }
        #endregion
    }
}