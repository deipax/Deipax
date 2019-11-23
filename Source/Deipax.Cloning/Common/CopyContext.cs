using Deipax.Core.Common;
using System.Collections.Generic;

namespace Deipax.Cloning.Common
{
    public class CopyContext
    {
        public CopyContext() :
            this(new Dictionary<object, object>(16, ReferenceEqualsComparer.Instance))
        {
        }

        public CopyContext(IDictionary<object, object> dict)
        {
            _dict = dict;
        }

        #region Field Members
        private readonly IDictionary<object, object> _dict;
        #endregion

        #region ICopyContext Members
        public void RecordCopy(object original, object copy)
        {
            _dict[original] = copy;
        }

        public bool TryGetCopy(object original, out object result)
        {
            return _dict.TryGetValue(original, out result);
        }

        public int GetCount()
        {
            return _dict.Count;
        }

        public void Reset()
        {
            _dict.Clear();
        }
        #endregion
    }
}