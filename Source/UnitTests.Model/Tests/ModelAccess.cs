using Deipax.Model;
using Deipax.Model.Interfaces;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Model
{
    public class ModelAccess
    {
        [Fact]
        public void BackingFieldCounts_GrandChildClass()
        {
            AssertBackingFieldCount<GrandChildClass>(15, 12, 24, 18, 24, 18);
        }

        [Fact]
        public void BackingFieldCounts_ChildAbstractClass()
        {
            AssertBackingFieldCount<ChildAbstractClass>(10, 8, 16, 12, 16, 12);
        }

        [Fact]
        public void BackingFieldCounts_ParentAbstractClass()
        {
            AssertBackingFieldCount<ParentAbstractClass>(5, 4, 8, 6, 8, 6);
        }

        [Fact]
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
        }

        [Fact]
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
        }

        [Fact]
        public void AccessTest()
        {
            AssertAccess<GrandChildClass>();
        }

        [Fact]
        public void GetGettersByName()
        {
            var names = ModelAccess<GrandChildClass>
                .Getters
                .Keys
                .ToList();

            Assert.Equal(31, names.Count);

            foreach (var name in names)
            {
                var getter = ModelAccess<GrandChildClass>.GetGetter(name);
                Assert.NotNull(getter);
            }
        }

        [Fact]
        public void GetGettersByName_CaseInsensitive()
        {
            var names = ModelAccess<GrandChildClass>
                .Getters
                .Keys
                .Select(x => x.ToUpperInvariant())
                .ToList();

            Assert.Equal(31, names.Count);

            foreach (var name in names)
            {
                var getter = ModelAccess<GrandChildClass>.GetGetter(name);
                Assert.NotNull(getter);
            }
        }

        [Fact]
        public void GetSettersByName()
        {
            var names = ModelAccess<GrandChildClass>
                .Setters
                .Keys
                .ToList();

            Assert.Equal(22, names.Count);

            foreach (var name in names)
            {
                var setter = ModelAccess<GrandChildClass>.GetSetter(name);
                Assert.NotNull(setter);
            }
        }

        [Fact]
        public void GetSettersByName_CaseInsensitive()
        {
            var names = ModelAccess<GrandChildClass>
                .Setters
                .Keys
                .Select(x => x.ToUpperInvariant())
                .ToList();

            Assert.Equal(22, names.Count);

            foreach (var name in names)
            {
                var setter = ModelAccess<GrandChildClass>.GetSetter(name);
                Assert.NotNull(setter);
            }
        }

        [Fact]
        public void GetGetterByExpression()
        {
            var getter = ModelAccess<GrandChildClass>.GetGetter(x => x.Child_PublicField);
            Assert.NotNull(getter);
        }

        [Fact]
        public void GetSetterByExpression()
        {
            var setter = ModelAccess<GrandChildClass>.GetSetter(x => x.Child_PublicField);
            Assert.NotNull(setter);
        }

        [Fact]
        public void StructTest()
        {
            var getter = ModelAccess<MyStruct>.GetGetter(x => x.PropTwo).GetDelegate<int>();
            var setter = ModelAccess<MyStruct>.GetSetter(x => x.PropTwo).GetDelegate<int>();

            MyStruct instance = new MyStruct();

            setter(ref instance, 3);
            var value = getter(ref instance);

            Assert.Equal(3, value);
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

            Assert.Equal(getterFieldCount, getterFields.Count());
            Assert.Equal(setterFieldCount, setterFields.Count());
            Assert.Equal(getterPropCount, getterProps.Count());
            Assert.Equal(setterPropCount, setterProps.Count());

            Assert.Empty(getterFields.Where(x => x.IsBackingField));
            Assert.Empty(setterFields.Where(x => x.IsBackingField));

            Assert.Equal(getterPropBackingFieldCount, getterProps.Where(x => x.HasBackingField).Count());
            Assert.Equal(setterPropBackingFieldCount, setterProps.Where(x => x.HasBackingField).Count());
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

            Assert.Equal(getterCount, getters.Count);
            Assert.Equal(setterCount, setters.Count);
            Assert.Equal(intersectCount, intersect.Count);
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

            Assert.Equal(getterCount, getters.Count);
            Assert.Equal(setterCount, setters.Count);
            Assert.Equal(intersectCount, intersect.Count);
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
                Assert.Equal(randValue, actual);
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
                Assert.Same(getter(ref source), getter(ref dest));
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