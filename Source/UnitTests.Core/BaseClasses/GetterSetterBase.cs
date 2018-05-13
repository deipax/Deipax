using Deipax.Core.Common;
using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Linq.Expressions;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.BaseClasses
{
    [TestClass]
    public abstract class GetterSetterBase<T, P> where T : new()
    {
        public GetterSetterBase(
            P testValue,
            Expression<Func<T, P>> memberExpression)
        {
            _testValue = testValue;
            _instance = new T();
            _memberExpression = memberExpression;
            _provider = CultureInfo.InvariantCulture;
        }

        #region Field Member
        private P _testValue;
        private T _instance;
        private Expression<Func<T, P>> _memberExpression;
        private IFormatProvider _provider;
        #endregion

        #region Public Member
        [TestMethod]
        public void ToBool()
        {
            RunTest<bool>();
        }

        [TestMethod]
        public void ToBoolNullable()
        {
            RunTest<bool?>();
        }

        [TestMethod]
        public void ToChar()
        {
            RunTest<char>();
        }

        [TestMethod]
        public void ToCharNullable()
        {
            RunTest<char?>();
        }

        [TestMethod]
        public void ToSByte()
        {
            RunTest<sbyte>();
        }

        [TestMethod]
        public void ToSByteNullable()
        {
            RunTest<sbyte?>();
        }

        [TestMethod]
        public void ToByte()
        {
            RunTest<byte>();
        }

        [TestMethod]
        public void ToByteNullable()
        {
            RunTest<byte?>();
        }

        [TestMethod]
        public void ToShort()
        {
            RunTest<short>();
        }

        [TestMethod]
        public void ToShortNullable()
        {
            RunTest<short>();
        }

        [TestMethod]
        public void ToUShort()
        {
            RunTest<ushort>();
        }

        [TestMethod]
        public void ToUShortNullable()
        {
            RunTest<ushort?>();
        }

        [TestMethod]
        public void ToInt()
        {
            RunTest<int>();
        }

        [TestMethod]
        public void ToIntNullable()
        {
            RunTest<int?>();
        }

        [TestMethod]
        public void ToUInt()
        {
            RunTest<uint>();
        }

        [TestMethod]
        public void ToUIntNullable()
        {
            RunTest<uint?>();
        }

        [TestMethod]
        public void ToLong()
        {
            RunTest<long>();
        }

        [TestMethod]
        public void ToLongNullable()
        {
            RunTest<long?>();
        }

        [TestMethod]
        public void ToULong()
        {
            RunTest<ulong>();
        }

        [TestMethod]
        public void ToULongNullable()
        {
            RunTest<ulong?>();
        }

        [TestMethod]
        public void ToFloat()
        {
            RunTest<float>();
        }

        [TestMethod]
        public void ToFloatNullable()
        {
            RunTest<float?>();
        }

        [TestMethod]
        public void ToDouble()
        {
            RunTest<double>();
        }

        [TestMethod]
        public void ToDoubleNullable()
        {
            RunTest<double?>();
        }

        [TestMethod]
        public void ToDecimal()
        {
            RunTest<decimal>();
        }

        [TestMethod]
        public void ToDecimalNullable()
        {
            RunTest<decimal?>();
        }

        [TestMethod]
        public void ToDateTime()
        {
            RunTest<DateTime>();
        }

        [TestMethod]
        public void ToDateTimeNullable()
        {
            RunTest<DateTime?>();
        }

        [TestMethod]
        public void ToObject()
        {
            RunTest<object>();
        }

        [TestMethod]
        public void To_String()
        {
            RunTest<string>();
        }

        [TestMethod]
        public void ToEnum()
        {
            RunTest<TestEnum>();
        }

        [TestMethod]
        public void ToEnumNullable()
        {
            RunTest<TestEnum?>();
        }
        #endregion

        #region Private Member
        private void RunTest<X>()
        {
            var getAsP = ModelAccess<T>.GetGetter(_memberExpression).GetDelegate<P>();
            var setAsP = ModelAccess<T>.GetSetter(_memberExpression).GetDelegate<P>();

            setAsP(ref _instance, _testValue);
            Assert.AreEqual(_testValue, getAsP(ref _instance));

            var getAsX = ModelAccess<T>.GetGetter(_memberExpression).GetDelegate<X>();
            var setAsX = ModelAccess<T>.GetSetter(_memberExpression).GetDelegate<X>();

            X expectedX = default(X);
            X actualX = default(X);

            try
            {
                expectedX = ConvertTo<X, P>.From(_testValue, _provider);
                setAsX(ref _instance, expectedX);
                actualX = getAsX(ref _instance, _provider);
            }
            catch (OverflowException)
            {
            }
            catch (FormatException)
            {
            }
            catch (InvalidCastException)
            {
            }

            Assert.AreEqual(expectedX, actualX);
        }
        #endregion
    }
}