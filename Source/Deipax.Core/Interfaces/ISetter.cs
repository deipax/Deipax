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
        IDataRecord record,
        int index,
        IFormatProvider provider = null);

    public interface ISetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        Set<T, X> GetDelegate<X>();
        SetFromRecord<T> GetSetFromRecord(Type t);
    }
}