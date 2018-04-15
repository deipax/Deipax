using Deipax.Core.Conversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Core.BaseClasses.Conversion;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.Deipax.Conversion.ConvertTo2
{
    [TestClass]
    public class ConvertTo2_Base<TTo> : BaseConvertTo<TTo>
    {
        public ConvertTo2_Base()
        {
            ConvertConfig.SafeConvert = true;
        }

        protected override TTo ConvertFrom<TFrom>(TFrom from)
        {
            return ConvertTo2<TTo, TFrom>.From(from, ConvertConfig.DefaultProvider);
        }
    }

    #region Bool/BoolNullable
    public class ConvertTo2_BoolBase<TTo> : ConvertTo2_Base<TTo>
    {
        public ConvertTo2_BoolBase()
        {
            _fromString_AsObject = _fromString = "true";
        }
    }

    [TestClass]
    public class ConvertTo2_Bool : ConvertTo2_BoolBase<bool>
    {
    }

    [TestClass]
    public class ConvertTo2_BoolNullable : ConvertTo2_BoolBase<bool?>
    {
    }
    #endregion

    #region Char/CharNullable
    [TestClass]
    public class ConvertTo2_CharBase<TTo> : ConvertTo2_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertTo2_Char : ConvertTo2_CharBase<char>
    {
    }

    [TestClass]
    public class ConvertTo2_CharNullable : ConvertTo2_CharBase<char?>
    {
    }
    #endregion

    #region SByte/SByteNullable
    [TestClass]
    public class ConvertTo2_SByte : ConvertTo2_Base<sbyte>
    {
    }

    [TestClass]
    public class ConvertTo2_SByteNullable : ConvertTo2_Base<sbyte?>
    {
    }
    #endregion

    #region Byte/ByteNullable
    [TestClass]
    public class ConvertTo2_Byte : ConvertTo2_Base<byte>
    {
    }

    [TestClass]
    public class ConvertTo2_ByteNullable : ConvertTo2_Base<byte?>
    {
    }
    #endregion

    #region Short/ShortNullable
    [TestClass]
    public class ConvertTo2_Short : ConvertTo2_Base<short>
    {
    }

    [TestClass]
    public class ConvertTo2_ShortNullable : ConvertTo2_Base<short?>
    {
    }
    #endregion

    #region UShort/UShortNullable
    [TestClass]
    public class ConvertTo2_UShort : ConvertTo2_Base<ushort>
    {
    }

    [TestClass]
    public class ConvertTo2_UShortNullable : ConvertTo2_Base<ushort?>
    {
    }
    #endregion

    #region Int/IntNullable
    [TestClass]
    public class ConvertTo2_Int : ConvertTo2_Base<int>
    {
    }

    [TestClass]
    public class ConvertTo2_IntNullable : ConvertTo2_Base<int?>
    {
    }
    #endregion

    #region UInt/UIntNullable
    [TestClass]
    public class ConvertTo2_UInt : ConvertTo2_Base<uint>
    {
    }

    [TestClass]
    public class ConvertTo2_UIntNullable : ConvertTo2_Base<uint?>
    {
    }
    #endregion

    #region Long/LongNullable
    [TestClass]
    public class ConvertTo2_Long : ConvertTo2_Base<long>
    {
    }

    [TestClass]
    public class ConvertTo2_LongNullable : ConvertTo2_Base<long?>
    {
    }
    #endregion

    #region ULong/ULongNullable
    [TestClass]
    public class ConvertTo2_ULong : ConvertTo2_Base<ulong>
    {
    }

    [TestClass]
    public class ConvertTo2_ULongNullable : ConvertTo2_Base<ulong?>
    {
    }
    #endregion

    #region Float/FloatNullable
    [TestClass]
    public class ConvertTo2_FloatBase<TTo> : ConvertTo2_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertTo2_Float : ConvertTo2_FloatBase<float>
    {
    }

    [TestClass]
    public class ConvertTo2_FloatNullable : ConvertTo2_FloatBase<float?>
    {
    }
    #endregion

    #region Double/DoubleNullable
    [TestClass]
    public class ConvertTo2_DoubleBase<TTo> : ConvertTo2_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertTo2_Double : ConvertTo2_DoubleBase<double>
    {
    }

    [TestClass]
    public class ConvertTo2_DoubleNullable : ConvertTo2_DoubleBase<double?>
    {
    }
    #endregion

    #region Decimal/DecimalNullable
    [TestClass]
    public class ConvertTo2_DecimalBase<TTo> : ConvertTo2_Base<TTo>
    {
    }

    [TestClass]
    public class ConvertTo2_Decimal : ConvertTo2_DecimalBase<decimal>
    {
    }

    [TestClass]
    public class ConvertTo2_DecimalNullable : ConvertTo2_DecimalBase<decimal?>
    {
    }
    #endregion

    #region DateTime/DateTimeNullable
    [TestClass]
    public class ConvertTo2_DateTimeBase<TTo> : ConvertTo2_Base<TTo>
    {
        public ConvertTo2_DateTimeBase()
        {
            _fromString_AsObject = _fromString = DateTime.MinValue.ToString();
        }
    }

    [TestClass]
    public class ConvertTo2_DateTime : ConvertTo2_DateTimeBase<DateTime>
    {
    }

    [TestClass]
    public class ConvertTo2_DateTimeNullable : ConvertTo2_DateTimeBase<DateTime?>
    {
    }
    #endregion

    #region String
    [TestClass]
    public class ConvertTo2_String : ConvertTo2_Base<string>
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
    public class ConvertTo2_Object : ConvertTo2_Base<object>
    {
        [TestMethod]
        public override void From_DBNull()
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
    public class ConvertTo2_Enum : ConvertTo2_Base<TestEnum>
    {
        protected override TestEnum GetExpected<TFrom>(TFrom @from)
        {
            return base.GetExpected(@from);
        }
    }
    #endregion

    #region IParent
    [TestClass]
    public class ConvertTo2_IParent : ConvertTo2_Base<IParent>
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