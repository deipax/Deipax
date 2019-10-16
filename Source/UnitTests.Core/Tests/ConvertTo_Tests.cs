using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Core.BaseClasses;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.Conversion
{
    [TestClass]
    public class ConvertTo_Base<TTo> : BaseConvertTo<TTo>
    {
        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo<TTo, TFrom>.From(from, ConvertConfig.DefaultProvider);
        }
    }

    #region Bool/BoolNullable
    public class ConvertToBoolBase<TTo> : ConvertTo_Base<TTo>
    {
        public ConvertToBoolBase()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }

    [TestClass]
    public class ConvertToBool : ConvertToBoolBase<bool>
    {
    }

    [TestClass]
    public class ConvertToBoolNullable : ConvertToBoolBase<bool?>
    {
    }
    #endregion

    #region Char/CharNullable
    [TestClass]
    public class ConvertToCharBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertToChar : ConvertToCharBase<char>
    {
    }

    [TestClass]
    public class ConvertToCharNullable : ConvertToCharBase<char?>
    {
    }
    #endregion

    #region SByte/SByteNullable
    [TestClass]
    public class ConvertToSByte : ConvertTo_Base<sbyte>
    {
    }

    [TestClass]
    public class ConvertToSByteNullable : ConvertTo_Base<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    [TestClass]
    public class ConvertToByte : ConvertTo_Base<byte>
    {
    }

    [TestClass]
    public class ConvertToByteNullable : ConvertTo_Base<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    [TestClass]
    public class ConvertToShort : ConvertTo_Base<short>
    {
    }

    [TestClass]
    public class ConvertToShortNullable : ConvertTo_Base<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    [TestClass]
    public class ConvertToUShort : ConvertTo_Base<ushort>
    {
    }

    [TestClass]
    public class ConvertToUShortNullable : ConvertTo_Base<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    [TestClass]
    public class ConvertToInt : ConvertTo_Base<int>
    {
    }

    [TestClass]
    public class ConvertToIntNullable : ConvertTo_Base<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    [TestClass]
    public class ConvertToUInt : ConvertTo_Base<uint>
    {
    }

    [TestClass]
    public class ConvertToUIntNullable : ConvertTo_Base<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    [TestClass]
    public class ConvertToLong : ConvertTo_Base<long>
    {
    }

    [TestClass]
    public class ConvertToLongNullable : ConvertTo_Base<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    [TestClass]
    public class ConvertToULong : ConvertTo_Base<ulong>
    {
    }

    [TestClass]
    public class ConvertToULongNullable : ConvertTo_Base<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    [TestClass]
    public class ConvertToFloatBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertToFloat : ConvertToFloatBase<float>
    {
    }

    [TestClass]
    public class ConvertToFloatNullable : ConvertToFloatBase<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    [TestClass]
    public class ConvertToDoubleBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertToDouble : ConvertToDoubleBase<double>
    {
    }

    [TestClass]
    public class ConvertToDoubleNullable : ConvertToDoubleBase<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    [TestClass]
    public class ConvertToDecimalBase<TTo> : ConvertTo_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertToDecimal : ConvertToDecimalBase<decimal>
    {
    }

    [TestClass]
    public class ConvertToDecimalNullable : ConvertToDecimalBase<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    [TestClass]
    public class ConvertToDateTimeBase<TTo> : ConvertTo_Base<TTo>
    {
        public ConvertToDateTimeBase()
        {
            _fromString_AsObject = _fromString = DateTime.MinValue.ToString();
        }
    }

    [TestClass]
    public class ConvertToDateTime : ConvertToDateTimeBase<DateTime>
    {
    }

    [TestClass]
    public class ConvertToDateTimeNullable : ConvertToDateTimeBase<DateTime?>
    {
    }
    #endregion

    #region String
    [TestClass]
    public class ConvertToString : ConvertTo_Base<string>
    {
        [TestMethod]
        public override void From_NonConvertibleClass()
        {
            TestConvertFrom(_nonConvertibleClass, _nonConvertibleClass.ToString());
        }

        [TestMethod]
        public override void From_NonConvertibleClass_AsObject()
        {
            TestConvertFrom(_nonConvertibleClass_AsObject, _nonConvertibleClass_AsObject.ToString());
        }

        [TestMethod]
        public override void From_NonConvertibleStruct()
        {
            TestConvertFrom(_nonConvertibleStruct, _nonConvertibleStruct.ToString());
        }

        [TestMethod]
        public override void From_NonConvertibleStruct_AsObject()
        {
            TestConvertFrom(_nonConvertibleStruct_AsObject, _nonConvertibleStruct_AsObject.ToString());
        }

        [TestMethod]
        public override void From_NonConvertibleStruct_Nullable_WithValue()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue, _nonConvertibleStructNullableWithValue.ToString());
        }

        [TestMethod]
        public override void From_NonConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue_AsObject, _nonConvertibleStructNullableWithValue_AsObject.ToString());
        }

        [TestMethod]
        public override void From_ParentClass()
        {
            TestConvertFrom(_parentClass, _parentClass.ToString());
        }

        [TestMethod]
        public override void From_ParentClass_AsObject()
        {
            TestConvertFrom(_parentClass_AsObject, _parentClass_AsObject.ToString());
        }

        [TestMethod]
        public override void From_ParentStruct()
        {
            TestConvertFrom(_parentStruct, _parentStruct.ToString());
        }

        [TestMethod]
        public override void From_ParentStruct_AsObject()
        {
            TestConvertFrom(_parentStruct_AsObject, _parentStruct_AsObject.ToString());
        }

        [TestMethod]
        public override void From_ParentStruct_Nullable_WithValue()
        {
            TestConvertFrom(_parentStructNullableWithValue, _parentStructNullableWithValue.ToString());
        }

        [TestMethod]
        public override void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableWithValue_AsObject, _parentStructNullableWithValue_AsObject.ToString());
        }
    }
    #endregion

    #region Object
    [TestClass]
    public class ConvertToObject : ConvertTo_Base<object>
    {
        [TestMethod]
        public override void From_DBNull()
        {
            TestConvertFrom(DBNull.Value, DBNull.Value);
        }

        [TestMethod]
        public override void From_DBNull_AsObject()
        {
            TestConvertFrom(DBNull.Value, DBNull.Value);
        }

        [TestMethod]
        public override void From_NonConvertibleClass()
        {
            TestConvertFrom(_nonConvertibleClass, _nonConvertibleClass);
        }

        [TestMethod]
        public override void From_NonConvertibleClass_AsObject()
        {
            TestConvertFrom(_nonConvertibleClass_AsObject, _nonConvertibleClass_AsObject);
        }

        [TestMethod]
        public override void From_NonConvertibleStruct()
        {
            TestConvertFrom(_nonConvertibleStruct, _nonConvertibleStruct);
        }

        [TestMethod]
        public override void From_NonConvertibleStruct_AsObject()
        {
            TestConvertFrom(_nonConvertibleStruct_AsObject, _nonConvertibleStruct_AsObject);
        }

        [TestMethod]
        public override void From_NonConvertibleStruct_Nullable_WithValue()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue, _nonConvertibleStructNullableWithValue);
        }

        [TestMethod]
        public override void From_NonConvertibleStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_nonConvertibleStructNullableWithValue_AsObject, _nonConvertibleStructNullableWithValue_AsObject);
        }

        [TestMethod]
        public override void From_ParentClass()
        {
            TestConvertFrom(_parentClass, _parentClass);
        }

        [TestMethod]
        public override void From_ParentClass_AsObject()
        {
            TestConvertFrom(_parentClass_AsObject, _parentClass_AsObject);
        }

        [TestMethod]
        public override void From_ParentStruct()
        {
            TestConvertFrom(_parentStruct, _parentStruct);
        }

        [TestMethod]
        public override void From_ParentStruct_AsObject()
        {
            TestConvertFrom(_parentStruct_AsObject, _parentStruct_AsObject);
        }

        [TestMethod]
        public override void From_ParentStruct_Nullable_WithValue()
        {
            TestConvertFrom(_parentStructNullableWithValue, _parentStructNullableWithValue);
        }

        [TestMethod]
        public override void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableWithValue_AsObject, _parentStructNullableWithValue_AsObject);
        }
    }
    #endregion

    #region Enum
    [TestClass]
    public class ConvertToEnum : ConvertTo_Base<TestEnum>
    {
        protected override TestEnum GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }

    [TestClass]
    public class ConvertToEnumNullable : ConvertTo_Base<TestEnum?>
    {
        protected override TestEnum? GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }

    [TestClass]
    public class ConvertToEnumLong : ConvertTo_Base<TestEnumLong>
    {
        protected override TestEnumLong GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }

    [TestClass]
    public class ConvertToEnumLongNullable : ConvertTo_Base<TestEnumLong?>
    {
        protected override TestEnumLong? GetExpected<TFrom>(TFrom from)
        {
            return base.GetExpected(from);
        }
    }
    #endregion

    #region IParent
    [TestClass]
    public class ConvertToIParent : ConvertTo_Base<IParent>
    {
        [TestMethod]
        public override void From_ParentClass()
        {
            TestConvertFrom(_parentClass, _parentClass);
        }

        [TestMethod]
        public override void From_ParentClass_AsObject()
        {
            TestConvertFrom(_parentClass_AsObject, (IParent)_parentClass_AsObject);
        }

        [TestMethod]
        public override void From_ParentStruct()
        {
            TestConvertFrom(_parentStruct, _parentStruct);
        }

        [TestMethod]
        public override void From_ParentStruct_AsObject()
        {
            TestConvertFrom(_parentStruct_AsObject, (IParent)_parentStruct_AsObject);
        }

        [TestMethod]
        public override void From_ParentStruct_Nullable_WithValue()
        {
            TestConvertFrom(_parentStructNullableWithValue, _parentStructNullableWithValue);
        }

        [TestMethod]
        public override void From_ParentStruct_Nullable_WithValue_AsObject()
        {
            TestConvertFrom(_parentStructNullableWithValue_AsObject, (IParent)_parentStructNullableWithValue_AsObject);
        }
    }
    #endregion
}