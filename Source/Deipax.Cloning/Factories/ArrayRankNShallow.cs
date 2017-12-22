using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;

namespace Deipax.Cloning.Factories
{
    class ArrayRankNShallow : ICloneDelFactory
    {
        #region ICloneDelFactory Members 
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsArray &&
                type.GetArrayRank() > 2 &&
                type.HasElementType)
            {
                var elementType = type.GetElementType();

                if (elementType.CanShallowClone())
                {
                    return Copy;
                }
            }

            return null;
        }
        #endregion

        #region Private Members
        private static T Copy<T>(T source, CopyContext context)
        {
            if (context.TryGetCopy(source, out var existingCopy))
            {
                return (T)existingCopy;
            }

            var sourceAsArray = source as Array;

            if (sourceAsArray == null)
            {
                throw new InvalidCastException($"Cannot cast non-array type {source?.GetType()} to Array.");
            }

            var elementType = source.GetType().GetElementType();

            var rank = sourceAsArray.Rank;
            var lengths = new int[rank];
            for (var i = 0; i < rank; i++)
            {
                lengths[i] = sourceAsArray.GetLength(i);
            }

            var target = Array.CreateInstance(elementType, lengths);
            context.RecordCopy(sourceAsArray, target);
            Array.Copy(sourceAsArray, target, sourceAsArray.Length);

            return (T)(object)target;
        }
        #endregion
    }
}
