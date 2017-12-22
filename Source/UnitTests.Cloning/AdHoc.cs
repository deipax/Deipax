using System.Collections.Generic;
using DeepCopy;
using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace UnitTests.Cloning
{
    [TestClass]
    public class AdHoc
    {
        [TestMethod]
        public void Tmp()
        {
            IReadOnlyList<MyTmpInterface> source = new List<MyTmpInterface>()
            {
                new Helper1() { PropOne = RandGen.GenerateInt() },
                new Helper1_1() { PropOne = RandGen.GenerateInt() },
            };

            for (int i = 0; i < 1000000; i++)
            {
                IReadOnlyList<MyTmpInterface> target1 = DeipaxClone(source);
                IReadOnlyList<MyTmpInterface> target2 = DeepClone(source);
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