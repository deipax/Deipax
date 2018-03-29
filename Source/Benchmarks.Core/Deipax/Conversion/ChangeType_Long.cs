using Benchmarks.Core.BaseClasses.Conversion;
using System;

namespace Benchmarks.Core.Deipax.Conversion
{
    public class ChangeType_Long : BaseConvertTo<long>
    {
        protected override long ConvertFrom<X>(X from)
        {
            return (long) Convert.ChangeType(from, Type);
        }
    }
}