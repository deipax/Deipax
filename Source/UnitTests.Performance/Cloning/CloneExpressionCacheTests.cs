using Deipax.Cloning.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace Performance.Cloning
{
    [TestClass]
    public class CloneExpressionCacheTests : BaseTest
    {
        [TestMethod]
        public void CloneExpressionCacheTests_AccessSpeed()
        {
            Type t = typeof(Helper1);

            var result = TimingHelper.GetPerformance(
                30000000,
                () => CloneExpressionCache.Get(t));

            WriteLine(result.GetReport());
        }
    }
}