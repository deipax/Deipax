using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.Core
{
    [TestClass]
    public class ConvertMapTests
    {
        [TestMethod]
        public void ConvertMap_CheckDefaults()
        {
            AssertDefault<bool>(true);
            AssertDefault<byte>(1);
            AssertDefault<char>('a');
            AssertDefault<DateTime>(DateTime.Now);
            AssertDefault<decimal>(1);
            AssertDefault<double>(1);
            AssertDefault<short>(1);
            AssertDefault<int>(1);
            AssertDefault<long>(1);
            AssertDefault<sbyte>(1);
            AssertDefault<float>(1);
            AssertDefault<string>("a");
            AssertDefault<ushort>(1);
            AssertDefault<uint>(1);
            AssertDefault<ulong>(1);
        }

        #region Private Members
        private static void AssertDefault<T>(T source)
        {
            Assert.IsTrue(ConvertMap<T>.DefaultFn != null);

            var dest = ConvertMap<T>.DefaultFn(source);

            var sourceType = source.GetType();
            var destType = dest.GetType();

            Assert.IsTrue(sourceType == destType);
            Assert.IsTrue(source.Equals(dest));
        }
        #endregion
    }
}