using Deipax.Convert.Factories;
using Deipax.Convert.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Convert
{
    public static class ConvertConfig
    {
        static ConvertConfig()
        {
            DefaultFactories = new List<IConvertFactory>()
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
        private static readonly IConvertFactory _defaultFactory = new DefaultFactory();
        #endregion

        #region Public Members
        public static IConvertFactory DefaultFactory { get; set; }
        public static IReadOnlyList<IConvertFactory> Factories { get; set; }
        public static IReadOnlyList<IConvertFactory> DefaultFactories { get; private set; }

        public static IConvertResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            var args = new ExpArgs<TFrom, TTo>();

            var result = GetResult(Factories, args);
            if (result != null) return result;

            result = GetResult(DefaultFactories, args);
            if (result != null) return result;

            result = DefaultFactory?.Create(args);
            if (result != null) return result;

            return _defaultFactory?.Create(args);
        }
        #endregion

        #region Private Members
        private static IConvertResult<TFrom, TTo> GetResult<TFrom, TTo>(
            IReadOnlyList<IConvertFactory> factories,
            IExpArgs<TFrom, TTo> args)
        {
            return factories?
                .Select(x => x.Create(args))
                .FirstOrDefault(x => x != null);
        }
        #endregion

        #region Helpers
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

            public IExpArgs<TFrom, TTo> Add(Expression expr)
            {
                if (expr != null)
                {
                    _expressions.Add(expr);
                }

                return this;
            }

            public IExpArgs<TFrom, TTo> AddVariable(ParameterExpression variable)
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
        #endregion
    }
}