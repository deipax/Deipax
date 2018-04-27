using System;

namespace Deipax.Core.Interfaces
{
    public delegate void Set<T>(
        object instance,
        T value,
        IFormatProvider provider = null);

    public interface ISetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        Set<object> Set { get; }
    }
}