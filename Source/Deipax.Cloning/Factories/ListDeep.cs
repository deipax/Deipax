using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class ListDeep : ICloneDelFactory
    {
        #region Field Members
        private static MethodInfo _methodInfo = typeof(ListDeep)
            .GetRuntimeMethods()
            .Where(x => x.Name == "Copy")
            .FirstOrDefault();
        #endregion

        #region ICloneDelFactory Members 
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsGenericType() &&
                type.GetGenericTypeDefinition() == typeof(List<>))
            {
                var elementType = type.GetGenericArguments()[0];

                if (!elementType.CanShallowClone())
                {
                    return (CloneDel<T>)_methodInfo.MakeGenericMethod(elementType).CreateDelegate(typeof(CloneDel<T>));
                }
            }

            return null;
        }
        #endregion

        #region Private Members
        private static List<T> Copy<T>(List<T> source, CopyContext context)
        {
            if (context.TryGetCopy(source, out var existingCopy))
            {
                return (List<T>)existingCopy;
            }

            var length = source.Count;
            var target = new List<T>(length);

            context.RecordCopy(source, target);

            for (var i = 0; i < length; i++)
            {
                T sourceItem = source[i];

                if (sourceItem != null)
                {
                    target.Add(Cloner<T>.Get(sourceItem, context));
                }
                else
                {
                    target.Add(sourceItem);
                }
            }

            return target;
        }
        #endregion
    }
}