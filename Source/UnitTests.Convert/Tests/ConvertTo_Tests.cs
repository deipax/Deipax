using Deipax.Convert;
using System;
using UnitTests.Common;
using UnitTests.Convert.BaseClasses;
using Xunit;

namespace UnitTests.Convert
{
    public abstract class ConvertTo_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo<TTo, TFrom>.From(from, ConvertConfig.DefaultProvider);
        }
    }

    #region Bool/BoolNullable
    public abstract class ConvertToBoolBase<TTo> : ConvertTo_Base<TTo>
    {
        public ConvertToBoolBase()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }

    public class ConvertToBool : ConvertToBoolBase<bool>
    {
    }

    public class ConvertToBoolNullable : ConvertToBoolBase<bool?>
    {
    }
    #endregion

    #region Char/CharNullable
    public abstract class ConvertToCharBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    public class ConvertToChar : ConvertToCharBase<char>
    {
    }

    public class ConvertToCharNullable : ConvertToCharBase<char?>
    {
    }
    #endregion

    #region SByte/SByteNullable
    public class ConvertToSByte : ConvertTo_Base<sbyte>
    {
    }

    public class ConvertToSByteNullable : ConvertTo_Base<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    public class ConvertToByte : ConvertTo_Base<byte>
    {
    }

    public class ConvertToByteNullable : ConvertTo_Base<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    public class ConvertToShort : ConvertTo_Base<short>
    {
    }

    public class ConvertToShortNullable : ConvertTo_Base<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    public class ConvertToUShort : ConvertTo_Base<ushort>
    {
    }

    public class ConvertToUShortNullable : ConvertTo_Base<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    public class ConvertToInt : ConvertTo_Base<int>
    {
    }

    public class ConvertToIntNullable : ConvertTo_Base<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    public class ConvertToUInt : ConvertTo_Base<uint>
    {
    }

    public class ConvertToUIntNullable : ConvertTo_Base<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    public class ConvertToLong : ConvertTo_Base<long>
    {
    }

    public class ConvertToLongNullable : ConvertTo_Base<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    public class ConvertToULong : ConvertTo_Base<ulong>
    {
    }

    public class ConvertToULongNullable : ConvertTo_Base<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    public abstract class ConvertToFloatBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    public class ConvertToFloat : ConvertToFloatBase<float>
    {
    }

    public class ConvertToFloatNullable : ConvertToFloatBase<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    public abstract class ConvertToDoubleBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    public class ConvertToDouble : ConvertToDoubleBase<double>
    {
    }

    public class ConvertToDoubleNullable : ConvertToDoubleBase<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    public abstract class ConvertToDecimalBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    public class ConvertToDecimal : ConvertToDecimalBase<decimal>
    {
    }

    public class ConvertToDecimalNullable : ConvertToDecimalBase<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    public abstract class ConvertToDateTimeBase<TTo> : ConvertTo_Base<TTo>
    {
        public ConvertToDateTimeBase()
        {
            _fromString_AsObject = _fromString = DateTime.MinValue.ToString();
        }
    }

    public class ConvertToDateTime : ConvertToDateTimeBase<DateTime>
    {
    }

    public class ConvertToDateTimeNullable : ConvertToDateTimeBase<DateTime?>
    {
    }
    #endregion

    #region String
    public class ConvertToString : ConvertTo_Base<string>
    {
        [Fact]
        public override void From_NonConvertibleClass()
        {
            TestConvertFrom(_nonConvertibleClass, _nonConvertibleClass.ToString());
        }

        [Fact]
        public override void From_NonConvertibleClass_AsObject()
        {
            TestConvertFrom(_nonConvertibleClass_AsObject, _nonConvertibleClass_AsObject.ToString());
        }

        [Fact]
        public override void From_NonConvertibleStruct()
        {
            TestConvertFrom(_nonConvertibleStruct, _nonConvertibleStruct.ToString());
        }

        [Fact]
        public override void From_NonConvertibleStruct_AsObject()
        {
            TestConvertFrom(_nonConvertibleStruct_AsObject, _nonConvertibleStruct_AsObject.ToString());
        }

        [Fact]
        public override void From_NonConvertibleStruct_Nullable_WithValue()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue, _nonConvertibleStructNullableWithValue.ToString());
        }

        [Fact]
        public override void From_NonConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue_AsObject, _nonConvertibleStructNullableWithValue_AsObject.ToString());
        }

        [Fact]
        public override void From_ParentClass()
        {
            TestConvertFrom(_parentClass, _parentClass.ToString());
        }

        [Fact]
        public override void From_ParentClass_AsObject()
        {
            TestConvertFrom(_parentClass_AsObject, _parentClass_AsObject.ToString());
        }

        [Fact]
        public override void From_ParentStruct()
        {
            TestConvertFrom(_parentStruct, _parentStruct.ToString());
        }

        [Fact]
        public override void From_ParentStruct_AsObject()
        {
            TestConvertFrom(_parentStruct_AsObject, _parentStruct_AsObject.ToString());
        }

        [Fact]
        public override void From_ParentStruct_Nullable_WithValue()
        {
            TestConvertFrom(_parentStructNullableWithValue, _parentStructNullableWithValue.ToString());
        }

        [Fact]
        public override void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableWithValue_AsObject, _parentStructNullableWithValue_AsObject.ToString());
        }
    }
    #endregion

    #region Object
    public class ConvertToObject : ConvertTo_Base<object>
    {
        [Fact]
        public override void From_DBNull()
        {
            TestConvertFrom(DBNull.Value, DBNull.Value);
        }

        [Fact]
        public override void From_DBNull_AsObject()
        {
            TestConvertFrom(DBNull.Value, DBNull.Value);
        }

        [Fact]
        public override void From_NonConvertibleClass()
        {
            TestConvertFrom(_nonConvertibleClass, _nonConvertibleClass);
        }

        [Fact]
        public override void From_NonConvertibleClass_AsObject()
        {
            TestConvertFrom(_nonConvertibleClass_AsObject, _nonConvertibleClass_AsObject);
        }

        [Fact]
        public override void From_NonConvertibleStruct()
        {
            TestConvertFrom(_nonConvertibleStruct, _nonConvertibleStruct);
        }

        [Fact]
        public override void From_NonConvertibleStruct_AsObject()
        {
            TestConvertFrom(_nonConvertibleStruct_AsObject, _nonConvertibleStruct_AsObject);
        }

        [Fact]
        public override void From_NonConvertibleStruct_Nullable_WithValue()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue, _nonConvertibleStructNullableWithValue);
        }

        [Fact]
        public override void From_NonConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue_AsObject, _nonConvertibleStructNullableWithValue_AsObject);
        }

        [Fact]
        public override void From_ParentClass()
        {
            TestConvertFrom(_parentClass, _parentClass);
        }

        [Fact]
        public override void From_ParentClass_AsObject()
        {
            TestConvertFrom(_parentClass_AsObject, _parentClass_AsObject);
        }

        [Fact]
        public override void From_ParentStruct()
        {
            TestConvertFrom(_parentStruct, _parentStruct);
        }

        [Fact]
        public override void From_ParentStruct_AsObject()
        {
            TestConvertFrom(_parentStruct_AsObject, _parentStruct_AsObject);
        }

        [Fact]
        public override void From_ParentStruct_Nullable_WithValue()
        {
            TestConvertFrom(_parentStructNullableWithValue, _parentStructNullableWithValue);
        }

        [Fact]
        public override void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableWithValue_AsObject, _parentStructNullableWithValue_AsObject);
        }
    }
    #endregion

    #region Enum
    public class ConvertToEnum : ConvertTo_Base<TestEnum>
    {
        protected override TestEnum GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }

    public class ConvertToEnumNullable : ConvertTo_Base<TestEnum?>
    {
        protected override TestEnum? GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }

    public class ConvertToEnumLong : ConvertTo_Base<TestEnumLong>
    {
        protected override TestEnumLong GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }

    public class ConvertToEnumLongNullable : ConvertTo_Base<TestEnumLong?>
    {
        protected override TestEnumLong? GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }
    #endregion

    #region IParent
    public class ConvertToIParent : ConvertTo_Base<IParent>
    {
        [Fact]
        public override void From_ParentClass()
        {
            TestConvertFrom(_parentClass, _parentClass);
        }

        [Fact]
        public override void From_ParentClass_AsObject()
        {
            TestConvertFrom(_parentClass_AsObject, (IParent)_parentClass_AsObject);
        }

        [Fact]
        public override void From_ParentStruct()
        {
            TestConvertFrom(_parentStruct, _parentStruct);
        }

        [Fact]
        public override void From_ParentStruct_AsObject()
        {
            TestConvertFrom(_parentStruct_AsObject, (IParent)_parentStruct_AsObject);
        }

        [Fact]
        public override void From_ParentStruct_Nullable_WithValue()
        {
            TestConvertFrom(_parentStructNullableWithValue, _parentStructNullableWithValue);
        }

        [Fact]
        public override void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableWithValue_AsObject, (IParent)_parentStructNullableWithValue_AsObject);
        }
    }
    #endregion
}