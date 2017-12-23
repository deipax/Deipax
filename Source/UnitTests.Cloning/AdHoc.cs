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
            var arrayDiff = Enumerable
                .Range(0, 10)
                .Select(x => GrandChildClassHelper.Generate())
                .ToArray();

            var dictDiff = arrayDiff.ToDictionary(x => x, x => GrandChildClassHelper.Generate());

            for (int i = 0; i < 10000000; i++)
            {
                var target1 = DeipaxClone(dictDiff);
                //var target2 = DeepClone(dictDiff);
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