using Deipax.Convert.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Deipax.Convert.Concretes
{
    public class ExpBuilder<TFrom, TTo> : IExpBuilder<TFrom, TTo>
    {
        public ExpBuilder()
        {
            FromType = typeof(TFrom);
            UnderlyingFromType = Nullable.GetUnderlyingType(FromType) ?? FromType;
            ToType = typeof(TTo);
            UnderlyingToType = Nullable.GetUnderlyingType(ToType) ?? ToType;

            Input = Expression.Parameter(typeof(TFrom), "input");
            Provider = Expression.Parameter(typeof(IFormatProvider), "provider");
            LabelTarget = Expression.Label(ToType);
            LabelExpression = Expression.Label(LabelTarget, Expression.Default(ToType));
            DefaultExpression = Expression.Default(ToType);
        }

        #region Field Members
        private readonly List<Expression> _expressions = new List<Expression>();
        private readonly List<ParameterExpression> _variables = new List<ParameterExpression>();
        #endregion

        #region Public Members
        public Type FromType { get; private set; }
        public Type UnderlyingFromType { get; private set; }
        public Type ToType { get; private set; }
        public Type UnderlyingToType { get; private set; }
        public ParameterExpression Input { get; private set; }
        public ParameterExpression Provider { get; private set; }
        public LabelTarget LabelTarget { get; private set; }
        public LabelExpression LabelExpression { get; private set; }
        public DefaultExpression DefaultExpression { get; private set; }

        public IExpBuilder<TFrom, TTo> Add(Expression expr)
        {
            if (expr != null)
            {
                _expressions.Add(expr);
            }

            return this;
        }

        public IExpBuilder<TFrom, TTo> AddVariable(ParameterExpression variable)
        {
            if (variable != null)
            {
                _variables.Add(variable);
            }

            return this;
        }

        public Expression<ConvertDelegate<TFrom, TTo>> Create()
        {
            if (_expressions.Count <= 0)
            {
                return null;
            }

            BlockExpression block;
            if (_variables.Count > 0)
            {
                block = Expression.Block(
                    ToType,
                    _variables,
                    _expressions);
            }
            else
            {
                block = Expression.Block(ToType, _expressions);
            }

            return Expression.Lambda<ConvertDelegate<TFrom, TTo>>(block, Input, Provider);
        }
        #endregion
    }
}
