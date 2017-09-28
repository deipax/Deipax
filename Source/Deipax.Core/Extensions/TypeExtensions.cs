using System;
using System.Collections.Generic;
using System.Reflection;

namespace Deipax.Core.Extensions
{
	public static class TypeExtensions
	{
		#region Field Members
		private static HashSet<Type> _immutableTypes = new HashSet<Type>()
		{
			typeof(string), typeof(DateTime), typeof(TimeSpan)
		};
		#endregion

		#region Public Members
		public static bool IsNullable(this Type source)
		{
			return source.IsGenericType() && source.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		public static bool IsImmutable(this Type source)
		{
			return _immutableTypes.Contains(source);
		}

		public static bool HasDefaultConstructor(this Type t)
		{
			return t.IsValueType() || t.GetConstructor(Type.EmptyTypes) != null;
		}

		public static bool IsPrimitive(this Type type)
		{
			return type.GetTypeInfo().IsPrimitive;
		}

		public static bool IsAbstract(this Type type)
		{
			return type.GetTypeInfo().IsAbstract;
		}

		public static bool IsClass(this Type type)
		{
			return type.GetTypeInfo().IsClass;
		}

		public static bool IsGenericType(this Type type)
		{
			return type.GetTypeInfo().IsGenericType;
		}

		public static bool IsInterface(this Type type)
		{
			return type.GetTypeInfo().IsInterface;
		}

		public static bool IsValueType(this Type type)
		{
			return type.GetTypeInfo().IsValueType;
		}

		public static Type BaseType(this Type type)
		{
			return type.GetTypeInfo().BaseType;
		}

		public static bool IsEnum(this Type type)
		{
			return type.GetTypeInfo().IsEnum;
		}
		#endregion
	}
}