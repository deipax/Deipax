using Deipax.Core.Conversion;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Common
{
    public class ModelAccess
    {
        static ModelAccess()
        {
            _cache = new ConcurrentDictionary<Type, ModelAccess>();
        }

        private ModelAccess(Type t)
        {
            this.Type = t;

            var fields = t.GetAllFields();
            var props = t.GetFilteredProperties(fields);

            AllGetters = GetAllGetters(t, props, fields);
            AllSetters = GetAllSetters(t, props, fields);

            Getters = AllGetters
                .GroupBy(x => x.Name, StringComparer.OrdinalIgnoreCase)
                .Select(x => x.OrderBy(y => y.ModelInfo.Depth).First())
                .ToDictionary(x => x.Name, x => x, StringComparer.OrdinalIgnoreCase);

            Setters = AllSetters
                .GroupBy(x => x.Name, StringComparer.OrdinalIgnoreCase)
                .Select(x => x.OrderBy(y => y.ModelInfo.Depth).First())
                .ToDictionary(x => x.Name, x => x, StringComparer.OrdinalIgnoreCase);
        }

        private ModelAccess()
        {
        }

        #region Field Members
        private static ConcurrentDictionary<Type, ModelAccess> _cache;

        private static MethodInfo _setterGenericHelper = typeof(ModelAccess)
            .GetRuntimeMethods()
            .Where(x =>
                x.Name == "CreateSetterDelegateHelper" &&
                x.IsStatic &&
                x.IsPrivate)
            .FirstOrDefault();

        private static MethodInfo _getterGenericHelper = typeof(ModelAccess)
            .GetRuntimeMethods()
            .Where(x =>
                x.Name == "CreateGetterDelegateHelper" &&
                x.IsStatic &&
                x.IsPrivate)
            .FirstOrDefault();
        #endregion

        #region Public Members
        public static ModelAccess Create(Type t)
        {
            if (t != null)
            {
                return _cache.GetOrAdd(t, (x) =>
                {
                    return new ModelAccess(x);
                });
            }

            return null;
        }

        public Type Type { get; private set; }
        public IReadOnlyDictionary<string, ISetter> Setters { get; private set; }
        public IReadOnlyDictionary<string, IGetter> Getters { get; private set; }
        public IReadOnlyList<ISetter> AllSetters { get; private set; }
        public IReadOnlyList<IGetter> AllGetters { get; private set; }

        public IGetter GetGetter(string name)
        {
            return Getters.TryGetValue(name);
        }

        public IGetter GetGetter<T>(Expression<Func<T, object>> expression)
        {
            return GetGetter(expression.ExtractMemberName());
        }

        public ISetter GetSetter(string name)
        {
            return Setters.TryGetValue(name);
        }

        public ISetter GetSetter<T>(Expression<Func<T, object>> expression)
        {
            return GetSetter(expression.ExtractMemberName());
        }
        #endregion

        #region Private Members
        private static IReadOnlyList<ISetter> GetAllSetters(
            Type t,
            IEnumerable<IPropertyModelInfo> properties,
            IEnumerable<IFieldModelInfo> fields)
        {
            List<ISetter> setters = new List<ISetter>();

            setters.AddRange(properties
                .Where(x => x.CanWrite && !x.IsStatic && !x.HasParameters)
                .Select(x => GetSetDelegate(t, x)));

            setters.AddRange(fields
                .Where(x => x.CanWrite && !x.IsStatic && !x.IsBackingField)
                .Select(x => GetSetDelegate(t, x)));

            return setters;
        }

        private static ISetter GetSetDelegate(Type t, IModelInfo info)
        {
            return (ISetter)_setterGenericHelper
                .MakeGenericMethod(t, info.Type)
                .Invoke(null, new object[] { info });
        }

        private static ISetter CreateSetterDelegateHelper<T, P>(IModelInfo info)
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
                GetOptimalMemberInfo(info));

            var safeAssign = Expression.IfThenElse(
                Expression.TypeEqual(input, propertyType),
                Expression.Assign(memberExpression, Expression.Convert(input, propertyType)),
                Expression.Assign(memberExpression, Expression.Invoke(Expression.Constant(ConvertTo<P>.From), input)));

            var lambda = Expression.Lambda<Action<object, object>>(safeAssign, instanceAsObject, input);

            return Setter.Create<T>(info, lambda);
        }

        private static IReadOnlyList<IGetter> GetAllGetters(
            Type t,
            IEnumerable<IPropertyModelInfo> properties,
            IEnumerable<IFieldModelInfo> fields)
        {
            List<IGetter> getters = new List<IGetter>();

            getters.AddRange(properties
                .Where(x => x.CanRead && !x.IsStatic && !x.HasParameters)
                .Select(x => GetGetDelegate(t, x)));

            getters.AddRange(fields
                .Where(x => x.CanRead && !x.IsStatic && !x.IsBackingField)
                .Select(x => GetGetDelegate(t, x)));

            return getters;
        }

        private static IGetter GetGetDelegate(Type t, IModelInfo info)
        {
            return (IGetter)_getterGenericHelper
                .MakeGenericMethod(t, info.Type)
                .Invoke(null, new object[] { info });
        }

        private static IGetter CreateGetterDelegateHelper<T, P>(IModelInfo info)
        {
            var instanceType = typeof(T);
            var instanceAsObject = Expression.Parameter(typeof(object), "instanceAsObject");

            var instance = instanceType.IsValueType() ?
                Expression.Unbox(instanceAsObject, instanceType) :
                Expression.Convert(instanceAsObject, instanceType);

            var memberExpression = Expression.MakeMemberAccess(
                instance,
                GetOptimalMemberInfo(info));

            var lambda = Expression.Lambda<Func<object, object>>(
                Expression.Convert(memberExpression, typeof(object)),
                instanceAsObject);
            return Getter.Create<T>(info, lambda);
        }

        private static MemberInfo GetOptimalMemberInfo(IModelInfo modelInfo)
        {
            var propInfo = modelInfo as IPropertyModelInfo;

            if (propInfo != null)
            {
                if (propInfo.HasBackingField)
                {
                    return propInfo.BackingField.FieldInfo;
                }
                else
                {
                    return propInfo.PropertyInfo;
                }
            }
            else
            {
                var fieldInfo = modelInfo as IFieldModelInfo;
                return fieldInfo.FieldInfo;
            }
        }
        #endregion

        #region Helpers
        [DebuggerDisplay("{Name} - {InstanceType.Name} - {ModelInfo.MemberInfo.DeclaringType.Name}")]
        class Setter : ISetter
        {
            public static ISetter Create<T>(
                IModelInfo info,
                Expression<Action<object, object>> setExpression)
            {
                return new Setter()
                {
                    InstanceType = typeof(T),
                    Name = info.Name,
                    ModelInfo = info,
                    Set = setExpression.Compile(),
                };
            }

            public Type InstanceType { get; private set; }
            public string Name { get; private set; }
            public Action<object, object> Set { get; private set; }
            public IModelInfo ModelInfo { get; private set; }
        }

        [DebuggerDisplay("{Name} - {InstanceType.Name} - {ModelInfo.MemberInfo.DeclaringType.Name}")]
        class Getter : IGetter
        {
            public static IGetter Create<T>(
                IModelInfo info,
                Expression<Func<object, object>> getExpression)
            {
                return new Getter()
                {
                    InstanceType = typeof(T),
                    Name = info.Name,
                    ModelInfo = info,
                    Get = getExpression.Compile(),
                };
            }

            public Type InstanceType { get; private set; }
            public string Name { get; private set; }
            public Func<object, object> Get { get; private set; }
            public IModelInfo ModelInfo { get; private set; }
        }
        #endregion
    }

    public static class ModelAccess<T>
    {
        static ModelAccess()
        {
            var modelAccess = ModelAccess.Create(typeof(T));
            Getters = modelAccess.Getters;
            Setters = modelAccess.Setters;
            AllGetters = modelAccess.AllGetters;
            AllSetters = modelAccess.AllSetters;
        }

        #region Public Members
        public static IReadOnlyDictionary<string, ISetter> Setters { get; private set; }
        public static IReadOnlyDictionary<string, IGetter> Getters { get; private set; }
        public static IReadOnlyList<ISetter> AllSetters { get; private set; }
        public static IReadOnlyList<IGetter> AllGetters { get; private set; }

        public static IGetter GetGetter(string name)
        {
            return Getters.TryGetValue(name);
        }

        public static IGetter GetGetter(Expression<Func<T, object>> expression)
        {
            return GetGetter(expression.ExtractMemberName());
        }

        public static ISetter GetSetter(string name)
        {
            return Setters.TryGetValue(name);
        }

        public static ISetter GetSetter(Expression<Func<T, object>> expression)
        {
            return GetSetter(expression.ExtractMemberName());
        }
        #endregion
    }
}