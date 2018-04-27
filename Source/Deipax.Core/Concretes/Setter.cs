using Deipax.Core.Conversion;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Core.Concretes
{
    internal class Setter<T, P> : ISetter<T>
    {
        public Setter(IModelInfo info)
        {
            var instanceType = typeof(T);
            var propertyType = typeof(P);

            var input = Expression.Parameter(typeof(object), "input");
            var provider = Expression.Parameter(typeof(IFormatProvider), "provider");
            var instanceAsObject = Expression.Parameter(typeof(object), "instanceAsObject");

            var instance = instanceType.IsValueType() ?
                Expression.Unbox(instanceAsObject, instanceType) :
                Expression.Convert(instanceAsObject, instanceType);

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                info.GetOptimalMemberInfo());

            var safeAssign = Expression.IfThenElse(
                Expression.TypeEqual(input, propertyType),
                Expression.Assign(memberExpression, Expression.Convert(input, propertyType)),
                Expression.Assign(memberExpression, Expression.Invoke(
                    Expression.Constant(ConvertTo<P, object>.From),
                    input,
                    provider)));

            var setter = Expression.Lambda<Set<object>>(
                safeAssign,
                instanceAsObject,
                input,
                provider);

            Name = info.Name;
            ModelInfo = info;
            Set = setter.Compile();
        }

        #region ISetter<T> Members
        public string Name { get; private set; }
        public IModelInfo ModelInfo { get; private set; }
        public Set<object> Set { get; private set; }
        #endregion
    }
}