using Deipax.Cloning.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Common
{
	public static class CloneExpressionCache
	{
		static CloneExpressionCache()
		{
			_cache = new ConcurrentDictionary<Type, ICloneExpression>();
		}

		#region Field Members
		private static ConcurrentDictionary<Type, ICloneExpression> _cache;

		private static MethodInfo _helper = typeof(CloneExpressionCache)
			.GetRuntimeMethods()
			.Where(x =>
				x.Name == "GetCloneExpressionHelper" &&
				x.IsPrivate &&
				x.IsStatic)
			.FirstOrDefault();
		#endregion

		#region Public Members
		public static ICloneExpression Get(Type t)
		{
			return _cache.GetOrAdd(t, (x) =>
			{
				return (ICloneExpression)_helper
					.MakeGenericMethod(x)
					.Invoke(null, null);
			});
		}

		public static object GetCloneDynamic(object source, IDictionary<object, object> clonedObjects)
		{
			return Get(source.GetType()).CloneAsObject(source, clonedObjects);
		}
		#endregion

		#region Private Members
		private static ICloneExpression GetCloneExpressionHelper<T>()
		{
			return CloneExpressionCache<T>.CloneExpression;
		}
		#endregion
	}

	public static class CloneExpressionCache<T>
	{
		static CloneExpressionCache()
		{
			var cloneExpression = CloneExpressionFactory<T>.Get();
			Clone = cloneExpression.Clone;
			CloneAsObject = cloneExpression.CloneAsObject;
			CloneExpression = cloneExpression;
		}

		#region Public Members
		public static ICloneExpression<T> CloneExpression { get; private set; }
		public static Func<T, IDictionary<object, object>, T> Clone { get; private set; }
		public static Func<object, IDictionary<object, object>, object> CloneAsObject { get; private set; }
		#endregion
	}
}