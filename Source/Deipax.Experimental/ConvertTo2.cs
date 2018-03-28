using System;

namespace Deipax.Core.Conversion
{
    public static class ConvertTo2<T,X>
    {
        static ConvertTo2()
        {
            Reset();
        }

        #region Field Members
        private static Func<X, T> _func;
        #endregion

        #region Public Members
        public static T From(X from)
        {
            return _func(from);
        }

        public static void Reset()
        {
            _func = ConvertConfig.Get<X, T>();
        }
        #endregion
    }
}