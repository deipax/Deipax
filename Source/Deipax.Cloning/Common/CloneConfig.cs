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
            Reset();
        }

        #region Field Members
        private static List<string> _include = new List<string>();
        private static List<string> _exclude = new List<string>();
        private static List<string> _shallow = new List<string>();
        #endregion

        #region Public Members
        public static Func<T, T> Initializer { get; set; }

        public static CloneDel<T> CloneDel { get; set; }

        public static CloneCmd CloneCmd { get; set; }

        public static bool ShallowClone { get; set; }

        public static void AddShallowClone(string name)
        {
            _shallow.Add(name);
        }

        public static void AddShallowClone(Expression<Func<T, object>> expression)
        {
            AddShallowClone(expression.ExtractMemberName());
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

        public static bool ShouldShallowClone(string name)
        {
            return _shallow.Contains(name);
        }

        public static bool ShouldShallowClone(Expression<Func<T, object>> expression)
        {
            return ShouldShallowClone(expression.ExtractMemberName());
        }

        public static IReadOnlyList<IFieldModelInfo> GetFields()
        {
            var allFields = typeof(T)
                .GetAllFields()
                .Where(x =>
                    x.CanRead &&
                    x.CanWrite &&
                    !x.IsStatic &&
                    !x.IsLiteral &&
                    !x.IsBackingField)
                .ToList();

            if (CloneCmd == CloneCmd.All)
            {
                return allFields
                    .Where(x => !_exclude.Contains(x.Name))
                    .ToList();
            }
            else if (CloneCmd == CloneCmd.None)
            {
                return allFields
                    .Where(x => _include.Contains(x.Name))
                    .ToList();
            }

            return allFields
                .Where(x =>
                    (x.IsPublic || _include.Contains(x.Name)) &&
                    !_exclude.Contains(x.Name))
                .ToList();
        }

        public static IReadOnlyList<IPropertyModelInfo> GetProperties()
        {
            var allProps = typeof(T)
                .GetFilteredProperties()
                .Where(x =>
                    x.CanRead &&
                    x.CanWrite &&
                    !x.IsLiteral &&
                    !x.IsStatic &&
                    !x.HasParameters)
                .ToList();

            if (CloneCmd == CloneCmd.All)
            {
                return allProps
                    .Where(x => !_exclude.Contains(x.Name))
                    .ToList();
            }
            else if (CloneCmd == CloneCmd.None)
            {
                return allProps
                    .Where(x => _include.Contains(x.Name))
                    .ToList();
            }

            return allProps
                .Where(x =>
                    (x.IsPublic || _include.Contains(x.Name)) &&
                    !_exclude.Contains(x.Name))
                .ToList();
        }

        public static void Reset()
        {
            Initializer = null;
            CloneDel = null;
            _include.Clear();
            _exclude.Clear();
            _shallow.Clear();

            var type = typeof(T);

            var cloneCmdAttr = type
                .GetCustomAttributes<CloneCmdAttribute>()
                .FirstOrDefault();

            var shallowAttr = type
                .GetCustomAttributes<ShallowCloneAttribute>()
                .FirstOrDefault();

            CloneCmd = cloneCmdAttr != null
                ? cloneCmdAttr.Cmd
                : CloneCmd.Default;

            ShallowClone = shallowAttr != null;

            var fields = type.GetAllFields();

            foreach (var field in fields)
            {
                if (field.GetCustomAttributes<CloneAttribute>().Count() > 0)
                {
                    Include(field.Name);
                }

                if (field.GetCustomAttributes<NoCloneAttribute>().Count() > 0)
                {
                    Exclude(field.Name);
                }

                if (field.GetCustomAttributes<ShallowCloneAttribute>().Count() > 0)
                {
                    AddShallowClone(field.Name);
                }
            }

            foreach(var prop in type.GetFilteredProperties(fields))
            {
                if (prop.GetCustomAttributes<CloneAttribute>().Count() > 0)
                {
                    Include(prop.Name);
                }

                if (prop.GetCustomAttributes<NoCloneAttribute>().Count() > 0)
                {
                    Exclude(prop.Name);
                }

                if (prop.GetCustomAttributes<ShallowCloneAttribute>().Count() > 0)
                {
                    AddShallowClone(prop.Name);
                }
            }
        }
        #endregion
    }
}