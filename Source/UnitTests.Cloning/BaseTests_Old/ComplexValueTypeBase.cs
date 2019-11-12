using UnitTests.Common;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ComplexValueTypeBase
    {
        protected abstract T GetClone<T>(T source, int expectedCount);

        [Fact]
        public void SimpleStruct()
        {
            HelperStruct2 source = new HelperStruct2()
            {
                Helper = new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt()
                }
            };

            HelperStruct2 target = GetClone(source, 0);

            Assert.Equal(source, target);
            Assert.Equal(source.Helper.PropOne, target.Helper.PropOne);
        }

        [Fact]
        public void InheritList_Struct()
        {
            var source = new Helper3<HelperStruct1>()
            {
                new HelperStruct1()
                {
                    PropOne = RandGen.GenerateInt()
                }
            };

            source.PropOne = RandGen.GenerateInt();

            var target = GetClone(source, 1);

            Assert.NotSame(source, target);
            Assert.Equal(source.Count, target.Count);
            Assert.Equal(source[0], target[0]);
            Assert.Equal(source[0].PropOne, target[0].PropOne);
            Assert.Equal(source.PropOne, target.PropOne);
        }

        [Fact]
        public void DefaultStruct()
        {
            HelperStruct1 source = default;
            var dest = GetClone(source, 0);
            Assert.Equal(source, dest);
        }
    }
}