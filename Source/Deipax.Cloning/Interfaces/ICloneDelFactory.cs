using Deipax.Cloning.Common;

namespace Deipax.Cloning.Interfaces
{
    public interface ICloneDelFactory
    {
        CloneDel<T> Get<T>();
    }
}