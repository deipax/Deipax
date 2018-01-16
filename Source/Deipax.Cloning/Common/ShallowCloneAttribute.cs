using System;

namespace Deipax.Cloning.Common
{
    [AttributeUsage(
        AttributeTargets.Property |
        AttributeTargets.Field |
        AttributeTargets.Class |
        AttributeTargets.Struct,
        AllowMultiple = false,
        Inherited = true)]
    public class ShallowCloneAttribute : Attribute
    {
    }
}