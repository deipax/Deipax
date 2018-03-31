using System;

namespace Deipax.Core.Interfaces
{
    public interface IConvertFactory
    {
        bool GuardCall { get; }
        Func<TFrom, TTo> Get<TFrom, TTo>();
    }

    public interface IResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        Func<TFrom, TTo> Converter { get; }
    }
}