using Deipax.Core.Conversion;
using Deipax.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.Tests
{
    [TestClass]
    public class ConvertConfigTests
    {
        [TestMethod]
        public void DefaultOverride()
        {
            var testFactory = new TestFactory();

            var count = testFactory.GetCount();
            Assert.AreEqual(0, count);

            ConvertConfig.Default = testFactory;

            var result = ConvertConfig.Get<bool, ParentClass>();

            count = testFactory.GetCount();
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void UserFactoriesOverride()
        {
            var testFactory = new TestFactory();
            var count = testFactory.GetCount();
            Assert.AreEqual(0, count);

            ConvertConfig.UserFactories = new List<IConvertFactory> { testFactory };

            var result = ConvertConfig.Get<bool, ParentClass>();

            count = testFactory.GetCount();
            Assert.AreEqual(1, count);
        }

        class TestFactory : IConvertFactory
        {
            public int _count = 0;

            public int GetCount()
            {
                return _count;
            }

            #region IConvertFactory Members
            public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
                IExpArgs<TFrom, TTo> args)
            {
                _count++;
                args.Add(args.LabelExpression);
                return args.Get();
            }
            #endregion
        }
    }
}