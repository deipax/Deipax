using System;
using Deipax.Cloning.Common;
using Deipax.Cloning.Concretes;
using Deipax.Cloning.Interfaces;
using System.Threading;

namespace Deipax.Cloning.Extensions
{
    public static class CloneExtensions
    {
        #region Field Members
        private static readonly ThreadLocal<ICopyContext> _context =
            new ThreadLocal<ICopyContext>(() => DefaultContext == null ? new CopyContext() : DefaultContext());
        #endregion

        #region Public Members
        public static Func<ICopyContext> DefaultContext;

        public static T GetClone<T>(
            this T source)
        {
            var context = _context.Value;
            try
            {
                return Cloner<T>.Get(source, context);
            }
            finally
            {
                context.Reset();
            }
        }

        public static T GetClone<T>(
            this T source,
            ICopyContext context)
        {
            return Cloner<T>.Get(source, context);
        }
        #endregion
    }
}