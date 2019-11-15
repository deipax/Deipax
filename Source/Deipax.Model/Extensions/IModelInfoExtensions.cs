using Deipax.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Deipax.Model.Extensions
{
    public static class IModelInfoExtensions
    {
        public static IEnumerable<T> GetCustomAttributes<T>(
            this IModelInfo source) where T : Attribute
        {
            return source?.MemberInfo.GetCustomAttributes<T>() ?? new List<T>();
        }

        public static MemberInfo GetOptimalMemberInfo(
            this IModelInfo source)
        {
            if (source is IPropertyModelInfo propInfo)
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
            else if (source is IFieldModelInfo fieldInfo)
            {
                return fieldInfo.FieldInfo;
            }

            return null;
        }
    }
}