using BenchmarkDotNet.Attributes;
using Deipax.Core.Conversion;

namespace Benchmarks.Core
{
    public class AdHoc
    {
        #region Field Members
        private long _long = 1;
        private long? _nullLongWithValue = 1;
        private long? _nullLongNoValue = null;
        #endregion
    }
}