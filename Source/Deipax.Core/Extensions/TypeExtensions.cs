using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Deipax.Core.Extensions
{
    public static class TypeExtensions
	{
		#region Field Members
        private static readonly Type _stringType = typeof(string);
	    private static readonly Type _dateTimeType = typeof(DateTime);
	    private static readonly Type _timeSpanType = typeof(TimeSpan);
        #endregion

        #region Public Members
	    public static bool IsAnonymous(this Type type)
	    {
	        return
	            Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false) &&
	            type.IsGenericType &&
	            type.Name.Contains("AnonymousType") &&
	            (type.Name.StartsWith("<>", StringComparison.OrdinalIgnoreCase) ||
	             type.Name.StartsWith("VB$", StringComparison.OrdinalIgnoreCase)) &&
	            (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
	    }

        public static bool IsNullable(this Type source)
		{
			return source.IsGenericType() && source.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		public static bool IsImmutable(this Type source)
		{
		    return source == _stringType ||
		           source == _dateTimeType ||
		           source == _timeSpanType;
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