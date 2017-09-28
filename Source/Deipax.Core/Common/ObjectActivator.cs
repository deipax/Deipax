using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using Deipax.Core.Extensions;

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
			_cache = new ConcurrentDictionary<Type, ObjectActivator>();
		}

		#region Field Members
		private static ConcurrentDictionary<Type, ObjectActivator> _cache;
		#endregion

		#region Public Members
		public static ObjectActivator GetActivator(Type t)
		{
			if (t != null)
			{
				return _cache.GetOrAdd(t, (x) =>
				{
					ObjectActivator a = new ObjectActivator();

					if (x == typeof(string))
					{
						a.CreateExpression = Expression.Lambda<Func<object>>(Expression.Constant(null));
					}
					else if (x.HasDefaultConstructor())
					{
						a.CreateExpression = Expression.Lambda<Func<object>>(Expression.Convert(Expression.New(x), typeof(object)));
					}
					else if (x.IsGenericType() && 
						x.GetConstructors().Count() > 0)
					{
						var constructor = x.GetConstructors()[0];
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
				});
			}

			return null;
		}

		public Func<object> Create { get; private set; }
		public Expression<Func<object>> CreateExpression { get; private set; }
		#endregion
	}
}