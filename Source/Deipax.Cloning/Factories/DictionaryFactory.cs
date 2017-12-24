using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    public class DictionaryFactory : ICloneDelFactory
    {
        #region Field Members
        private static MethodInfo _methodInfo = typeof(DictionaryFactory)
            .GetRuntimeMethods()
            .Where(x => x.Name == "GetHelper")
            .FirstOrDefault();
        #endregion

        #region ICloneDelFactory Members
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsGenericType() &&
                type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            {
                var keyType = type.GetGenericArguments()[0];
                var valueType = type.GetGenericArguments()[1];

                return (CloneDel<T>)_methodInfo
                    .MakeGenericMethod(new[] { keyType, valueType })
                    .Invoke(null, null);
            }

            return null;
        }
        #endregion

        #region Private Members
        private static CloneDel<Dictionary<X, Y>> GetHelper<X, Y>()
        {
            var keyType = typeof(X);
            var valueType = typeof(Y);

            var helper = new DictHelper<X, Y>()
            {
                KeyCloner = keyType.CanShallowClone() ?
                    (CloneDel<X>)SimpleReturn<X> :
                    Cloner<X>.Get,
                ValueCloner = valueType.CanShallowClone() ?
                    (CloneDel<Y>)SimpleReturn<Y> :
                    Cloner<Y>.Get,
            };

            return helper.GetClone;
        }

        private static T SimpleReturn<T>(T source, CopyContext context)
        {
            return source;
        }
        #endregion

        #region Helper
        class DictHelper<X, Y>
        {
            public CloneDel<X> KeyCloner { get; set; }
            public CloneDel<Y> ValueCloner { get; set; }

            public Dictionary<X, Y> GetClone(Dictionary<X, Y> source, CopyContext context)
            {
                if (context.TryGetCopy(source, out var existingCopy))
                {
                    return (Dictionary<X, Y>) existingCopy;
                }

                var target = new Dictionary<X, Y>(source.Count, source.Comparer);

                context.RecordCopy(source, target);

                foreach(var pair in source)
                {
                    target.Add(KeyCloner(pair.Key, context), ValueCloner(pair.Value, context));
                }

                return target;
            }
        }
        #endregion
    }
}