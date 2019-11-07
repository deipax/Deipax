﻿using Deipax.Model;
using Deipax.Model.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace UnitTests.Model
{
    [TestClass]
    public class ModelAccessTests
    {
        [TestMethod]
        public void BackingFieldCounts_GrandChildClass()
        {
            AssertBackingFieldCount<GrandChildClass>(15, 12, 24, 18, 24, 18);
        }

        [TestMethod]
        public void BackingFieldCounts_ChildAbstractClass()
        {
            AssertBackingFieldCount<ChildAbstractClass>(10, 8, 16, 12, 16, 12);
        }

        [TestMethod]
        public void BackingFieldCounts_ParentAbstractClass()
        {
            AssertBackingFieldCount<ParentAbstractClass>(5, 4, 8, 6, 8, 6);
        }

        [TestMethod]
        public void GettersSetters_All()
        {
            AssertAllGettersSetters<GrandChildClass>(39, 30, 30);
            AssertAllGettersSetters<ChildAbstractClass>(26, 20, 20);
            AssertAllGettersSetters<ParentAbstractClass>(13, 10, 10);
            AssertAllGettersSetters<MyInterface>(2, 1, 1);
            AssertAllGettersSetters<MyStruct>(1, 1, 1);
            AssertAllGettersSetters<MyStaticClass>(0, 0, 0);

            AssertAllGettersSetters<string[]>(8, 0, 0);
            AssertAllGettersSetters<IDictionary<int, int>>(2, 0, 0);
            AssertAllGettersSetters<object>(0, 0, 0);

#if NETFRAMEWORK || NETCOREAPP2_0
            AssertAllGettersSetters<string>(4, 2, 2);
            AssertAllGettersSetters<DateTime>(16, 1, 1);
            AssertAllGettersSetters<int>(1, 1, 1);
            AssertAllGettersSetters<List<int>>(11, 5, 5);
            AssertAllGettersSetters<TimeSpan>(12, 1, 1);
#elif NETCOREAPP3_0
            AssertAllGettersSetters<string>(3, 2, 2);
            AssertAllGettersSetters<DateTime>(16, 0, 0);
            AssertAllGettersSetters<int>(1, 0, 0);
            AssertAllGettersSetters<List<int>>(10, 4, 4);
            AssertAllGettersSetters<TimeSpan>(12, 0, 0);
#else
            AssertAllGettersSetters<string>(3, 2, 2);
            AssertAllGettersSetters<DateTime>(16, 0, 0);
            AssertAllGettersSetters<int>(1, 1, 1);
            AssertAllGettersSetters<List<int>>(11, 5, 5);
            AssertAllGettersSetters<TimeSpan>(12, 1, 1);
#endif
        }

        [TestMethod]
        public void GettersSetters()
        {
            AssertGettersSetters<GrandChildClass>(31, 22, 22);
            AssertGettersSetters<ChildAbstractClass>(22, 16, 16);
            AssertGettersSetters<ParentAbstractClass>(13, 10, 10);
            AssertGettersSetters<MyInterface>(2, 1, 1);
            AssertGettersSetters<MyStruct>(1, 1, 1);
            AssertGettersSetters<MyStaticClass>(0, 0, 0);
      
            AssertGettersSetters<string[]>(8, 0, 0);
            AssertGettersSetters<IDictionary<int, int>>(2, 0, 0);
            AssertGettersSetters<object>(0, 0, 0);

#if NETFRAMEWORK || NETCOREAPP2_0
            AssertGettersSetters<string>(4, 2, 2);
            AssertGettersSetters<DateTime>(16, 1, 1);
            AssertGettersSetters<int>(1, 1, 1);
            AssertGettersSetters<List<int>>(11, 5, 5);
            AssertGettersSetters<TimeSpan>(12, 1, 1);
#elif NETCOREAPP3_0
            AssertGettersSetters<string>(3, 2, 2);
            AssertGettersSetters<DateTime>(16, 0, 0);
            AssertGettersSetters<int>(1, 0, 0);
            AssertGettersSetters<List<int>>(10, 4, 4);
            AssertGettersSetters<TimeSpan>(12, 0, 0);
#else
            AssertGettersSetters<string>(3, 2, 2);
            AssertGettersSetters<DateTime>(16, 0, 0);
            AssertGettersSetters<int>(1, 1, 1);
            AssertGettersSetters<List<int>>(11, 5, 5);
            AssertGettersSetters<TimeSpan>(12, 1, 1);
#endif
        }

        [TestMethod]
        public void AccessTest()
        {
            AssertAccess<GrandChildClass>();
        }

        [TestMethod]
        public void GetGettersByName()
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
        public void GetGettersByName_CaseInsensitive()
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
        public void GetSettersByName()
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
        public void GetSettersByName_CaseInsensitive()
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
        public void GetGetterByExpression()
        {
            var getter = ModelAccess<GrandChildClass>.GetGetter(x => x.Child_PublicField);
            Assert.IsTrue(getter != null);
        }

        [TestMethod]
        public void GetSetterByExpression()
        {
            var setter = ModelAccess<GrandChildClass>.GetSetter(x => x.Child_PublicField);
            Assert.IsTrue(setter != null);
        }

        [TestMethod]
        public void StructTest()
        {
            var getter = ModelAccess<MyStruct>.GetGetter(x => x.PropTwo).GetDelegate<int>();
            var setter = ModelAccess<MyStruct>.GetSetter(x => x.PropTwo).GetDelegate<int>();

            MyStruct instance = new MyStruct();

            setter(ref instance, 3);
            var tmp = getter(ref instance);

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

            Assert.AreEqual(getterCount, getters.Count, $"For type: #{typeof(T).Name} - Getters");
            Assert.AreEqual(setterCount, setters.Count, $"For type: #{typeof(T).Name} - Setters");
            Assert.AreEqual(intersectCount, intersect.Count, $"For type: #{typeof(T).Name} - Intersect");
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

            Assert.AreEqual(getterCount, getters.Count, $"For type: #{typeof(T).Name} - Getters");
            Assert.AreEqual(setterCount, setters.Count, $"For type: #{typeof(T).Name} - Setters");
            Assert.AreEqual(intersectCount, intersect.Count, $"For type: #{typeof(T).Name} - Intersect");
        }

        private static void AssertAccess<T>() where T : new()
        {
            var intersect = Intersect<T>.Create();

            T source = new T();
            T dest = new T();

            // Make sure all public and private field/props
            // are initialized.
            foreach (var i in intersect)
            {
                var randValue = RandGen.GenerateString(10);
                var setter = i.Setter.GetDelegate<object>();
                var getter = i.Getter.GetDelegate<object>();
                setter(ref source, randValue);

                var actual = getter(ref source);
                Assert.AreEqual(randValue, actual);
            }

            foreach (var i in intersect)
            {
                var getter = i.Getter.GetDelegate<object>();
                var setter = i.Setter.GetDelegate<object>();
                setter(ref dest, getter(ref source));
            }

            foreach (var i in intersect)
            {
                var getter = i.Getter.GetDelegate<object>();
                Assert.IsTrue(Equals(getter(ref source), getter(ref dest)));
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