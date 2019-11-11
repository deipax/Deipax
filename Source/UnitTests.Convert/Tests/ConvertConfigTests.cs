using Deipax.Convert;
using Deipax.Convert.Factories;
using Deipax.Convert.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Convert
{
    public class ConvertConfigTests : IDisposable
    {
        [Fact]
        public void DefaultOverride()
        {
            var testFactory = new TestFactory();

            var count = testFactory.GetCount();
            Assert.Equal(0, count);

            ConvertConfig.DefaultFactory = testFactory;

            var result = ConvertConfig.Get<bool, ParentClass>();

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

            var result = ConvertConfig.Get<bool, ParentClass>();

            count = testFactory.GetCount();
            Assert.Equal(1, count);
        }

        public void Dispose()
        {
            ConvertConfig.DefaultFactory = new DefaultFactory();
            ConvertConfig.UserFactories = null;
        }

        #region Helpers
        class TestFactory : IConvertFactory
        {
            private int _count = 0;

            public int GetCount()
            {
                return _count;
            }

            public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
                IExpArgs<TFrom, TTo> args)
            {
                _count++;
                args.Add(args.LabelExpression);
                return args.Get();
            }
        }
        #endregion
    }
}