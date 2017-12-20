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
	}
}