using System;

namespace Deipax.Cloning.Common
{
    [AttributeUsage(
        AttributeTargets.Property |
        AttributeTargets.Field,
        AllowMultiple = false,
        Inherited = true)]
    public class NoCloneAttribute : Attribute
    {
    }

    [AttributeUsage(
        AttributeTargets.Property |
        AttributeTargets.Field,
        AllowMultiple = false,
        Inherited = true)]
    public class CloneAttribute : Attribute
    {
    }

    /// <summary>
    /// This attribute will flag allow all private members to be 
    /// cloned without having to decorate each individual member.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Struct,
        AllowMultiple = false,
        Inherited = true)]
    public class CloneCmdAttribute : Attribute
    {
        public CloneCmdAttribute(CloneCmd cmd)
        {
            this.Cmd = cmd;
        }

        private CloneCmdAttribute()
        {
        }

        public CloneCmd Cmd { get; private set; }
    }

    public enum CloneCmd
    {
        All,
        None,
        Default
    }
}