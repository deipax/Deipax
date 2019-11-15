using Deipax.Cloning;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System.Collections.Generic;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning
{
    public class CloneConfigTests
    {
        [Fact]
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

            Assert.Same(source, target);
            Assert.Equal(1, callCount);
        }

        [Fact]
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

            Assert.NotNull(dest);
            Assert.NotSame(source, dest);
            Assert.Equal(source.Prop, dest.Prop);
            Assert.Equal(6, dest.Prop);
            Assert.Equal(1, methodCalled);
        }

        [Fact]
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

            Assert.Equal(source.Prop, dest.Prop);
            Assert.Equal(6, dest.Prop);
            Assert.Equal(1, methodCalled);
        }

        [Fact]
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

            Assert.NotNull(dest);
            Assert.Same(source, dest);
            Assert.Equal(source.PropOne, dest.PropOne);
            Assert.Equal(6, dest.PropOne);
            Assert.Equal(1, methodCalled);
        }

        [Fact]
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

            Assert.Equal(source.Prop, dest.Prop);
            Assert.Equal(6, dest.Prop);
            Assert.Equal(1, methodCalled);
        }

        #region Helpers
        class HelperFactory<X> : ICloneDelFactory
        {
            public CloneDel<X> MyFunc { get; set; }

            public CloneDel<T> Create<T>()
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