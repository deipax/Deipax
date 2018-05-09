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

        private static MethodInfo _createSetField = typeof(DataRecordMap<T>)
            .GetRuntimeMethods()
            .Where(x => x.Name == "CreateSetField")
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

        private static Func<IDataRecord, T> CreateHelper(IDataReader r)
        {
            var instance = Expression.Variable(typeof(T), "instance");
            var record = Expression.Parameter(typeof(IDataRecord), "record");
            var provider = Expression.Variable(typeof(IFormatProvider), "provider");
            var value = Expression.Variable(typeof(object), "value");
            var labelTarget = Expression.Label(typeof(T));
            var labelExpression = Expression.Label(labelTarget, Expression.Default(typeof(T)));

            var isNullOrDbNull = Expression.Or(
                Expression.Equal(value, Expression.Constant(DBNull.Value, typeof(object))),
                Expression.Equal(value, Expression.Constant(null, typeof(object))));

            List<Expression> expressions = new List<Expression>();

            expressions.Add(Expression.Assign(
                instance,
                Expression.New(typeof(T))));

            var setters = ModelAccess<T>.Setters;
            int fieldCount = r.FieldCount;

            for (var i = 0; i < fieldCount; i++)
            {
                if (setters.TryGetValue(r.GetName(i), out ISetter<T> setter) &&
                    setter != null)
                {
                    var fieldType = r.GetFieldType(i);

                    var getValueCall = Expression.Call(
                        record,
                        _getValueMethod,
                        Expression.Constant(i));

                    expressions.Add(Expression.Assign(value, getValueCall));

                    var setCall = (InvocationExpression)_createSetField
                        .MakeGenericMethod(new[] { fieldType })
                        .Invoke(null, new object[] { instance, value, provider, setter });

                    var ifThenElse = Expression.IfThen(
                        Expression.Not(isNullOrDbNull),
                        setCall);

                    expressions.Add(ifThenElse);
                }
            }

            expressions.Add(Expression.Return(labelTarget, instance));
            expressions.Add(labelExpression);

            BlockExpression block = Expression.Block(
                new[] { value, instance, provider },
                expressions);

            var lambda = Expression.Lambda<Func<IDataRecord, T>>(
                block,
                record);

            return lambda.Compile();
        }

        private static InvocationExpression CreateSetField<X>(
            ParameterExpression instance,
            ParameterExpression value,
            ParameterExpression provider,
            ISetter<T> setter)
        {
            return Expression.Invoke(
                setter.GetExpression<X>(),
                instance,
                Expression.Convert(value, typeof(X)),
                provider);
        }
        #endregion
    }
}