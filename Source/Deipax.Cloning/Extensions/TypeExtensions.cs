using Deipax.Core.Common;
using Deipax.Core.Extensions;
using Deipax.Model.Extensions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Deipax.Cloning.Extensions
{
    public static class TypeExtensions
    {
        #region Field Members
        private static readonly MethodInfo _cloneConfigHelper = typeof(TypeExtensions)
            .GetRuntimeMethods()
            .Where(x => x.Name == nameof(CheckCloneConfigHelper))
            .FirstOrDefault();

        private static readonly RuntimeTypeHandle _intPtrTypeHandle = typeof(IntPtr).TypeHandle;
        private static readonly RuntimeTypeHandle _uIntPtrTypeHandle = typeof(UIntPtr).TypeHandle;

        private static readonly ConcurrentDictionary<Type, bool> _canShallowClone =
            new ConcurrentDictionary<Type, bool>(8, 16, ReferenceEqualsComparer.Instance);

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
            return type
                .GetAllFields()
                .Where(x => x.FieldInfo.IsSupported() && !x.IsStatic)
                .Select(x => x.FieldInfo)
                .OrderBy(x => x.Name)
                .ToList();
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

            static bool CanShallowCloneFields(Type type)
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
            return CloneCmdConfig<T>.ShallowCloneType;
        }
        #endregion
    }
}