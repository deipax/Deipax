using Benchmarks.Core.BaseClasses.Conversion;
using Deipax.Core.Conversion;

namespace Benchmarks.Core.Deipax.Conversion
{
    public class ConvertTo_Long : BaseConvertTo<long>
    {
        protected override long ConvertFrom<X>(X from)
        {
            return ConvertTo<long>.From(from);
        }
    }
}