using Deipax.Cloning.Common;
using Deipax.Cloning.Interfaces;
using System;

namespace Deipax.Cloning.Factories
{
    internal class NotSupported : ICloneDelFactory
    {
        #region ICloneDelegateFactory Members
        public CloneDel<T> Get<T>()
        {
            return ThrowNotSupportedType;
        }
        #endregion

        #region Private Members
        private static T ThrowNotSupportedType<T>(
            T source,
            ICopyContext context)
        {
            throw new NotSupportedException($"Unable to copy object of type {typeof(T)}.");
        }
        #endregion
    }
}