using System;
using System.Collections.Generic;

namespace Deipax.Cloning.Interfaces
{
	public interface ICloneExpression
	{
		ICloneLogic CloneLogic { get; }
		Func<object, IDictionary<object, object>, object> CloneAsObject { get; }
	}

	public interface ICloneExpression<T> : ICloneExpression
	{
		Func<T, IDictionary<object, object>, T> Clone { get; }
	}
}