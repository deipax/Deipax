using Deipax.Convert.Interfaces;
using Deipax.Core.Common;
using Deipax.Core.Extensions;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Convert.Common
{
    public static class ConvertObject<TTo>
    {
        #region Field Members
        private static readonly Type _type = typeof(TTo);

        private static readonly Type _underlyingType = typeof(TTo).IsNullable()
            ? Nullable.GetUnderlyingType(typeof(TTo))
            : typeof(TTo);

        private static readonly bool _returnTypeIsObject = _type == typeof(object);

        private static readonly ConcurrentDictionary<Type, ConvertDelegate<object, TTo>> _cache =
            new ConcurrentDictionary<Type, ConvertDelegate<object, TTo>>(8, 16, ReferenceEqualsComparer.Instance);

        private static readonly Func<Type, ConvertDelegate<object, TTo>> _create = Create;
        #endregion

        #region Public Members
        public static TTo Convert(object source, IFormatProvider provider = null)
        {
            if (source == null) return default;
            if (_returnTypeIsObject) return (TTo)source;

            var runtimeType = source.GetType();

            if (!(source is IConvertible) && !runtimeType.CanBeAssignedTo(_type)) return default;

            if (_type == runtimeType || _underlyingType == runtimeType) return (TTo)source;

            var del = _cache.GetOrAdd(runtimeType, _create);
            return del(source, provider);
        }
        #endregion

        #region Private Members
        private static ConvertDelegate<object, TTo> Create(Type runtimeType)
        {
            var source = Expression.Parameter(typeof(object), "source");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");
            var defaultValue = Expression.Constant(default(TTo), _type);
            var labelTarget = Expression.Label(_type);
            var returnLabel = Expression.Label(labelTarget, defaultValue);

            var fieldInfo = typeof(ConvertTo<,>)
                .MakeGenericType(_type, runtimeType)
                .GetRuntimeFields()
                .Where(x => x.Name == "From")
                .FirstOrDefault();

            var del = (Delegate)fieldInfo.GetValue(null);

            // If the source is a value type, casting it from
            // an object to its strong type will cause it to 
            // be unboxxed.
            var invokeExpression = Expression.Invoke(
                Expression.Constant(del),
                Expression.Convert(source, runtimeType),
                provider);

            GotoExpression returnExpression = Expression.Return(
                labelTarget,
                invokeExpression);

            var block = Expression.Block(
                returnExpression,
                returnLabel);

            return Expression.Lambda<ConvertDelegate<object, TTo>>(block, source, provider).Compile();
        }
        #endregion
    }
}