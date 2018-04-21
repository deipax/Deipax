using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class AdHoc
    {
        private int _intValue;
        private object _intValueAsObject;

        [TestInitialize]
        public void Init()
        {
            _intValue = 1;
            _intValueAsObject = _intValue;
            int to = ConvertTo2<int, object>.From(_intValueAsObject);
        }

        //[TestMethod]
        public void Temp1()
        {
            for (int i = 0; i < 100000000; i++)
            {
                int to = ConvertTo2<int, object>.From(_intValueAsObject);
            }
        }
    }
}