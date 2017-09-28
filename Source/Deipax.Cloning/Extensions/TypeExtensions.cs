using Deipax.Core.Extensions;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Deipax.Cloning.Extensions
{
	internal static class TypeExtensions
	{
		public static bool IsPrimitiveCloneLogic(this Type source)
		{
			return source.IsPrimitive() || source.IsImmutable() || typeof(Delegate).IsAssignableFrom(source);
		}

		public static bool IsAnonymous(this Type type)
		{
			return 
				Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)  && 
				type.IsGenericType && 
				type.Name.Contains("AnonymousType") && 
				(type.Name.StartsWith("<>", StringComparison.OrdinalIgnoreCase) || 
					type.Name.StartsWith("VB$", StringComparison.OrdinalIgnoreCase)) && 
				(type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
		}
	}
}