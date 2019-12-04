using Deipax.Core.Common;
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
        private static readonly object _mapLock = new object();
        private static readonly object _headerLock = new object();

        private static readonly Dictionary<int, string[]> _headers =
            new Dictionary<int, string[]>();

        private static readonly Dictionary<int, Func<IDataRecord, DynamicTable, DynamicRow>> _maps =
            new Dictionary<int, Func<IDataRecord, DynamicTable, DynamicRow>>();

        private static readonly MethodInfo _getValueMethod = typeof(IDataRecord)
            .GetRuntimeMethods()
            .Where(x => x.Name == nameof(IDataRecord.GetValue))
            .FirstOrDefault();

        private static readonly ConstructorInfo _constructor = typeof(DynamicRow)
            .GetConstructors()
            .First();
        #endregion

        #region Public Members
        public static DynamicTable GetTable(DataReaderCache cache)
        {
            if (!_headers.TryGetValue(cache.GetColumnHash(), out string[] header))
            {
                lock (_headerLock)
                {
                    if (!_headers.TryGetValue(cache.GetColumnHash(), out header))
                    {
                        header = CreateHeaders(cache.Reader);
                        _headers.Add(cache.GetColumnHash(), header);
                    }
                }
            }

            string[] target = new string[header.Length];
            Array.Copy(header, 0, target, 0, header.Length);

            return new DynamicTable(target);
        }

        public static Func<IDataRecord, DynamicTable, DynamicRow> CreateMap(DataReaderCache cache)
        {
            if (!_maps.TryGetValue(cache.GetColumnHash(), out Func<IDataRecord, DynamicTable, DynamicRow> func))
            {
                lock (_mapLock)
                {
                    if (!_maps.TryGetValue(cache.GetColumnHash(), out func))
                    {
                        func = Create(cache.Reader);
                        _maps.Add(cache.GetColumnHash(), func);
                    }
                }
            }

            return func;
        }
        #endregion

        #region Private Members
        private static string[] CreateHeaders(IDataReader r)
        {
            string[] list = new string[r.FieldCount];

            for (int i = 0; i < r.FieldCount; i++)
            {
                list[i] = r.GetName(i);
            }

            return list;
        }

        private static Func<IDataRecord, DynamicTable, DynamicRow> Create(IDataReader r)
        {
            var table = Expression.Parameter(typeof(DynamicTable), "table");
            var record = Expression.Parameter(typeof(IDataRecord), "record");
            var value = Expression.Parameter(typeof(object), "value");
            var values = Expression.Variable(typeof(object[]), "values");
            var returnItem = Expression.Variable(typeof(DynamicRow), "returnItem");

            var labelTarget = Expression.Label(typeof(DynamicRow));

            var labelExpression = Expression.Label(
                labelTarget,
                Expression.Default(typeof(DynamicRow)));

            List<Expression> expressions = new List<Expression>
            {
                Expression.Assign(
                values,
                Expression.NewArrayBounds(typeof(object), Expression.Constant(r.FieldCount)))
            };

            for (int fieldIndex = 0; fieldIndex < r.FieldCount; fieldIndex++)
            {
                Type fieldType = r.GetFieldType(fieldIndex);

                var getValueCall = Expression.Call(
                    record,
                    _getValueMethod,
                    Expression.Constant(fieldIndex));

                var isDbNull = Expression.Equal(
                    value,
                    Expression.Constant(DBNull.Value, typeof(object)));

                var setValue = Expression.Assign(
                    Expression.ArrayAccess(values, Expression.Constant(fieldIndex)),
                    value);

                var setDefault = Expression.Assign(
                    Expression.ArrayAccess(values, Expression.Constant(fieldIndex)),
                    Expression.Convert(Expression.Default(fieldType), typeof(object)));

                expressions.Add(Expression.Assign(
                    value,
                    getValueCall));

                expressions.Add(Expression.IfThenElse(
                    isDbNull,
                    setDefault,
                    setValue));
            }

            expressions.Add(Expression.Assign(
                returnItem,
                Expression.New(_constructor, table, values)));

            expressions.Add(Expression.Return(labelTarget, returnItem));
            expressions.Add(labelExpression);

            var block = Expression.Block(
                typeof(DynamicRow),
                new[] { values, returnItem, value },
                expressions);

            var lambda = Expression.Lambda<Func<IDataRecord, DynamicTable, DynamicRow>>(
                block,
                record,
                table);

            return lambda.Compile();
        }
        #endregion
    }
}