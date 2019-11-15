using Deipax.Convert;
using Deipax.Convert.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

            var result = ConvertConfig.Get<bool, TestClass_1>();

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

            var result = ConvertConfig.Get<bool, TestClass_1>();

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

            public Expression<ConvertDelegate<TFrom, TTo>> Create<TFrom, TTo>(
                IExpArgs<TFrom, TTo> args)
            {
                if (args.ToType == typeof(TestClass_1))
                {
                    _count++;
                    args.Add(args.LabelExpression);
                    return args.Create();
                }

                return null;
            }
        }

        class TestClass_1
        { }
        #endregion
    }
}