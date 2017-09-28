using Deipax.Cloning.Interfaces;
using System;

namespace Deipax.Cloning.Common
{
    public static class CloneConfig<T>
    {
        public static ICloneLogic UserCloneLogic { get; set; }
        internal static ICloneLogic DefaultCloneLogic { get; set; }

        public static Func<T, T> Initializer { get; set; }
    }
}