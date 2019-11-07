using BenchmarkDotNet.Attributes;
using Benchmarks.Core.TestClasses;
using Deipax.Convert;
using Deipax.Model;
using Deipax.Model.Interfaces;
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

            _setBool = setter.GetDelegate<bool>();
            _setBoolNullable = setter.GetDelegate<bool?>();
            _setChar = setter.GetDelegate<char>();
            _setCharNullable = setter.GetDelegate<char?>();
            _setSByte = setter.GetDelegate<sbyte>();
            _setSByteNullable = setter.GetDelegate<sbyte?>();
            _setByte = setter.GetDelegate<byte>();
            _setByteNullable = setter.GetDelegate<byte?>();
            _setShort = setter.GetDelegate<short>();
            _setShortNullable = setter.GetDelegate<short?>();
            _setUShort = setter.GetDelegate<ushort>();
            _setUShortNullable = setter.GetDelegate<ushort?>();
            _setInt = setter.GetDelegate<int>();
            _setIntNullable = setter.GetDelegate<int?>();
            _setUInt = setter.GetDelegate<uint>();
            _setUIntNullable = setter.GetDelegate<uint?>();
            _setLong = setter.GetDelegate<long>();
            _setLongNullable = setter.GetDelegate<long?>();
            _setULong = setter.GetDelegate<ulong>();
            _setULongNullable = setter.GetDelegate<ulong?>();
            _setFloat = setter.GetDelegate<float>();
            _setFloatNullable = setter.GetDelegate<float?>();
            _setDouble = setter.GetDelegate<double>();
            _setDoubleNullable = setter.GetDelegate<double?>();
            _setDecimal = setter.GetDelegate<decimal>();
            _setDecimalNullable = setter.GetDelegate<decimal?>();
            _setDateTime = setter.GetDelegate<DateTime>();
            _setDateTimeNullable = setter.GetDelegate<DateTime?>();
            _setObject = setter.GetDelegate<object>();
            _setString = setter.GetDelegate<string>();
            _setEnum = setter.GetDelegate<TestEnum>();
            _setEnumNullable = setter.GetDelegate<TestEnum?>();

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
            _testValueEnumNullable = ConvertSafe<TestEnum?, P>(testValue);

            _provider = CultureInfo.InvariantCulture;
        }

        #region Field Member
        private T _instance;

        private Set<T, bool> _setBool;
        private Set<T, bool?> _setBoolNullable;
        private Set<T, char> _setChar;
        private Set<T, char?> _setCharNullable;
        private Set<T, sbyte> _setSByte;
        private Set<T, sbyte?> _setSByteNullable;
        private Set<T, byte> _setByte;
        private Set<T, byte?> _setByteNullable;
        private Set<T, short> _setShort;
        private Set<T, short?> _setShortNullable;
        private Set<T, ushort> _setUShort;
        private Set<T, ushort?> _setUShortNullable;
        private Set<T, int> _setInt;
        private Set<T, int?> _setIntNullable;
        private Set<T, uint> _setUInt;
        private Set<T, uint?> _setUIntNullable;
        private Set<T, long> _setLong;
        private Set<T, long?> _setLongNullable;
        private Set<T, ulong> _setULong;
        private Set<T, ulong?> _setULongNullable;
        private Set<T, float> _setFloat;
        private Set<T, float?> _setFloatNullable;
        private Set<T, double> _setDouble;
        private Set<T, double?> _setDoubleNullable;
        private Set<T, decimal> _setDecimal;
        private Set<T, decimal?> _setDecimalNullable;
        private Set<T, DateTime> _setDateTime;
        private Set<T, DateTime?> _setDateTimeNullable;
        private Set<T, object> _setObject;
        private Set<T, string> _setString;
        private Set<T, TestEnum> _setEnum;
        private Set<T, TestEnum?> _setEnumNullable;

        private bool _testValueBool;
        private bool? _testValueBoolNullable;
        private char _testValueChar;
        private char? _testValueCharNullable;
        private sbyte _testValueSByte;
        private sbyte? _testValueSByteNullable;
        private byte _testValueByte;
        private byte? _testValueByteNullable;
        private short _testValueShort;
        private short? _testValueShortNullable;
        private ushort _testValueUShort;
        private ushort? _testValueUShortNullable;
        private int _testValueInt;
        private int? _testValueIntNullable;
        private uint _testValueUInt;
        private uint? _testValueUIntNullable;
        private long _testValueLong;
        private long? _testValueLongNullable;
        private ulong _testValueULong;
        private ulong? _testValueULongNullable;
        private float _testValueFloat;
        private float? _testValueFloatNullable;
        private double _testValueDouble;
        private double? _testValueDoubleNullable;
        private decimal _testValueDecimal;
        private decimal? _testValueDecimalNullable;
        private DateTime _testValueDateTime;
        private DateTime? _testValueDateTimeNullable;
        private object _testValueObject;
        private string _testValueString;
        private TestEnum _testValueEnum;
        private TestEnum? _testValueEnumNullable;

        private IFormatProvider _provider;
        #endregion

        #region Public Member
        [Benchmark]
        public void FromBool()
        {
            _setBool(ref _instance, _testValueBool, _provider);
        }

        [Benchmark]
        public void FromBoolNullable()
        {
            _setBoolNullable(ref _instance, _testValueBoolNullable, _provider);
        }

        [Benchmark]
        public void FromChar()
        {
            _setChar(ref _instance, _testValueChar, _provider);
        }

        [Benchmark]
        public void FromCharNullable()
        {
            _setCharNullable(ref _instance, _testValueCharNullable, _provider);
        }

        [Benchmark]
        public void FromSByte()
        {
            _setSByte(ref _instance, _testValueSByte, _provider);
        }

        [Benchmark]
        public void FromSByteNullable()
        {
            _setSByteNullable(ref _instance, _testValueSByteNullable, _provider);
        }

        [Benchmark]
        public void FromByte()
        {
            _setByte(ref _instance, _testValueByte, _provider);
        }

        [Benchmark]
        public void FromByteNullable()
        {
            _setByteNullable(ref _instance, _testValueByteNullable, _provider);
        }

        [Benchmark]
        public void FromShort()
        {
            _setShort(ref _instance, _testValueShort, _provider);
        }

        [Benchmark]
        public void FromShortNullable()
        {
            _setShortNullable(ref _instance, _testValueShortNullable, _provider);
        }

        [Benchmark]
        public void FromUShort()
        {
            _setUShort(ref _instance, _testValueUShort, _provider);
        }

        [Benchmark]
        public void FromUShortNullable()
        {
            _setUShortNullable(ref _instance, _testValueUShortNullable, _provider);
        }

        [Benchmark]
        public void FromInt()
        {
            _setInt(ref _instance, _testValueInt, _provider);
        }

        [Benchmark]
        public void FromIntNullable()
        {
            _setIntNullable(ref _instance, _testValueIntNullable, _provider);
        }

        [Benchmark]
        public void FromUInt()
        {
            _setUInt(ref _instance, _testValueUInt, _provider);
        }

        [Benchmark]
        public void FromUIntNullable()
        {
            _setUIntNullable(ref _instance, _testValueUIntNullable, _provider);
        }

        [Benchmark]
        public void FromLong()
        {
            _setLong(ref _instance, _testValueLong, _provider);
        }

        [Benchmark]
        public void FromLongNullable()
        {
            _setLongNullable(ref _instance, _testValueLongNullable, _provider);
        }

        [Benchmark]
        public void FromULong()
        {
            _setULong(ref _instance, _testValueULong, _provider);
        }

        [Benchmark]
        public void FromULongNullable()
        {
            _setULongNullable(ref _instance, _testValueULongNullable, _provider);
        }

        [Benchmark]
        public void FromFloat()
        {
            _setFloat(ref _instance, _testValueFloat, _provider);
        }

        [Benchmark]
        public void FromFloatNullable()
        {
            _setFloatNullable(ref _instance, _testValueFloatNullable, _provider);
        }

        [Benchmark]
        public void FromDouble()
        {
            _setDouble(ref _instance, _testValueDouble, _provider);
        }

        [Benchmark]
        public void FromDoubleNullable()
        {
            _setDoubleNullable(ref _instance, _testValueDoubleNullable, _provider);
        }

        [Benchmark]
        public void FromDecimal()
        {
            _setDecimal(ref _instance, _testValueDecimal, _provider);
        }

        [Benchmark]
        public void FromDecimalNullable()
        {
            _setDecimalNullable(ref _instance, _testValueDecimalNullable, _provider);
        }

        [Benchmark]
        public void FromDateTime()
        {
            _setDateTime(ref _instance, _testValueDateTime, _provider);
        }

        [Benchmark]
        public void FromDateTimeNullable()
        {
            _setDateTimeNullable(ref _instance, _testValueDateTimeNullable, _provider);
        }

        [Benchmark]
        public void FromObject()
        {
            _setObject(ref _instance, _testValueObject, _provider);
        }

        [Benchmark]
        public void FromString()
        {
            _setString(ref _instance, _testValueString, _provider);
        }

        [Benchmark]
        public void FromEnum()
        {
            _setEnum(ref _instance, _testValueEnum, _provider);
        }

        [Benchmark]
        public void FromEnumNullable()
        {
            _setEnumNullable(ref _instance, _testValueEnumNullable, _provider);
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