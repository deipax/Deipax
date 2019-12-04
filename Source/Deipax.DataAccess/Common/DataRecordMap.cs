using Deipax.Model;
using Deipax.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.DataAccess.Common
{
    public static class DataRecordMap<T> where T : new()
    {
        #region Field Members
        private static readonly object _lock = new object();

        private static readonly Dictionary<int, Func<IDataRecord, T>> _cache =
            new Dictionary<int, Func<IDataRecord, T>>();

        private static readonly MethodInfo _getValueMethod = typeof(IDataRecord)
            .GetRuntimeMethods()
            .Where(x => x.Name == nameof(IDataRecord.GetValue))
            .FirstOrDefault();

        private static readonly MethodInfo _createSetNullableField = typeof(DataRecordMap<T>)
            .GetRuntimeMethods()
            .Where(x => x.Name == nameof(DataRecordMap<T>.CreateSetNullableField))
            .FirstOrDefault();
        #endregion

        #region Public Members
        public static Func<IDataRecord, T> Create(DataReaderCache cache)
        {
            if (!_cache.TryGetValue(cache.GetColumnHash(), out Func<IDataRecord, T> func))
            {
                lock (_lock)
                {
                    if (!_cache.TryGetValue(cache.GetColumnHash(), out func))
                    {
                        func = CreateHelper(cache.Reader);
                        _cache.Add(cache.GetColumnHash(), func);
                    }
                }
            }

            return func;
        }
        #endregion

        #region Private Members
        private static Func<IDataRecord, T> CreateHelper(
            IDataReader reader)
        {
            var setters = ModelAccess<T>.Setters;

            var instance = Expression.Variable(typeof(T), "instance");
            var value = Expression.Variable(typeof(object), "value");
            var provider = Expression.Variable(typeof(IFormatProvider), "provider");

            Args args = new Args()
            {
                Instance = instance,
                Record = Expression.Parameter(typeof(IDataRecord), "record"),
                Provider = provider,
                Value = value,
                Expressions = new List<Expression>()
                {
                    Expression.Assign(instance, Expression.New(typeof(T)))
                },
                Variables = new List<ParameterExpression>()
                {
                    instance,
                    value,
                    provider
                }
            };

            for (var i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
                var type = reader.GetFieldType(i);

                if (setters.TryGetValue(name, out ISetter<T> setter) &&
                    setter != null)
                {
                    _createSetNullableField
                        .MakeGenericMethod(new[] { setter.ModelInfo.Type, type })
                        .Invoke(null, new object[] { args, i, setter });
                }
            }

            var labelTarget = Expression.Label(typeof(T));
            var labelExpression = Expression.Label(labelTarget, Expression.Default(typeof(T)));

            args.Expressions.Add(Expression.Return(labelTarget, args.Instance));
            args.Expressions.Add(labelExpression);

            BlockExpression block = Expression.Block(
                args.Variables,
                args.Expressions);

            var lambda = Expression.Lambda<Func<IDataRecord, T>>(
                block,
                args.Record);

            return lambda.Compile();
        }

        private static void CreateSetNullableField<P, X>(
            Args args,
            int fieldIndex,
            ISetter<T> setter)
        {
            var getValueCall = Expression.Call(
                args.Record,
                _getValueMethod,
                Expression.Constant(fieldIndex));

            var setCall = Expression.Invoke(
                setter.GetExpression<X>(),
                args.Instance,
                Expression.Convert(args.Value, typeof(X)),
                args.Provider);

            var isDbNull = Expression.Equal(
                args.Value,
                Expression.Constant(DBNull.Value, typeof(object)));

            args.Expressions.Add(Expression.Assign(
                args.Value,
                getValueCall));

            args.Expressions.Add(Expression.IfThen(
                Expression.Not(isDbNull),
                setCall));
        }
        #endregion

        #region Helper
        class Args
        {
            public ParameterExpression Instance { get; set; }
            public ParameterExpression Record { get; set; }
            public ParameterExpression Value { get; set; }
            public ParameterExpression Provider { get; set; }
            public List<ParameterExpression> Variables { get; set; }
            public List<Expression> Expressions { get; set; }
        }
        #endregion
    }
}