using Deipax.Core.Concretes;
using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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
            var type = typeof(Setter<,>)
                .MakeGenericType(typeof(T), info.Type);

            return (ISetter<T>)Activator.CreateInstance(type, new[] { info });
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
            var type = typeof(Getter<,>)
                .MakeGenericType(typeof(T), info.Type);

            return (IGetter<T>)Activator.CreateInstance(type, new[] { info });
        }
        #endregion
    }
}