using System;

namespace Deipax.Core.Interfaces
{
    public interface IConvertFactory
    {
        IResult<TFrom, TTo> Get<TFrom, TTo>();
    }

    public interface IResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        Func<TFrom, TTo> Func { get; }
        bool GuardCall { get; }
    }
}