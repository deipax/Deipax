using Deipax.Core.Conversion;
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
    internal class Setter<T, P> : ISetter<T>
    {
        public Setter(IModelInfo info)
        {
            _cache = new ConcurrentDictionary<Type, Delegate>();
            Name = info.Name;
            ModelInfo = info;
        }

        #region Field Members
        private ConcurrentDictionary<Type, Delegate> _cache;

        private static Func<Type, IModelInfo, Delegate> _createDelegate = CreateDelegate;

        private static MethodInfo _createHelper = typeof(Setter<T, P>)
            .GetRuntimeMethods()
            .Where(x => x.Name == "CreateHelper")
            .FirstOrDefault();
        #endregion

        #region ISetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }

        public Set<T, X> GetDelegate<X>()
        {
            return (Set<T, X>)GetDelegate(typeof(X));
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

        private static Set<T, X> CreateHelper<X>(
            IModelInfo info)
        {
            var xType = typeof(X);

            var input = Expression.Parameter(typeof(X), "input");
            var instance = Expression.Parameter(typeof(T).MakeByRefType(), "instance");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                info.GetOptimalMemberInfo());

            List<Expression> expressions = new List<Expression>();

            if (info.Type == xType)
            {
                expressions.Add(Expression.Assign(memberExpression, input));
            }
            else if (info.Type == typeof(object) &&
                     !xType.IsNullable())
            {
                expressions.Add(Expression.Assign(memberExpression, Expression.Convert(input, typeof(object))));
            }
            else if (info.Type == typeof(object) &&
                     xType.IsNullable())
            {
                var value = Expression.Property(input, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(input, "HasValue"),
                    Expression.Assign(memberExpression, Expression.Convert(value, typeof(object))),
                    Expression.Assign(memberExpression, Expression.Default(info.Type)));

                expressions.Add(ifThenElse);
            }
            else if (xType.IsNullable() &&
                     Nullable.GetUnderlyingType(xType) == info.Type)
            {
                var value = Expression.Property(input, "Value");

                var ifThenElse = Expression.IfThenElse(
                    Expression.Property(input, "HasValue"),
                    Expression.Assign(memberExpression, Expression.Convert(value, info.Type)),
                    Expression.Assign(memberExpression, Expression.Default(info.Type)));

                expressions.Add(ifThenElse);
            }
            else if (info.Type.IsNullable() &&
                     Nullable.GetUnderlyingType(info.Type) == xType)
            {
                expressions.Add(Expression.Assign(memberExpression, Expression.Convert(input, info.Type)));
            }
            else if (xType == typeof(object))
            {
                var invoke = Expression.Invoke(
                    Expression.Constant(ConvertTo<P, X>.From),
                    input,
                    provider);

                var ifThenElse = Expression.IfThenElse(
                    Expression.TypeEqual(input, info.Type),
                    Expression.Assign(memberExpression, Expression.Convert(input, info.Type)),
                    Expression.Assign(memberExpression, invoke));

                expressions.Add(ifThenElse);
            }
            else if (xType != info.Type)
            {
                var invoke = Expression.Invoke(
                    Expression.Constant(ConvertTo<P, X>.From),
                    input,
                    provider);

                expressions.Add(Expression.Assign(memberExpression, invoke));
            }

            var setter = Expression.Lambda<Set<T, X>>(
                Expression.Block(expressions),
                instance,
                input,
                provider);

            return setter.Compile();
        }
        #endregion
    }
}