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
        private static CloneCmd _cloneCmd;
        private static List<string> _include = new List<string>();
        private static List<string> _exclude = new List<string>();
        #endregion

        #region Public Members
        public static Func<T, T> Initializer { get; set; }

        public static CloneDel<T> CloneDel { get; set; }

        public static void SetCloneCmd(CloneCmd cmd)
        {
            _cloneCmd = cmd;
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
            var allFields = typeof(T)
                .GetAllFields()
                .Where(x =>
                    x.CanRead &&
                    x.CanWrite &&
                    !x.IsStatic &&
                    !x.IsLiteral &&
                    !x.IsBackingField);

            if (_cloneCmd == CloneCmd.All)
            {
                return allFields
                    .Where(x => !_exclude.Contains(x.Name))
                    .ToList();
            }
            else if (_cloneCmd == CloneCmd.None)
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
                    !x.HasParameters);

            if (_cloneCmd == CloneCmd.All)
            {
                return allProps
                    .Where(x => !_exclude.Contains(x.Name))
                    .ToList();
            }
            else if (_cloneCmd == CloneCmd.None)
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

            var type = typeof(T);

            var cloneCmd = type
                .GetCustomAttributes<CloneCmdAttribute>()
                .FirstOrDefault();

            if (cloneCmd != null)
            {
                SetCloneCmd(cloneCmd.Cmd);
            }
            else
            {
                SetCloneCmd(CloneCmd.Default);
            }

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
        #endregion
    }
}