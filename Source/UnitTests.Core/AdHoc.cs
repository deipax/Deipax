using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using Deipax.Core.Conversion;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core
{
    [TestClass]
    public class AdHoc
    {
        public AdHoc()
        {
            
        }

        [TestInitialize]
        public void TestInit()
        {
            _instance = new ParentClass();
            _testValue = TestEnum.One;
            _testValueAsBool = ConvertTo<bool, TestEnum>.From(_testValue);
            _provider = CultureInfo.InvariantCulture;
            var setter = ModelAccess<ParentClass>.GetSetter(x => x.EnumProp);
            _setBool = setter.GetDelegate<bool>();
            _setBool(ref _instance, _testValueAsBool, _provider);
        }

        #region Field Members
        private ParentClass _instance;
        private Set<ParentClass, bool> _setBool;
        private TestEnum _testValue;
        private bool _testValueAsBool;
        private IFormatProvider _provider;
        #endregion

        //[TestMethod]
        public void Temp1()
        {
            _setBool(ref _instance, _testValueAsBool, _provider);
        }
    }
}