using Deipax.Cloning.Common;
using System.Threading;

namespace Deipax.Cloning.Extensions
{
    public static class CloneExtensions
    {
        #region Field Members
        private static readonly ThreadLocal<CopyContext> _context =
            new ThreadLocal<CopyContext>(() =>  new CopyContext());
        #endregion

        #region Public Members
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
        #endregion
    }
}