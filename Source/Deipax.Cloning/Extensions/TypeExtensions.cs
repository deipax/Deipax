using Deipax.Core.Common;
using Deipax.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Deipax.Cloning.Common;

namespace Deipax.Cloning.Extensions
{
    public static class TypeExtensions
    {
        #region Field Members

        private static MethodInfo _cloneConfigHelper = typeof(TypeExtensions)
            .GetRuntimeMethods()
            .Where(x => x.Name == "CheckCloneConfigHelper")
            .FirstOrDefault();

        private static readonly RuntimeTypeHandle _intPtrTypeHandle = typeof(IntPtr).TypeHandle;
        private static readonly RuntimeTypeHandle _uIntPtrTypeHandle = typeof(UIntPtr).TypeHandle;

        private static readonly QuickCache<Type, bool> _canShallowClone = 
            new QuickCache<Type, bool>(16, ReferenceEqualsComparer.Instance);

        private static readonly Func<Type, bool> _canShallowCloneHelper = CanShallowCloneHelper;
        #endregion

        #region Public Members
        public static bool CanShallowClone(
            this Type source)
        {
            return _canShallowClone.GetOrAdd(source, _canShallowCloneHelper) || 
                CheckCloneConfig(source);
        }

        public static List<FieldInfo> GetCopyableFields(
            this Type type)
        {
            return GetAllFields(type)
                .Where(fieldInfo => fieldInfo.IsSupported())
                .OrderBy(x => x.Name)
                .ToList();

            IEnumerable<FieldInfo> GetAllFields(Type containingType)
            {
                BindingFlags allFields =
                    BindingFlags.Instance |
                    BindingFlags.Public |
                    BindingFlags.NonPublic |
                    BindingFlags.DeclaredOnly;

                var current = containingType;

                while (current != typeof(object) && current != null)
                {
                    var fields = current.GetFields(allFields);

                    foreach (var field in fields)
                    {
                        yield return field;
                    }

                    current = current.BaseType;
                }
            }
        }

        public static bool IsSupported(
            this Type source)
        {
            if (source.IsPointer || source.IsByRef) return false;

            var handle = source.TypeHandle;
            if (handle.Equals(_intPtrTypeHandle)) return false;
            if (handle.Equals(_uIntPtrTypeHandle)) return false;

            return true;
        }
        #endregion

        #region Private Members
        private static bool CanShallowCloneHelper(
            Type source)
        {
            return source.IsPrimitive() ||
                source.IsImmutable() ||
                typeof(Delegate).IsAssignableFrom(source) ||
                source.IsEnum() ||
                source.IsPointer ||
                (source.IsNullable() && Nullable.GetUnderlyingType(source).CanShallowClone()) ||
                (source.IsValueType() && CanShallowCloneFields(source));

            bool CanShallowCloneFields(Type type)
            {
                foreach (var copyableField in type.GetCopyableFields())
                {
                    if (!copyableField.FieldType.CanShallowClone())
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        private static bool CheckCloneConfig(Type type)
        {
            return (bool)_cloneConfigHelper
                .MakeGenericMethod(type)
                .Invoke(null, null);
        }

        private static bool CheckCloneConfigHelper<T>()
        {
            return CloneConfig<T>.ShallowCloneType;
        }
        #endregion
    }
}