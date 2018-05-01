using BenchmarkDotNet.Attributes;
using Benchmarks.Core.TestClasses;
using Deipax.Core.Common;
using Deipax.Core.Conversion;
using Deipax.Core.Interfaces;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Benchmarks.Core.BaseClasses
{
    public abstract class SetterBase<T, P> where T : new()
    {
        public SetterBase(
            P testValue,
            Expression<Func<T, P>> memberExpression)
        {
            _instance = new T();

            var setter = ModelAccess<T>.GetSetter(memberExpression);

            _setBool = setter.Set;
            _setBoolNullable = setter.Set;
            _setChar = setter.Set;
            _setCharNullable = setter.Set;
            _setSByte = setter.Set;
            _setSByteNullable = setter.Set;
            _setByte = setter.Set;
            _setByteNullable = setter.Set;
            _setShort = setter.Set;
            _setShortNullable = setter.Set;
            _setUShort = setter.Set;
            _setUShortNullable = setter.Set;
            _setInt = setter.Set;
            _setIntNullable = setter.Set;
            _setUInt = setter.Set;
            _setUIntNullable = setter.Set;
            _setLong = setter.Set;
            _setLongNullable = setter.Set;
            _setULong = setter.Set;
            _setULongNullable = setter.Set;
            _setFloat = setter.Set;
            _setFloatNullable = setter.Set;
            _setDouble = setter.Set;
            _setDoubleNullable = setter.Set;
            _setDecimal = setter.Set;
            _setDecimalNullable = setter.Set;
            _setDateTime = setter.Set;
            _setDateTimeNullable = setter.Set;
            _setObject = setter.Set;
            _setString = setter.Set;
            _setEnum = setter.Set;

            _testValueBool = ConvertSafe<bool, P>(testValue);
            _testValueBoolNullable = ConvertSafe<bool?, P>(testValue);
            _testValueChar = ConvertSafe<char, P>(testValue);
            _testValueCharNullable = ConvertSafe<char?, P>(testValue);
            _testValueSByte = ConvertSafe<sbyte, P>(testValue);
            _testValueSByteNullable = ConvertSafe<sbyte?, P>(testValue);
            _testValueByte = ConvertSafe<byte, P>(testValue);
            _testValueByteNullable = ConvertSafe<byte?, P>(testValue);
            _testValueShort = ConvertSafe<short, P>(testValue);
            _testValueShortNullable = ConvertSafe<short?, P>(testValue);
            _testValueUShort = ConvertSafe<ushort, P>(testValue);
            _testValueUShortNullable = ConvertSafe<ushort?, P>(testValue);
            _testValueInt = ConvertSafe<int, P>(testValue);
            _testValueIntNullable = ConvertSafe<int?, P>(testValue);
            _testValueUInt = ConvertSafe<uint, P>(testValue);
            _testValueUIntNullable = ConvertSafe<uint?, P>(testValue);
            _testValueLong = ConvertSafe<long, P>(testValue);
            _testValueLongNullable = ConvertSafe<long?, P>(testValue);
            _testValueULong = ConvertSafe<ulong, P>(testValue);
            _testValueULongNullable = ConvertSafe<ulong?, P>(testValue);
            _testValueFloat = ConvertSafe<float, P>(testValue);
            _testValueFloatNullable = ConvertSafe<float?, P>(testValue);
            _testValueDouble = ConvertSafe<double, P>(testValue);
            _testValueDoubleNullable = ConvertSafe<double?, P>(testValue);
            _testValueDecimal = ConvertSafe<decimal, P>(testValue);
            _testValueDecimalNullable = ConvertSafe<decimal?, P>(testValue);
            _testValueDateTime = ConvertSafe<DateTime, P>(testValue);
            _testValueDateTimeNullable = ConvertSafe<DateTime?, P>(testValue);
            _testValueObject = ConvertSafe<object, P>(testValue);
            _testValueString = ConvertSafe<string, P>(testValue);
            _testValueEnum = ConvertSafe<TestEnum, P>(testValue);

            _provider = CultureInfo.InvariantCulture;
        }

        #region Field Member
        private object _instance;

        private Set<object> _setBool;
        private Set<object> _setBoolNullable;
        private Set<object> _setChar;
        private Set<object> _setCharNullable;
        private Set<object> _setSByte;
        private Set<object> _setSByteNullable;
        private Set<object> _setByte;
        private Set<object> _setByteNullable;
        private Set<object> _setShort;
        private Set<object> _setShortNullable;
        private Set<object> _setUShort;
        private Set<object> _setUShortNullable;
        private Set<object> _setInt;
        private Set<object> _setIntNullable;
        private Set<object> _setUInt;
        private Set<object> _setUIntNullable;
        private Set<object> _setLong;
        private Set<object> _setLongNullable;
        private Set<object> _setULong;
        private Set<object> _setULongNullable;
        private Set<object> _setFloat;
        private Set<object> _setFloatNullable;
        private Set<object> _setDouble;
        private Set<object> _setDoubleNullable;
        private Set<object> _setDecimal;
        private Set<object> _setDecimalNullable;
        private Set<object> _setDateTime;
        private Set<object> _setDateTimeNullable;
        private Set<object> _setObject;
        private Set<object> _setString;
        private Set<object> _setEnum;

        private object _testValueBool;
        private object _testValueBoolNullable;
        private object _testValueChar;
        private object _testValueCharNullable;
        private object _testValueSByte;
        private object _testValueSByteNullable;
        private object _testValueByte;
        private object _testValueByteNullable;
        private object _testValueShort;
        private object _testValueShortNullable;
        private object _testValueUShort;
        private object _testValueUShortNullable;
        private object _testValueInt;
        private object _testValueIntNullable;
        private object _testValueUInt;
        private object _testValueUIntNullable;
        private object _testValueLong;
        private object _testValueLongNullable;
        private object _testValueULong;
        private object _testValueULongNullable;
        private object _testValueFloat;
        private object _testValueFloatNullable;
        private object _testValueDouble;
        private object _testValueDoubleNullable;
        private object _testValueDecimal;
        private object _testValueDecimalNullable;
        private object _testValueDateTime;
        private object _testValueDateTimeNullable;
        private object _testValueObject;
        private object _testValueString;
        private object _testValueEnum;

        private IFormatProvider _provider;
        #endregion

        #region Public Member
        [Benchmark]
        public void FromBool()
        {
            _setBool(_instance, _testValueBool, _provider);
        }

        [Benchmark]
        public void FromBoolNullable()
        {
            _setBoolNullable(_instance, _testValueBoolNullable, _provider);
        }

        [Benchmark]
        public void FromChar()
        {
            _setChar(_instance, _testValueChar, _provider);
        }

        [Benchmark]
        public void FromCharNullable()
        {
            _setCharNullable(_instance, _testValueCharNullable, _provider);
        }

        [Benchmark]
        public void FromSByte()
        {
            _setSByte(_instance, _testValueSByte, _provider);
        }

        [Benchmark]
        public void FromSByteNullable()
        {
            _setSByteNullable(_instance, _testValueSByteNullable, _provider);
        }

        [Benchmark]
        public void FromByte()
        {
            _setByte(_instance, _testValueByte, _provider);
        }

        [Benchmark]
        public void FromByteNullable()
        {
            _setByteNullable(_instance, _testValueByteNullable, _provider);
        }

        [Benchmark]
        public void FromShort()
        {
            _setShort(_instance, _testValueShort, _provider);
        }

        [Benchmark]
        public void FromShortNullable()
        {
            _setShortNullable(_instance, _testValueShortNullable, _provider);
        }

        [Benchmark]
        public void FromUShort()
        {
            _setUShort(_instance, _testValueUShort, _provider);
        }

        [Benchmark]
        public void FromUShortNullable()
        {
            _setUShortNullable(_instance, _testValueUShortNullable, _provider);
        }

        [Benchmark]
        public void FromInt()
        {
            _setInt(_instance, _testValueInt, _provider);
        }

        [Benchmark]
        public void FromIntNullable()
        {
            _setIntNullable(_instance, _testValueIntNullable, _provider);
        }

        [Benchmark]
        public void FromUInt()
        {
            _setUInt(_instance, _testValueUInt, _provider);
        }

        [Benchmark]
        public void FromUIntNullable()
        {
            _setUIntNullable(_instance, _testValueUIntNullable, _provider);
        }

        [Benchmark]
        public void FromLong()
        {
            _setLong(_instance, _testValueLong, _provider);
        }

        [Benchmark]
        public void FromLongNullable()
        {
            _setLongNullable(_instance, _testValueLongNullable, _provider);
        }

        [Benchmark]
        public void FromULong()
        {
            _setULong(_instance, _testValueULong, _provider);
        }

        [Benchmark]
        public void FromULongNullable()
        {
            _setULongNullable(_instance, _testValueULongNullable, _provider);
        }

        [Benchmark]
        public void FromFloat()
        {
            _setFloat(_instance, _testValueFloat, _provider);
        }

        [Benchmark]
        public void FromFloatNullable()
        {
            _setFloatNullable(_instance, _testValueFloatNullable, _provider);
        }

        [Benchmark]
        public void FromDouble()
        {
            _setDouble(_instance, _testValueDouble, _provider);
        }

        [Benchmark]
        public void FromDoubleNullable()
        {
            _setDoubleNullable(_instance, _testValueDoubleNullable, _provider);
        }

        [Benchmark]
        public void FromDecimal()
        {
            _setDecimal(_instance, _testValueDecimal, _provider);
        }

        [Benchmark]
        public void FromDecimalNullable()
        {
            _setDecimalNullable(_instance, _testValueDecimalNullable, _provider);
        }

        [Benchmark]
        public void FromDateTime()
        {
            _setDateTime(_instance, _testValueDateTime, _provider);
        }

        [Benchmark]
        public void FromDateTimeNullable()
        {
            _setDateTimeNullable(_instance, _testValueDateTimeNullable, _provider);
        }

        [Benchmark]
        public void FromObject()
        {
            _setObject(_instance, _testValueObject, _provider);
        }

        [Benchmark]
        public void FromString()
        {
            _setString(_instance, _testValueString, _provider);
        }

        [Benchmark]
        public void FromEnum()
        {
            _setEnum(_instance, _testValueEnum, _provider);
        }
        #endregion

        #region Private Members
        private static TTo ConvertSafe<TTo, TFrom>(TFrom value)
        {
            try
            {
                return ConvertTo<TTo, TFrom>.From(value);
            }
            catch
            {
            }

            return default(TTo);
        }
        #endregion
    }
}