using Deipax.Cloning.Common;
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

        [TestMethod]
        public void CanShallowCloneType_CloneConfig()
        {
            var type = typeof(ComplexStruct);
            Assert.AreEqual(false, type.CanShallowClone());

            try
            {
                CloneConfig<ComplexStruct>.ShallowCloneType = true;
                Assert.AreEqual(true, type.CanShallowClone());
                CloneConfig<ComplexStruct>.Reset();
                Assert.AreEqual(false, type.CanShallowClone());
            }
            finally
            {
                CloneConfig<ComplexStruct>.Reset();
            }
        }

        [TestMethod]
        public void CanShallowCloneType_ByAttribute()
        {
            var type = typeof(HelperClass1);
            Assert.AreEqual(true, type.CanShallowClone());
        }

        [TestMethod]
        public void CanShallowCloneType_ByRegistration()
        {
            var type = typeof(HelperClass2);
            Assert.AreEqual(false, type.CanShallowClone());

            try
            {
                CloneConfig<HelperClass2>.ShallowCloneType = true;
                Assert.AreEqual(true, type.CanShallowClone());
                CloneConfig<HelperClass2>.Reset();
                Assert.AreEqual(false, type.CanShallowClone());
            }
            finally
            {
                CloneConfig<HelperClass2>.Reset();
            }
        }

        [TestMethod]
        public void CanShallowCloneType_ByRegistration_Global()
        {
            List<int> listOne = new List<int>();

            HelperClass3 source3 = new HelperClass3()
            {
                PropOne = listOne
            };

            HelperClass4 source4 = new HelperClass4()
            {
                PropOne = listOne
            };

            try
            {
                HelperClass3 target3 = source3.GetClone();
                HelperClass4 target4 = source4.GetClone();

                Assert.AreNotSame(source3.PropOne, target3.PropOne);
                Assert.AreNotSame(source4.PropOne, target4.PropOne);
                Assert.AreSame(source3.PropOne, source4.PropOne);
                Assert.AreNotSame(target3.PropOne, target4.PropOne);

                CloneConfig<List<int>>.ShallowCloneType = true;
                Cloner<List<int>>.Reset();
                Cloner<HelperClass3>.Reset();
                Cloner<HelperClass4>.Reset();

                target3 = source3.GetClone();
                target4 = source4.GetClone();

                Assert.AreSame(source3.PropOne, target3.PropOne);
                Assert.AreSame(source4.PropOne, target4.PropOne);
                Assert.AreSame(source3.PropOne, source4.PropOne);
                Assert.AreSame(target3.PropOne, target4.PropOne);
            }
            finally
            {
                CloneConfig<List<int>>.Reset();
                Cloner<List<int>>.Reset();
                Cloner<HelperClass3>.Reset();
                Cloner<HelperClass4>.Reset();
            }
        }

        [TestMethod]
        public void CanShallowCloneType_ByAttribute_Global()
        {
            HelperClass1 one = new HelperClass1();

            HelperClass5 source5 = new HelperClass5()
            {
                PropOne = one
            };

            HelperClass6 source6 = new HelperClass6()
            {
                PropOne = one
            };

            try
            {
                HelperClass5 target5 = source5.GetClone();
                HelperClass6 target6 = source6.GetClone();

                Assert.AreSame(source5.PropOne, target5.PropOne);
                Assert.AreSame(source6.PropOne, target6.PropOne);
                Assert.AreSame(source5.PropOne, source6.PropOne);
                Assert.AreSame(target5.PropOne, target6.PropOne);
            }
            finally
            {
                CloneConfig<List<int>>.Reset();
                Cloner<List<int>>.Reset();
                Cloner<HelperClass3>.Reset();
                Cloner<HelperClass4>.Reset();
            }
        }

        [TestMethod]
        public void CanShallowClone_Field()
        {
            HelperClass2 two = new HelperClass2();

            HelperClass7 source7 = new HelperClass7()
            {
                FieldOne = two,
                FieldTwo = two
            };

            try
            {
                HelperClass7 target7 = source7.GetClone();

                Assert.AreSame(source7.FieldOne, target7.FieldOne);
                Assert.AreNotSame(source7.FieldTwo, target7.FieldTwo);
                Assert.AreNotSame(target7.FieldOne, target7.FieldTwo);

                CloneConfig<HelperClass7>.ShallowClone(x => x.FieldTwo);
                Cloner<HelperClass7>.Reset();

                target7 = source7.GetClone();

                Assert.AreSame(source7.FieldOne, target7.FieldOne);
                Assert.AreSame(source7.FieldTwo, target7.FieldTwo);
                Assert.AreSame(target7.FieldOne, target7.FieldTwo);
            }
            finally
            {
                CloneConfig<HelperClass7>.Reset();
                Cloner<HelperClass7>.Reset();
            }
        }

        [TestMethod]
        public void CanShallowClone_Property()
        {
            HelperClass2 two = new HelperClass2();

            HelperClass8 source8 = new HelperClass8()
            {
                PropOne = two,
                PropTwo = two
            };

            try
            {
                HelperClass8 target8 = source8.GetClone();

                Assert.AreSame(source8.PropOne, target8.PropOne);
                Assert.AreNotSame(source8.PropTwo, target8.PropTwo);
                Assert.AreNotSame(target8.PropOne, target8.PropTwo);

                CloneConfig<HelperClass8>.ShallowClone(x => x.PropTwo);
                Cloner<HelperClass8>.Reset();

                target8 = source8.GetClone();

                Assert.AreSame(source8.PropOne, target8.PropOne);
                Assert.AreSame(source8.PropTwo, target8.PropTwo);
                Assert.AreSame(target8.PropOne, target8.PropTwo);
            }
            finally
            {
                CloneConfig<HelperClass8>.Reset();
                Cloner<HelperClass8>.Reset();
            }
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

        #region Helpers
        [ShallowClone]
        class HelperClass1
        {
        }

        class HelperClass2
        {
        }

        class HelperClass3
        {
            public List<int> PropOne { get; set; }
        }

        class HelperClass4
        {
            public List<int> PropOne { get; set; }
        }

        class HelperClass5
        {
            public HelperClass1 PropOne { get; set; }
        }

        class HelperClass6
        {
            public HelperClass1 PropOne { get; set; }
        }

        class HelperClass7
        {
            [ShallowClone]
            public HelperClass2 FieldOne;

            public HelperClass2 FieldTwo;
        }

        class HelperClass8
        {
            [ShallowClone]
            public HelperClass2 PropOne { get; set; }

            public HelperClass2 PropTwo { get; set; }
        }
        #endregion
    }
}