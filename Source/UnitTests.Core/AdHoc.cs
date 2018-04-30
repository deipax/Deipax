using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core
{
    [TestClass]
    public class AdHoc
    {
        //[TestMethod]
        public void Temp1()
        {
            var getterObject = ModelAccess<ParentClass>.GetGetter(x => x.BoolNullableField).GetDelegate<object>();
            var getterBool = ModelAccess<ParentClass>.GetGetter(x => x.BoolNullableField).GetDelegate<bool>();
            var getterBoolNullable = ModelAccess<ParentClass>.GetGetter(x => x.BoolNullableField).GetDelegate<bool?>();
            var getterString = ModelAccess<ParentClass>.GetGetter(x => x.BoolNullableField).GetDelegate<string>();

            ParentClass instance = new ParentClass();
            var objectInstance = instance;

            var tmp1 = getterBool(ref instance);
            var tmp2 = getterString(ref instance);
            var tmp3 = getterObject(ref instance);
            var tmp4 = getterBoolNullable(ref instance);
        }
    }
}