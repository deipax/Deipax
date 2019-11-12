using Deipax.Convert;
using Deipax.Convert.Factories;
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
            var testFactory = new TestFactory(new DefaultFactory());

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

            ConvertConfig.UserFactories = new List<IConvertFactory> { testFactory };

            var result = ConvertConfig.Get<bool, TestClass_1>();

            count = testFactory.GetCount();
            Assert.Equal(1, count);
        }

        public void Dispose()
        {
            ConvertConfig.UserFactories = null;
        }

        #region Helpers
        class TestFactory : IConvertFactory
        {
            public TestFactory()
            {
            }

            public TestFactory(IConvertFactory factory)
            {
                _factory = factory;
            }

            private int _count = 0;
            private IConvertFactory _factory;

            public int GetCount()
            {
                return _count;
            }

            public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
                IExpArgs<TFrom, TTo> args)
            {
                if (args.ToType == typeof(TestClass_1))
                {
                    _count++;
                    args.Add(args.LabelExpression);
                    return args.Get();
                }

                return _factory?.Get(args);
            }
        }

        class TestClass_1
        { }
        #endregion
    }
}