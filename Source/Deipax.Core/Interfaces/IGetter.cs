using System;

namespace Deipax.Core.Interfaces
{
    public delegate T Get<T>(
        object instance,
        IFormatProvider provider = null);

    public interface IGetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        Get<X> GetDelegate<X>();
        Delegate GetDelegate(Type t);
    }
}