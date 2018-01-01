using DeepCopy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Common;

namespace UnitTests.Cloning
{
    [TestClass]
    public class DeepCopyIssues
    {
        [TestMethod]
        public void Dictionary()
        {
            SimpleClass item = new SimpleClass();

            Dictionary<SimpleClass, SimpleClass> source = new Dictionary<SimpleClass, SimpleClass>()
            {
                { item, item }
            };

            var target = DeepCopier.Copy(source);

            var key = target.Keys.First();

            // Throws exception
            var value = target[key];

            Assert.AreEqual(key, value);
        }

        [TestMethod]
        public void ComplexStructAsObject()
        {
            object source = new ComplexStruct();
            var target = DeepCopier.Copy(source);
        }

        [TestMethod]
        public void ComplexStructNullable()
        {
            ComplexStruct? source = new ComplexStruct();
            var target = DeepCopier.Copy(source);
        }

        [TestMethod]
        public void DoubleSimple()
        {
            SimpleClass x = new SimpleClass();

            DoubleSimpleClass source = new DoubleSimpleClass()
            {
                One = x,
                Two = x
            };

            var target = DeepCopier.Copy(source);

            Assert.AreSame(target.One, target.Two);
        }
    }
}