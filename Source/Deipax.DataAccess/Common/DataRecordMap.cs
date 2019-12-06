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

        private static readonly MethodInfo _getSetExpressionHelper = typeof(DataRecordMap<T>)
            .GetRuntimeMethods()
            .Where(x => x.Name == nameof(DataRecordMap<T>.GetSetExpressionHelper))
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
            var record = Expression.Parameter(typeof(IDataRecord), "record");

            var expressions = new List<Expression>
            {
                Expression.Assign(instance, Expression.New(typeof(T)))
            };

            for (var fieldIndex = 0; fieldIndex < reader.FieldCount; fieldIndex++)
            {
                var fieldName = reader.GetName(fieldIndex);
                var fieldType = reader.GetFieldType(fieldIndex);

                if (setters.TryGetValue(fieldName, out ISetter<T> setter) &&
                    setter != null)
                {
                    var getValueCall = Expression.Call(
                        record,
                        _getValueMethod,
                        Expression.Constant(fieldIndex));

                    var isNotDbNull = Expression.NotEqual(
                        value,
                        Expression.Constant(DBNull.Value, typeof(object)));

                    // Unbox the value and set the value on the instance
                    var setCall = Expression.Invoke(
                        GetSetExpression(setter, fieldType),
                        instance,
                        Expression.Convert(value, fieldType),
                        provider);

                    // Get the Value
                    expressions.Add(Expression.Assign(
                        value,
                        getValueCall));

                    // Only bother setting the value if is not dbnull,
                    // otherwise let the field stay at the default value
                    expressions.Add(Expression.IfThen(
                        isNotDbNull,
                        setCall));
                }
            }

            var labelTarget = Expression.Label(typeof(T));
            var labelExpression = Expression.Label(labelTarget, Expression.Default(typeof(T)));

            expressions.Add(Expression.Return(labelTarget, instance));
            expressions.Add(labelExpression);

            BlockExpression block = Expression.Block(
                new[] { instance, value, provider },
                expressions);

            var lambda = Expression.Lambda<Func<IDataRecord, T>>(
                block,
                record);

            return lambda.Compile();
        }

        private static Expression GetSetExpression(
            ISetter<T> setter, 
            Type fieldType)
        {
            return (Expression)_getSetExpressionHelper
                .MakeGenericMethod(new[] { fieldType })
                .Invoke(null, new object[] { setter });
        }

        private static Expression GetSetExpressionHelper<X>(ISetter<T> setter)
        {
            return setter.GetExpression<X>();
        }
        #endregion
    }
}