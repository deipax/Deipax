using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace UnitTests.Core
{
    [TestClass]
    public class AdHoc
    {
        [TestMethod]
        public void Temp()
        {
            MyEnum tmp = MyEnum.Hello;
            IConvertible x = tmp;

            var bool1 = tmp.GetType().IsAssignableFrom(typeof(IConvertible));
            var bool2 = typeof(IConvertible).IsAssignableFrom(tmp.GetType());

            if (x != null)
            {
                var y = x.ToInt32(CultureInfo.InvariantCulture);
            }
        }

        enum MyEnum
        {
            Hello = 1
        }
    }
}
