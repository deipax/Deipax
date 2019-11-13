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
            _defaultFactory = new DefaultFactory();

            _defaultFactories = new List<IConvertFactory>()
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
        private static IReadOnlyList<IConvertFactory> _defaultFactories;
        private static IConvertFactory _defaultFactory;
        #endregion

        #region Public Members
        public static IConvertFactory DefaultFactory { get; set; }
        public static IReadOnlyList<IConvertFactory> Factories { get; set; }

        public static IConvertResult<TFrom, TTo> Get<TFrom, TTo>()
        {
            var args = new ExpArgs<TFrom, TTo>();

            var result = GetResult(Factories, args);
            if (result != null) return result;

            result = GetResult(_defaultFactories, args);
            if (result != null) return result;

            result = GetResult(DefaultFactory, args);
            if (result != null) return result;

            return GetResult(_defaultFactory, args);
        }
        #endregion

        #region Private Members
        private static Result<TFrom, TTo> GetResult<TFrom, TTo>(
            IReadOnlyList<IConvertFactory> factories,
            IExpArgs<TFrom, TTo> args)
        {
            return factories?
                .Select(x => GetResult(x, args))
                .FirstOrDefault(x => x != null);
        }

        private static Result<TFrom, TTo> GetResult<TFrom, TTo>(
            IConvertFactory factory,
            IExpArgs<TFrom, TTo> args)
        {
            var result = factory?.Get(args);

            if (result != null)
            {
                return new Result<TFrom, TTo>()
                {
                    Factory = factory,
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