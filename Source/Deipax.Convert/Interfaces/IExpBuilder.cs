using System;
using System.Linq.Expressions;

namespace Deipax.Convert.Interfaces
{
    public interface IExpBuilder<TFrom, TTo>
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

        IExpBuilder<TFrom, TTo> Add(Expression expr);
        IExpBuilder<TFrom, TTo> AddVariable(ParameterExpression variable);
        Expression<ConvertDelegate<TFrom, TTo>> Create();
    }
}
