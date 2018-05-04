﻿using Deipax.Core.Conversion;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Concretes
{
    internal class Getter<T, P> : IGetter<T>
    {
        public Getter(IModelInfo info)
        {
            _cache = new ConcurrentDictionary<Type, Delegate>();
            Name = info.Name;
            ModelInfo = info;
        }

        #region Field Members
        private ConcurrentDictionary<Type, Delegate> _cache;

        private static Func<Type, IModelInfo, Delegate> _createDelegate = CreateDelegate;

        private static MethodInfo _createHelper = typeof(Getter<T, P>)
            .GetRuntimeMethods()
            .Where(x => x.Name == "CreateHelper")
            .FirstOrDefault();
        #endregion

        #region IGetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }

        public Get<T, X> GetDelegate<X>()
        {
            return (Get<T, X>)GetDelegate(typeof(X));
        }

        public Delegate GetDelegate(Type t)
        {
            return _cache.GetOrAdd(t, x => _createDelegate(x, ModelInfo));
        }
        #endregion

        #region Private Members
        private static Delegate CreateDelegate(
            Type t,
            IModelInfo info)
        {
            return (Delegate)_createHelper
                .MakeGenericMethod(new[] { t })
                .Invoke(null, new[] { info });
        }

        private static Get<T, X> CreateHelper<X>(
            IModelInfo info)
        {
            var xType = typeof(X);

            var labelTarget = Expression.Label(xType);
            var labelExpression = Expression.Label(labelTarget, Expression.Default(xType));

            var instance = Expression.Parameter(typeof(T).MakeByRefType(), "instance");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                info.GetOptimalMemberInfo());

            List<Expression> expressions = new List<Expression>();

            if (xType == info.Type)
            {
                expressions.Add(Expression.Return(
                    labelTarget,
                    memberExpression));
            }
            else if (xType == typeof(object) &&
                     !info.Type.IsNullable())
            {
                expressions.Add(Expression.Return(
                    labelTarget,
                    Expression.Convert(memberExpression, xType)));
            }
            else if (xType == typeof(object) &&
                     info.Type.IsNullable())
            {
                var value = Expression.Property(memberExpression, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(memberExpression, "HasValue"),
                    Expression.Return(labelTarget, Expression.Convert(value, xType)),
                    Expression.Return(labelTarget, Expression.Default(xType)));

                expressions.Add(ifThenElse);
            }
            else if (xType.IsNullable() &&
                     Nullable.GetUnderlyingType(xType) == info.Type)
            {
                expressions.Add(Expression.Return(
                    labelTarget,
                    Expression.Convert(memberExpression, xType)));
            }
            else if (info.Type.IsNullable() &&
                     Nullable.GetUnderlyingType(info.Type) == xType)
            {
                var value = Expression.Property(memberExpression, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(memberExpression, "HasValue"),
                    Expression.Return(labelTarget, Expression.Convert(value, xType)),
                    Expression.Return(labelTarget, Expression.Default(xType)));

                expressions.Add(ifThenElse);
            }
            else if (xType != info.Type)
            {
                var invoke = Expression.Invoke(
                    Expression.Constant(ConvertTo<X, P>.From),
                    memberExpression,
                    provider);

                expressions.Add(Expression.Return(labelTarget, invoke));
            }

            expressions.Add(labelExpression);

            var getter = Expression.Lambda<Get<T, X>>(
                Expression.Block(xType, expressions),
                instance,
                provider);

            return getter.Compile();
        }
        #endregion
    }
}