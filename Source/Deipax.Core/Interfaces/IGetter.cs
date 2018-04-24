using System;

namespace Deipax.Core.Interfaces
{
	public interface IGetter<T>
	{
		string Name { get; }
		IModelInfo ModelInfo { get; }
		Func<object, object> Get { get; }
	}
}