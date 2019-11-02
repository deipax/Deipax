﻿using Deipax.Cloning.Extensions;
using Deipax.Core.Common;
using Deipax.Core.Extensions;
using System;
using System.Linq.Expressions;

namespace Deipax.Cloning.Common
{
    public static class Cloner<T>
    {
        #region Field Members
        private static readonly Type _type = typeof(T).IsNullable()
            ? Nullable.GetUnderlyingType(typeof(T))
            : typeof(T);

        private static CloneDel<T> _del = CloneConfig.Get<T>();

        private static readonly QuickCache<Type, CloneDel<T>> _cache =
            new QuickCache<Type, CloneDel<T>>(16, ReferenceEqualsComparer.Instance);

        private static readonly Func<Type, CloneDel<T>> _create = Create;
        #endregion

        #region Public Members
        public static T Get(T source, CopyContext context)
        {
            if (source == null)
            {
                return source;
            }

            var runtimeType = source.GetType();

            CloneDel<T> del = runtimeType == _type
                ? _del
                : _cache.GetOrAdd(runtimeType, _create);

            return del(source, context);
        }
        #endregion

        #region Private Members
        private static CloneDel<T> Create(Type runtimeType)
        {
            return runtimeType.CanShallowClone()
                ? ExpressionHelper.CreateShallowClone<T>()
                : CreateUnSafeClone(runtimeType);
        }

        private static CloneDel<T> CreateUnSafeClone(Type runtimeType)
        {
            ParameterExpression source = Expression.Parameter(_type, "source");
            ParameterExpression context = Expression.Parameter(typeof(CopyContext), "context");
            ConstantExpression defaultValue = Expression.Constant(default(T), _type);
            LabelTarget returnTarget = Expression.Label(_type);
            LabelExpression returnLabel = Expression.Label(returnTarget, defaultValue);

            var cloneCall = ExpressionHelper.GetUnSafeClone(
                runtimeType,
                Expression.Convert(source, runtimeType),
                context);

            GotoExpression returnExpression = Expression.Return(
                returnTarget,
                Expression.Convert(cloneCall, _type),
                _type);

            var block = Expression.Block(
                returnExpression,
                returnLabel);

            return Expression.Lambda<CloneDel<T>>(block, source, context).Compile();
        }
        #endregion
    }
}