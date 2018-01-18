using System.Reflection;

namespace Deipax.Cloning.Extensions
{
    public static class FieldInfoExtensions
    {
        #region Public Members
        public static bool IsSupported(
            this FieldInfo fieldInfo)
        {
            if (!fieldInfo.FieldType.IsSupported()) return false;
            if (fieldInfo.IsInitOnly || fieldInfo.IsLiteral) return false;

            return true;
        }
        #endregion
    }
}