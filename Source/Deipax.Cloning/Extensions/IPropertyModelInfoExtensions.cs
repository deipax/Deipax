using Deipax.Cloning.Common;
using Deipax.Model.Interfaces;
using System.Linq;
using System.Reflection;

namespace Deipax.Cloning.Extensions
{
    public static class IPropertyModelInfoExtensions
    {
        #region Field Members
        private static MethodInfo _helper = typeof(IPropertyModelInfoExtensions)
            .GetRuntimeMethods()
            .Where(x => x.Name == "CanShallowClonePropHelper")
            .FirstOrDefault();
        #endregion

        public static bool CanShallowClone(
            this IPropertyModelInfo source)
        {
            return source.Type.CanShallowClone() ||
                   CanShallowCloneField(source.PropertyInfo);
        }

        #region Field Member
        private static bool CanShallowCloneField(
            PropertyInfo info)
        {
            return (bool)_helper
                .MakeGenericMethod(info.DeclaringType)
                .Invoke(null, new[] { info.Name });
        }

        private static bool CanShallowClonePropHelper<T>(
            string propName)
        {
            return CloneCmdConfig<T>.CanShallowClone(propName);
        }
        #endregion
    }
}