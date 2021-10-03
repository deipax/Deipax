using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Interfaces
{
    public delegate TTo ConvertDelegate<TFrom, TTo>(
        TFrom from,
        IFormatProvider provider = null);

    public interface IConvertFactory
    {
        IConvertResult<TFrom, TTo> Create<TFrom, TTo>();
    }

    public interface IConvertResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        ConvertDelegate<TFrom, TTo> Func { get; }
        Expression<ConvertDelegate<TFrom, TTo>> Expression { get; }
    }
}