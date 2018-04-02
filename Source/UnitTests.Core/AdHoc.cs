using System;
using System.Globalization;
using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Core
{
    [TestClass]
    public class AdHoc
    {
        [TestMethod]
        public void Temp1()
        {
            MyEnum? x = MyEnum.One;
            object y = x;

            int z = (int) y;
        }

        enum MyEnum
        {
            One = 1
        }
    }
}