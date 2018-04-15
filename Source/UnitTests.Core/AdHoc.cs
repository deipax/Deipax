using System;
using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core
{
    [TestClass]
    public class AdHoc
    {
        private int _intValue;
        private object _intValueAsObject;

        [TestInitialize]
        public void Init()
        {
            _intValue = 1;
            _intValueAsObject = _intValue;
            int to = ConvertTo2<int, object>.From(_intValueAsObject);
        }

        //[TestMethod]
        public void Temp1()
        {
            Type intType = typeof(int);
            Type longType = typeof(long);

            var tmp1 = intType.IsAssignableFrom(longType);
            var tmp2 = longType.IsAssignableFrom(intType);

            Type iType = typeof(IParent);
            Type pType = typeof(ParentClass);

            var tmp3 = iType.IsAssignableFrom(pType);
            var tmp4 = pType.IsAssignableFrom(iType);

            ParentClass p = new ParentClass();

            IParent tmp10 = ConvertTo2<IParent, ParentClass>.From(p);
        }
    }
}