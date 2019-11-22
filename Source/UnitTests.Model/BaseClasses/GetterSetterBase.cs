using Deipax.Convert;
using Deipax.Model;
using System;
using System.Globalization;
using System.Linq.Expressions;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Model.BaseClasses
{
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
        [Fact]
        public void ToBool()
        {
            RunTest<bool>();
        }

        [Fact]
        public void ToBoolNullable()
        {
            RunTest<bool?>();
        }

        [Fact]
        public void ToChar()
        {
            RunTest<char>();
        }

        [Fact]
        public void ToCharNullable()
        {
            RunTest<char?>();
        }

        [Fact]
        public void ToSByte()
        {
            RunTest<sbyte>();
        }

        [Fact]
        public void ToSByteNullable()
        {
            RunTest<sbyte?>();
        }

        [Fact]
        public void ToByte()
        {
            RunTest<byte>();
        }

        [Fact]
        public void ToByteNullable()
        {
            RunTest<byte?>();
        }

        [Fact]
        public void ToShort()
        {
            RunTest<short>();
        }

        [Fact]
        public void ToShortNullable()
        {
            RunTest<short>();
        }

        [Fact]
        public void ToUShort()
        {
            RunTest<ushort>();
        }

        [Fact]
        public void ToUShortNullable()
        {
            RunTest<ushort?>();
        }

        [Fact]
        public void ToInt()
        {
            RunTest<int>();
        }

        [Fact]
        public void ToIntNullable()
        {
            RunTest<int?>();
        }

        [Fact]
        public void ToUInt()
        {
            RunTest<uint>();
        }

        [Fact]
        public void ToUIntNullable()
        {
            RunTest<uint?>();
        }

        [Fact]
        public void ToLong()
        {
            RunTest<long>();
        }

        [Fact]
        public void ToLongNullable()
        {
            RunTest<long?>();
        }

        [Fact]
        public void ToULong()
        {
            RunTest<ulong>();
        }

        [Fact]
        public void ToULongNullable()
        {
            RunTest<ulong?>();
        }

        [Fact]
        public void ToFloat()
        {
            RunTest<float>();
        }

        [Fact]
        public void ToFloatNullable()
        {
            RunTest<float?>();
        }

        [Fact]
        public void ToDouble()
        {
            RunTest<double>();
        }

        [Fact]
        public void ToDoubleNullable()
        {
            RunTest<double?>();
        }

        [Fact]
        public void ToDecimal()
        {
            RunTest<decimal>();
        }

        [Fact]
        public void ToDecimalNullable()
        {
            RunTest<decimal?>();
        }

        [Fact]
        public void ToDateTime()
        {
            RunTest<DateTime>();
        }

        [Fact]
        public void ToDateTimeNullable()
        {
            RunTest<DateTime?>();
        }

        [Fact]
        public void ToObject()
        {
            RunTest<object>();
        }

        [Fact]
        public void To_String()
        {
            RunTest<string>();
        }

        [Fact]
        public void ToEnum()
        {
            RunTest<TestEnum>();
        }

        [Fact]
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
            Assert.Equal(_testValue, getAsP(ref _instance));

            var getAsX = ModelAccess<T>.GetGetter(_memberExpression).GetDelegate<X>();
            var setAsX = ModelAccess<T>.GetSetter(_memberExpression).GetDelegate<X>();

            X expectedX = default;
            X actualX = default;

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

            Assert.Equal(expectedX, actualX);
        }
        #endregion
    }
}