using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Linq;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class ArrayRank1Deep : ICloneDelFactory
    {
        #region Field Members
        private static MethodInfo _methodInfo = typeof(ArrayRank1Deep)
            .GetRuntimeMethods()
            .Where(x => x.Name == "Copy")
            .FirstOrDefault();
        #endregion

        #region ICloneDelFactory Members
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsArray &&
                type.GetArrayRank() == 1 &&
                type.HasElementType)
            {
                var elementType = type.GetElementType();

                if (!elementType.CanShallowClone())
                {
                    return (CloneDel<T>)_methodInfo.MakeGenericMethod(elementType).CreateDelegate(typeof(CloneDel<T>));
                }
            }

            return null;
        }
        #endregion

        #region Private Members
        private static T[] Copy<T>(T[] source, CopyContext context)
        {
            if (context.TryGetCopy(source, out var existingCopy))
            {
                return (T[])existingCopy;
            }
            var length = source.Length;
            var target = new T[length];

            context.RecordCopy(source, target);

            for (var i = 0; i < length; i++)
            {
                T sourceItem = source[i];

                if (sourceItem != null)
                {
                    target[i] = Cloner<T>.Get(sourceItem, context);
                }
            }

            return target;
        }
        #endregion
    }
}