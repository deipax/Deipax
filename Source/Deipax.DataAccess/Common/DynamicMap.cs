using Deipax.Core.Common;
using Deipax.DataAccess.Extensions;
using System;
using System.Collections.Concurrent;
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
        private static readonly ConcurrentDictionary<int, Func<IDataRecord, DynamicDictionary>> _cache =
            new ConcurrentDictionary<int, Func<IDataRecord, DynamicDictionary>>();

        private readonly static MethodInfo _addMethod = typeof(DynamicDictionary)
            .GetRuntimeMethods()
            .Where(x => x.Name == "Add")
            .FirstOrDefault();

        private readonly static MethodInfo _getValueMethod = typeof(IDataRecord)
            .GetRuntimeMethods()
            .Where(x => x.Name == "GetValue")
            .FirstOrDefault();
        #endregion

        #region Public Members
        public static Func<IDataRecord, DynamicDictionary> Create(IDataReader r)
        {
            return _cache.GetOrAdd(r.GetColumnHash(), x => CreateHelper(r));
        }
        #endregion

        #region Private Members
        private static Func<IDataRecord, DynamicDictionary> CreateHelper(IDataReader r)
        {
            var record = Expression.Parameter(typeof(IDataRecord), "input");
            var value = Expression.Parameter(typeof(object), "value");
            var returnItem = Expression.Variable(typeof(DynamicDictionary), "returnItem");

            var labelTarget = Expression.Label(typeof(DynamicDictionary));

            var labelExpression = Expression.Label(
                labelTarget,
                Expression.Default(typeof(DynamicDictionary)));

            List<Expression> expressions = new List<Expression>
            {
                Expression.Assign(
                returnItem,
                Expression.New(typeof(DynamicDictionary)))
            };

            for (int i = 0; i < r.FieldCount; i++)
            {
                string fieldName = r.GetName(i);
                Type fieldType = r.GetFieldType(i);

                var getValueCall = Expression.Call(
                    record,
                    _getValueMethod,
                    Expression.Constant(i));

                var isDbNull = Expression.Equal(
                    value,
                    Expression.Constant(DBNull.Value, typeof(object)));

                var setValue = Expression.Call(
                    returnItem,
                    _addMethod,
                    Expression.Constant(fieldName),
                    value);

                var setDefault = Expression.Call(
                    returnItem,
                    _addMethod,
                    Expression.Constant(fieldName),
                    Expression.Convert(Expression.Default(fieldType), typeof(object)));

                expressions.Add(Expression.Assign(
                    value,
                    getValueCall));

                expressions.Add(Expression.IfThenElse(
                    isDbNull,
                    setDefault,
                    setValue));
            }

            expressions.Add(Expression.Return(labelTarget, returnItem));
            expressions.Add(labelExpression);

            var block = Expression.Block(
                typeof(DynamicDictionary),
                new[] { returnItem, value },
                expressions);

            var lambda = Expression.Lambda<Func<IDataRecord, DynamicDictionary>>(
                block,
                record);

            return lambda.Compile();
        }
        #endregion
    }
}