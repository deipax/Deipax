﻿using Deipax.Cloning;
using Deipax.Cloning.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning
{
    [TestClass]
    public class AbstractTests : AbstractBaseTests
    {
        protected override T GetClone<T>(T source, int expectedCount)
        {
            CopyContext c = new CopyContext();
            T target = Cloner<T>.Get(source, c);
            Assert.AreEqual(expectedCount, c.GetCount(), "Cache count incorrect.");
            return target;
        }
    }
}