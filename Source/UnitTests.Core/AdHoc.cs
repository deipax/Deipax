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
            MyEnum? tmp = null;

            int x = (int)tmp;
        }

        enum MyEnum
        {
            Hello = 1
        }
    }
}
