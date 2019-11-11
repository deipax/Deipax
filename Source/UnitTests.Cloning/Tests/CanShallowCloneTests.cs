using Deipax.Cloning;
using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTests.Common;

namespace UnitTests.Cloning
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
        public void StructByRegistrationExtension()
        {
            // Test a complex struct.
            var type = typeof(Test1Struct);
            Assert.AreEqual(false, type.CanShallowClone());
            CloneCmdConfig<Test1Struct>.ShallowCloneType = true;
            Assert.AreEqual(true, type.CanShallowClone());
        }

        [TestMethod]
        public void ComplexStructWithShallowCloneMembers()
        {
            // A complex struct whose members can be shallow
            // cloned implies the struct itself can be shallow cloned.
            var type = typeof(Test2Struct);
            Assert.AreEqual(true, type.CanShallowClone());
        }

        [TestMethod]
        public void ClassByAttributeExtension()
        {
            var type = typeof(Test3Class);
            Assert.AreEqual(true, type.CanShallowClone());
        }

        [TestMethod]
        public void ClassByRegistrationExtension()
        {
            var type = typeof(Test4Class);
            Assert.AreEqual(false, type.CanShallowClone());
            CloneCmdConfig<Test4Class>.ShallowCloneType = true;
            Assert.AreEqual(true, type.CanShallowClone());
        }

        [TestMethod]
        public void ClassByRegistration()
        {
            Test5_3Class<int> listOne = new Test5_3Class<int>();

            Test5_1Class source1 = new Test5_1Class()
            {
                PropOne = listOne
            };

            Test5_2Class source2 = new Test5_2Class()
            {
                PropOne = listOne
            };


            CloneCmdConfig<Test5_3Class<int>>.ShallowCloneType = true;

            var target1 = source1.GetClone();
            var target2 = source2.GetClone();

            Assert.AreSame(source1.PropOne, source2.PropOne);
            Assert.AreSame(source1.PropOne, target1.PropOne);
            Assert.AreSame(source2.PropOne, target2.PropOne);
            Assert.AreSame(source2.PropOne, target1.PropOne);
            Assert.AreSame(target1.PropOne, target2.PropOne);
        }

        [TestMethod]
        public void ClassByAttribute()
        {
            Test6_3Class one = new Test6_3Class();

            Test6_1Class source1 = new Test6_1Class()
            {
                PropOne = one
            };

            Test6_2Class source2 = new Test6_2Class()
            {
                PropOne = one
            };

            var target1 = source1.GetClone();
            var target2 = source2.GetClone();

            Assert.AreSame(source1.PropOne, source2.PropOne);
            Assert.AreSame(source1.PropOne, target1.PropOne);
            Assert.AreSame(source2.PropOne, target2.PropOne);
            Assert.AreSame(source2.PropOne, target1.PropOne);
            Assert.AreSame(target1.PropOne, target2.PropOne);
        }

        [TestMethod]
        public void FieldByAttribute()
        {
            Test7_2Class two = new Test7_2Class();

            Test7_1Class source1 = new Test7_1Class()
            {
                FieldOne = two,
                FieldTwo = two
            };

            var target1 = source1.GetClone();

            Assert.AreSame(source1.FieldOne, source1.FieldTwo);
            Assert.AreSame(source1.FieldOne, target1.FieldOne);
            Assert.AreNotSame(source1.FieldTwo, target1.FieldTwo);
            Assert.AreNotSame(target1.FieldOne, target1.FieldTwo);
        }

        [TestMethod]
        public void PropertyByAttribute()
        {
            Test8_2Class two = new Test8_2Class();

            Test8_1Class source1 = new Test8_1Class()
            {
                FieldOne = two,
                FieldTwo = two
            };

            var target1 = source1.GetClone();

            Assert.AreSame(source1.FieldOne, source1.FieldTwo);
            Assert.AreSame(source1.FieldOne, target1.FieldOne);
            Assert.AreNotSame(source1.FieldTwo, target1.FieldTwo);
            Assert.AreNotSame(target1.FieldOne, target1.FieldTwo);
        }

        [TestMethod]
        public void FieldByRegistration()
        {
            var type = typeof(Test9_class);
            Assert.AreEqual(false, CloneCmdConfig<Test9_class>.CanShallowClone(x => x.FieldOne));
            CloneCmdConfig<Test9_class>.ShallowCloneType = true;
            Assert.AreEqual(false, CloneCmdConfig<Test9_class>.CanShallowClone(x => x.FieldOne));
        }

        [TestMethod]
        public void PropertyByRegistration()
        {
            var type = typeof(Test10_class);
            Assert.AreEqual(false, CloneCmdConfig<Test10_class>.CanShallowClone(x => x.PropOne));
            CloneCmdConfig<Test10_class>.ShallowCloneType = true;
            Assert.AreEqual(false, CloneCmdConfig<Test10_class>.CanShallowClone(x => x.PropOne));
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
        struct Test1Struct
        {
            public int Int { get; set; }
            public Test1Class One { get; set; }
        }

        class Test1Class
        {
        }

        struct Test2Struct
        {
            public int Int { get; set; }
            public Test2Class One { get; set; }
        }

        [ShallowClone]
        class Test2Class
        {
        }

        [ShallowClone]
        class Test3Class
        {
        }

        class Test4Class
        {
        }

        class Test5_1Class
        {
            public Test5_3Class<int> PropOne { get; set; }
        }

        class Test5_2Class
        {
            public Test5_3Class<int> PropOne { get; set; }
        }

        class Test5_3Class<T> : List<T>
        {
        }

        class Test6_1Class
        {
            public Test6_3Class PropOne { get; set; }
        }

        class Test6_2Class
        {
            public Test6_3Class PropOne { get; set; }
        }

        [ShallowClone]
        class Test6_3Class
        {
        }

        class Test7_1Class
        {
            [ShallowClone]
            public Test7_2Class FieldOne;
            public Test7_2Class FieldTwo;
        }

        class Test7_2Class
        {
        }

        class Test8_1Class
        {
            [ShallowClone]
            public Test8_2Class FieldOne { get; set; }
            public Test8_2Class FieldTwo { get; set; }
        }

        class Test8_2Class
        {
        }

        class Test9_class
        {
            public int FieldOne;
        }

        class Test10_class
        {
            public int PropOne { get; set; }
        }
        #endregion
    }
}