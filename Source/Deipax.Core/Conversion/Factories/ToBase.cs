using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
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

    public class ToSByte : ToBase<sbyte>
    {
        public ToSByte() : base(
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

    public class ToShort : ToBase<short>
    {
        public ToShort() : base(
            typeof(DateTime))
        {
        }
    }

    public class ToUShort : ToBase<ushort>
    {
        public ToUShort() : base(
            typeof(DateTime))
        {
        }
    }

    public class ToInt : ToBase<int>
    {
        public ToInt() : base(
            typeof(DateTime))
        {
        }
    }

    public class ToUInt : ToBase<uint>
    {
        public ToUInt() : base(
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

    public class ToULong : ToBase<ulong>
    {
        public ToULong() : base(
            typeof(DateTime))
        {
        }
    }

    public class ToFloat : ToBase<float>
    {
        public ToFloat() : base(
            typeof(char),
            typeof(DateTime))
        {
        }
    }

    public class ToDouble : ToBase<double>
    {
        public ToDouble() : base(
            typeof(char),
            typeof(DateTime))
        {
        }
    }

    public class ToDecimal : ToBase<decimal>
    {
        public ToDecimal() : base(
            typeof(char),
            typeof(DateTime))
        {
        }
    }

    public class ToDateTime : ToBase<DateTime>
    {
        public ToDateTime() : base(
            typeof(bool),
            typeof(char),
            typeof(sbyte),
            typeof(byte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double),
            typeof(decimal))
        {
        }
    }

    public abstract class ToBase<T> : IConvertFactory
    {
        public ToBase(params Type[] invalidCastTypes)
        {
            _invalidCastTypes = invalidCastTypes?.ToList() ?? new List<Type>();
        }

        #region Field Member
        private List<Type> _invalidCastTypes;
        #endregion

        #region IConvertFactory Members
        public IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>()
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
                        ParameterExpression provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                        var returnTarget = Expression.Label(toType);
                        var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                        Expression guardedInput = fromType != underlyingFromType
                            ? Expression.Property(input, "Value")
                            : (Expression)input;

                        MethodCallExpression callExpression = Expression.Call(
                            methodInfo,
                            guardedInput);

                        GotoExpression returnExpression = toType != underlyingToType
                            ? Expression.Return(returnTarget, Expression.Convert(callExpression, toType))
                            : Expression.Return(returnTarget, callExpression);

                        BlockExpression block = Expression.Block(
                            returnExpression,
                            returnLabel);

                        return new ConvertFactoryResult<TFrom, TTo>()
                        {
                            GuardCall = true,
                            Factory = this,
                            Func = Expression.Lambda<Convert<TFrom, TTo>>(block, input, provider).Compile()
                        };
                    }
                }
            }

            return null;
        }
        #endregion
    }
}