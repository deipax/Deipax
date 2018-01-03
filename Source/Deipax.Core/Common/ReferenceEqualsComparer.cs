using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Deipax.Core.Common
{
    public class ReferenceEqualsComparer : IEqualityComparer<object>
    {
        public static readonly ReferenceEqualsComparer Instance = new ReferenceEqualsComparer();

        bool IEqualityComparer<object>.Equals(object x, object y)
        {
            return object.ReferenceEquals(x, y);
        }

        int IEqualityComparer<object>.GetHashCode(object obj)
        {
            return obj == null ? 0 : RuntimeHelpers.GetHashCode(obj);
        }
    }
}