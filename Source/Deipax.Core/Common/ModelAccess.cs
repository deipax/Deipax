using Deipax.Core.Conversion;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Common
{
    public static class ModelAccess<T>
    {
        static ModelAccess()
        {
            var t = typeof(T);
            var fields = t.GetAllFields();
            var props = t.GetFilteredProperties(fields);

            AllGetters = GetAllGetters(props, fields);
            AllSetters = GetAllSetters(props, fields);

            Getters = AllGetters
                .GroupBy(x => x.Name, StringComparer.OrdinalIgnoreCase)
                .Select(x => x.OrderBy(y => y.ModelInfo.Depth).First())
                .ToDictionary(x => x.Name, x => x, StringComparer.OrdinalIgnoreCase);

            Setters = AllSetters
                .GroupBy(x => x.Name, StringComparer.OrdinalIgnoreCase)
                .Select(x => x.OrderBy(y => y.ModelInfo.Depth).First())
                .ToDictionary(x => x.Name, x => x, StringComparer.OrdinalIgnoreCase);
        }

        #region Public Members
        public static IReadOnlyDictionary<string, ISetter<T>> Setters { get; private set; }
        public static IReadOnlyDictionary<string, IGetter<T>> Getters { get; private set; }
        public static IReadOnlyList<ISetter<T>> AllSetters { get; private set; }
        public static IReadOnlyList<IGetter<T>> AllGetters { get; private set; }

        public static IGetter<T> GetGetter(string name)
        {
            return Getters.TryGetValue(name);
        }

        public static IGetter<T> GetGetter<P>(Expression<Func<T, P>> expression)
        {
            return GetGetter(expression.ExtractMemberName());
        }

        public static ISetter<T> GetSetter(string name)
        {
            return Setters.TryGetValue(name);
        }

        public static ISetter<T> GetSetter<P>(Expression<Func<T, P>> expression)
        {
            return GetSetter(expression.ExtractMemberName());
        }
        #endregion

        #region Private Members
        private static IReadOnlyList<ISetter<T>> GetAllSetters(
            IEnumerable<IPropertyModelInfo> properties,
            IEnumerable<IFieldModelInfo> fields)
        {
            List<ISetter<T>> setters = new List<ISetter<T>>();

            setters.AddRange(properties
                .Where(x => x.CanWrite && !x.IsStatic && !x.HasParameters)
                .Select(x => GetSetDelegate(x)));

            setters.AddRange(fields
                .Where(x => x.CanWrite && !x.IsStatic && !x.IsBackingField)
                .Select(x => GetSetDelegate(x)));

            return setters;
        }

        private static ISetter<T> GetSetDelegate(
            IModelInfo info)
        {
            return (ISetter<T>)typeof(ModelAccess<T>)
                .GetRuntimeMethods()
                .Where(x =>
                    x.Name == "CreateSetterDelegateHelper" &&
                    x.IsStatic &&
                    x.IsPrivate)
                .FirstOrDefault()
                .MakeGenericMethod(info.Type)
                .Invoke(null, new object[] { info });
        }

        private static ISetter<T> CreateSetterDelegateHelper<P>(
            IModelInfo info)
        {
            var instanceType = typeof(T);
            var propertyType = typeof(P);

            var input = Expression.Parameter(typeof(object), "input");
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
                Expression.Assign(memberExpression, Expression.Invoke(Expression.Constant(ConvertTo<P>.From), input)));

            var lambda = Expression.Lambda<Action<object, object>>(safeAssign, instanceAsObject, input);

            return Setter<T>.Create(info, lambda);
        }

        private static IReadOnlyList<IGetter<T>> GetAllGetters(
            IEnumerable<IPropertyModelInfo> properties,
            IEnumerable<IFieldModelInfo> fields)
        {
            List<IGetter<T>> getters = new List<IGetter<T>>();

            getters.AddRange(properties
                .Where(x => x.CanRead && !x.IsStatic && !x.HasParameters)
                .Select(x => GetGetDelegate(x)));

            getters.AddRange(fields
                .Where(x => x.CanRead && !x.IsStatic && !x.IsBackingField)
                .Select(x => GetGetDelegate(x)));

            return getters;
        }

        private static IGetter<T> GetGetDelegate(
            IModelInfo info)
        {
            return (IGetter<T>)typeof(ModelAccess<T>)
                .GetRuntimeMethods()
                .Where(x =>
                    x.Name == "CreateGetterDelegateHelper" &&
                    x.IsStatic &&
                    x.IsPrivate)
                .FirstOrDefault()
                .MakeGenericMethod(info.Type)
                .Invoke(null, new object[] { info });
        }

        private static IGetter<T> CreateGetterDelegateHelper<P>(
            IModelInfo info)
        {
            var instanceType = typeof(T);
            var instanceAsObject = Expression.Parameter(typeof(object), "instanceAsObject");

            var instance = instanceType.IsValueType() ?
                Expression.Unbox(instanceAsObject, instanceType) :
                Expression.Convert(instanceAsObject, instanceType);

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                info.GetOptimalMemberInfo());

            var lambda = Expression.Lambda<Func<object, object>>(
                Expression.Convert(memberExpression, typeof(object)),
                instanceAsObject);
            return Getter<T>.Create(info, lambda);
        }
        #endregion

        #region Helpers
        class Setter<X> : ISetter<X>
        {
            public static ISetter<X> Create(
                IModelInfo info,
                Expression<Action<object, object>> setExpression)
            {
                return new Setter<X>()
                {
                    InstanceType = typeof(X),
                    Name = info.Name,
                    ModelInfo = info,
                    Set = setExpression.Compile(),
                };
            }

            public Type InstanceType { get; private set; }
            public string Name { get; private set; }
            public IModelInfo ModelInfo { get; private set; }
            public Action<object, object> Set { get; private set; }
        }

        class Getter<X> : IGetter<X>
        {
            public static IGetter<X> Create(
                IModelInfo info,
                Expression<Func<object, object>> getExpression)
            {
                return new Getter<X>()
                {
                    InstanceType = typeof(X),
                    Name = info.Name,
                    ModelInfo = info,
                    Get = getExpression.Compile(),
                };
            }

            public Type InstanceType { get; private set; }
            public string Name { get; private set; }
            public IModelInfo ModelInfo { get; private set; }
            public Func<object, object> Get { get; private set; }
        }
        #endregion
    }
}