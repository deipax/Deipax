using System;

namespace Deipax.Core.Interfaces
{
    public interface ISetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        Action<object, object> Set { get; }
    }
}