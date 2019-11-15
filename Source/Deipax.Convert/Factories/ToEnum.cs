using Deipax.Convert.Common;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class ToEnum : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<ConvertDelegate<TFrom, TTo>> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.UnderlyingToType.IsEnum)
            {
                MethodCallExpression callExpression;

                if (args.FromType == typeof(string))
                {
                    callExpression = Expression.Call(
                        typeof(EnumHelper<,>).MakeGenericType(
                            args.ToType,
                            Enum.GetUnderlyingType(args.UnderlyingToType)),
                        "ConvertFromString",
                        Array.Empty<Type>(),
                        args.Input,
                        args.GetDefaultProvider());
                }
                else if (args.FromType == typeof(object))
                {
                    callExpression = Expression.Call(
                        typeof(EnumHelper<,>).MakeGenericType(
                            args.ToType,
                            Enum.GetUnderlyingType(args.UnderlyingToType)),
                        "ConvertFromObject",
                        Array.Empty<Type>(),
                        args.Input,
                        args.GetDefaultProvider());
                }
                else
                {
                    Expression guardedInput = args.FromType.IsNullable()
                        ? Expression.Property(args.Input, "Value")
                        : (Expression)args.Input;

                    callExpression = Expression.Call(
                        typeof(EnumHelper<,>).MakeGenericType(
                            args.ToType,
                            Enum.GetUnderlyingType(args.UnderlyingToType)),
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

                return args.Create();
            }

            return null;
        }
        #endregion
    }
}