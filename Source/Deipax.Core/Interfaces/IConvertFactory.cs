using Deipax.Core.Conversion;

namespace Deipax.Core.Interfaces
{
    public interface IConvertFactory
    {
        IConvertFactoryResult<TFrom, TTo> Get<TFrom, TTo>();
    }

    public interface IConvertFactoryResult<TFrom, TTo>
    {
        IConvertFactory Factory { get; }
        Convert<TFrom, TTo> Func { get; }
        bool GuardCall { get; }
    }

    internal class ConvertFactoryResult<TFrom, TTo> : IConvertFactoryResult<TFrom, TTo>
    {
        public IConvertFactory Factory { get; set; }
        public Convert<TFrom, TTo> Func { get; set; }
        public bool GuardCall { get; set; }
    }
}