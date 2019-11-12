using System.Collections.Generic;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class AbstractBaseTests
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [Fact]
        public void IRealOnlyList_String()
        {
            IReadOnlyList<string> source = new List<string>()
            {
                RandGen.GenerateString(10)
            };

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Count, source.Count);
            Assert.Equal(dest[0], source[0]);
        }

        [Fact]
        public void GrandChildClass_AsInterface()
        {
            MyInterface source = GrandChildClassHelper.Generate();

            var dest = GetClone(source, 1);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);
            Assert.Equal(source.Parent_Public_GetSet_AutoProp, dest.Parent_Public_GetSet_AutoProp);
            Assert.Equal(source.Parent_Public_Get_AutoProp, dest.Parent_Public_Get_AutoProp);
        }

        [Fact]
        public void Struct_AsInterface()
        {
            MyTmpInterface source = new HelperStruct3()
            {
                PropOne = RandGen.GenerateInt()
            };

            var dest = GetClone(source, 0);

            Assert.NotNull(dest);
            Assert.Equal(source.PropOne, dest.PropOne);
        }

        [Fact]
        public void IRealOnlyList_Interface()
        {
            IReadOnlyList<MyTmpInterface> source = new List<MyTmpInterface>()
            {
                new Helper1() { PropOne = RandGen.GenerateInt() },
                new Helper1_1() { PropOne = RandGen.GenerateInt() },
                new HelperStruct3() {  PropOne = RandGen.GenerateInt() }
            };

            var dest = GetClone(source, 3);

            Assert.NotNull(dest);
            Assert.NotSame(dest, source);

            Assert.IsAssignableFrom<Helper1>(dest[0]);
            Assert.IsAssignableFrom<Helper1_1>(dest[1]);
            Assert.IsAssignableFrom<HelperStruct3>(dest[2]);

            Assert.Equal(source[0].PropOne, dest[0].PropOne);
            Assert.Equal(source[1].PropOne, dest[1].PropOne);
            Assert.Equal(source[2].PropOne, dest[2].PropOne);
        }

        [Fact]
        public void ListOfClasses_DuplicateReuse()
        {
            Helper1 tmp = new Helper1();

            IReadOnlyList<Helper1> source = new List<Helper1>()
            {
                tmp,
                tmp,
                tmp
            };

            var dest = GetClone(source, 2);

            Assert.NotNull(dest);
            Assert.NotEqual(dest, source);
            Assert.NotSame(dest, source);
            Assert.Equal(dest.Count, source.Count);

            var firstItem = dest[0];

            for (int i = 0; i < dest.Count; i++)
            {
                Assert.NotSame(source[i], dest[i]);
                Assert.Same(firstItem, dest[i]);
            }
        }
    }
}