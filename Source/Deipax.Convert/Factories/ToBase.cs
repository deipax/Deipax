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
        private List<Type> _invalidCastTypes;
        #endregion

        #region IConvertFactory Members
        public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            if (args.UnderlyingToType == typeof(T) &&
                args.UnderlyingFromType != typeof(string) &&
                args.UnderlyingFromType != typeof(object))
            {
                var methodInfo = typeof(System.Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == args.UnderlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == args.UnderlyingFromType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    if (_invalidCastTypes.Exists(x => x == args.UnderlyingFromType))
                    {
                        return ConvertConfig.DefaultFactory?.Get(args);
                    }
                    else
                    {
                        Expression guardedInput = args.FromType.IsNullable()
                            ? Expression.Property(args.Input, "Value")
                            : (Expression)args.Input;

                        MethodCallExpression callExpression = Expression.Call(
                            methodInfo,
                            guardedInput);

                        GotoExpression returnExpression = args.ToType.IsNullable()
                            ? Expression.Return(args.LabelTarget, Expression.Convert(callExpression, args.ToType))
                            : Expression.Return(args.LabelTarget, callExpression);

                        args.AddGuards();
                        args.Add(returnExpression);
                        args.Add(args.LabelExpression);

                        return args.Get();
                    }
                }
            }

            return null;
        }
        #endregion
    }
}