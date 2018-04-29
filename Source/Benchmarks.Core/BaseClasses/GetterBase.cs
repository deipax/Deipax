using BenchmarkDotNet.Attributes;
using Benchmarks.Core.TestClasses;
using Deipax.Core.Common;
using Deipax.Core.Interfaces;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Benchmarks.Core.BaseClasses
{
    public abstract class GetterBase<T, P> where T : IParent, new()
    {
        public GetterBase(
            P testValue,
            Expression<Func<T, P>> memberExpression)
        {
            _testValue = testValue;
            _instanceAsObject = _instance = new T();

            var setter = ModelAccess<T>.GetSetter(memberExpression);
            setter.Set(_instanceAsObject, _testValue);

            var getter = ModelAccess<T>.GetGetter(memberExpression);

            _getBool = getter.GetDelegate<bool>();
            _getBoolNullable = getter.GetDelegate<bool?>();
            _getChar = getter.GetDelegate<char>();
            _getCharNullable = getter.GetDelegate<char?>();
            _getSByte = getter.GetDelegate<sbyte>();
            _getSByteNullable = getter.GetDelegate<sbyte?>();
            _getByte = getter.GetDelegate<byte>();
            _getByteNullable = getter.GetDelegate<byte?>();
            _getShort = getter.GetDelegate<short>();
            _getShortNullable = getter.GetDelegate<short?>();
            _getUShort = getter.GetDelegate<ushort>();
            _getUShortNullable = getter.GetDelegate<ushort?>();
            _getInt = getter.GetDelegate<int>();
            _getIntNullable = getter.GetDelegate<int?>();
            _getUInt = getter.GetDelegate<uint>();
            _getUIntNullable = getter.GetDelegate<uint?>();
            _getLong = getter.GetDelegate<long>();
            _getLongNullable = getter.GetDelegate<long?>();
            _getULong = getter.GetDelegate<ulong>();
            _getULongNullable = getter.GetDelegate<ulong?>();
            _getFloat = getter.GetDelegate<float>();
            _getFloatNullable = getter.GetDelegate<float?>();
            _getDouble = getter.GetDelegate<double>();
            _getDoubleNullable = getter.GetDelegate<double?>();
            _getDecimal = getter.GetDelegate<decimal>();
            _getDecimalNullable = getter.GetDelegate<decimal?>();
            _getDateTime = getter.GetDelegate<DateTime>();
            _getDateTimeNullable = getter.GetDelegate<DateTime?>();
            _getObject = getter.GetDelegate<object>();
            _getString = getter.GetDelegate<string>();
            _getEnum = getter.GetDelegate<TestEnum>();

            _provider = CultureInfo.InvariantCulture;
        }

        #region Field Member
        private P _testValue;
        private T _instance;
        private object _instanceAsObject;

        private Get<bool> _getBool;
        private Get<bool?> _getBoolNullable;
        private Get<char> _getChar;
        private Get<char?> _getCharNullable;
        private Get<sbyte> _getSByte;
        private Get<sbyte?> _getSByteNullable;
        private Get<byte> _getByte;
        private Get<byte?> _getByteNullable;
        private Get<short> _getShort;
        private Get<short?> _getShortNullable;
        private Get<ushort> _getUShort;
        private Get<ushort?> _getUShortNullable;
        private Get<int> _getInt;
        private Get<int?> _getIntNullable;
        private Get<uint> _getUInt;
        private Get<uint?> _getUIntNullable;
        private Get<long> _getLong;
        private Get<long?> _getLongNullable;
        private Get<ulong> _getULong;
        private Get<ulong?> _getULongNullable;
        private Get<float> _getFloat;
        private Get<float?> _getFloatNullable;
        private Get<double> _getDouble;
        private Get<double?> _getDoubleNullable;
        private Get<decimal> _getDecimal;
        private Get<decimal?> _getDecimalNullable;
        private Get<DateTime> _getDateTime;
        private Get<DateTime?> _getDateTimeNullable;
        private Get<object> _getObject;
        private Get<string> _getString;
        private Get<TestEnum> _getEnum;

        private IFormatProvider _provider;
        #endregion

        #region Public Member
        [Benchmark]
        public void ToBool()
        {
            bool x = _getBool(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToBoolNullable()
        {
            bool? x = _getBoolNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToChar()
        {
            char x = _getChar(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToCharNullable()
        {
            char? x = _getCharNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToSByte()
        {
            sbyte x = _getSByte(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToSByteNullable()
        {
            sbyte? x = _getSByteNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToByte()
        {
            byte x = _getByte(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToByteNullable()
        {
            byte? x = _getByteNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToShort()
        {
            short x = _getShort(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToShortNullable()
        {
            short? x = _getShortNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToUShort()
        {
            ushort x = _getUShort(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToUShortNullable()
        {
            ushort? x = _getUShortNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToInt()
        {
            int x = _getInt(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToIntNullable()
        {
            int? x = _getIntNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToUInt()
        {
            uint x = _getUInt(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToUIntNullable()
        {
            uint? x = _getUIntNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToLong()
        {
            long x = _getLong(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToLongNullable()
        {
            long? x = _getLongNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToULong()
        {
            ulong x = _getULong(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToULongNullable()
        {
            ulong? x = _getULongNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToFloat()
        {
            float x = _getFloat(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToFloatNullable()
        {
            float? x = _getFloatNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToDouble()
        {
            double x = _getDouble(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToDoubleNullable()
        {
            double? x = _getDoubleNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToDecimal()
        {
            decimal x = _getDecimal(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToDecimalNullable()
        {
            decimal? x = _getDecimalNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToDateTime()
        {
            DateTime x = _getDateTime(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToDateTimeNullable()
        {
            DateTime? x = _getDateTimeNullable(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToObject()
        {
            object x = _getObject(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void To_String()
        {
            string x = _getString(_instanceAsObject, _provider);
        }

        [Benchmark]
        public void ToEnum()
        {
            TestEnum x = _getEnum(_instanceAsObject, _provider);
        }
        #endregion
    }
}