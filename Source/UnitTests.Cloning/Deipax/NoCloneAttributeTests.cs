using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
    public class NoCloneAttributeTests
    {
        [TestMethod]
        public void NoCloneAttributeTests_TestClass1()
        {
            var source = new TestClass1(3, 4)
            {
                PropOne = 1,
                PropTwo = 2
            };

            var dest = source.GetClone();

            var getterPropThree = ModelAccess<TestClass1>.GetGetter("PropThree").GetDelegate<object>();
            var getterPropFour = ModelAccess<TestClass1>.GetGetter("PropFour").GetDelegate<object>();

            var destPropThree = getterPropThree(ref dest);
            var destPropFour = getterPropFour(ref dest);

            Assert.AreEqual(dest.PropOne, 1);
            Assert.AreEqual(dest.PropTwo, 2);
            Assert.AreEqual(destPropThree, 3);
            Assert.AreEqual(destPropFour, 4);
        }

        [TestMethod]
        public void NoCloneAttributeTests_TestClass2()
        {
            var source = new TestClass2(3, 4)
            {
                PropOne = 1,
                PropTwo = 2
            };

            var dest = source.GetClone();

            var getterPropThree = ModelAccess<TestClass2>.GetGetter("PropThree").GetDelegate<object>();
            var getterPropFour = ModelAccess<TestClass2>.GetGetter("PropFour").GetDelegate<object>();

            var destPropThree = getterPropThree(ref dest);
            var destPropFour = getterPropFour(ref dest);

            Assert.AreEqual(dest.PropOne, 1);
            Assert.AreEqual(dest.PropTwo, default(int));
            Assert.AreEqual(destPropThree, 3);
            Assert.AreEqual(destPropFour, default(int));
        }

        [TestMethod]
        public void NoCloneAttributeTests_TestClass3()
        {
            var source = new TestClass3(3, 4)
            {
                PropOne = 1,
                PropTwo = 2
            };

            var dest = source.GetClone();

            var getterPropThree = ModelAccess<TestClass3>.GetGetter("PropThree").GetDelegate<object>();
            var getterPropFour = ModelAccess<TestClass3>.GetGetter("PropFour").GetDelegate<object>();

            var destPropThree = getterPropThree(ref dest);
            var destPropFour = getterPropFour(ref dest);

            Assert.AreEqual(dest.PropOne, default(int));
            Assert.AreEqual(dest.PropTwo, 2);
            Assert.AreEqual(destPropThree, default(int));
            Assert.AreEqual(destPropFour, 4);
        }

        [TestMethod]
        public void NoCloneAttributeTests_TestStruct1()
        {
            var source = new TestStruct1(3, 4)
            {
                PropOne = 1,
                PropTwo = 2
            };

            var dest = source.GetClone();

            var getterPropThree = ModelAccess<TestStruct1>.GetGetter("PropThree").GetDelegate<object>();
            var getterPropFour = ModelAccess<TestStruct1>.GetGetter("PropFour").GetDelegate<object>();

            var destPropThree = getterPropThree(ref dest);
            var destPropFour = getterPropFour(ref dest);

            Assert.AreEqual(dest.PropOne, 1);
            Assert.AreEqual(dest.PropTwo, 2);
            Assert.AreEqual(destPropThree, 3);
            Assert.AreEqual(destPropFour, 4);
        }

        [TestMethod]
        public void NoCloneAttributeTests_TestStruct2()
        {
            var source = new TestStruct2(3, 4)
            {
                PropOne = 1,
                PropTwo = 2
            };

            var dest = source.GetClone();

            var getterPropThree = ModelAccess<TestStruct2>.GetGetter("PropThree").GetDelegate<object>();
            var getterPropFour = ModelAccess<TestStruct2>.GetGetter("PropFour").GetDelegate<object>();

            var destPropThree = getterPropThree(ref dest);
            var destPropFour = getterPropFour(ref dest);

            Assert.AreEqual(dest.PropOne, 1);
            Assert.AreEqual(dest.PropTwo, default(int));
            Assert.AreEqual(destPropThree, 3);
            Assert.AreEqual(destPropFour, default(int));
        }

        [TestMethod]
        public void NoCloneAttributeTests_TestStruct3()
        {
            var source = new TestStruct3(3, 4)
            {
                PropOne = 1,
                PropTwo = 2
            };

            var dest = source.GetClone();

            var getterPropThree = ModelAccess<TestStruct3>.GetGetter("PropThree").GetDelegate<object>();
            var getterPropFour = ModelAccess<TestStruct3>.GetGetter("PropFour").GetDelegate<object>();

            var destPropThree = getterPropThree(ref dest);
            var destPropFour = getterPropFour(ref dest);

            Assert.AreEqual(dest.PropOne, default(int));
            Assert.AreEqual(dest.PropTwo, 2);
            Assert.AreEqual(destPropThree, default(int));
            Assert.AreEqual(destPropFour, 4);
        }

        [TestMethod]
        public void NoCloneAttributeTests_TestClass4()
        {
            var source = new TestClass4(5, 6)
            {
                PropOne = 1,
                PropTwo = 2,
                PropThree = 3,
                PropFour = 4
            };

            CloneConfig<TestClass4>.CloneCmd = CloneCmd.All;
            CloneConfig<TestClass4>.NoClone(x => x.PropOne);
            CloneConfig<TestClass4>.NoClone(x => x.PropTwo);
            CloneConfig<TestClass4>.NoClone("PropSix");

            var propFive = ModelAccess<TestClass4>.GetGetter("PropFive").GetDelegate<object>();
            var propSix = ModelAccess<TestClass4>.GetGetter("PropSix").GetDelegate<object>();
            var dest = source.GetClone();

            Assert.AreEqual(default(int), dest.PropOne);
            Assert.AreEqual(default(int), dest.PropTwo);
            Assert.AreEqual(source.PropThree, dest.PropThree);
            Assert.AreEqual(source.PropFour, dest.PropFour);

            Assert.AreEqual(propFive(ref source), propFive(ref dest));
            Assert.AreNotEqual(default(int), propFive(ref dest));

            Assert.AreNotEqual(default(int), propSix(ref source));
            Assert.AreEqual(default(int), propSix(ref dest));
        }

        [TestMethod]
        public void NoCloneAttributeTests_TestClass5()
        {
            var propOneGet = ModelAccess<TestClass5>.GetGetter("PropOne").GetDelegate<object>();
            var propOneSet = ModelAccess<TestClass5>.GetSetter("PropOne").GetDelegate<object>();

            var propTwoGet = ModelAccess<TestClass5>.GetGetter("PropTwo").GetDelegate<object>();
            var propTwoSet = ModelAccess<TestClass5>.GetSetter("PropTwo").GetDelegate<object>();

            var propThreeGet = ModelAccess<TestClass5>.GetGetter("PropThree").GetDelegate<object>();
            var propThreeSet = ModelAccess<TestClass5>.GetSetter("PropThree").GetDelegate<object>();

            var propFourGet = ModelAccess<TestClass5>.GetGetter("PropFour").GetDelegate<object>();
            var propFourSet = ModelAccess<TestClass5>.GetSetter("PropFour").GetDelegate<object>();

            var source = new TestClass5();

            propOneSet(ref source, 1);
            propTwoSet(ref source, 2);
            propThreeSet(ref source, 3);
            propFourSet(ref source, 4);

            var dest = source.GetClone();

            Assert.AreNotEqual(default(int), propOneGet(ref source));
            Assert.AreNotEqual(default(int), propTwoGet(ref source));
            Assert.AreNotEqual(default(int), propThreeGet(ref source));
            Assert.AreNotEqual(default(int), propFourGet(ref source));

            Assert.AreEqual(propOneGet(ref source), propOneGet(ref dest));
            Assert.AreEqual(propTwoGet(ref source), propTwoGet(ref dest));
            Assert.AreEqual(default(int), propThreeGet(ref dest));
            Assert.AreEqual(default(int), propFourGet(ref dest));
        }

        #region Helper
        [CloneCmd(CloneCmd.All)]
        private class TestClass1
        {
            public TestClass1(
                int propThree,
                int propFour)
            {
                PropThree = propThree;
                PropFour = propFour;
            }

            public TestClass1()
            {
            }

            public int PropOne { get; set; }
            public int PropTwo { get; set; }
            private int PropThree { get; set; }
            private int PropFour { get; set; }
        }

        [CloneCmd(CloneCmd.All)]
        private class TestClass2
        {
            public TestClass2(
                int propThree,
                int propFour)
            {
                PropThree = propThree;
                PropFour = propFour;
            }

            public TestClass2()
            {
            }

            [Clone]
            public int PropOne { get; set; }

            [NoClone]
            public int PropTwo { get; set; }

            [Clone]
            private int PropThree { get; set; }

            [NoClone]
            private int PropFour { get; set; }
        }

        private class TestClass3
        {
            public TestClass3(
                int propThree,
                int propFour)
            {
                PropThree = propThree;
                PropFour = propFour;
            }

            public TestClass3()
            {
            }

            [NoClone]
            public int PropOne { get; set; }

            public int PropTwo { get; set; }

            private int PropThree { get; set; }

            [Clone]
            private int PropFour { get; set; }
        }

        [CloneCmd(CloneCmd.All)]
        private class TestStruct1
        {
            public TestStruct1(
                int propThree,
                int propFour)
            {
                PropThree = propThree;
                PropFour = propFour;
            }

            public TestStruct1()
            {
            }

            public int PropOne { get; set; }
            public int PropTwo { get; set; }
            private int PropThree { get; set; }
            private int PropFour { get; set; }
        }

        [CloneCmd(CloneCmd.All)]
        private class TestStruct2
        {
            public TestStruct2(
                int propThree,
                int propFour)
            {
                PropThree = propThree;
                PropFour = propFour;
            }

            public TestStruct2()
            {
            }

            [Clone]
            public int PropOne { get; set; }

            [NoClone]
            public int PropTwo { get; set; }

            [Clone]
            private int PropThree { get; set; }

            [NoClone]
            private int PropFour { get; set; }
        }

        private class TestStruct3
        {
            public TestStruct3(
                int propThree,
                int propFour)
            {
                PropThree = propThree;
                PropFour = propFour;
            }

            public TestStruct3()
            {
            }

            [NoClone]
            public int PropOne { get; set; }

            public int PropTwo { get; set; }

            private int PropThree { get; set; }

            [Clone]
            private int PropFour { get; set; }
        }

        private class TestClass4
        {
            public TestClass4(int propFive, int propSix)
            {
                PropFive = propFive;
                PropSix = propSix;
            }

            public TestClass4()
            {
            }

            public int PropOne { get; set; }
            public int PropTwo { get; set; }
            public int PropThree { get; set; }
            public int PropFour { get; set; }

            private int PropFive { get; set; }
            private int PropSix { get; set; }
        }

        [CloneCmd(CloneCmd.None)]
        private class TestClass5
        {
            [Clone]
            private int PropOne { get; set; }

            [Clone]
            private int PropTwo { get; set; }
            private int PropThree { get; set; }
            private int PropFour { get; set; }
        }
        #endregion
    }
}