using Deipax.Cloning.Common;
using Deipax.Cloning.Concretes;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning.Deipax
{
    [TestClass]
    public class CloneConfigTests
    {
        [TestMethod]
        public void UserFactory()
        {
            try
            {
                int callCount = 0;
                Helper1 mysource = new Helper1();

                HelperFactory<Helper1> helperFactory = new HelperFactory<Helper1>()
                {
                    MyFunc = (source, context) =>
                    {
                        callCount++;
                        return mysource;
                    }
                };

                CloneDelConfig.UserFactories.Add(helperFactory);

                var del = CloneDelConfig.Get<Helper1>();
                var target = del(new Helper1(), new CopyContext());

                Assert.AreSame(mysource, target);
                Assert.AreEqual(1, callCount);
            }
            finally
            {
                CloneDelConfig.UserFactories.Clear();
            }
        }

        [TestMethod]
        public void Initializer_Override_Class()
        {
            try
            {
                int methodCalled = 0;

                CloneConfig<Helper5>.Initializer = (x) =>
                {
                    methodCalled++;
                    return new Helper5(x.Prop);
                };

                var cloneDelegate = CloneDelConfig.Get<Helper5>();
                var context = new CopyContext();

                var source = new Helper5(6);
                var dest = cloneDelegate(source, context);

                Assert.IsNotNull(dest);
                Assert.AreNotSame(source, dest);
                Assert.AreEqual(source.Prop, dest.Prop);
                Assert.AreEqual(dest.Prop, 6);
                Assert.AreEqual(methodCalled, 1);
            }
            finally
            {
                CloneConfig<Helper5>.Initializer = null;
            }
        }

        [TestMethod]
        public void Initializer_Override_Struct()
        {
            try
            {
                int methodCalled = 0;

                CloneConfig<HelperStruct6>.Initializer = (x) =>
                {
                    methodCalled++;
                    return new HelperStruct6(x.Prop);
                };

                var cloneDelegate = CloneDelConfig.Get<HelperStruct6>();
                var context = new CopyContext();

                var source = new HelperStruct6(6);

                var dest = source.GetClone();

                Assert.IsNotNull(dest);
                Assert.AreEqual(source.Prop, dest.Prop);
                Assert.AreEqual(dest.Prop, 6);
                Assert.AreEqual(methodCalled, 1);       
            }
            finally
            {
                CloneConfig<HelperStruct6>.Initializer = null;
            }
        }

        #region Helpers
        class HelperFactory<X> : ICloneDelFactory
        {
            public CloneDel<X> MyFunc { get; set; }

            public CloneDel<T> Get<T>()
            {
                return MyFunc as CloneDel<T>;
            }
        }
        #endregion
    }
}