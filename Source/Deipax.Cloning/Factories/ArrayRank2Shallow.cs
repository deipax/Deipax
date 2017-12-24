﻿using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class ArrayRank2Shallow : ICloneDelFactory
    {
        #region Field Members
        private static MethodInfo _methodInfo = typeof(ArrayRank2Shallow)
            .GetRuntimeMethods()
            .Where(x => x.Name == "Copy")
            .FirstOrDefault();
        #endregion

        #region ICloneDelFactory Members 
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsArray &&
                type.GetArrayRank() == 2 &&
                type.HasElementType)
            {
                var elementType = type.GetElementType();

                if (elementType.CanShallowClone())
                {
                    return (CloneDel<T>)_methodInfo.MakeGenericMethod(elementType).CreateDelegate(typeof(CloneDel<T>));
                }
            }

            return null;
        }
        #endregion

        #region Private Members
        private static T[,] Copy<T>(T[,] source, CopyContext context)
        {
            if (context.TryGetCopy(source, out var existingCopy))
            {
                return (T[,])existingCopy;
            }

            var lenI = source.GetLength(0);
            var lenJ = source.GetLength(1);
            var result = new T[lenI, lenJ];
            context.RecordCopy(source, result);
            Array.Copy(source, result, source.Length);
            return result;
        }
        #endregion
    }
}