using System;

namespace Deipax.Cloning.Common
{
    public static class CloneConfig<T>
    {
        public static Func<T, T> Initializer { get; set; }
    }
}