using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Deipax.Core.Extensions
{
	public static class IModelInfoExtensions
	{
		public static IEnumerable<T> GetCustomAttributes<T>(
			this IModelInfo source) where T : Attribute
		{
			if (source != null)
			{
				return source.MemberInfo.GetCustomAttributes<T>();
			}

			return new List<T>();
		}
	}
}