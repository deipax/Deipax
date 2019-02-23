using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using UnitTests.Common;

namespace UnitTests.Cloning
{
    [TestClass]
    public class AdHoc
    {
        public void Tmp()
        {
            var single = SimpleClass.Generate();

            var arraySame = Enumerable.Repeat(single, 10000).ToArray();
            var arraySameObjects = arraySame.Cast<object>().ToArray();

            var type = typeof(ComplexStruct);

            for (int i = 0; i < 10000000; i++)
            {
                var tmp = type.CanShallowClone();
            }
        }

        #region Private Members
        private static T DeipaxClone<T>(T source)
        {
            return source.GetClone();
        }
        #endregion
    }
}