using System;

namespace Deipax.Core.Interfaces
{
	public interface IGetter
	{
		Type InstanceType { get; }
		string Name { get; }
		IModelInfo ModelInfo { get; }
		Func<object, object> Get { get; }
	}
}