using Deipax.Core.Extensions;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion
{
    public class ConvertConfig
    {
        #region Public Members
        public static Func<TIn, TOut> Get<TIn, TOut>()
        {
            Func<TIn, TOut> func = null;

            if (func == null)
            {
                func = NoConvertNeeded<TIn, TOut>();
            }

            if (func == null)
            {
                func = FromString<TIn, TOut>();
            }

            if (func == null)
            {
                func = FromNonNullable<TIn, TOut>();
            }

            if (func == null)
            {
                func = FromNullable<TIn, TOut>();
            }

            if (func == null)
            {
                func = FromIConvertible<TIn, TOut>();
            }

            if (func == null)
            {
                func = GetDefault<TIn, TOut>();
            }

            return func;
        }
        #endregion

        #region Private Members
        private static Func<TIn, TOut> NoConvertNeeded<TIn, TOut>()
        {
            Type inType = typeof(TIn);
            Type outType = typeof(TOut);
            Type underlyingOutType = Nullable.GetUnderlyingType(outType) ?? outType;
            Type underlyingInType = Nullable.GetUnderlyingType(inType) ?? inType;

            ParameterExpression input = Expression.Parameter(typeof(TIn), "input");
            DefaultExpression defaultOut = Expression.Default(outType);
            LabelTarget returnTarget = Expression.Label(outType);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultOut);

            BlockExpression block = null;

            if (inType == outType)
            {
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    input,
                    outType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (inType == underlyingOutType)
            {
                // In type is non-nullable.  Out type is nullable.
                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    Expression.Convert(input, outType),
                    outType);

                block = Expression.Block(
                    returnExpression,
                    returnLabel);
            }
            else if (underlyingInType == outType)
            {
                // In type is nullable, Out type is not.
                var returnValue = Expression.Variable(outType, "returnValue");
                var hasValue = Expression.Property(input, "HasValue");
                var assignDefault = Expression.Assign(returnValue, defaultOut);

                var ifThen = Expression.IfThen(
                    hasValue,
                    Expression.Assign(returnValue, Expression.Convert(input, outType)));

                GotoExpression returnExpression = Expression.Return(
                    returnTarget,
                    returnValue,
                    outType);

                block = Expression.Block(
                    new[] { returnValue },
                    assignDefault,
                    ifThen,
                    returnExpression,
                    returnLabel);
            }

            if (block != null)
            {
                return Expression.Lambda<Func<TIn, TOut>>(block, input).Compile();
            }

            return null;
        }

        private static Func<TIn, TOut> FromIConvertible<TIn, TOut>(
            IFormatProvider provider = null)
        {
            // This will only return a func IF the in type is an object 
            // and the out type is supported by IConvertible.  If
            // the inType is of type object, it is because someone 
            // explicitly cast it that way.
            Type inType = typeof(TIn);
            Type underlyingInType = Nullable.GetUnderlyingType(inType) ?? inType;

            if (inType == typeof(object) || 
                typeof(IConvertible).IsAssignableFrom(inType))
            {
                Type outType = typeof(TOut);
                Type underlyingOutType = Nullable.GetUnderlyingType(outType) ?? outType;

                var methodInfo = typeof(IConvertible)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingOutType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TIn), "input");
                    var p = provider ?? CultureInfo.InvariantCulture;
                    var returnTarget = Expression.Label(outType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(outType));
                    ParameterExpression converter = Expression.Variable(typeof(IConvertible), "converter");

                    var isNullOrDbNullExpression = Expression.Or(
                        Expression.Equal(input, Expression.Constant(null, typeof(object))),
                        Expression.Equal(input, Expression.Constant(DBNull.Value, typeof(object))));

                    var ifNullReturnExpression = Expression.IfThen(
                        isNullOrDbNullExpression,
                        Expression.Return(returnTarget, Expression.Default(outType)));

                    var assignConverter = Expression.Assign(converter, Expression.TypeAs(input, typeof(IConvertible)));

                    var ifConverter = Expression.IfThen(
                        Expression.Equal(converter, Expression.Constant(null, typeof(object))),
                        Expression.Return(returnTarget, Expression.Default(outType)));

                    var callExpression = Expression.Call(
                        converter,
                        methodInfo,
                        Expression.Constant(p));

                    GotoExpression returnExpression = outType == underlyingOutType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, outType));

                    BlockExpression block = Expression.Block(
                        new[] { converter },
                        ifNullReturnExpression,
                        assignConverter,
                        ifConverter,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TIn, TOut>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TIn, TOut> FromString<TIn, TOut>(
            IFormatProvider provider = null)
        {
            Type inType = typeof(TIn);

            if (inType == typeof(string))
            {
                Type outType = typeof(TOut);
                Type underlyingOutType = Nullable.GetUnderlyingType(outType) ?? outType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingOutType &&
                        x.GetParameters().Count() == 2 &&
                        x.GetParameters()[0].ParameterType == inType &&
                        x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TIn), "input");
                    var p = provider ?? CultureInfo.InvariantCulture;
                    var returnTarget = Expression.Label(outType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(outType));

                    MethodCallExpression isNullOrEmpty = Expression.Call(
                        typeof(string),
                        "IsNullOrEmpty",
                        null,
                        input);

                    MethodCallExpression convertExpression = Expression.Call(
                        methodInfo,
                        input,
                        Expression.Constant(p));

                    GotoExpression returnExpression = outType == underlyingOutType
                        ? Expression.Return(returnTarget, convertExpression)
                        : Expression.Return(returnTarget, Expression.Convert(convertExpression, outType));

                    var ifThenElse = Expression.IfThenElse(
                        isNullOrEmpty,
                        Expression.Return(returnTarget, Expression.Default(outType)),
                        returnExpression);

                    BlockExpression block = Expression.Block(
                        outType,
                        ifThenElse,
                        returnLabel);

                    return Expression.Lambda<Func<TIn, TOut>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TIn, TOut> FromNonNullable<TIn, TOut>()
        {
            Type inType = typeof(TIn);

            // DO NOT BOX
            if (!inType.IsNullable() &&
                inType != typeof(object))
            {
                Type outType = typeof(TOut);
                Type underlyingOutType = Nullable.GetUnderlyingType(outType) ?? outType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingOutType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == inType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TIn), "input");
                    var returnTarget = Expression.Label(outType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(outType));

                    MethodCallExpression callExpression = Expression.Call(
                        methodInfo,
                        input);

                    GotoExpression returnExpression = underlyingOutType == outType
                        ? Expression.Return(returnTarget, callExpression)
                        : Expression.Return(returnTarget, Expression.Convert(callExpression, outType));

                    BlockExpression block = Expression.Block(
                        outType,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TIn, TOut>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TIn, TOut> FromNullable<TIn, TOut>()
        {
            Type inType = typeof(TIn);

            // DO NOT BOX
            if (inType.IsNullable() &&
                inType != typeof(object))
            {
                Type outType = typeof(TOut);
                Type underlyingOutType = Nullable.GetUnderlyingType(outType) ?? outType;
                Type underlyingInType = Nullable.GetUnderlyingType(inType) ?? inType;

                var methodInfo = typeof(Convert)
                    .GetRuntimeMethods()
                    .Where(x =>
                        x.ReturnType == underlyingOutType &&
                        x.GetParameters().Count() == 1 &&
                        x.GetParameters()[0].ParameterType == underlyingInType)
                    .FirstOrDefault();

                if (methodInfo != null)
                {
                    ParameterExpression input = Expression.Parameter(typeof(TIn), "input");
                    var returnTarget = Expression.Label(outType);
                    var returnLabel = Expression.Label(returnTarget, Expression.Default(outType));
                    var returnValue = Expression.Variable(underlyingOutType, "returnValue");

                    MethodCallExpression callExpression = Expression.Call(
                        methodInfo,
                        Expression.Property(input, "Value"));

                    var ifThenElse = Expression.IfThenElse(
                        Expression.Property(input, "HasValue"),
                        Expression.Assign(returnValue, callExpression),
                        Expression.Assign(returnValue, Expression.Default(underlyingOutType)));

                    GotoExpression returnExpression = underlyingOutType == outType
                        ? Expression.Return(returnTarget, returnValue)
                        : Expression.Return(returnTarget, Expression.Convert(returnValue, outType));

                    BlockExpression block = Expression.Block(
                        new[] { returnValue },
                        ifThenElse,
                        returnExpression,
                        returnLabel);

                    return Expression.Lambda<Func<TIn, TOut>>(block, input).Compile();
                }
            }

            return null;
        }

        private static Func<TIn, TOut> GetDefault<TIn, TOut>()
        {
            // If we got here, we do not know how to convert the 
            // input type to the output type.  Return the default
            // value of the output type.
            var inType = typeof(TIn);
            var outType = typeof(TOut);
            var input = Expression.Parameter(inType, "input");
            var returnTarget = Expression.Label(outType);
            var returnLabel = Expression.Label(returnTarget, Expression.Default(outType));
            return Expression.Lambda<Func<TIn, TOut>>(returnLabel, input).Compile();
        }
        #endregion
    }
}