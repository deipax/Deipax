using Deipax.Core.Extensions;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion
{
    public class ConvertFactory
    {
        #region Public Members
        public static Func<TFrom, TTo> Get<TFrom, TTo>()
        {
            Func<TFrom, TTo> func = null;

            if (func == null)
            {
                func = NoConvertNeeded<TFrom, TTo>();
            }

            if (func == null)
            {
                func = FromString<TFrom, TTo>();
            }

            if (func == null)
            {
                func = FromNonNullable<TFrom, TTo>();
            }

            if (func == null)
            {
                func = FromNullable<TFrom, TTo>();
            }

            if (func == null)
            {
                func = FromIConvertibleRefType<TFrom, TTo>();
            }

            if (func == null)
            {
                func = FromIConvertibleValueType<TFrom, TTo>();
            }

            if (func == null)
            {
                func = GetDefault<TFrom, TTo>();
            }

            return func;
        }
        #endregion

        #region Private Members
        private static Func<TFrom, TTo> NoConvertNeeded<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);
            Type toType = typeof(TTo);
            Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
            DefaultExpression defaultOut = Expression.Default(toType);
            LabelTarget returnTarget = Expression.Label(toType);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultOut);

            BlockExpression block = null;

            if (fromType == toType)
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    input,
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (fromType == underlyingToType)
            {
                // In type is non-nullable.  Out type is nullable.
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    Expression.Convert(input, toType),
                    toType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (underlyingFromType == toType)
            {
                // In type is nullable, Out type is not.
                var returnValue = Expression.Variable(toType, "returnValue");
                var hasValue = Expression.Property(input, "HasValue");
                var assignDefault = Expression.Assign(returnValue, defaultOut);

                var ifThen = Expression.IfThen(
                    hasValue,
                    Expression.Assign(returnValue, Expression.Convert(input, toType)));

                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    returnValue,
                    toType);

                block = Expression.Block(
                    new[] { returnValue },
                    assignDefault,
                    ifThen,
                    returnExpression,
                    returnLabel);
            }

            if (block != null)
            {
                return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
            }

            return null;
        }

        private static Func<TFrom, TTo> FromIConvertibleRefType<TFrom, TTo>(
            IFormatProvider provider = null)
        {
            // This will only return a func IF TFrom is an object
            // or implements IConvertible and the TTo is supported by 
            // IConvertible.
            Type fromType = typeof(TFrom);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (fromType == typeof(object) ||
                (!fromType.IsValueType && typeof(IConvertible).IsAssignableFrom(fromType)))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(IConvertible)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var p = provider ?? CultureInfo.InvariantCulture;
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    var isNullOrDbNullExpression = Expression.Or(
                        Expression.Equal(input, Expression.Constant(null, typeof(object))),
                        Expression.Equal(input, Expression.Constant(DBNull.Value, typeof(object))));

                    var ifNullReturnExpression = Expression.IfThen(
                        isNullOrDbNullExpression,
                        Expression.Return(returnTarget, Expression.Default(toType)));

                    Expression returnIfSameAsTargetTypeExpression = Expression.Empty();

                    if (fromType == typeof(object))
                    {
                        if (toType == underlyingToType)
                        {
                            returnIfSameAsTargetTypeExpression = Expression.IfThen(
                                Expression.TypeEqual(input, toType),
                                Expression.Return(returnTarget, Expression.Convert(input, toType)));
                        }
                        else
                        {
                            returnIfSameAsTargetTypeExpression = Expression.IfThen(
                                Expression.TypeEqual(input, underlyingToType),
                                Expression.Return(returnTarget, Expression.Convert(input, toType)));
                        }
                    }

                    var assignConverter = Expression.Assign(converter, Expression.TypeAs(input, typeof(IConvertible)));

                    var ifConverter = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(returnTarget, Expression.Default(toType)));

                    var callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        Expression.Constant(p));

                    GotoExpression returnExpression = toType == underlyingToType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                    BlockExpression block = Expression.Block(
                        new[] { converter },
                        ifNullReturnExpression,
                        returnIfSameAsTargetTypeExpression,
                        assignConverter,
                        ifConverter,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TFrom, TTo> FromIConvertibleValueType<TFrom, TTo>(
            IFormatProvider provider = null)
        {
            // This will only return a func IF TFrom is an object
            // or implements IConvertible and the TTo is supported by 
            // IConvertible.
            Type fromType = typeof(TFrom);
            Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

            if (fromType.IsValueType &&
                typeof(IConvertible).IsAssignableFrom(underlyingFromType))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(IConvertible)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var p = provider ?? CultureInfo.InvariantCulture;
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    var assignConverter = Expression.Assign(converter, Expression.TypeAs(input, typeof(IConvertible)));

                    var ifConverter = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(returnTarget, Expression.Default(toType)));

                    var callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        Expression.Constant(p));

                    GotoExpression returnExpression = toType == underlyingToType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                    BlockExpression block = Expression.Block(
                        new[] { converter },
                        assignConverter,
                        ifConverter,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TFrom, TTo> FromString<TFrom, TTo>(
            IFormatProvider provider = null)
        {
            Type fromType = typeof(TFrom);

            if (fromType == typeof(string))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 2 &&
                        x.GetParameters()[0].ParameterType == fromType &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var p = provider ?? CultureInfo.InvariantCulture;
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                    MethodCallExpression isNullOrEmpty = Expression.Call(
                        typeof(string),
                        "IsNullOrEmpty",
                        null,
                        input);

                    MethodCallExpression convertExpression = Expression.Call(
                        methodInfo,
                        input,
                        Expression.Constant(p));

                    GotoExpression returnExpression = toType == underlyingToType
                        ? Expression.Return(returnTarget, convertExpression)
                        : Expression.Return(returnTarget, Expression.Convert(convertExpression, toType));

                    var ifThenElse = Expression.IfThenElse(
                        isNullOrEmpty,
                        Expression.Return(returnTarget, Expression.Default(toType)),
                        returnExpression);

                    BlockExpression block = Expression.Block(
                        toType,
                        ifThenElse,
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TFrom, TTo> FromNonNullable<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);

            // Avoid calling Convert.ToXXX(object)
            if (!fromType.IsNullable() &&
                fromType != typeof(object))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == fromType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));

                    MethodCallExpression callExpression = Expression.Call(
                        methodInfo,
                        input);

                    GotoExpression returnExpression = underlyingToType == toType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, toType));

                    BlockExpression block = Expression.Block(
                        toType,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TFrom, TTo> FromNullable<TFrom, TTo>()
        {
            Type fromType = typeof(TFrom);

            // Avoid calling Convert.ToXXX(object)
            if (fromType.IsNullable() &&
                fromType != typeof(object))
            {
                Type toType = typeof(TTo);
                Type underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
                Type underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingToType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == underlyingFromType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TFrom), "input");
                    var returnTarget = Expression.Label(toType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
                    var returnValue = Expression.Variable(underlyingToType, "returnValue");

                    MethodCallExpression callExpression = Expression.Call(
                        methodInfo,
                        Expression.Property(input, "Value"));

                    var ifThenElse = Expression.IfThenElse(
                        Expression.Property(input, "HasValue"),
                        Expression.Assign(returnValue, callExpression),
                        Expression.Assign(returnValue, Expression.Default(underlyingToType)));

                    GotoExpression returnExpression = underlyingToType == toType
                        ? Expression.Return(returnTarget, returnValue)
                        : Expression.Return(returnTarget, Expression.Convert(returnValue, toType));

                    BlockExpression block = Expression.Block(
                        new[] { returnValue },
                        ifThenElse,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TFrom, TTo>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TFrom, TTo> GetDefault<TFrom, TTo>()
        {
            // If we got here, we do not know how to convert the 
            // input type to the output type.  Return the default
            // value of the TTo type.
            var fromType = typeof(TFrom);
            var toType = typeof(TTo);
            var input = Expression.Parameter(fromType, "input");
            var returnTarget = Expression.Label(toType);
            var returnLabel = Expression.Label(returnTarget, Expression.Default(toType));
            return Expression.Lambda<Func<TFrom, TTo>>(returnLabel, input).Compile();
        }
        #endregion
    }
}