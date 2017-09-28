using System;
using System.Linq.Expressions;

namespace Deipax.Cloning.Interfaces
{
	public interface ICloneLogicFactory
	{
		ICloneLogic Get<T>(ICloneLogicArgs args);
	}

	public interface ICloneLogic
	{
		bool AddNullCheck { get; }
		bool CheckClonedObjects { get; }
		Expression CloneLogicExpression { get; }
	}

	public interface ICloneLogicArgs
	{
		Type Type { get; }
		ParameterExpression Source { get; }
		ParameterExpression Target { get; }
		ParameterExpression ClonedObjects { get; }
	}
}