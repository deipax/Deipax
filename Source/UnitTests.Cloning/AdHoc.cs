using DeepCopy;
using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using UnitTests.Common;

namespace UnitTests.Cloning
{
    [TestClass]
    public class AdHoc
    {
        [TestMethod]
        public void Tmp()
        {
            var single = SimpleClass.Generate();

            var arraySame = Enumerable.Repeat(single, 10000).ToArray();
            var arraySameObjects = arraySame.Cast<object>().ToArray();

            var type = typeof(ComplexStruct);

            for (int i = 0; i < 10000000; i++)
            {
                //var target1 = DeipaxClone(arraySameObjects);
                //var target2 = DeepClone(arraySameObjects);
                var tmp = type.CanShallowClone();
            }
        }

        #region Private Members
        private static T DeipaxClone<T>(T source)
        {
            return source.GetClone();
        }

        private static T DeepClone<T>(T source)
        {
            return DeepCopier.Copy(source);
        }
        #endregion
    }
}