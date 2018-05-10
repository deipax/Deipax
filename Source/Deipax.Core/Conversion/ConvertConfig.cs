using Deipax.Core.Conversion.Factories;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;

namespace Deipax.Core.Conversion
{
    public static class ConvertConfig
    {
        static ConvertConfig()
        {
            DefaultProvider = CultureInfo.InvariantCulture;
            Default = new DefaultFactory();

            _defaults = new List<IConvertFactory>()
            {
                new NoConvert(),
                new ToEnum(),
                new ToOrFromDBNull(),
                new ToString(),
                new ToBool(),
                new ToChar(),
                new ToByte(),
                new ToSByte(),
                new ToShort(),
                new ToUShort(),
                new ToInt(),
                new ToUInt(),
                new ToLong(),
                new ToULong(),
                new ToFloat(),
                new ToDouble(),
                new ToDecimal(),
                new ToDateTime(),
                new FromEnum(),
                new FromString(),
                new FromIConvertible(),
                new FromObject(),
            };
        }

        #region Field Members
        private static IReadOnlyList<IConvertFactory> _defaults;
        #endregion

        #region Public Members
        public static IFormatProvider DefaultProvider { get; set; }
        public static IConvertFactory Default { get; set; }

        public static IConvertResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            IExpArgs<TFrom, TTo> args = new ExpArgs<TFrom, TTo>();

            Expression<Convert<TFrom, TTo>> result = null;

            foreach (var factory in _defaults)
            {
                result = factory.Get(args);

                if (result != null)
                {
                    return new Result<TFrom, TTo>()
                    {
                        Factory = factory,
                        Func = result.Compile(),
                        Expression = result
                    };
                }
            }

            result = Default?.Get(args);

            if (result != null)
            {
                return new Result<TFrom, TTo>()
                {
                    Factory = Default,
                    Func = result.Compile(),
                    Expression = result
                };
            }

            return null;
        }
        #endregion

        #region Helpers
        class Result<TFrom, TTo> : IConvertResult<TFrom, TTo>
        {
            public IConvertFactory Factory { get; set; }
            public Convert<TFrom, TTo> Func { get; set; }
            public Expression<Convert<TFrom, TTo>> Expression { get; set; }
        }

        class ExpArgs<TFrom, TTo> : IExpArgs<TFrom, TTo>
        {
            public ExpArgs()
            {
                FromType = typeof(TFrom);
                UnderlyingFromType = Nullable.GetUnderlyingType(FromType) ?? FromType;
                ToType = typeof(TTo);
                UnderlyingToType = Nullable.GetUnderlyingType(ToType) ?? ToType;

                Input = Expression.Parameter(typeof(TFrom), "input");
                Provider = Expression.Parameter(typeof(IFormatProvider), "provider");
                LabelTarget = Expression.Label(ToType);
                LabelExpression = Expression.Label(LabelTarget, Expression.Default(ToType));
                Default = Expression.Default(ToType);
            }

            #region Field Members
            private List<Expression> _expressions = new List<Expression>();
            private List<ParameterExpression> _variables = new List<ParameterExpression>();
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
            public DefaultExpression Default { get; private set; }

            public void Add(Expression expr)
            {
                if (expr != null)
                {
                    _expressions.Add(expr);
                }
            }

            public void AddVariable(ParameterExpression variable)
            {
                if (variable != null)
                {
                    _variables.Add(variable);
                }
            }

            public Expression<Convert<TFrom, TTo>> Get()
            {
                if (_expressions.Count <= 0)
                {
                    return null;
                }

                BlockExpression block = null;

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

                return Expression.Lambda<Convert<TFrom, TTo>>(block, Input, Provider);
            }
            #endregion
        }
        #endregion
    }
}