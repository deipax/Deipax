using Deipax.Cloning;
using Deipax.Cloning.Common;
using System;
using UnitTests.Cloning.BaseTests;
using Xunit;

namespace UnitTests.Cloning
{
    public class ComplexRefTypeTests : ComplexRefTypeBase
    {
        protected override T GetClone<T>(T source, int expectedCount)
        {
            CopyContext c = new CopyContext();
            T target = Cloner<T>.Get(source, c);
            Assert.Equal(expectedCount, c.GetCount());
            return target;
        }

        [Fact]
        public override void Anon()
        {
            Assert.Throws<NotSupportedException>(() => base.Anon());
        }

        [Fact]
        public override void NoDefaultConstructor_Class()
        {
            Assert.Throws<ArgumentException>(() => base.NoDefaultConstructor_Class());
        }
    }
}