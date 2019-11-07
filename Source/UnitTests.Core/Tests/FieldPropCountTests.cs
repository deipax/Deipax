using Deipax.Model.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using UnitTests.Common;

namespace UnitTests.Core
{
    [TestClass]
    public class FieldPropCountTests
    {
        [TestMethod]
        public void FieldPropCountTests_ShadowFieldProps()
        {
            AssertFields<DerivedClassOne>(10, 7, 2, 0, 0, 10, 10);
            AssertProperties<DerivedClassOne>(6, 6, 6, 0, 6, 6, 0, 4);

            AssertFields<D>(4, 4, 0, 0, 0, 4, 4);
            AssertProperties<D>(2, 2, 2, 0, 2, 2, 0, 2);
        }

        [TestMethod]
        public void FieldPropCountTests_GrandChildClass()
        {
            AssertFields<GrandChildClass>(51, 30, 15, 12, 3, 51, 39);
            AssertProperties<GrandChildClass>(30, 18, 30, 6, 30, 24, 0, 2);
        }

        [TestMethod]
        public void FieldPropCountTests_ChildAbstractClass()
        {
            AssertFields<ChildAbstractClass>(34, 20, 10, 8, 2, 34, 26);
            AssertProperties<ChildAbstractClass>(20, 12, 20, 4, 20, 16, 0, 2);
        }

        [TestMethod]
        public void FieldPropCountTests_ParentAbstractClass()
        {
            AssertFields<ParentAbstractClass>(17, 10, 5, 4, 1, 17, 13);
            AssertProperties<ParentAbstractClass>(10, 6, 10, 2, 10, 8, 0, 2);
        }

        [TestMethod]
        public void FieldPropCountTests_MyInterface()
        {
            AssertFields<MyInterface>(0, 0, 0, 0, 0, 0, 0);
            AssertProperties<MyInterface>(2, 2, 0, 0, 2, 1, 2, 2);
        }

        #region Private Members
        private static void AssertFields<T>(
            int fieldCount,
            int backingFieldCount,
            int publicFieldCount,
            int staticFieldCount,
            int literalFieldCount,
            int canReadFieldCount,
            int canWriteFieldCount)
        {
            var fields1 = typeof(T).GetAllFields();

            var backingFields = fields1
                .Where(x => x.IsBackingField)
                .ToList();

            var publicFields = fields1
                .Where(x => x.IsPublic)
                .ToList();

            var staticFields = fields1
                .Where(x => x.IsStatic)
                .ToList();

            var literalFields = fields1
                .Where(x => x.IsLiteral)
                .ToList();

            var canReadFields = fields1
                .Where(x => x.CanRead)
                .ToList();

            var canWriteFields = fields1
                .Where(x => x.CanWrite)
                .ToList();

            Assert.IsTrue(fields1.Count() == fieldCount);
            Assert.IsTrue(backingFields.Count == backingFieldCount);
            Assert.IsTrue(publicFields.Count == publicFieldCount);
            Assert.IsTrue(staticFields.Count == staticFieldCount);
            Assert.IsTrue(literalFields.Count == literalFieldCount);
            Assert.IsTrue(canReadFields.Count == canReadFieldCount);
            Assert.IsTrue(canWriteFields.Count == canWriteFieldCount);
        }

        private static void AssertProperties<T>(
            int propCount,
            int publicPropCount,
            int backingFieldCount,
            int staticPropCount,
            int canReadPropCount,
            int canWritePropCount,
            int abstractPropCount,
            int virtualPropCount)
        {
            var props1 = typeof(T).GetFilteredProperties();

            var publicProps = props1
                .Where(x => x.IsPublic)
                .ToList();

            var backingFields = props1
                .Where(x => x.HasBackingField)
                .ToList();

            var staticProps = props1
                .Where(x => x.IsStatic)
                .ToList();

            var canReadProps = props1
                .Where(x => x.CanRead)
                .ToList();

            var canWriteProps = props1
                .Where(x => x.CanWrite)
                .ToList();

            var hasParameters = props1
                .Where(x => x.HasParameters)
                .ToList();

            var abstractProps = props1
                .Where(x => x.IsAbstract)
                .ToList();

            var vitrualProps = props1
                .Where(x => x.IsVirtual)
                .ToList();

            var literalProps = props1
                .Where(x => x.IsLiteral)
                .ToList();

            Assert.IsTrue(props1.Count() == propCount);
            Assert.IsTrue(publicProps.Count == publicPropCount);
            Assert.IsTrue(backingFields.Count == backingFieldCount);
            Assert.IsTrue(staticProps.Count == staticPropCount);
            Assert.IsTrue(canReadProps.Count == canReadPropCount);
            Assert.IsTrue(canWriteProps.Count == canWritePropCount);
            Assert.IsTrue(abstractProps.Count == abstractPropCount);
            Assert.IsTrue(vitrualProps.Count == virtualPropCount);
            Assert.IsTrue(literalProps.Count == 0);
            Assert.IsTrue(hasParameters.Count == 0);
        }
        #endregion
    }
}