﻿using Deipax.Cloning.Extensions;
using Deipax.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Deipax.Cloning.Common
{
    internal static class Cloner<T>
    {
        #region Field Members
        private static readonly object _lock = new object();

        private static readonly Type _type = typeof(T).IsNullable()
            ? Nullable.GetUnderlyingType(typeof(T))
            : typeof(T);

        private static readonly CloneDel<T> _del = CloneDelConfig.Get<T>();

        private static readonly Dictionary<object, CloneDel<T>> _cache =
            new Dictionary<object, CloneDel<T>>(16, ReferenceEqualsComparer.Instance);

        private static readonly Func<Type, CloneDel<T>> _create = Create;
        #endregion

        #region Public Members
        public static T Get(
            T source,
            CopyContext context)
        {
            if (source == null)
            {
                return source;
            }

            var type = source.GetType();

            if (type == _type)
            {
                return _del(source, context);
            }

            CloneDel<T> result = null;

            if (!_cache.TryGetValue(type, out result))
            {
                lock (_lock)
                {
                    if (!_cache.TryGetValue(type, out result))
                    {
                        result = Create(type);
                        _cache[type] = result;
                    }
                }
            }

            return result(source, context);
        }

        public static T GetUnsafe(
            T source,
            CopyContext context)
        {
            return _del(source, context);
        }
        #endregion

        #region Private Members
        private static CloneDel<T> Create(Type t)
        {
            if (t.CanShallowClone())
            {
                return SimpleReturn;
            }

            ParameterExpression source = Expression.Parameter(_type, "source");
            ParameterExpression context = Expression.Parameter(typeof(CopyContext), "context");

            ConstantExpression defaultValue = Expression.Constant(default(T), _type);
            LabelTarget returnTarget = Expression.Label(_type);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

            var cloneCall = ExpressionHelper.GetUnGuardedClone(t, Expression.Convert(source, t), context);

            GotoExpression returnExpression = Expression.Return(returnTarget, Expression.Convert(cloneCall, _type), _type);

            var block = Expression.Block(
                returnExpression,
                returnLabel);

            return Expression.Lambda<CloneDel<T>>(block, source, context).Compile();
        }

        private static T SimpleReturn(T source, CopyContext context)
        {
            return source;
        }
        #endregion
    }
}