using Deipax.Convert.Concretes;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Convert.Factories
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
        private readonly List<Type> _invalidCastTypes;
        #endregion

        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            if (expBuilder.UnderlyingToType == typeof(T) &&
                expBuilder.UnderlyingFromType != typeof(string) &&
                expBuilder.UnderlyingFromType != typeof(object))
            {
                var methodInfo = typeof(System.Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == expBuilder.UnderlyingToType &&
                        x.GetParameters().Length == 1 &&
                        x.GetParameters()[0].ParameterType == expBuilder.UnderlyingFromType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    if (_invalidCastTypes.Exists(x => x == expBuilder.UnderlyingFromType))
                    {
                        return expBuilder
                            .Add(expBuilder.LabelExpression)
                            .ToResult(this);
                    }
                    else
                    {
                        Expression guardedInput = expBuilder.FromType.IsNullable()
                            ? Expression.Property(expBuilder.Input, "Value")
                            : (Expression)expBuilder.Input;

                        MethodCallExpression callExpression = Expression.Call(
                            methodInfo,
                            guardedInput);

                        GotoExpression returnExpression = expBuilder.ToType.IsNullable()
                            ? Expression.Return(expBuilder.LabelTarget, Expression.Convert(callExpression, expBuilder.ToType))
                            : Expression.Return(expBuilder.LabelTarget, callExpression);

                        return expBuilder
                            .AddGuards()
                            .Add(returnExpression)
                            .Add(expBuilder.LabelExpression)
                            .ToResult(this);
                    }
                }
            }

            return null;
        }
        #endregion
    }
}