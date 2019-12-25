using System;
using System.Collections.Generic;

namespace Deipax.DataAccess.Interfaces
{
    public interface IManagedEnumerable<T> : IEnumerable<T>, IDisposable
    {
    }
}
