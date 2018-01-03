using Deipax.Core.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Core.Common
{
    public static class ObjectActivator<T>
    {
        static ObjectActivator()
        {
            var activator = ObjectActivator.GetActivator(typeof(T));

            if (activator.CreateExpression != null)
            {
                var invoke = Expression.Invoke(activator.CreateExpression);
                var convert = Expression.Convert(invoke, typeof(T));
                CreateExpression = Expression.Lambda<Func<T>>(convert);
                Create = CreateExpression.Compile();
            }
        }

        #region Public Members
        public static Func<T> Create { get; private set; }
        public static Expression<Func<T>> CreateExpression { get; private set; }
        #endregion
    }

    public class ObjectActivator
    {
        static ObjectActivator()
        {
            _cache = new QuickCache<Type, ObjectActivator>(ReferenceEqualsComparer.Instance);
        }

        #region Field Members
        private static QuickCache<Type, ObjectActivator> _cache;
        private static Func<Type, ObjectActivator> _init = Init;
        #endregion

        #region Public Members
        public static ObjectActivator GetActivator(Type t)
        {
            if (t != null)
            {
                return _cache.GetOrAdd(t, _init);
            }

            return null;
        }

        public Func<object> Create { get; private set; }
        public Expression<Func<object>> CreateExpression { get; private set; }
        #endregion

        #region Private Members
        private static ObjectActivator Init(Type t)
        {
            ObjectActivator a = new ObjectActivator();

            if (t == typeof(string))
            {
                a.CreateExpression = Expression.Lambda<Func<object>>(Expression.Constant(null));
            }
            else if (t.HasDefaultConstructor())
            {
                a.CreateExpression = Expression.Lambda<Func<object>>(Expression.Convert(Expression.New(t), typeof(object)));
            }
            else if (t.IsGenericType() &&
                     t.GetConstructors().Count() > 0)
            {
                var constructor = t.GetConstructors()[0];
                var parameters = constructor
                    .GetParameters()
                    .Select(y => Expression.Default(y.ParameterType))
                    .ToList();

                var newExpression = Expression.New(constructor, parameters);
                a.CreateExpression = Expression.Lambda<Func<object>>(Expression.Convert(newExpression, typeof(object)));
            }

            if (a.CreateExpression != null)
            {
                a.Create = a.CreateExpression.Compile();
            }

            return a;
        }
        #endregion
    }
}