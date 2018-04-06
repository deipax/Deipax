using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class ToBool : ToBase<bool>
    {
        public ToBool() : base(
            typeof(char),
            typeof(DateTime))
        {
        }
    }

    public class ToChar : ToBase<char>
    {
        public ToChar() : base(
            typeof(bool),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(DateTime))
        {
        }
    }

    public class ToByte : ToBase<byte>
    {
        public ToByte() : base(
            typeof(DateTime))
        {
        }
    }

    public class ToLong : ToBase<long>
    {
        public ToLong() : base(
            typeof(DateTime))
        {
        }
    }

    public abstract class ToBase<T> : IConvertFactory
    {
        public ToBase(params Type[] invalidCastTypes)
        {
            _invalidCastTypes = invalidCastTypes?.ToList() ?? new List<Type>();
        }

        #region Field Members
        private List<Type> _invalidCastTypes;
        #endregion

        #region IConvertFactory Members
        public IResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            var toType = typeof(TTo);
            var underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            var fromType = typeof(TFrom);
            var underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (underlyingToType == typeof(T) &&
                underlyingFromType != typeof(string) &&
                underlyingFromType != typeof(object))
            {
                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == underlyingFromType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    if (_invalidCastTypes.Exists(x => x == underlyingFromType))
                    {
                        return ConvertConfig.Default?.Get<TFrom, TTo>();
                    }
                    else
                    {
                        ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                        var returnTarget = Expression.Label(toType);
                        var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                        Expression fromConvert = fromType != underlyingFromType
                            ? Expression.Property(input, "Value")
                            : (Expression)input;

                        MethodCallExpression callExpression = Expression.Call(
                            methodInfo,
                            fromConvert);

                        GotoExpression returnExpression = toType != underlyingToType
                            ? Expression.Return(returnTarget, Expression.Convert(callExpression, toType))
                            : Expression.Return(returnTarget, callExpression);

                        BlockExpression block = Expression.Block(
                            returnExpression,
                            returnLabel);

                        return new Result<TFrom, TTo>()
                        {
                            GuardCall = true,
                            Factory = this,
                            Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile()
                        };
                    }
                }
            }

            return null;
        }
        #endregion
    }
}