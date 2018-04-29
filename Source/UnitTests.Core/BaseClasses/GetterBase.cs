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
    public abstract class GetterBase<T, P> where T : new()
    {
        public GetterBase(
            P testValue,
            Expression<Func<T, P>> memberExpression)
        {
            _testValue = testValue;
            _instanceAsObject = new T();
            _memberExpression = memberExpression;

            var setter = ModelAccess<T>.GetSetter(memberExpression);
            setter.Set(_instanceAsObject, _testValue);

            _provider = CultureInfo.InvariantCulture;
        }

        #region Field Member
        private P _testValue;
        private object _instanceAsObject;
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
        #endregion

        #region Private Member
        private void RunTest<X>()
        {
            var getter = ModelAccess<T>.GetGetter(_memberExpression).GetDelegate<X>();
            X expected = default(X);
            X actual = default(X);

            try
            {
                expected = ConvertTo<X, P>.From(_testValue, _provider);
                actual = getter(_instanceAsObject, _provider);       
            }
            catch (OverflowException)
            {
            }
            catch (FormatException)
            {
            }

            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}