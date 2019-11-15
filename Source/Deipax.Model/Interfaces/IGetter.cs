using System;
using System.Linq.Expressions;

namespace Deipax.Model.Interfaces
{
    public delegate TValue GetDelegate<T, TValue>(
        ref T instance,
        IFormatProvider provider = null);

    public interface IGetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        GetDelegate<T, TValue> GetDelegate<TValue>();
        Expression<GetDelegate<T, TValue>> GetExpression<TValue>();
    }
}