namespace Deipax.Cloning.Interfaces
{
    public interface ICloneDelFactory
    {
        CloneDel<T> Create<T>();
    }
}