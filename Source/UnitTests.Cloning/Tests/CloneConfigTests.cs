using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Common;

namespace UnitTests.Cloning
{
    [TestClass]
    public class CloneConfigTests
    {
        [TestMethod]
        public void UserFactory()
        {
            try
            {
                int callCount = 0;
                Helper1 mysource = new Helper1();

                HelperFactory<Helper1> helperFactory = new HelperFactory<Helper1>()
                {
                    MyFunc = (x, y) =>
                    {
                        callCount++;
                        return mysource;
                    }
                };

                Reset<Helper1>(factory: helperFactory);

                var source = new Helper1();
                var target = source.GetClone();

                Assert.AreSame(mysource, target);
                Assert.AreEqual(1, callCount);
            }
            finally
            {
                Reset<Helper1>();
            }
        }

        [TestMethod]
        public void Initializer_Override_Class()
        {
            try
            {
                int methodCalled = 0;

                Func<Helper5, Helper5> func = (x) =>
                {
                    methodCalled++;
                    return new Helper5(x.Prop);
                };

                Reset(initializer: func);

                var source = new Helper5(6);
                var dest = source.GetClone();

                Assert.IsNotNull(dest);
                Assert.AreNotSame(source, dest);
                Assert.AreEqual(source.Prop, dest.Prop);
                Assert.AreEqual(dest.Prop, 6);
                Assert.AreEqual(methodCalled, 1);
            }
            finally
            {
                Reset<Helper5>();
            }
        }

        [TestMethod]
        public void Initializer_Override_Struct()
        {
            try
            {
                int methodCalled = 0;

                Func<HelperStruct6, HelperStruct6> func = (x) =>
                {
                    methodCalled++;
                    return new HelperStruct6(x.Prop);
                };

                Reset(initializer: func);

                var source = new HelperStruct6(6);
                var dest = source.GetClone();

                Assert.IsNotNull(dest);
                Assert.AreEqual(source.Prop, dest.Prop);
                Assert.AreEqual(dest.Prop, 6);
                Assert.AreEqual(methodCalled, 1);
            }
            finally
            {
                Reset<HelperStruct6>();
            }
        }

        [TestMethod]
        public void CloneDel_Override_Class()
        {
            try
            {
                int methodCalled = 0;

                CloneDel<Helper1_1> cloneDel = (x, y) =>
                {
                    methodCalled++;
                    return x;
                };

                Reset(cloneDel: cloneDel);

                var source = new Helper1_1();
                source.PropOne = 6;

                var dest = source.GetClone();

                Assert.IsNotNull(dest);
                Assert.AreSame(source, dest);
                Assert.AreEqual(source.PropOne, dest.PropOne);
                Assert.AreEqual(dest.PropOne, 6);
                Assert.AreEqual(methodCalled, 1);
            }
            finally
            {
                Reset<Helper1_1>();
            }
        }

        [TestMethod]
        public void CloneDel_Override_Struct()
        {
            try
            {
                int methodCalled = 0;

                CloneDel<HelperStruct6> cloneDel = (x, y) =>
                {
                    methodCalled++;
                    return x;
                };

                Reset(cloneDel: cloneDel);

                var source = new HelperStruct6(6);
                var dest = source.GetClone();

                Assert.IsNotNull(dest);
                Assert.AreEqual(source.Prop, dest.Prop);
                Assert.AreEqual(dest.Prop, 6);
                Assert.AreEqual(methodCalled, 1);
            }
            finally
            {
                Reset<HelperStruct6>();
            }
        }

        #region Private Members
        private static void Reset<T>(
            Func<T, T> initializer = null,
            CloneDel<T> cloneDel = null,
            ICloneDelFactory factory = null)
        {
            CloneCmdConfig<T>.Reset();
            CloneConfig.UserFactories.Clear();

            if (factory != null)
            {
                CloneConfig.UserFactories.Add(factory);
            }

            CloneCmdConfig<T>.Initializer = initializer;
            CloneCmdConfig<T>.CloneDel = cloneDel;
            Cloner<T>.Reset();
        }
        #endregion

        #region Helpers
        class HelperFactory<X> : ICloneDelFactory
        {
            public CloneDel<X> MyFunc { get; set; }

            public CloneDel<T> Get<T>()
            {
                return MyFunc as CloneDel<T>;
            }
        }
        #endregion
    }
}