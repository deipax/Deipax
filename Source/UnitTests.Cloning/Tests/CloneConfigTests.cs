using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning
{
    [TestClass]
    public class CloneConfigTests
    {
        [TestMethod]
        public void UserFactory_Override()
        {
            int callCount = 0;
            var source = new TestClass1();

            HelperFactory<TestClass1> helperFactory = new HelperFactory<TestClass1>()
            {
                MyFunc = (x, y) =>
                {
                    callCount++;
                    return source;
                }
            };

            CloneConfig.UserFactories = new List<ICloneDelFactory>
            {
                helperFactory
            };

            var target = source.GetClone();

            Assert.AreSame(source, target);
            Assert.AreEqual(1, callCount);
        }

        [TestMethod]
        public void Initializer_Override_Class()
        {
            int methodCalled = 0;

            CloneConfig<TestClass2>.Initializer = (x) =>
            {
                methodCalled++;
                return new TestClass2(x.Prop);
            };

            var source = new TestClass2(6);
            var dest = source.GetClone();

            Assert.IsNotNull(dest);
            Assert.AreNotSame(source, dest);
            Assert.AreEqual(source.Prop, dest.Prop);
            Assert.AreEqual(dest.Prop, 6);
            Assert.AreEqual(methodCalled, 1);
        }

        [TestMethod]
        public void Initializer_Override_Struct()
        {
            int methodCalled = 0;

            CloneConfig<TestStruct1>.Initializer = (x) =>
            {
                methodCalled++;
                return new TestStruct1(x.Prop);
            };

            var source = new TestStruct1(6);
            var dest = source.GetClone();

            Assert.IsNotNull(dest);
            Assert.AreEqual(source.Prop, dest.Prop);
            Assert.AreEqual(dest.Prop, 6);
            Assert.AreEqual(1, methodCalled);
        }

        [TestMethod]
        public void CloneDel_Override_Class()
        {
            int methodCalled = 0;

            CloneConfig<TestClass3>.CloneDel = (x, y) =>
            {
                methodCalled++;
                return x;
            };

            var source = new TestClass3();
            source.PropOne = 6;

            var dest = source.GetClone();

            Assert.IsNotNull(dest);
            Assert.AreSame(source, dest);
            Assert.AreEqual(source.PropOne, dest.PropOne);
            Assert.AreEqual(dest.PropOne, 6);
            Assert.AreEqual(methodCalled, 1);
        }

        [TestMethod]
        public void CloneDel_Override_Struct()
        {
            int methodCalled = 0;

            CloneConfig<TestStruct2>.CloneDel = (x, y) =>
            {
                methodCalled++;
                return x;
            };

            var source = new TestStruct2(6);
            var dest = source.GetClone();

            Assert.IsNotNull(dest);
            Assert.AreEqual(source.Prop, dest.Prop);
            Assert.AreEqual(dest.Prop, 6);
            Assert.AreEqual(1, methodCalled);
        }

        #region Helpers
        class HelperFactory<X> : ICloneDelFactory
        {
            public CloneDel<X> MyFunc { get; set; }

            public CloneDel<T> Get<T>()
            {
                return MyFunc as CloneDel<T>;
            }
        }

        class TestClass1
        {
        }

        class TestClass2
        {
            public TestClass2(int prop)
            {
                this.Prop = prop;
            }

            public int Prop { get; private set; }
        }

        class TestClass3
        {
            public int PropOne { get; set; }
        }

        struct TestStruct1
        {
            public TestStruct1(int prop)
            {
                this.Prop = prop;
                this.Helper1 = new Helper1();
            }

            public int Prop { get; private set; }
            public Helper1 Helper1 { get; set; }
        }

        struct TestStruct2
        {
            public TestStruct2(int prop)
            {
                this.Prop = prop;
                this.Helper1 = new Helper1();
            }

            public int Prop { get; private set; }
            public Helper1 Helper1 { get; set; }
        }
        #endregion
    }
}