using System;
using System.Globalization;
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

            _enum = MyEnum.One;
            _enumConvertible = _enum;
            _enumNulable = MyEnum.One;
        }

        private long _long;
        private object _longAsObject;
        private MyEnum _enum;
        private MyEnum? _enumNulable;
        private IConvertible _enumConvertible;

        //[TestMethod]
        public void Temp1()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                //var tmp1 = ConvertTo2<long, object>.From(_longAsObject);
                var tmp2 = ConvertTo<long>.From(_longAsObject);
            }
        }

        [TestMethod]
        public void Temp2()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                //int tmp1 = (int)_enum;
                //int tmp2 = _enumConvertible.ToInt32(CultureInfo.InvariantCulture);
                long tmp3 = (long)_enum;
            }
        }

        enum MyEnum
        {
            One = 1
        }
    }
}