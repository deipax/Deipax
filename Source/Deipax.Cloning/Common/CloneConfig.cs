using Deipax.Core.Extensions;
using Deipax.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Common
{
    public static class CloneConfig<T>
    {
        static CloneConfig()
        {
            var type = typeof(T);

            _cloneAll = type
                .GetCustomAttributes<CloneAllAttribute>()
                .Count() > 0;

            var fields = type
                .GetAllFields()
                .ToList();

            fields.ForEach(x =>
            {
                if (x.GetCustomAttributes<CloneAttribute>().Count() > 0)
                {
                    Include(x.Name);
                }

                if (x.GetCustomAttributes<NoCloneAttribute>().Count() > 0)
                {
                    Exclude(x.Name);
                }
            });

            var properties = type
                .GetFilteredProperties(fields)
                .ToList();

            properties.ForEach(x =>
            {
                if (x.GetCustomAttributes<CloneAttribute>().Count() > 0)
                {
                    Include(x.Name);
                }

                if (x.GetCustomAttributes<NoCloneAttribute>().Count() > 0)
                {
                    Exclude(x.Name);
                }
            });
        }

        #region Field Members
        private static bool _cloneAll = false;
        private static List<string> _include = new List<string>();
        private static List<string> _exclude = new List<string>();
        #endregion

        #region Public Members
        public static Func<T, T> Initializer { get; set; }

        public static void CloneAll(bool value)
        {
            _cloneAll = value;
        }

        public static void Include(string name)
        {
            _include.Add(name);
        }

        public static void Include(Expression<Func<T, object>> expression)
        {
            Include(expression.ExtractMemberName());
        }

        public static void Exclude(string name)
        {
            _exclude.Add(name);
        }

        public static void Exclude(Expression<Func<T, object>> expression)
        {
            Exclude(expression.ExtractMemberName());
        }

        public static IReadOnlyList<IFieldModelInfo> GetFields()
        {
            return typeof(T)
                .GetAllFields()
                .Where(x =>
                    x.CanRead &&
                    x.CanWrite &&
                    !x.IsStatic &&
                    !x.IsLiteral &&
                    !x.IsBackingField &&
                    (x.IsPublic || _cloneAll || _include.Contains(x.Name)) &&
                    !_exclude.Contains(x.Name))
                .ToList();
        }

        public static IReadOnlyList<IPropertyModelInfo> GetProperties()
        {
            return typeof(T)
                .GetFilteredProperties()
                .Where(x =>
                    x.CanRead &&
                    x.CanWrite &&
                    !x.IsLiteral &&
                    !x.IsStatic &&
                    !x.HasParameters &&
                    (x.IsPublic || _cloneAll || _include.Contains(x.Name)) &&
                    !_exclude.Contains(x.Name))
                .ToList();
        }
        #endregion
    }
}