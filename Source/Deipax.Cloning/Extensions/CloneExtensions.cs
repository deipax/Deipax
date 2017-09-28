using Deipax.Cloning.Common;
using System.Collections.Generic;

namespace Deipax.Cloning.Extensions
{
	public static class CloneExtensions
	{
		public static T GetClone<T>(this T source)
		{
			return CloneExpressionCache<T>.Clone(source, new Dictionary<object, object>());
		}

		public static T GetClone<T>(this T source, IDictionary<object, object> clonedObjects)
		{
			return CloneExpressionCache<T>.Clone(source, clonedObjects);
		}
	}
}