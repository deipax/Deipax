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
            Args args = new Args()
            {
                Expressions = new List<Expression>(),
                Instance = Expression.Variable(typeof(T), "instance"),
                Record = Expression.Parameter(typeof(IDataRecord), "record"),
                Provider = Expression.Variable(typeof(IFormatProvider), "provider"),
                Value = Expression.Variable(typeof(object), "value"),
            };

            args.Variables = new List<ParameterExpression>()
            {
                args.Instance,
                args.Value,
                args.Provider
            };

            args.Expressions.Add(Expression.Assign(
                args.Instance,
                Expression.New(typeof(T))));



            var setters = ModelAccess<T>.Setters;
            int fieldCount = r.FieldCount;

            for (var i = 0; i < fieldCount; i++)
            {
                if (setters.TryGetValue(r.GetName(i), out ISetter<T> setter) &&
                    setter != null)
                {
                    var fieldType = r.GetFieldType(i);

                    var setCall = (Expression)_createSetField
                        .MakeGenericMethod(new[] { setter.ModelInfo.Type, fieldType })
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

        private static void CreateSetField<P, X>(
            Args args,
            int fieldIndex,
            ISetter<T> setter)
        {
            var isDbNull = Expression.Equal(
                args.Value,
                Expression.Constant(DBNull.Value, typeof(object)));

            var getValueCall = Expression.Call(
                args.Record,
                _getValueMethod,
                Expression.Constant(fieldIndex));

            args.Expressions.Add(Expression.Assign(
                args.Value,
                getValueCall));

            var setCall = Expression.Invoke(
                setter.GetExpression<X>(),
                args.Instance,
                Expression.Convert(args.Value, typeof(X)),
                args.Provider);

            var ifThenElse = Expression.IfThen(
                Expression.Not(isDbNull),
                setCall);

            args.Expressions.Add(ifThenElse);
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