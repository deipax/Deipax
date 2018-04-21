using System;
using System.Linq.Expressions;

namespace Deipax.Core.Interfaces
{
    public delegate TTo Convert<TFrom, TTo>(
        TFrom from,
        IFormatProvider provider = null);

    public interface IExpArgs<TFrom, TTo>
    {
        Type FromType { get; }
        Type UnderlyingFromType { get; }
        Type ToType { get; }
        Type UnderlyingToType { get; }
        ParameterExpression Input { get; }
        ParameterExpression Provider { get; }
        LabelTarget LabelTarget { get; }
        LabelExpression LabelExpression { get; }
        DefaultExpression Default { get; }

        void Add(Expression expr);
        void AddVariable(ParameterExpression variable);
        Convert<TFrom, TTo> GetConvertResult();
    }

    public interface IConvertFactory
    {
        Convert<TFrom, TTo> Get<TFrom, TTo>(IExpArgs<TFrom, TTo> args);
    }

    public interface IConvertResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        Convert<TFrom, TTo> Func { get; }
    }
}