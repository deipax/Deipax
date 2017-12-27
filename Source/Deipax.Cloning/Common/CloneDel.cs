using Deipax.Cloning.Interfaces;

namespace Deipax.Cloning.Common
{
    public delegate T CloneDel<T>(T source, ICopyContext context);
}