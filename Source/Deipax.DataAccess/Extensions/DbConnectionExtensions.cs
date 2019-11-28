using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;

namespace Deipax.DataAccess.Interfaces
{
    public static class DbConnectionExtensions
    {
        public static DbParameter CreateParameter(
            this DbConnection source,
            string name = null,
            object value = null,
            ParameterDirection? direction = default,
            DbType? dbType = default,
            int? size = default)
        {
            using (var cmd = source?.CreateCommand())
            {
                var p = cmd.CreateParameter();

                if (!string.IsNullOrEmpty(name))
                {
                    p.ParameterName = name;
                }

                if (value != null)
                {
                    p.Value = value;
                }
                else
                {
                    p.Value = DBNull.Value;
                }

                if (direction.HasValue)
                {
                    p.Direction = direction.Value;
                }

                if (dbType.HasValue)
                {
                    p.DbType = dbType.Value;
                }

                if (size.HasValue)
                {
                    p.Size = size.Value;
                }

                return p;
            }
        }

        public static IEnumerable<DbParameter> CreateParameters(
            this DbConnection source,
            string baseName,
            IEnumerable<object> values)
        {
            List<DbParameter> list = new List<DbParameter>();

            if (values != null)
            {
                var items = values.Where(x => x != null);

                for (int i = 0; i < items.Count(); i++)
                {
                    list.Add(source.CreateParameter(
                        baseName + i.ToString(CultureInfo.InvariantCulture),
                        items.ElementAtOrDefault(i)));
                }
            }

            return list;
        }

        internal static DbConnection OpenSafe(
            this DbConnection source)
        {
            if (source.State != ConnectionState.Open)
            {
                lock (source)
                {
                    if (source.State != ConnectionState.Open)
                    {
                        source.Open();
                    }
                }
            }

            return source;
        }
    }
}