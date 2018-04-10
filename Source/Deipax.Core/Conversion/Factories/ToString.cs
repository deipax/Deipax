using Deipax.Core.Interfaces;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion.Factories
{
    public class ToString : IConvertFactory
    {
        public ToString() : this(CultureInfo.InvariantCulture)
        {
        }

        public ToString(IFormatProvider provider)
        {
            _provider = provider;
        }

        #region  Field Members
        private IFormatProvider _provider;
        #endregion

        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            Type toType = typeof(TTo);

            if (toType == typeof(string))
            {
                ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                var returnTarget = Expression.Label(toType);
                var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                var method = typeof(TFrom)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.Name == "ToString" &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (method != null)
                {
                    MethodCallExpression callExpression = Expression.Call(
                        input,
                        method,
                        Expression.Constant(_provider));

                    BlockExpression block = Expression.Block(
                        toType,
                        Expression.Return(returnTarget, callExpression),
                        returnLabel);

                    return new ConvertFactoryResult<TFrom, TTo>()
                    {
                        Factory = this,
                        GuardCall = true,
                        Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile()
                    };
                }

                method = typeof(TFrom)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.Name == "ToString" &&
                        x.GetParameters().Length == 0)
                    .FirstOrDefault();

                if (method != null)
                {
                    MethodCallExpression callExpression = Expression.Call(
                        input,
                        method);

                    BlockExpression block = Expression.Block(
                        toType,
                        Expression.Return(returnTarget, callExpression),
                        returnLabel);

                    return new ConvertFactoryResult<TFrom, TTo>()
                    {
                        Factory = this,
                        GuardCall = true,
                        Func = Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile()
                    };
                }
            }

            return null;
        }
        #endregion
    }
}