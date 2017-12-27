namespace Deipax.Cloning.Interfaces
{
    public interface ICopyContext
    {
        void RecordCopy(object original, object copy);
        bool TryGetCopy(object original, out object result);
        int GetCount();
        void Reset();
    }
}