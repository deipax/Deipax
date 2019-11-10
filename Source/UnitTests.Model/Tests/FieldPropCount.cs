using Deipax.Model.Extensions;
using System.Linq;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Model
{
    public class FieldPropCount
    {
        [Fact]
        public void ShadowFieldProps()
        {
            AssertFields<DerivedClassOne>(10, 7, 2, 0, 0, 10, 10);
            AssertProperties<DerivedClassOne>(6, 6, 6, 0, 6, 6, 0, 4);

            AssertFields<D>(4, 4, 0, 0, 0, 4, 4);
            AssertProperties<D>(2, 2, 2, 0, 2, 2, 0, 2);
        }

        [Fact]
        public void GrandChildClass()
        {
            AssertFields<GrandChildClass>(51, 30, 15, 12, 3, 51, 39);
            AssertProperties<GrandChildClass>(30, 18, 30, 6, 30, 24, 0, 2);
        }

        [Fact]
        public void ChildAbstractClass()
        {
            AssertFields<ChildAbstractClass>(34, 20, 10, 8, 2, 34, 26);
            AssertProperties<ChildAbstractClass>(20, 12, 20, 4, 20, 16, 0, 2);
        }

        [Fact]
        public void ParentAbstractClass()
        {
            AssertFields<ParentAbstractClass>(17, 10, 5, 4, 1, 17, 13);
            AssertProperties<ParentAbstractClass>(10, 6, 10, 2, 10, 8, 0, 2);
        }

        [Fact]
        public void MyInterface()
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

            Assert.Equal(fieldCount, fields1.Count());
            Assert.Equal(backingFieldCount, backingFields.Count);
            Assert.Equal(publicFieldCount, publicFields.Count);
            Assert.Equal(staticFieldCount, staticFields.Count);
            Assert.Equal(literalFieldCount, literalFields.Count);
            Assert.Equal(canReadFieldCount, canReadFields.Count);
            Assert.Equal(canWriteFieldCount, canWriteFields.Count);
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

            Assert.Equal(propCount, props1.Count());
            Assert.Equal(publicPropCount, publicProps.Count);
            Assert.Equal(backingFieldCount, backingFields.Count);
            Assert.Equal(staticPropCount, staticProps.Count);
            Assert.Equal(canReadPropCount, canReadProps.Count);
            Assert.Equal(canWritePropCount, canWriteProps.Count);
            Assert.Equal(abstractPropCount, abstractProps.Count);
            Assert.Equal(virtualPropCount, vitrualProps.Count);
            Assert.Empty(literalProps);
            Assert.Empty(hasParameters);
        }
        #endregion
    }
}