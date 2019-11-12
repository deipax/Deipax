using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ComplexRefTypeBase
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [Fact]
        public virtual void ObjectsAreReused()
        {
            Helper1 helper1 = new Helper1();
            Helper2 helper2 = new Helper2()
            {
                Helper = helper1
            };

            List<Helper2> source = new List<Helper2>()
            {
                helper2,
                helper2,
            };

            var target = GetClone(source, 3);

            Assert.NotNull(target);
            Assert.Equal(target.Count, source.Count);

            Assert.NotSame(target, source);

            Assert.NotSame(target[0], source[0]);
            Assert.NotSame(target[0], helper1);
            Assert.NotSame(target[0].Helper, source[0].Helper);
            Assert.NotSame(target[0].Helper, helper2);

            Assert.NotSame(target[1], source[1]);
            Assert.NotSame(target[1], helper1);
            Assert.NotSame(target[1].Helper, source[1].Helper);
            Assert.NotSame(target[1].Helper, helper2);

            Assert.Same(target[0], target[1]);
            Assert.Same(target[0].Helper, target[1].Helper);
        }

        [Fact]
        public virtual void SimpleClass()
        {
            Helper2 source = new Helper2()
            {
                Helper = new Helper1()
                {
                    PropOne = RandGen.GenerateInt()
                }
            };

            Helper2 dest = GetClone(source, 2);

            Assert.NotNull(dest);
            Assert.NotNull(dest.Helper);
            Assert.NotSame(dest.Helper, source.Helper);
            Assert.Equal(dest.Helper.PropOne, source.Helper.PropOne);
        }

        [Fact]
        public virtual void Null()
        {
            Helper1 source = null;
            var dest = GetClone(source, 0);
            Assert.Null(dest);
        }

        [Fact]
        public virtual void InheritList_Class()
        {
            var source = new Helper3<Helper1>()
            {
                PropOne = RandGen.GenerateInt()
            };

            for (int i = 0; i < 1000; i++)
            {
                source.Add(new Helper1()
                {
                    PropOne = RandGen.GenerateInt()
                });
            };

            var target = GetClone(source, 1001);

            Assert.NotSame(source, target);
            Assert.Equal(target.Count, source.Count);
            Assert.Equal(target.PropOne, source.PropOne);

            for (int i = 0; i < target.Count; i++)
            {
                Assert.NotSame(target[i], source[i]);
                Assert.Equal(target[i].PropOne, source[i].PropOne);
            }
        }

        [Fact]
        public virtual void InheritList_Int()
        {
            var source = new Helper3<int>();

            for (int i = 0; i < 1000; i++)
            {
                source.Add(RandGen.GenerateInt());
            };

            var target = GetClone(source, 1);

            Assert.NotSame(source, target);
            Assert.Equal(target.Count, source.Count);

            for (int i = 0; i < target.Count; i++)
            {
                Assert.Equal(target[i], source[i]);
            }
        }

        [Fact]
        public virtual void InheritList_Stuct()
        {
            var source = new Helper3<HelperStruct1>()
            {
                PropOne = RandGen.GenerateInt()
            };

            for (int i = 0; i < 1000; i++)
            {
                source.Add(new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt()
                });
            };

            var target = GetClone(source, 1);

            Assert.NotSame(source, target);
            Assert.Equal(source.Count, target.Count);
            Assert.Equal(source.PropOne, target.PropOne);

            for (int i = 0; i < target.Count; i++)
            {
                Assert.Equal(source[i].PropOne, target[i].PropOne);
            }
        }

        [Fact]
        public virtual void CyclicalReference()
        {
            Helper4 source = new Helper4();
            source.Prop = source;

            var target = GetClone(source, 1);

            Assert.NotSame(source, target);
            Assert.Same(target, target.Prop);
        }

        [Fact]
        public virtual void ListOfClasses()
        {
            List<Helper2> source = new List<Helper2>();

            for (int i = 0; i < 1000; i++)
            {
                source.Add(new Helper2()
                {
                    Helper = new Helper1()
                    {
                        PropOne = RandGen.GenerateInt()
                    }
                });
            }

            List<Helper2> dest = GetClone(source, 2001);

            Assert.NotNull(dest);
            Assert.Equal(dest.Count, source.Count);

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.NotSame(dest[i], source[i]);
                Assert.NotSame(dest[i].Helper, source[i].Helper);
                Assert.Equal(dest[i].Helper.PropOne, source[i].Helper.PropOne);
            }
        }

        [Fact]
        public virtual void ListOfStructs()
        {
            List<HelperStruct2> source = new List<HelperStruct2>()
            {
                new HelperStruct2()
                {
                    Helper = new HelperStruct1()
                    {
                        PropOne = RandGen.GenerateInt()
                    }
                }
            };

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.Equal(source.Count, dest.Count);
            Assert.Equal(source[0].Helper.PropOne, dest[0].Helper.PropOne);
        }

        [Fact]
        public virtual void DictionaryOfStructs()
        {
            Dictionary<HelperStruct1, HelperStruct1> source = new Dictionary<HelperStruct1, HelperStruct1>();

            for (int i = 0; i < 1000; i++)
            {
                source.Add(new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt() + i
                },
                new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt() + i
                });
            }

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.Equal(dest.Count, source.Count);

            var destKeys = dest.Keys.ToList();
            var destValues = dest.Values.ToList();
            var sourceKeys = source.Keys.ToList();
            var sourceValues = source.Values.ToList();

            for (int i = 0; i < dest.Keys.Count; i++)
            {
                Assert.True(source.ContainsKey(destKeys[i]));
                Assert.True(dest.ContainsKey(sourceKeys[i]));

                Assert.Equal(destKeys[i].PropOne, sourceKeys[i].PropOne);
                Assert.Equal(destValues[i], sourceValues[i]);
                Assert.Equal(destValues[i].PropOne, sourceValues[i].PropOne);
            }
        }

        [Fact]
        public virtual void DictionaryOfClasses()
        {
            Dictionary<Helper1, Helper1> source = new Dictionary<Helper1, Helper1>();

            for (int i = 0; i < 1000; i++)
            {
                source.Add(new Helper1()
                {
                    PropOne = RandGen.GenerateInt()
                },
                new Helper1()
                {
                    PropOne = RandGen.GenerateInt()
                });
            }

            var dest = GetClone(source, 2001);

            Assert.NotNull(dest);
            Assert.Equal(dest.Count, source.Count);

            var destKeys = dest.Keys.ToList();
            var destValues = dest.Values.ToList();
            var sourceKeys = source.Keys.ToList();
            var sourceValues = source.Values.ToList();

            for (int i = 0; i < dest.Keys.Count; i++)
            {
                Assert.NotSame(destKeys[i], sourceKeys[i]);
                Assert.Equal(destKeys[i].PropOne, sourceKeys[i].PropOne);

                Assert.NotSame(destValues[i], sourceValues[i]);
                Assert.Equal(destValues[i].PropOne, sourceValues[i].PropOne);
            }
        }

        [Fact]
        public virtual void DictionaryOfPrimitives()
        {
            Dictionary<int, int> source = new Dictionary<int, int>();

            for (int i = 0; i < 1000; i++)
            {
                source.Add(i, RandGen.GenerateInt());
            }

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.Equal(dest.Count, source.Count);

            foreach (var key in dest.Keys)
            {
                Assert.Equal(dest[key], source[key]);
            }
        }

        [Fact]
        public virtual void ListStringArrays_DuplicateReuse()
        {
            var helper = RandGen
                .GenerateStringList(20, 5).
                ToArray();

            List<string[]> source = new List<string[]>()
            {
                helper,
                helper,
                helper,
                helper
            };

            var dest = GetClone(source, 2);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Count, source.Count);

            var firstItem = dest[0];

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.NotSame(source[i], dest[i]);
                Assert.Same(firstItem, dest[i]);
                Assert.Equal(source[i].Length, dest[i].Length);

                for (int j = 0; j < dest[i].Length; j++)
                {
                    Assert.Equal(source[i][j], dest[i][j]);
                }
            }
        }

        [Fact]
        public virtual void PolymorphicSupport()
        {
            Message source = new Message()
            {
                aRef = new Derived()
                {
                    iBase = RandGen.GenerateInt(),
                    iDerived = RandGen.GenerateInt()
                }
            };

            var dest = GetClone(source, 2);

            Assert.NotNull(dest);
            Assert.NotNull(dest.aRef);
            Assert.NotSame(dest, source);
            Assert.NotSame(dest.aRef, source.aRef);
            Assert.Equal(dest.aRef.iBase, source.aRef.iBase);

            Assert.IsType<Derived>(source.aRef);
            Assert.IsType<Derived>(dest.aRef);
        }

        [Fact]
        public virtual void ListOfObjects()
        {
            List<object> source = new List<object>()
            {
                1,
                (double)2,
                new Helper1(),
                new Helper2()
                {
                    Helper = new Helper1()
                },
                RandGen.GenerateString(10)
            };

            var target = GetClone(source, 4);

            Assert.NotNull(target);
            Assert.NotSame(source, target);

            Assert.Equal(source[0], target[0]);
            Assert.IsType<int>(target[0]);

            Assert.Equal(source[1], target[1]);
            Assert.IsType<double>(target[1]);

            Assert.NotSame(source[2], target[2]);
            Assert.NotEqual(source[2], target[2]);
            Assert.IsType<Helper1>(target[2]);

            Assert.NotSame(source[3], target[3]);
            Assert.NotEqual(source[3], target[3]);
            Assert.IsType<Helper2>(target[3]);

            Assert.Equal(source[4], target[4]);
            Assert.IsType<string>(target[4]);
        }

        [Fact]
        public virtual void Object()
        {
            object source = new object();
            var target = GetClone(source, 1);
            Assert.NotNull(target);
            Assert.NotSame(source, target);
        }

        [Fact]
        public virtual void IntAsObject()
        {
            int sourceAsInt = 1;
            object source = sourceAsInt;
            var target = GetClone(source, 0);

            Assert.NotNull(target);

            var targetAsInt = (int)target;

            Assert.Equal(sourceAsInt, targetAsInt);
        }

        [Fact]
        public virtual void Anon()
        {
            var source = new
            {
                PropAnon = 1
            };

            var target = GetClone(source, 1);

            Assert.Equal(target, source);
            Assert.NotSame(target, source);
        }

        [Fact]
        public virtual void ShadowFieldProps1()
        {
            DerivedClassOne source = new DerivedClassOne()
            {
                MyField = 1,
                Property = 1,
                VirtualProperty = 2,
                VirtualProperty2 = 3,
                AbstractProperty = 4,
                VirtualProperty3 = "test1"
            };

            Assert.Equal(2, source.VirtualProperty);
            Assert.Equal(3, source.VirtualProperty2);
            Assert.Equal(4, source.AbstractProperty);
            Assert.Equal("test1", source.VirtualProperty3);

            ((BaseClassOne)source).MyField = 2;
            ((BaseClassOne)source).Property = 5;
            source.VirtualProperty = 6;
            source.VirtualProperty2 = 7;
            source.AbstractProperty = 8;
            source.VirtualProperty3 = "test2";

            Assert.Equal(1, source.MyField);
            Assert.Equal(2, ((BaseClassOne)source).MyField);

            Assert.Equal(1, source.Property);
            Assert.Equal(5, ((BaseClassOne)source).Property);

            Assert.Equal(6, source.VirtualProperty);
            Assert.Equal(6, source.VirtualProperty);

            Assert.Equal(7, source.VirtualProperty2);
            Assert.Equal(7, source.VirtualProperty2);

            Assert.Equal(8, source.AbstractProperty);
            Assert.Equal(8, source.AbstractProperty);

            Assert.Equal("test2", source.VirtualProperty3);
            Assert.Equal("test2", source.VirtualProperty3);

            var target = GetClone(source, 1);

            Assert.Equal(1, target.MyField);
            Assert.Equal(2, ((BaseClassOne)target).MyField);

            Assert.Equal(1, target.Property);
            Assert.Equal(5, ((BaseClassOne)target).Property);

            Assert.Equal(6, target.VirtualProperty);
            Assert.Equal(6, target.VirtualProperty);

            Assert.Equal(7, target.VirtualProperty2);
            Assert.Equal(7, target.VirtualProperty2);

            Assert.Equal(8, target.AbstractProperty);
            Assert.Equal(8, target.AbstractProperty);

            Assert.Equal("test2", target.VirtualProperty3);
            Assert.Equal("test2", target.VirtualProperty3);
        }

        [Fact]
        public virtual void ShadowFieldProps2()
        {
            D source = new D()
            {
                Foo = "D"
            };

            source.Foo = "C";
            ((B)source).Foo = "B";
            ((A)source).Foo = "A";

            Assert.Equal("C", source.Foo);
            Assert.Equal("C", source.Foo);
            Assert.Equal("A", ((B)source).Foo);
            Assert.Equal("A", ((A)source).Foo);

            var target = GetClone(source, 1);

            Assert.Equal("C", target.Foo);
            Assert.Equal("C", target.Foo);
            Assert.Equal("A", ((B)target).Foo);
            Assert.Equal("A", ((A)target).Foo);
        }

        [Fact]
        public virtual void NoDefaultConstructor_Class()
        {
            var source = new Helper5(1);
            GetClone(source, 1);
        }
    }
}