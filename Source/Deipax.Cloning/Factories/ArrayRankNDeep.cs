using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System;

namespace Deipax.Cloning.Factories
{
    internal class ArrayRankNDeep : ICloneDelFactory
    {
        #region ICloneDelFactory Members 
        public CloneDel<T> Create<T>()
        {
            var type = typeof(T);

            if (type.IsArray &&
                type.GetArrayRank() > 2 &&
                type.HasElementType)
            {
                var elementType = type.GetElementType();

                if (!elementType.CanShallowClone())
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

            if (!(source is Array sourceAsArray))
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

            var index = new int[rank];
            var sizes = new int[rank];
            sizes[rank - 1] = 1;

            for (var k = rank - 2; k >= 0; k--)
            {
                sizes[k] = sizes[k + 1] * lengths[k + 1];
            }

            for (var i = 0; i < sourceAsArray.Length; i++)
            {
                var k = i;

                for (var n = 0; n < rank; n++)
                {
                    var offset = k / sizes[n];
                    k = k - offset * sizes[n];
                    index[n] = offset;
                }

                // using objects will cause a performance issue
                // for value types due to boxing/unboxing.  
                // TODO: Find a way to deal with this in a strongly 
                // typed fashion.
                object sourceItem = sourceAsArray.GetValue(index);

                if (sourceItem != null)
                {
                    target.SetValue(Cloner<object>.Get(sourceItem, context), index);
                }
            }

            return (T)(object)target;
        }
        #endregion
    }
}