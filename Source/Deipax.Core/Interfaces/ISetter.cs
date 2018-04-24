using System;

namespace Deipax.Core.Interfaces
{
    public interface ISetter
    {
        Type InstanceType { get; }
        string Name { get; }
        IModelInfo ModelInfo { get; }
        Action<object, object> Set { get; }
    }

    public interface ISetter<T> : ISetter
    {
    }
}