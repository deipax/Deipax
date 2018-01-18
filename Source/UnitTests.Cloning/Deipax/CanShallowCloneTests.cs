using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
    public class CanShallowCloneTests
    {
        [TestMethod]
        public void AssertDefaultBehavior()
        {
            // Primitives
            AssertShallowClone<bool>(true, true, true);
            AssertShallowClone<byte>(1, true, true);
            AssertShallowClone<sbyte>(1, true, true);
            AssertShallowClone<short>(1, true, true);
            AssertShallowClone<ushort>(1, true, true);
            AssertShallowClone<int>(1, true, true);
            AssertShallowClone<uint>(1, true, true);
            AssertShallowClone<long>(1, true, true);
            AssertShallowClone<ulong>(1, true, true);
            AssertShallowClone<float>(1, true, true);
            AssertShallowClone<double>(1, true, true);
            AssertShallowClone<char>('c', true, true);

            // Immutables
            AssertShallowClone(DateTime.Now, true, false);
            AssertShallowClone(new TimeSpan(), true, false);
            AssertShallowClone<string>("123", true, false);

            // Delegates
            AssertShallowClone<Delegate>((Action)TestDel, true, false);

            // Value Type
            AssertShallowClone<decimal>(1, true, false);
            AssertShallowClone(new HelperStruct1(), true, false);
            AssertShallowClone(new HelperStruct2(), true, false);
            AssertShallowClone(new ComplexStruct(), false, false);
            AssertShallowClone(new KeyValuePair<int, int>(1, 1), true, false);

            // Nullables
            AssertShallowClone<int?>(1, true, true);
            AssertShallowClone<decimal?>(1, true, false);

            // Ref Type
            AssertShallowClone(new List<int>(), false, false);
            AssertShallowClone(new int[0], false, false);
            AssertShallowClone(new int[0, 0], false, false);
            AssertShallowClone(new int[0, 0, 0], false, false);
            AssertShallowClone(new Dictionary<int, int>(), false, false);
        }

        #region Private Members
        private static void AssertShallowClone<T>(
            T source,
            bool canShallowClone,
            bool isPrimitive)
        {
            var type = source.GetType();
            Assert.AreEqual(isPrimitive, type.IsPrimitive);
            Assert.AreEqual(canShallowClone, type.CanShallowClone());
        }

        private static void TestDel()
        {
        }
        #endregion
    }
}