using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.DataAccess.Common
{
    public class DataRecordMap<T> where T : new()
    {
        static DataRecordMap()
        {
            _cache = new ConcurrentDictionary<int, Func<IDataRecord, T>>();
        }

        #region Field Members
        private static ConcurrentDictionary<int, Func<IDataRecord, T>> _cache;

        private static MethodInfo _getValueMethod = typeof(IDataRecord)
            .GetRuntimeMethods()
            .Where(x => x.Name == "GetValue")
            .FirstOrDefault();

        private static MethodInfo _createSetNullableField = typeof(DataRecordMap<T>)
            .GetRuntimeMethods()
            .Where(x => x.Name == "CreateSetNullableField")
            .FirstOrDefault();
        #endregion

        #region Public Members
        public static Func<IDataRecord, T> Create(IDataReader r)
        {
            return _cache.GetOrAdd(GetColumnHash(r), x => CreateHelper(r)); ;
        }
        #endregion

        #region Private Members
        private static int GetColumnHash(
            IDataReader reader,
            int startBound = 0,
            int length = -1)
        {
            unchecked
            {
                int max = length < 0 ? reader.FieldCount : startBound + length;
                int hash = (-37 * startBound) + max;
                for (int i = startBound; i < max; i++)
                {
                    object tmp = reader.GetName(i);
                    hash = (-79 * ((hash * 31) + (tmp?.GetHashCode() ?? 0))) + (reader.GetFieldType(i)?.GetHashCode() ?? 0);
                }
                return hash;
            }
        }

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

            var columns = reader
                .GetSchemaTable()
                .Rows
                .OfType<DataRow>()
                .Select(x => new
                {
                    Name = (string)x[0],
                    Type = (Type)x[12],
                    AllowNull = (bool)x[13]
                })
                .ToList();

            for (var i = 0; i < columns.Count; i++)
            {
                var column = columns[i];

                if (setters.TryGetValue(column.Name, out ISetter<T> setter) &&
                    setter != null)
                {
                    _createSetNullableField
                        .MakeGenericMethod(new[] { setter.ModelInfo.Type, column.Type })
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