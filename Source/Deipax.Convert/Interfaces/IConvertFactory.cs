using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Interfaces
{
    public delegate TTo ConvertDelegate<TFrom, TTo>(
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
        DefaultExpression DefaultExpression { get; }

        IExpArgs<TFrom, TTo> Add(Expression expr);
        IExpArgs<TFrom, TTo> AddVariable(ParameterExpression variable);
        Expression<ConvertDelegate<TFrom, TTo>> Create();
    }

    public interface IConvertFactory
    {
        IConvertResult<TFrom, TTo> Create<TFrom, TTo>(IExpArgs<TFrom, TTo> args);
    }

    public interface IConvertResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        ConvertDelegate<TFrom, TTo> Func { get; }
        Expression<ConvertDelegate<TFrom, TTo>> Expression { get; }
    }
}