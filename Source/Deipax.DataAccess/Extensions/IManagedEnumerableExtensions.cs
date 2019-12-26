using Deipax.DataAccess.Interfaces;
using System;
using System.Linq;

namespace Deipax.DataAccess.Extensions
{
    public static class IManagedEnumerableExtensions
    {
        /// <summary>
        ///  Returns the first element of a sequence.  Cleans up all db resources.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ExecuteFirst<T>(
            this IManagedEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            using (source)
            {
                return source.First();
            }
        }

        /// <summary>
        ///  Returns the first element of a sequence, or a default value if the sequence contains
        ///  no elements.  Cleans up all db resources.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ExecuteFirstOrDefault<T>(
            this IManagedEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            using (source)
            {
                return source.FirstOrDefault();
            }
        }

        /// <summary>
        ///  Returns the only element of a sequence, and throws an exception if there is not
        ///  exactly one element in the sequence.  Cleans up all db resources.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ExecuteSingle<T>(
            this IManagedEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            using (source)
            {
                return source.Single();
            }
        }

        /// <summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.  Cleans up all db resources.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ExecuteSingleOrDefault<T>(
            this IManagedEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            using (source)
            {
                return source.SingleOrDefault();
            }
        }
    }
}
