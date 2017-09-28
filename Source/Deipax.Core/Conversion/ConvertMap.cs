using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion
{
	public static class ConvertMap<T>
	{
		static ConvertMap()
		{
			DefaultFn = GetDefaultFn();
		}

		#region Public Members
		public static Func<object, T> DefaultFn { get; private set; }
		#endregion

		#region Private Members
		private static Func<object, T> GetDefaultFn()
		{
			var func = ConvertMap.GetDefaultFn<T>();

			if (func != null)
			{
				var input = Expression.Parameter(typeof(object), "input");
				var invokeExpression = Expression.Invoke(
					Expression.Constant(func),
					input,
					Expression.Constant(CultureInfo.InvariantCulture));
				return Expression.Lambda<Func<object, T>>(invokeExpression, input).Compile();
			}

			return null;
		}
		#endregion
	}

	internal static class ConvertMap
	{
		static ConvertMap()
		{
			RegisterDefault(Convert.ToBoolean);
			RegisterDefault(Convert.ToByte);
			RegisterDefault(Convert.ToChar);
			RegisterDefault(Convert.ToDateTime);
			RegisterDefault(Convert.ToDecimal);
			RegisterDefault(Convert.ToDouble);
			RegisterDefault(Convert.ToInt16);
			RegisterDefault(Convert.ToInt32);
			RegisterDefault(Convert.ToInt64);
			RegisterDefault(Convert.ToSByte);
			RegisterDefault(Convert.ToSingle);
			RegisterDefault(Convert.ToString);
			RegisterDefault(Convert.ToUInt16);
			RegisterDefault(Convert.ToUInt32);
			RegisterDefault(Convert.ToUInt64);
		}

		#region Field Members
		private static Dictionary<Type, object> _defaultCache = new Dictionary<Type, object>();
		#endregion

		#region Public Members
		public static Func<object, IFormatProvider, T> GetDefaultFn<T>()
		{
			object result = null;
			_defaultCache.TryGetValue(typeof(T), out result);
			return (Func<object, IFormatProvider, T>)result;
		}
		#endregion

		#region Private Members
		private static void RegisterDefault<X>(Func<object, IFormatProvider, X> func)
		{
			_defaultCache.Add(typeof(X), func);
		}
		#endregion
	}
}