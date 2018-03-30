using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class AdHoc
    {
        public AdHoc()
        {
            _long = 1;
            _longAsObject = _long;
            var tmp1 = ConvertTo2<long, object>.From(_longAsObject);
            var tmp2 = ConvertTo<long>.From(_longAsObject);
        }

        private long _long;
        private object _longAsObject;

        [TestMethod]
        public void Temp()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                //var tmp1 = ConvertTo2<long, object>.From(_longAsObject);
                var tmp2 = ConvertTo<long>.From(_longAsObject);
            }
        }
    }
}