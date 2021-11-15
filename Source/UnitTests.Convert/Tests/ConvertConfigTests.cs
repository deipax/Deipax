using Deipax.Convert;
using Deipax.Convert.Common;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.Convert
{
    public class ConvertConfigTests : IDisposable
    {
        [Fact]
        public void DefaultFactoryOverride()
        {
            var testFactory = new TestFactory();

            var count = testFactory.GetCount();
            Assert.Equal(0, count);

            ConvertConfig.DefaultFactory = testFactory;

            ConvertConfig.Get<bool, TestClass_1>();

            count = testFactory.GetCount();
            Assert.Equal(1, count);
        }

        [Fact]
        public void UserFactoriesOverride()
        {
            var testFactory = new TestFactory();
            var count = testFactory.GetCount();
            Assert.Equal(0, count);

            ConvertConfig.Factories = new List<IConvertFactory> { testFactory };

            ConvertConfig.Get<bool, TestClass_1>();

            count = testFactory.GetCount();
            Assert.Equal(1, count);
        }

        public void Dispose()
        {
            ConvertConfig.Factories = null;
        }

        #region Helpers
        class TestFactory : IConvertFactory
        {
            private int _count = 0;

            public int GetCount()
            {
                return _count;
            }

            public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
            {
                var args = new ExpBuilder<TFrom, TTo>();

                if (args.ToType == typeof(TestClass_1))
                {
                    _count++;
                    args.Add(args.LabelExpression);
                    return args.ToResult(this);
                }

                return null;
            }
        }

        class TestClass_1
        { }
        #endregion
    }
}