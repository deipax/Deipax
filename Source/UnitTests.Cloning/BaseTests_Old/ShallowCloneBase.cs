using System;
using Xunit;

namespace UnitTests.Cloning.BaseTests
{
    public abstract class ShallowCloneBase
    {
        [Fact]
        public virtual void IntTest()
        {
            int source = 10;
            var dest = GetClone(source, 0);
            Assert.Equal(dest, source);
        }

        [Fact]
        public virtual void DoubleTest()
        {
            double source = 10.4;
            var dest = GetClone(source, 0);
            Assert.Equal(dest, source);
        }

        [Fact]
        public virtual void DateTimeTest()
        {
            DateTime source = DateTime.Now;
            var dest = GetClone(source, 0);
            Assert.Equal(dest, source);
        }

        [Fact]
        public virtual void TimeSpanTest()
        {
            TimeSpan source = TimeSpan.FromMinutes(10.5);
            var dest = GetClone(source, 0);
            Assert.Equal(dest, source);
        }

        [Fact]
        public virtual void StringTest()
        {
            string source = "my input string";
            var dest = GetClone(source, 0);
            Assert.Same(dest, source);
        }

        [Fact]
        public virtual void EmptyStringTest()
        {
            string source = string.Empty;
            var dest = GetClone(source, 0);
            Assert.Same(dest, source);
        }

        [Fact]
        public virtual void NullStringTest()
        {
            string source = null;
            var dest = GetClone(source, 0);
            Assert.Null(dest);
        }

        [Fact]
        public virtual void DelegateTest()
        {
            Func<int, int> source = (s) => s + 10;
            var dest = GetClone(source, 0);
            Assert.Same(source, dest);
        }

        #region Protected Members
        protected abstract T GetClone<T>(T source, int expectedCount);
        #endregion
    }
}