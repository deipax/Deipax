using System;
using System.Data;

namespace Deipax.DataAccess.Extensions
{
    public static class IDataReaderExtensions
    {
        public static int GetColumnHash(
            this IDataReader source,
            int startBound = 0,
            int length = -1)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            unchecked
            {
                int max = length < 0 ? source.FieldCount : startBound + length;
                int hash = (-37 * startBound) + max;
                for (int i = startBound; i < max; i++)
                {
                    object tmp = source.GetName(i);
                    hash = (-79 * ((hash * 31) + (tmp?.GetHashCode() ?? 0))) +
                           (source.GetFieldType(i)?.GetHashCode() ?? 0);
                }

                return hash;
            }
        }
    }
}
