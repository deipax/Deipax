﻿using BenchmarkDotNet.Attributes;
using Deipax.Model;
using Deipax.Model.Interfaces;
using System;
using System.Globalization;
using System.Linq.Expressions;
using UnitTests.Common;

namespace Benchmarks.Model.BaseClasses
{
    public abstract class GetterBase<T, P> where T : new()
    {
        public GetterBase(
            P testValue,
            Expression<Func<T, P>> memberExpression)
        {
            _testValue = testValue;
            _instance = new T();

            var setter = ModelAccess<T>
                .GetSetter(memberExpression)
                .GetDelegate<P>();

            setter(ref _instance, _testValue);

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
            _getEnumNullable = getter.GetDelegate<TestEnum?>();

            _provider = CultureInfo.InvariantCulture;
        }

        #region Field Member
        private P _testValue;
        private T _instance;

        private GetDelegate<T, bool> _getBool;
        private GetDelegate<T, bool?> _getBoolNullable;
        private GetDelegate<T, char> _getChar;
        private GetDelegate<T, char?> _getCharNullable;
        private GetDelegate<T, sbyte> _getSByte;
        private GetDelegate<T, sbyte?> _getSByteNullable;
        private GetDelegate<T, byte> _getByte;
        private GetDelegate<T, byte?> _getByteNullable;
        private GetDelegate<T, short> _getShort;
        private GetDelegate<T, short?> _getShortNullable;
        private GetDelegate<T, ushort> _getUShort;
        private GetDelegate<T, ushort?> _getUShortNullable;
        private GetDelegate<T, int> _getInt;
        private GetDelegate<T, int?> _getIntNullable;
        private GetDelegate<T, uint> _getUInt;
        private GetDelegate<T, uint?> _getUIntNullable;
        private GetDelegate<T, long> _getLong;
        private GetDelegate<T, long?> _getLongNullable;
        private GetDelegate<T, ulong> _getULong;
        private GetDelegate<T, ulong?> _getULongNullable;
        private GetDelegate<T, float> _getFloat;
        private GetDelegate<T, float?> _getFloatNullable;
        private GetDelegate<T, double> _getDouble;
        private GetDelegate<T, double?> _getDoubleNullable;
        private GetDelegate<T, decimal> _getDecimal;
        private GetDelegate<T, decimal?> _getDecimalNullable;
        private GetDelegate<T, DateTime> _getDateTime;
        private GetDelegate<T, DateTime?> _getDateTimeNullable;
        private GetDelegate<T, object> _getObject;
        private GetDelegate<T, string> _getString;
        private GetDelegate<T, TestEnum> _getEnum;
        private GetDelegate<T, TestEnum?> _getEnumNullable;

        private IFormatProvider _provider;
        #endregion

        #region Public Member
        [Benchmark]
        public void ToBool()
        {
            bool x = _getBool(ref _instance, _provider);
        }

        [Benchmark]
        public void ToBoolNullable()
        {
            bool? x = _getBoolNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToChar()
        {
            char x = _getChar(ref _instance, _provider);
        }

        [Benchmark]
        public void ToCharNullable()
        {
            char? x = _getCharNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToSByte()
        {
            sbyte x = _getSByte(ref _instance, _provider);
        }

        [Benchmark]
        public void ToSByteNullable()
        {
            sbyte? x = _getSByteNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToByte()
        {
            byte x = _getByte(ref _instance, _provider);
        }

        [Benchmark]
        public void ToByteNullable()
        {
            byte? x = _getByteNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToShort()
        {
            short x = _getShort(ref _instance, _provider);
        }

        [Benchmark]
        public void ToShortNullable()
        {
            short? x = _getShortNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToUShort()
        {
            ushort x = _getUShort(ref _instance, _provider);
        }

        [Benchmark]
        public void ToUShortNullable()
        {
            ushort? x = _getUShortNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToInt()
        {
            int x = _getInt(ref _instance, _provider);
        }

        [Benchmark]
        public void ToIntNullable()
        {
            int? x = _getIntNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToUInt()
        {
            uint x = _getUInt(ref _instance, _provider);
        }

        [Benchmark]
        public void ToUIntNullable()
        {
            uint? x = _getUIntNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToLong()
        {
            long x = _getLong(ref _instance, _provider);
        }

        [Benchmark]
        public void ToLongNullable()
        {
            long? x = _getLongNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToULong()
        {
            ulong x = _getULong(ref _instance, _provider);
        }

        [Benchmark]
        public void ToULongNullable()
        {
            ulong? x = _getULongNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToFloat()
        {
            float x = _getFloat(ref _instance, _provider);
        }

        [Benchmark]
        public void ToFloatNullable()
        {
            float? x = _getFloatNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToDouble()
        {
            double x = _getDouble(ref _instance, _provider);
        }

        [Benchmark]
        public void ToDoubleNullable()
        {
            double? x = _getDoubleNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToDecimal()
        {
            decimal x = _getDecimal(ref _instance, _provider);
        }

        [Benchmark]
        public void ToDecimalNullable()
        {
            decimal? x = _getDecimalNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToDateTime()
        {
            DateTime x = _getDateTime(ref _instance, _provider);
        }

        [Benchmark]
        public void ToDateTimeNullable()
        {
            DateTime? x = _getDateTimeNullable(ref _instance, _provider);
        }

        [Benchmark]
        public void ToObject()
        {
            object x = _getObject(ref _instance, _provider);
        }

        [Benchmark]
        public void To_String()
        {
            string x = _getString(ref _instance, _provider);
        }

        [Benchmark]
        public void ToEnum()
        {
            TestEnum x = _getEnum(ref _instance, _provider);
        }

        [Benchmark]
        public void ToEnumNullable()
        {
            TestEnum? x = _getEnumNullable(ref _instance, _provider);
        }
        #endregion
    }
}