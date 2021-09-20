using Benchmarks.Model.Base;
using System;
using UnitTests.Common;

namespace Benchmarks.Model.Deipax
{
    #region Bool/BoolNullable
    public class Set_Prop_Bool : SetterBase<ParentClass, bool>
    {
        public Set_Prop_Bool() : base(true, x => x.BoolProp)
        {
        }
    }

    public class Set_Prop_BoolNullable : SetterBase<ParentClass, bool?>
    {
        public Set_Prop_BoolNullable() : base(true, x => x.BoolNullableProp)
        {
        }
    }

    public class Set_Prop_BoolNullable_NoValue : SetterBase<ParentClass, bool?>
    {
        public Set_Prop_BoolNullable_NoValue() : base(null, x => x.BoolNullableProp)
        {
        }
    }
    #endregion

    #region Char/CharNullable
    public class Set_Prop_Char : SetterBase<ParentClass, char>
    {
        public Set_Prop_Char() : base('c', x => x.CharProp)
        {
        }
    }

    public class Set_Prop_CharNullable : SetterBase<ParentClass, char?>
    {
        public Set_Prop_CharNullable() : base('c', x => x.CharNullableProp)
        {
        }
    }

    public class Set_Prop_CharNullable_NoValue : SetterBase<ParentClass, char?>
    {
        public Set_Prop_CharNullable_NoValue() : base(null, x => x.CharNullableProp)
        {
        }
    }
    #endregion

    #region Sbyte/SbyteNullable
    public class Set_Prop_SByte : SetterBase<ParentClass, sbyte>
    {
        public Set_Prop_SByte() : base(1, x => x.SbyteProp)
        {
        }
    }

    public class Set_Prop_SByteNullable : SetterBase<ParentClass, sbyte?>
    {
        public Set_Prop_SByteNullable() : base(1, x => x.SbyteNullableProp)
        {
        }
    }

    public class Set_Prop_SByteNullable_NoValue : SetterBase<ParentClass, sbyte?>
    {
        public Set_Prop_SByteNullable_NoValue() : base(null, x => x.SbyteNullableProp)
        {
        }
    }
    #endregion

    #region Byte/ByteNullable
    public class Set_Prop_Byte : SetterBase<ParentClass, byte>
    {
        public Set_Prop_Byte() : base(1, x => x.ByteProp)
        {
        }
    }

    public class Set_Prop_ByteNullable : SetterBase<ParentClass, byte?>
    {
        public Set_Prop_ByteNullable() : base(1, x => x.ByteNullableProp)
        {
        }
    }

    public class Set_Prop_ByteNullable_NoValue : SetterBase<ParentClass, byte?>
    {
        public Set_Prop_ByteNullable_NoValue() : base(null, x => x.ByteNullableProp)
        {
        }
    }
    #endregion

    #region Short/ShortNullable
    public class Set_Prop_Short : SetterBase<ParentClass, short>
    {
        public Set_Prop_Short() : base(1, x => x.ShortProp)
        {
        }
    }

    public class Set_Prop_ShortNullable : SetterBase<ParentClass, short?>
    {
        public Set_Prop_ShortNullable() : base(1, x => x.ShortNullableProp)
        {
        }
    }

    public class Set_Prop_ShortNullable_NoValue : SetterBase<ParentClass, short?>
    {
        public Set_Prop_ShortNullable_NoValue() : base(null, x => x.ShortNullableProp)
        {
        }
    }
    #endregion

    #region UShort/UShortNullable
    public class Set_Prop_UShort : SetterBase<ParentClass, ushort>
    {
        public Set_Prop_UShort() : base(1, x => x.UShortProp)
        {
        }
    }

    public class Set_Prop_UShortNullable : SetterBase<ParentClass, ushort?>
    {
        public Set_Prop_UShortNullable() : base(1, x => x.UShortNullableProp)
        {
        }
    }

    public class Set_Prop_UShortNullable_NoValue : SetterBase<ParentClass, ushort?>
    {
        public Set_Prop_UShortNullable_NoValue() : base(null, x => x.UShortNullableProp)
        {
        }
    }
    #endregion

    #region Int/IntNullable
    public class Set_Prop_Int : SetterBase<ParentClass, int>
    {
        public Set_Prop_Int() : base(1, x => x.IntProp)
        {
        }
    }

    public class Set_Prop_IntNullable : SetterBase<ParentClass, int?>
    {
        public Set_Prop_IntNullable() : base(1, x => x.IntNullableProp)
        {
        }
    }

    public class Set_Prop_IntNullable_NoValue : SetterBase<ParentClass, int?>
    {
        public Set_Prop_IntNullable_NoValue() : base(null, x => x.IntNullableProp)
        {
        }
    }
    #endregion

    #region UInt/UIntNullable
    public class Set_Prop_UInt : SetterBase<ParentClass, uint>
    {
        public Set_Prop_UInt() : base(1, x => x.UIntProp)
        {
        }
    }

    public class Set_Prop_UIntNullable : SetterBase<ParentClass, uint?>
    {
        public Set_Prop_UIntNullable() : base(1, x => x.UIntNullableProp)
        {
        }
    }

    public class Set_Prop_UIntNullable_NoValue : SetterBase<ParentClass, uint?>
    {
        public Set_Prop_UIntNullable_NoValue() : base(null, x => x.UIntNullableProp)
        {
        }
    }
    #endregion

    #region Long/LongNullable
    public class Set_Prop_Long : SetterBase<ParentClass, long>
    {
        public Set_Prop_Long() : base(1, x => x.LongProp)
        {
        }
    }

    public class Set_Prop_LongNullable : SetterBase<ParentClass, long?>
    {
        public Set_Prop_LongNullable() : base(1, x => x.LongNullableProp)
        {
        }
    }

    public class Set_Prop_LongNullable_NoValue : SetterBase<ParentClass, long?>
    {
        public Set_Prop_LongNullable_NoValue() : base(null, x => x.LongNullableProp)
        {
        }
    }
    #endregion

    #region ULong/ULongNullable
    public class Set_Prop_ULong : SetterBase<ParentClass, ulong>
    {
        public Set_Prop_ULong() : base(1, x => x.ULongProp)
        {
        }
    }

    public class Set_Prop_ULongNullable : SetterBase<ParentClass, ulong?>
    {
        public Set_Prop_ULongNullable() : base(1, x => x.ULongNullableProp)
        {
        }
    }

    public class Set_Prop_ULongNullable_NoValue : SetterBase<ParentClass, ulong?>
    {
        public Set_Prop_ULongNullable_NoValue() : base(null, x => x.ULongNullableProp)
        {
        }
    }
    #endregion

    #region Float/FloatNullable
    public class Set_Prop_Float : SetterBase<ParentClass, float>
    {
        public Set_Prop_Float() : base(1, x => x.FloatProp)
        {
        }
    }

    public class Set_Prop_FloatNullable : SetterBase<ParentClass, float?>
    {
        public Set_Prop_FloatNullable() : base(1, x => x.FloatNullableProp)
        {
        }
    }

    public class Set_Prop_FloatNullable_NoValue : SetterBase<ParentClass, float?>
    {
        public Set_Prop_FloatNullable_NoValue() : base(null, x => x.FloatNullableProp)
        {
        }
    }
    #endregion

    #region Double/DoubleNullable
    public class Set_Prop_Double : SetterBase<ParentClass, double>
    {
        public Set_Prop_Double() : base(1, x => x.DoubleProp)
        {
        }
    }

    public class Set_Prop_DoubleNullable : SetterBase<ParentClass, double?>
    {
        public Set_Prop_DoubleNullable() : base(1, x => x.DoubleNullableProp)
        {
        }
    }

    public class Set_Prop_DoubleNullable_NoValue : SetterBase<ParentClass, double?>
    {
        public Set_Prop_DoubleNullable_NoValue() : base(null, x => x.DoubleNullableProp)
        {
        }
    }
    #endregion

    #region Decimal/DecimalNullable
    public class Set_Prop_Decimal : SetterBase<ParentClass, decimal>
    {
        public Set_Prop_Decimal() : base(1, x => x.DecimalProp)
        {
        }
    }

    public class Set_Prop_DecimalNullable : SetterBase<ParentClass, decimal?>
    {
        public Set_Prop_DecimalNullable() : base(1, x => x.DecimalNullableProp)
        {
        }
    }

    public class Set_Prop_DecimalNullable_NoValue : SetterBase<ParentClass, decimal?>
    {
        public Set_Prop_DecimalNullable_NoValue() : base(null, x => x.DecimalNullableProp)
        {
        }
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class Set_Prop_DateTime : SetterBase<ParentClass, DateTime>
    {
        public Set_Prop_DateTime() : base(DateTime.MinValue, x => x.DateTimeProp)
        {
        }
    }

    public class Set_Prop_DateTimeNullable : SetterBase<ParentClass, DateTime?>
    {
        public Set_Prop_DateTimeNullable() : base(DateTime.MinValue, x => x.DateTimeNullableProp)
        {
        }
    }

    public class Set_Prop_DateTimeNullable_NoValue : SetterBase<ParentClass, DateTime?>
    {
        public Set_Prop_DateTimeNullable_NoValue() : base(null, x => x.DateTimeNullableProp)
        {
        }
    }
    #endregion

    #region String
    public class Set_Prop_String : SetterBase<ParentClass, string>
    {
        public Set_Prop_String() : base("1", x => x.StringProp)
        {
        }
    }

    public class Set_Prop_String_Empty : SetterBase<ParentClass, string>
    {
        public Set_Prop_String_Empty() : base(string.Empty, x => x.StringProp)
        {
        }
    }

    public class Set_Prop_String_NoValue : SetterBase<ParentClass, string>
    {
        public Set_Prop_String_NoValue() : base(null, x => x.StringProp)
        {
        }
    }
    #endregion

    #region Object
    public class Set_Prop_Object : SetterBase<ParentClass, object>
    {
        public Set_Prop_Object() : base(new object(), x => x.ObjectProp)
        {
        }
    }

    public class Set_Prop_Object_NoValue : SetterBase<ParentClass, object>
    {
        public Set_Prop_Object_NoValue() : base(null, x => x.ObjectProp)
        {
        }
    }
    #endregion

    #region Enum
    public class Set_Prop_Enum : SetterBase<ParentClass, TestEnum>
    {
        public Set_Prop_Enum() : base(TestEnum.One, x => x.EnumProp)
        {
        }
    }

    public class Set_Prop_EnumNullable : SetterBase<ParentClass, TestEnum?>
    {
        public Set_Prop_EnumNullable() : base(TestEnum.One, x => x.EnumNullableProp)
        {
        }
    }

    public class Set_Prop_EnumNullable_NoValue : SetterBase<ParentClass, TestEnum?>
    {
        public Set_Prop_EnumNullable_NoValue() : base(null, x => x.EnumNullableProp)
        {
        }
    }
    #endregion
}