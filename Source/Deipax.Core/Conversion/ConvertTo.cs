using Deipax.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Conversion
{
	public static class ConvertTo<T>
	{
		static ConvertTo()
		{
			From = GetGuardedFunc(GetUnguardedFunc());
		}

		#region Public Members
		public static readonly Func<object, T> From;
		#endregion

		#region Private Members
		private static Func<object, T> GetUnguardedFunc()
		{
			var func = ConvertMap<T>.DefaultFn;

			if (func != null)
			{
				return func;
			}

			var targetType = typeof(T);

			if (targetType.IsNullable())
			{
				return GetToNullableFunc();
			}

			if (targetType.IsEnum())
			{
				return EnumConverter<T>.From;
			}

			return GetDefaultValueFunc();
		}

		private static Func<object, T> GetGuardedFunc(Func<object, T> convertFunc)
		{
			var targetType = typeof(T);
			var input = Expression.Parameter(typeof(object), "input");
			var defaultValue = Expression.Constant(default(T), targetType);

			var returnTarget = Expression.Label(targetType);
			var returnLabel = Expression.Label(returnTarget, Expression.Default(targetType));

			var isNullOrDbNullExpression = Expression.Or(
				Expression.Equal(input, Expression.Constant(null, typeof(object))),
				Expression.Equal(input, Expression.Constant(DBNull.Value, typeof(object))));

			var ifNullReturnExpression = Expression.IfThen(
				isNullOrDbNullExpression,
				Expression.Return(returnTarget, defaultValue));

			var returnIfSameAsTargetTypeExpression = Expression.IfThen(
				Expression.TypeEqual(input, targetType),
				Expression.Return(returnTarget, Expression.Convert(input, targetType)));

			var invokeExpression = Expression.Return(
				returnTarget,
				Expression.Invoke(Expression.Constant(convertFunc), input));

			BlockExpression blockExpression = null;

			if (targetType.IsNullable())
			{
				var underlyingType = Nullable.GetUnderlyingType(targetType);

				var returnIfSameAsUnderlyingTypeExpression = Expression.IfThen(
					Expression.TypeEqual(input, underlyingType),
					Expression.Return(returnTarget, Expression.Convert(input, targetType)));

				blockExpression = Expression.Block(
					targetType,
					ifNullReturnExpression,
					returnIfSameAsTargetTypeExpression,
					returnIfSameAsUnderlyingTypeExpression,
					invokeExpression,
					returnLabel);
			}
			else
			{
				blockExpression = Expression.Block(
					targetType,
					ifNullReturnExpression,
					returnIfSameAsTargetTypeExpression,
					invokeExpression,
					returnLabel);
			}

			return Expression.Lambda<Func<object, T>>(blockExpression, input).Compile();
		}

		private static Func<object, T> GetToNullableFunc()
		{
			var targetType = typeof(T);
			var delegateType = typeof(Func<object, T>);
			var methodInfo = typeof(ConvertTo<T>)
				.GetRuntimeMethods()
				.Where(x =>
					x.Name == "GetToNullableFuncHelper" &&
					x.IsStatic &&
					x.IsPrivate)
				.FirstOrDefault();

			var genericMethod = methodInfo.MakeGenericMethod(targetType.GetGenericArguments()[0]);
			return (Func<object, T>)genericMethod.Invoke(null, new object[] { });
		}

		private static Func<object, TElem?> GetToNullableFuncHelper<TElem>() where TElem : struct
		{
			var targetType = typeof(TElem?);
			var input = Expression.Parameter(typeof(object), "input");
			var invokeExpression = Expression.Invoke(Expression.Constant(ConvertTo<TElem>.From), input);
			var convertExpression = Expression.Convert(invokeExpression, targetType);
			return Expression.Lambda<Func<object, TElem?>>(convertExpression, input).Compile();
		}

		private static Func<object, T> GetDefaultValueFunc()
		{
			var targetType = typeof(T);
			var input = Expression.Parameter(typeof(object), "input");

			Expression defaultValue = Expression.Default(targetType);

			if (targetType.IsNullable() || !targetType.IsValueType())
			{
				defaultValue = Expression.Coalesce(
					Expression.TypeAs(input, targetType), 
					Expression.Default(targetType));
			}
			
			var returnTarget = Expression.Label(targetType);
			var returnLabel = Expression.Label(returnTarget, defaultValue);
			return Expression.Lambda<Func<object, T>>(returnLabel, input).Compile();
		}
		#endregion
	}

	internal static class EnumConverter<T>
	{
		static EnumConverter()
		{
			if (_targetType.IsEnum())
			{
				foreach (var name in Enum.GetNames(_targetType))
				{
					_enumValues.Add(name, Enum.Parse(_targetType, name));
				}

				foreach (var value in Enum.GetValues(_targetType).Cast<int>())
				{
					_enumValues.Add(value, Enum.Parse(_targetType, value.ToString()));
					_enumValues.Add(value.ToString(), Enum.Parse(_targetType, value.ToString()));
				}

				_intconverter = ConvertMap<int>.DefaultFn;

				From = GetToEnumFunc();
			}
		}

		#region Field Members
		private static Type _intType = typeof(int);
		private static Type _stringType = typeof(string);
		private static Type _targetType = typeof(T);
		private static Func<object, int> _intconverter;
		private static Dictionary<object, object> _enumValues = new Dictionary<object, object>();
		#endregion

		#region Public Members
		public static readonly Func<object, T> From;
		#endregion

		#region Private Members
		private static Func<object, T> GetToEnumFunc()
		{
			var delegateType = typeof(Func<object, T>);
			var methodInfo = typeof(EnumConverter<T>)
				.GetRuntimeMethods()
				.Where(x =>
					x.Name == "GetToEnumFuncHelper" &&
					x.IsStatic &&
					x.IsPrivate)
				.FirstOrDefault();

			var genericMethod = methodInfo.MakeGenericMethod(typeof(T));
			return (Func<object, T>)genericMethod.CreateDelegate(delegateType);
		}

		private static TEnum GetToEnumFuncHelper<TEnum>(object source) where TEnum : struct
		{
			object retVal = null;
			var sourceType = source.GetType();

			if (sourceType == _stringType || sourceType == _intType)
			{
				_enumValues.TryGetValue(source, out retVal);
			}
			else
			{
				_enumValues.TryGetValue(_intconverter(source), out retVal);
			}

			return retVal != null ? (TEnum)retVal : default(TEnum);
		}
		#endregion
	}
}
