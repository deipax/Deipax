using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Deipax.Cloning.Extensions
{
    public static class FieldInfoExtensions
    {
        #region Field Members
        private static readonly RuntimeTypeHandle _intPtrTypeHandle = typeof(IntPtr).TypeHandle;
        private static readonly RuntimeTypeHandle _uIntPtrTypeHandle = typeof(UIntPtr).TypeHandle;
        #endregion

        #region Public Members
        public static bool IsSupportedField(this FieldInfo fieldInfo)
        {
            var fieldType = fieldInfo.FieldType;

            if (fieldType.IsPointer || fieldType.IsByRef) return false;

            if (fieldInfo.IsInitOnly || fieldInfo.IsLiteral) return false;

            var handle = fieldType.TypeHandle;
            if (handle.Equals(_intPtrTypeHandle)) return false;
            if (handle.Equals(_uIntPtrTypeHandle)) return false;

            return true;
        }
        #endregion
    }
}