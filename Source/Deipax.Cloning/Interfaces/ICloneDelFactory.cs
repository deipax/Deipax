namespace Deipax.Cloning.Interfaces
{
    public interface ICloneDelFactory
    {
        CloneDel<T> Create<T>();
    }

    public interface ICloneDelResult<T>
    {
        ICloneDelFactory Factory { get; }
        CloneDel<T> Func { get; }
    }
}