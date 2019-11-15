using System;
using System.Linq.Expressions;

namespace Deipax.Model.Interfaces
{
    public delegate void SetDelegate<T, TValue>(
        ref T instance,
        TValue value,
        IFormatProvider provider = null);

    public interface ISetter<T>
    {
        string Name { get; }
        IModelInfo ModelInfo { get; }
        SetDelegate<T, TValue> GetDelegate<TValue>();
        Expression<SetDelegate<T, TValue>> GetExpression<TValue>();
    }
}