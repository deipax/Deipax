using System;

namespace Deipax.Core.Interfaces
{
    public delegate void Set<T, X>(
        ref T instance,
        X value,
        IFormatProvider provider = null);

    public interface ISetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        Set<T, X> GetDelegate<X>();
        Delegate GetDelegate(Type t);
    }
}