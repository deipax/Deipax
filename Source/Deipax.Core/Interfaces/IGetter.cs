using System;

namespace Deipax.Core.Interfaces
{
    public delegate X Get<T, X>(
        ref T instance,
        IFormatProvider provider = null);

    public interface IGetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        Get<T, X> GetDelegate<X>();
    }
}