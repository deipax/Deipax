using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Concretes
{
    internal class Getter<T, P> : IGetter<T>
    {
        public Getter(IModelInfo info)
        {
            var instanceType = typeof(T);
            var instanceAsObject = Expression.Parameter(typeof(object), "instanceAsObject");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");

            var instance = instanceType.IsValueType() ?
                Expression.Unbox(instanceAsObject, instanceType) :
                Expression.Convert(instanceAsObject, instanceType);

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                info.GetOptimalMemberInfo());

            var getter = Expression.Lambda<Get<object>>(
                Expression.Convert(memberExpression, typeof(object)),
                instanceAsObject,
                provider);

            Name = info.Name;
            ModelInfo = info;
            Get = getter.Compile();
        }

        #region IGetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }
        public Get<object> Get { get; private set; }
        #endregion
    }
}