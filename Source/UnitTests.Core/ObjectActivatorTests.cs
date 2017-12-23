using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Common;

namespace UnitTests.Core
{
    [TestClass]
    public class ObjectActivatorTests
    {
        [TestMethod]
        public void ObjectActivatorTests_Test1()
        {
            AssertActivator(new GrandChildClass());
            AssertActivator<DateTime>(new DateTime());
            AssertActivator(new MyStruct());
            AssertActivator(new MyStaticClass());
            AssertActivator(new TimeSpan());
            AssertActivator("S");
            AssertActivator(10);
            AssertActivator((int?)10);
            AssertActivator(new Tuple<int>(10));
        }

        #region Private Members
        private static void AssertActivator<T>(T source)
        {
            var initializer = ObjectActivator.GetActivator(typeof(T)).Create;
            object item = initializer();
            item = source;

            Assert.IsTrue(item is T);

            object item2 = ObjectActivator<T>.Create();
            item2 = source;
            Assert.IsTrue(item2 is T);
        }
        #endregion
    }
}