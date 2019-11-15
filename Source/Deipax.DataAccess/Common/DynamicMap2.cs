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
    public static class DynamicMap2
    {
        #region Field Members
        private static readonly ConcurrentDictionary<int, IEnumerable<string>> _headers = 
            new ConcurrentDictionary<int, IEnumerable<string>>();

        private static readonly ConcurrentDictionary<int, Func<IDataRecord, DynamicTable, DynamicRow>> _maps = 
            new ConcurrentDictionary<int, Func<IDataRecord, DynamicTable, DynamicRow>>();

        private static readonly MethodInfo _getValueMethod = typeof(IDataRecord)
            .GetRuntimeMethods()
            .Where(x => x.Name == "GetValue")
            .FirstOrDefault();

        private static readonly ConstructorInfo _constructor = typeof(DynamicRow)
            .GetConstructors()
            .First();
        #endregion

        #region Public Members
        public static DynamicTable GetTable(IDataReader r)
        {
            return new DynamicTable(_headers.GetOrAdd(r.GetColumnHash(), x => CreateHeaders(r)));
        }

        public static Func<IDataRecord, DynamicTable, DynamicRow> CreateMap(IDataReader r)
        {
            return _maps.GetOrAdd(r.GetColumnHash(), x => Create(r));
        }
        #endregion

        #region Private Members
        private static IEnumerable<string> CreateHeaders(IDataReader r)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < r.FieldCount; i++)
            {
                list.Add(r.GetName(i));
            }

            return list;
        }

        private static Func<IDataRecord, DynamicTable, DynamicRow> Create(IDataReader r)
        {
            var table = Expression.Parameter(typeof(DynamicTable), "table");
            var record = Expression.Parameter(typeof(IDataRecord), "record");
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
                var getValueCall = Expression.Call(
                    record,
                    _getValueMethod,
                    Expression.Constant(fieldIndex));

                expressions.Add(Expression.Assign(
                    Expression.ArrayAccess(values, Expression.Constant(fieldIndex)),
                    getValueCall));
            }

            expressions.Add(Expression.Assign(
                returnItem,
                Expression.New(_constructor, table, values)));

            expressions.Add(Expression.Return(labelTarget, returnItem));
            expressions.Add(labelExpression);

            var block = Expression.Block(
                typeof(DynamicRow),
                new[] { values, returnItem },
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