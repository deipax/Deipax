using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Core.BaseClasses;
using UnitTests.Core.TestClasses;

namespace UnitTests.Core.Deipax.GetterSetter
{
    #region Bool/BoolNullable
    [TestClass]
    public class GetSet_Prop_Bool : GetterSetterBase<ParentClass, bool>
    {
        public GetSet_Prop_Bool() : base(true, x => x.BoolProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_BoolNullable : GetterSetterBase<ParentClass, bool?>
    {
        public GetSet_Prop_BoolNullable() : base(true, x => x.BoolNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_BoolNullable_NoValue : GetterSetterBase<ParentClass, bool?>
    {
        public GetSet_Prop_BoolNullable_NoValue() : base(null, x => x.BoolNullableProp)
        {
        }
    }
    #endregion

    #region Char/CharNullable
    [TestClass]
    public class GetSet_Prop_Char : GetterSetterBase<ParentClass, char>
    {
        public GetSet_Prop_Char() : base('c', x => x.CharProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_CharNullable : GetterSetterBase<ParentClass, char?>
    {
        public GetSet_Prop_CharNullable() : base('c', x => x.CharNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_CharNullable_NoValue : GetterSetterBase<ParentClass, char?>
    {
        public GetSet_Prop_CharNullable_NoValue() : base(null, x => x.CharNullableProp)
        {
        }
    }
    #endregion

    #region Sbyte/SbyteNullable
    [TestClass]
    public class GetSet_Prop_SByte : GetterSetterBase<ParentClass, sbyte>
    {
        public GetSet_Prop_SByte() : base(1, x => x.SbyteProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_SByteNullable : GetterSetterBase<ParentClass, sbyte?>
    {
        public GetSet_Prop_SByteNullable() : base(1, x => x.SbyteNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_SByteNullable_NoValue : GetterSetterBase<ParentClass, sbyte?>
    {
        public GetSet_Prop_SByteNullable_NoValue() : base(null, x => x.SbyteNullableProp)
        {
        }
    }
    #endregion

    #region Byte/ByteNullable
    [TestClass]
    public class GetSet_Prop_Byte : GetterSetterBase<ParentClass, byte>
    {
        public GetSet_Prop_Byte() : base(1, x => x.ByteProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_ByteNullable : GetterSetterBase<ParentClass, byte?>
    {
        public GetSet_Prop_ByteNullable() : base(1, x => x.ByteNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_ByteNullable_NoValue : GetterSetterBase<ParentClass, byte?>
    {
        public GetSet_Prop_ByteNullable_NoValue() : base(null, x => x.ByteNullableProp)
        {
        }
    }
    #endregion

    #region Short/ShortNullable
    [TestClass]
    public class GetSet_Prop_Short : GetterSetterBase<ParentClass, short>
    {
        public GetSet_Prop_Short() : base(1, x => x.ShortProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_ShortNullable : GetterSetterBase<ParentClass, short?>
    {
        public GetSet_Prop_ShortNullable() : base(1, x => x.ShortNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_ShortNullable_NoValue : GetterSetterBase<ParentClass, short?>
    {
        public GetSet_Prop_ShortNullable_NoValue() : base(null, x => x.ShortNullableProp)
        {
        }
    }
    #endregion

    #region UShort/UShortNullable
    [TestClass]
    public class GetSet_Prop_UShort : GetterSetterBase<ParentClass, ushort>
    {
        public GetSet_Prop_UShort() : base(1, x => x.UShortProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_UShortNullable : GetterSetterBase<ParentClass, ushort?>
    {
        public GetSet_Prop_UShortNullable() : base(1, x => x.UShortNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_UShortNullable_NoValue : GetterSetterBase<ParentClass, ushort?>
    {
        public GetSet_Prop_UShortNullable_NoValue() : base(null, x => x.UShortNullableProp)
        {
        }
    }
    #endregion

    #region Int/IntNullable
    [TestClass]
    public class GetSet_Prop_Int : GetterSetterBase<ParentClass, int>
    {
        public GetSet_Prop_Int() : base(1, x => x.IntProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_IntNullable : GetterSetterBase<ParentClass, int?>
    {
        public GetSet_Prop_IntNullable() : base(1, x => x.IntNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_IntNullable_NoValue : GetterSetterBase<ParentClass, int?>
    {
        public GetSet_Prop_IntNullable_NoValue() : base(null, x => x.IntNullableProp)
        {
        }
    }
    #endregion

    #region UInt/UIntNullable
    [TestClass]
    public class GetSet_Prop_UInt : GetterSetterBase<ParentClass, uint>
    {
        public GetSet_Prop_UInt() : base(1, x => x.UIntProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_UIntNullable : GetterSetterBase<ParentClass, uint?>
    {
        public GetSet_Prop_UIntNullable() : base(1, x => x.UIntNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_UIntNullable_NoValue : GetterSetterBase<ParentClass, uint?>
    {
        public GetSet_Prop_UIntNullable_NoValue() : base(null, x => x.UIntNullableProp)
        {
        }
    }
    #endregion

    #region Long/LongNullable
    [TestClass]
    public class GetSet_Prop_Long : GetterSetterBase<ParentClass, long>
    {
        public GetSet_Prop_Long() : base(1, x => x.LongProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_LongNullable : GetterSetterBase<ParentClass, long?>
    {
        public GetSet_Prop_LongNullable() : base(1, x => x.LongNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_LongNullable_NoValue : GetterSetterBase<ParentClass, long?>
    {
        public GetSet_Prop_LongNullable_NoValue() : base(null, x => x.LongNullableProp)
        {
        }
    }
    #endregion

    #region ULong/ULongNullable
    [TestClass]
    public class GetSet_Prop_ULong : GetterSetterBase<ParentClass, ulong>
    {
        public GetSet_Prop_ULong() : base(1, x => x.ULongProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_ULongNullable : GetterSetterBase<ParentClass, ulong?>
    {
        public GetSet_Prop_ULongNullable() : base(1, x => x.ULongNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_ULongNullable_NoValue : GetterSetterBase<ParentClass, ulong?>
    {
        public GetSet_Prop_ULongNullable_NoValue() : base(null, x => x.ULongNullableProp)
        {
        }
    }
    #endregion

    #region Float/FloatNullable
    [TestClass]
    public class GetSet_Prop_Float : GetterSetterBase<ParentClass, float>
    {
        public GetSet_Prop_Float() : base(1, x => x.FloatProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_FloatNullable : GetterSetterBase<ParentClass, float?>
    {
        public GetSet_Prop_FloatNullable() : base(1, x => x.FloatNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_FloatNullable_NoValue : GetterSetterBase<ParentClass, float?>
    {
        public GetSet_Prop_FloatNullable_NoValue() : base(null, x => x.FloatNullableProp)
        {
        }
    }
    #endregion

    #region Double/DoubleNullable
    [TestClass]
    public class GetSet_Prop_Double : GetterSetterBase<ParentClass, double>
    {
        public GetSet_Prop_Double() : base(1, x => x.DoubleProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_DoubleNullable : GetterSetterBase<ParentClass, double?>
    {
        public GetSet_Prop_DoubleNullable() : base(1, x => x.DoubleNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_DoubleNullable_NoValue : GetterSetterBase<ParentClass, double?>
    {
        public GetSet_Prop_DoubleNullable_NoValue() : base(null, x => x.DoubleNullableProp)
        {
        }
    }
    #endregion

    #region Decimal/DecimalNullable
    [TestClass]
    public class GetSet_Prop_Decimal : GetterSetterBase<ParentClass, decimal>
    {
        public GetSet_Prop_Decimal() : base(1, x => x.DecimalProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_DecimalNullable : GetterSetterBase<ParentClass, decimal?>
    {
        public GetSet_Prop_DecimalNullable() : base(1, x => x.DecimalNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_DecimalNullable_NoValue : GetterSetterBase<ParentClass, decimal?>
    {
        public GetSet_Prop_DecimalNullable_NoValue() : base(null, x => x.DecimalNullableProp)
        {
        }
    }
    #endregion

    #region DateTime/DateTimeNullable
    [TestClass]
    public class GetSet_Prop_DateTime : GetterSetterBase<ParentClass, DateTime>
    {
        public GetSet_Prop_DateTime() : base(DateTime.MinValue, x => x.DateTimeProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_DateTimeNullable : GetterSetterBase<ParentClass, DateTime?>
    {
        public GetSet_Prop_DateTimeNullable() : base(DateTime.MinValue, x => x.DateTimeNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_DateTimeNullable_NoValue : GetterSetterBase<ParentClass, DateTime?>
    {
        public GetSet_Prop_DateTimeNullable_NoValue() : base(null, x => x.DateTimeNullableProp)
        {
        }
    }
    #endregion

    #region String
    [TestClass]
    public class GetSet_Prop_String : GetterSetterBase<ParentClass, string>
    {
        public GetSet_Prop_String() : base("1", x => x.StringProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_String_Empty : GetterSetterBase<ParentClass, string>
    {
        public GetSet_Prop_String_Empty() : base(string.Empty, x => x.StringProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_String_NoValue : GetterSetterBase<ParentClass, string>
    {
        public GetSet_Prop_String_NoValue() : base(null, x => x.StringProp)
        {
        }
    }
    #endregion

    #region Object
    [TestClass]
    public class GetSet_Prop_Object : GetterSetterBase<ParentClass, object>
    {
        public GetSet_Prop_Object() : base(1, x => x.ObjectProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_Object_NoValue : GetterSetterBase<ParentClass, object>
    {
        public GetSet_Prop_Object_NoValue() : base(null, x => x.ObjectProp)
        {
        }
    }
    #endregion

    #region Enum
    [TestClass]
    public class GetSet_Prop_Enum : GetterSetterBase<ParentClass, TestEnum>
    {
        public GetSet_Prop_Enum() : base(TestEnum.One, x => x.EnumProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_EnumNullable : GetterSetterBase<ParentClass, TestEnum?>
    {
        public GetSet_Prop_EnumNullable() : base(TestEnum.One, x => x.EnumNullableProp)
        {
        }
    }

    [TestClass]
    public class GetSet_Prop_EnumNullable_NoValue : GetterSetterBase<ParentClass, TestEnum?>
    {
        public GetSet_Prop_EnumNullable_NoValue() : base(null, x => x.EnumNullableProp)
        {
        }
    }
    #endregion
}