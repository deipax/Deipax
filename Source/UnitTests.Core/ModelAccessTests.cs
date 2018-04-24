using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace UnitTests.Core
{
    [TestClass]
    public class ModelAccessTests
    {
        [TestMethod]
        public void ModelAccessTests_BackingFieldCounts_GrandChildClass()
        {
            AssertBackingFieldCount<GrandChildClass>(15, 12, 24, 18, 24, 18);
        }

        [TestMethod]
        public void ModelAccessTests_BackingFieldCounts_ChildAbstractClass()
        {
            AssertBackingFieldCount<ChildAbstractClass>(10, 8, 16, 12, 16, 12);
        }

        [TestMethod]
        public void ModelAccessTests_BackingFieldCounts_ParentAbstractClass()
        {
            AssertBackingFieldCount<ParentAbstractClass>(5, 4, 8, 6, 8, 6);
        }

        [TestMethod]
        public void ModelAccessTests_GettersSetters_All()
        {
            AssertAllGettersSetters<GrandChildClass>(39, 30, 30);
            AssertAllGettersSetters<ChildAbstractClass>(26, 20, 20);
            AssertAllGettersSetters<ParentAbstractClass>(13, 10, 10);
            AssertAllGettersSetters<MyInterface>(2, 1, 1);
            AssertAllGettersSetters<MyStruct>(1, 1, 1);
            AssertAllGettersSetters<MyStaticClass>(0, 0, 0);

            AssertAllGettersSetters<int>(1, 1, 1);
            AssertAllGettersSetters<List<int>>(11, 5, 5);
            AssertAllGettersSetters<string>(4, 2, 2);
            AssertAllGettersSetters<string[]>(8, 0, 0);
            AssertAllGettersSetters<IDictionary<int, int>>(2, 0, 0);
            AssertAllGettersSetters<object>(0, 0, 0);
            AssertAllGettersSetters<DateTime>(16, 1, 1);
            AssertAllGettersSetters<TimeSpan>(12, 1, 1);
        }

        [TestMethod]
        public void ModelAccessTests_GettersSetters()
        {
            AssertGettersSetters<GrandChildClass>(31, 22, 22);
            AssertGettersSetters<ChildAbstractClass>(22, 16, 16);
            AssertGettersSetters<ParentAbstractClass>(13, 10, 10);
            AssertGettersSetters<MyInterface>(2, 1, 1);
            AssertGettersSetters<MyStruct>(1, 1, 1);
            AssertGettersSetters<MyStaticClass>(0, 0, 0);

            AssertGettersSetters<int>(1, 1, 1);
            AssertGettersSetters<List<int>>(11, 5, 5);
            AssertGettersSetters<string>(4, 2, 2);
            AssertGettersSetters<string[]>(8, 0, 0);
            AssertGettersSetters<IDictionary<int, int>>(2, 0, 0);
            AssertGettersSetters<object>(0, 0, 0);
            AssertGettersSetters<DateTime>(16, 1, 1);
            AssertGettersSetters<TimeSpan>(12, 1, 1);
        }

        [TestMethod]
        public void ModelAccessTests_AccessTest()
        {
            AssertAccess<GrandChildClass>();
        }

        [TestMethod]
        public void ModelAccessTests_GetGettersByName()
        {
            var names = ModelAccess<GrandChildClass>
                .Getters
                .Keys
                .ToList();

            Assert.IsTrue(names.Count == 31);

            foreach (var name in names)
            {
                var getter = ModelAccess<GrandChildClass>.GetGetter(name);
                Assert.IsTrue(getter != null);
            }
        }

        [TestMethod]
        public void ModelAccessTests_GetGettersByName_CaseInsensitive()
        {
            var names = ModelAccess<GrandChildClass>
                .Getters
                .Keys
                .Select(x => x.ToUpperInvariant())
                .ToList();

            Assert.IsTrue(names.Count == 31);

            foreach (var name in names)
            {
                var getter = ModelAccess<GrandChildClass>.GetGetter(name);
                Assert.IsTrue(getter != null);
            }
        }

        [TestMethod]
        public void ModelAccessTests_GetSettersByName()
        {
            var names = ModelAccess<GrandChildClass>
                .Setters
                .Keys
                .ToList();

            Assert.IsTrue(names.Count == 22);

            foreach (var name in names)
            {
                var setter = ModelAccess<GrandChildClass>.GetSetter(name);
                Assert.IsTrue(setter != null);
            }
        }

        [TestMethod]
        public void ModelAccessTests_GetSettersByName_CaseInsensitive()
        {
            var names = ModelAccess<GrandChildClass>
                .Setters
                .Keys
                .Select(x => x.ToUpperInvariant())
                .ToList();

            Assert.IsTrue(names.Count == 22);

            foreach (var name in names)
            {
                var setter = ModelAccess<GrandChildClass>.GetSetter(name);
                Assert.IsTrue(setter != null);
            }
        }

        [TestMethod]
        public void ModelAccessTests_GetGetterByExpression()
        {
            var getter = ModelAccess<GrandChildClass>.GetGetter(x => x.Child_PublicField);
            Assert.IsTrue(getter != null);
        }

        [TestMethod]
        public void ModelAccessTests_GetSetterByExpression()
        {
            var setter = ModelAccess<GrandChildClass>.GetSetter(x => x.Child_PublicField);
            Assert.IsTrue(setter != null);
        }

        [TestMethod]
        public void ModelAccessTests_StructTest()
        {
            var getter = ModelAccess<MyStruct>.GetGetter(x => x.PropTwo);
            var setter = ModelAccess<MyStruct>.GetSetter(x => x.PropTwo);

            object boxed = new MyStruct();

            setter.Set(boxed, 3);

            var tmp = (int)getter.Get(boxed);

            Assert.IsTrue(tmp == 3);
        }

        #region Private Members
        private static void AssertBackingFieldCount<T>(
            int getterFieldCount,
            int setterFieldCount,
            int getterPropCount,
            int setterPropCount,
            int getterPropBackingFieldCount,
            int setterPropBackingFieldCount)
        {
            var getterFields = ModelAccess<T>
                .AllGetters
                .Select(x => x.ModelInfo)
                .OfType<IFieldModelInfo>()
                .ToList();

            var setterFields = ModelAccess<T>
                .AllSetters
                .Select(x => x.ModelInfo)
                .OfType<IFieldModelInfo>()
                .ToList();

            var getterProps = ModelAccess<T>
                .AllGetters
                .Select(x => x.ModelInfo)
                .OfType<IPropertyModelInfo>()
                .ToList();

            var setterProps = ModelAccess<T>
                .AllSetters
                .Select(x => x.ModelInfo)
                .OfType<IPropertyModelInfo>()
                .ToList();

            Assert.AreEqual(getterFieldCount, getterFields.Count());
            Assert.AreEqual(setterFieldCount, setterFields.Count());
            Assert.AreEqual(getterPropCount, getterProps.Count());
            Assert.AreEqual(setterPropCount, setterProps.Count());

            Assert.AreEqual(0, getterFields.Where(x => x.IsBackingField).Count());
            Assert.AreEqual(0, setterFields.Where(x => x.IsBackingField).Count());

            Assert.AreEqual(getterPropBackingFieldCount, getterProps.Where(x => x.HasBackingField).Count());
            Assert.AreEqual(setterPropBackingFieldCount, setterProps.Where(x => x.HasBackingField).Count());
        }

        private static void AssertAllGettersSetters<T>(
            int getterCount,
            int setterCount,
            int intersectCount)
        {
            var getters = ModelAccess<T>
                .AllGetters
                .ToList();

            var setters = ModelAccess<T>
                .AllSetters
                .ToList();

            var intersect = Intersect<T>.CreateAll();

            Assert.IsTrue(getters.Count == getterCount);
            Assert.IsTrue(setters.Count == setterCount);
            Assert.IsTrue(intersect.Count == intersectCount);
        }

        private static void AssertGettersSetters<T>(
            int getterCount,
            int setterCount,
            int intersectCount)
        {
            var getters = ModelAccess<T>
                .Getters
                .Values
                .ToList();

            var setters = ModelAccess<T>
                .Setters
                .Values
                .ToList();

            var intersect = Intersect<T>.Create();

            Assert.IsTrue(getters.Count == getterCount);
            Assert.IsTrue(setters.Count == setterCount);
            Assert.IsTrue(intersect.Count == intersectCount);
        }

        private static void AssertAccess<T>()
        {
            var intersect = Intersect<T>.Create();

            T source = ObjectActivator<T>.Create();
            T dest = ObjectActivator<T>.Create();

            // Make sure all public and private field/props
            // are initialized.
            foreach (var i in intersect)
            {
                var randValue = RandGen.GenerateString(10);
                var setter = i.Setter;
                var getter = i.Getter;
                setter.Set(source, randValue);
                Assert.IsTrue(string.Equals(getter.Get(source), randValue));
            }

            foreach (var i in intersect)
            {
                var getter = i.Getter;
                var setter = i.Setter;
                setter.Set(dest, getter.Get(source));
            }

            foreach (var i in intersect)
            {
                var getter = i.Getter;
                Assert.IsTrue(string.Equals(getter.Get(source), getter.Get(dest)));
            }
        }
        #endregion

        #region Helpers
        class Intersect<T>
        {
            private Intersect()
            {
            }

            public static IReadOnlyList<Intersect<T>> CreateAll()
            {
                return
                (from g in ModelAccess<T>.AllGetters
                 from s in ModelAccess<T>.AllSetters
                 where
                     g.Name == s.Name &&
                     g.ModelInfo.MemberInfo.DeclaringType == s.ModelInfo.MemberInfo.DeclaringType &&
                     g.ModelInfo.Depth == s.ModelInfo.Depth
                 select new Intersect<T>()
                 {
                     Getter = g,
                     Setter = s
                 })
                .ToList();
            }

            public static IReadOnlyList<Intersect<T>> Create()
            {
                return
                (from g in ModelAccess<T>.Getters.Values
                 from s in ModelAccess<T>.Setters.Values
                 where
                     g.Name == s.Name &&
                     g.ModelInfo.MemberInfo.DeclaringType == s.ModelInfo.MemberInfo.DeclaringType &&
                     g.ModelInfo.Depth == s.ModelInfo.Depth
                 select new Intersect<T>()
                 {
                     Getter = g,
                     Setter = s
                 })
                .ToList();
            }

            public IGetter<T> Getter { get; private set; }
            public ISetter<T> Setter { get; private set; }
        }
        #endregion
    }
}