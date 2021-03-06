﻿using Deipax.Cloning.Common;
using Deipax.Core.Extensions;
using Deipax.Model.Extensions;
using Deipax.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning
{
    public static class CloneCmdConfig<T>
    {
        static CloneCmdConfig()
        {
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

            ShallowCloneType = shallowAttr != null;

            var fields = type.GetAllFields();

            foreach (var field in fields)
            {
                if (field.GetCustomAttributes<CloneAttribute>().Any()) Clone(field.Name);
                if (field.GetCustomAttributes<NoCloneAttribute>().Any()) NoClone(field.Name);
                if (field.GetCustomAttributes<ShallowCloneAttribute>().Any()) ShallowClone(field.Name);
            }

            foreach (var prop in type.GetFilteredProperties(fields))
            {
                if (prop.GetCustomAttributes<CloneAttribute>().Any()) Clone(prop.Name);
                if (prop.GetCustomAttributes<NoCloneAttribute>().Any()) NoClone(prop.Name);
                if (prop.GetCustomAttributes<ShallowCloneAttribute>().Any()) ShallowClone(prop.Name);
            }
        }

        #region Field Members
        private static readonly List<string> _clone = new List<string>();
        private static readonly List<string> _noClone = new List<string>();
        private static readonly List<string> _shallow = new List<string>();
        #endregion

        #region Public Members
        public static CloneCmd CloneCmd { get; set; }

        public static bool ShallowCloneType { get; set; }

        public static void ShallowClone(string name)
        {
            _shallow.Add(name);
        }

        public static void ShallowClone(Expression<Func<T, object>> expression)
        {
            ShallowClone(expression.ExtractMemberName());
        }

        public static void Clone(string name)
        {
            _clone.Add(name);
        }

        public static void Clone(Expression<Func<T, object>> expression)
        {
            Clone(expression.ExtractMemberName());
        }

        public static void NoClone(string name)
        {
            _noClone.Add(name);
        }

        public static void NoClone(Expression<Func<T, object>> expression)
        {
            NoClone(expression.ExtractMemberName());
        }

        public static bool CanShallowClone(string name)
        {
            return _shallow.Contains(name);
        }

        public static bool CanShallowClone(Expression<Func<T, object>> expression)
        {
            return CanShallowClone(expression.ExtractMemberName());
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
                    .Where(x => !_noClone.Contains(x.Name))
                    .ToList();
            }
            else if (CloneCmd == CloneCmd.None)
            {
                return allFields
                    .Where(x => _clone.Contains(x.Name))
                    .ToList();
            }

            return allFields
                .Where(x =>
                    (x.IsPublic || _clone.Contains(x.Name)) &&
                    !_noClone.Contains(x.Name))
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
                    .Where(x => !_noClone.Contains(x.Name))
                    .ToList();
            }
            else if (CloneCmd == CloneCmd.None)
            {
                return allProps
                    .Where(x => _clone.Contains(x.Name))
                    .ToList();
            }

            return allProps
                .Where(x =>
                    (x.IsPublic || _clone.Contains(x.Name)) &&
                    !_noClone.Contains(x.Name))
                .ToList();
        }
        #endregion
    }
}