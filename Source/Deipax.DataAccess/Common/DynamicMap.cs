using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.DataAccess.Common
{
    public static class DynamicMap
    {
        #region Field Members
        private static readonly object _lock = new object();

        private static readonly Dictionary<int, Func<IDataRecord, object>> _maps =
            new Dictionary<int, Func<IDataRecord, object>>();

        private static readonly MethodInfo _getValueMethod = typeof(IDataRecord)
            .GetRuntimeMethods()
            .Where(x => x.Name == nameof(IDataRecord.GetValue))
            .FirstOrDefault();
        #endregion

        #region Public Members
        public static Func<IDataRecord, object> CreateMap(DataReaderCache cache)
        {
            if (cache == null) throw new ArgumentNullException(nameof(cache));

            if (!_maps.TryGetValue(cache.GetColumnHash(), out Func<IDataRecord, object> func))
            {
                lock (_lock)
                {
                    if (!_maps.TryGetValue(cache.GetColumnHash(), out func))
                    {
                        func = Create(cache);
                        _maps.Add(cache.GetColumnHash(), func);
                    }
                }
            }

            return func;
        }
        #endregion

        #region Private Members
        private static Func<IDataRecord, object> Create(DataReaderCache cache)
        {
            Type instanceType = DynamicType.Get(cache);

            var instance = Expression.Variable(instanceType, "instance");
            var value = Expression.Variable(typeof(object), "value");
            var record = Expression.Parameter(typeof(IDataRecord), "record");

            var expressions = new List<Expression>
            {
                Expression.Assign(instance, Expression.New(instanceType))
            };

            for (var fieldIndex = 0; fieldIndex < cache.Reader.FieldCount; fieldIndex++)
            {
                var fieldName = cache.Reader.GetName(fieldIndex);
                var fieldType = cache.Reader.GetFieldType(fieldIndex);

                var getValueCall = Expression.Call(
                    record,
                    _getValueMethod,
                    Expression.Constant(fieldIndex));

                var isNotDbNull = Expression.NotEqual(
                    value,
                    Expression.Constant(DBNull.Value, typeof(object)));

                var memberExpression = Expression.MakeMemberAccess(
                    instance,
                    instanceType.GetField(fieldName));

                var setCall = Expression.Assign(
                    memberExpression,
                    Expression.Convert(value, fieldType));

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

            var labelTarget = Expression.Label(typeof(object));
            var labelExpression = Expression.Label(labelTarget, Expression.Default(typeof(object)));

            expressions.Add(Expression.Return(
                labelTarget,
                Expression.Convert(instance, typeof(object))));

            expressions.Add(labelExpression);

            BlockExpression block = Expression.Block(
                new[] { instance, value },
                expressions);

            var lambda = Expression.Lambda<Func<IDataRecord, object>>(
                block,
                record);

            return lambda.Compile();
        }
        #endregion
    }
}