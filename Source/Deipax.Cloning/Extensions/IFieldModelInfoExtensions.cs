using Deipax.Cloning.Common;
using Deipax.Core.Interfaces;
using System.Linq;
using System.Reflection;

namespace Deipax.Cloning.Extensions
{
    public static class IFieldModelInfoExtensions
    {
        #region Field Members
        private static MethodInfo _helper = typeof(IFieldModelInfoExtensions)
            .GetRuntimeMethods()
            .Where(x => x.Name == "CanShallowCloneFieldHelper")
            .FirstOrDefault();
        #endregion

        public static bool CanShallowClone(
            this IFieldModelInfo source)
        {
            return source.Type.CanShallowClone() ||
                   CanShallowCloneField(source.FieldInfo);
        }

        #region Field Member
        private static bool CanShallowCloneField(
            FieldInfo info)
        {
            return (bool)_helper
                .MakeGenericMethod(info.DeclaringType)
                .Invoke(null, new[] { info.Name });
        }

        private static bool CanShallowCloneFieldHelper<T>(
            string fieldName)
        {
            return CloneConfig<T>.CanShallowClone(fieldName);
        }
        #endregion
    }
}