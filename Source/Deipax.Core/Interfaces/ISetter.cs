using System;
using System.Data;

namespace Deipax.Core.Interfaces
{
    public delegate void Set<T, X>(
        ref T instance,
        X value,
        IFormatProvider provider = null);

    public delegate void SetFromRecord<T>(
        ref T instance,
        IDataRecord r,
        int index,
        IFormatProvider provider = null);

    public interface ISetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        SetFromRecord<T> SetFromRecord { get; }
        Set<T, X> GetDelegate<X>();
    }
}