using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.Tests
{
    [TestClass]
    public class AdHoc
    {
        //[TestMethod]
        public void Tmp()
        {
            TestEnum t = TestEnum.NinetyNine;

            var one = EnumHelper<TestEnum, int>.ConvertToString(t);
            var two = EnumHelper<TestEnum, int>.ConvertToString(t);
        }
    }
}
