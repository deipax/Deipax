using System;
using Benchmarks.Core.BaseClasses;
using Benchmarks.Core.TestClasses;

namespace Benchmarks.Core.Deipax
{
    #region Bool/BoolNullable
    public class Get_Prop_Bool : GetterBase<ParentClass, bool>
    {
        public Get_Prop_Bool() : base(true, x => x.BoolProp)
        {
        }
    }

    public class Get_Prop_BoolNullable : GetterBase<ParentClass, bool?>
    {
        public Get_Prop_BoolNullable() : base(true, x => x.BoolNullableProp)
        {
        }
    }

    public class Get_Prop_BoolNullable_NoValue : GetterBase<ParentClass, bool?>
    {
        public Get_Prop_BoolNullable_NoValue() : base(null, x => x.BoolNullableProp)
        {
        }
    }
    #endregion

    #region Char/CharNullable
    public class Get_Prop_Char : GetterBase<ParentClass, char>
    {
        public Get_Prop_Char() : base('c', x => x.CharProp)
        {
        }
    }

    public class Get_Prop_CharNullable : GetterBase<ParentClass, char?>
    {
        public Get_Prop_CharNullable() : base('c', x => x.CharNullableProp)
        {
        }
    }

    public class Get_Prop_CharNullable_NoValue : GetterBase<ParentClass, char?>
    {
        public Get_Prop_CharNullable_NoValue() : base(null, x => x.CharNullableProp)
        {
        }
    }
    #endregion

    #region Sbyte/SbyteNullable
    public class Get_Prop_SByte : GetterBase<ParentClass, sbyte>
    {
        public Get_Prop_SByte() : base(1, x => x.SbyteProp)
        {
        }
    }

    public class Get_Prop_SByteNullable : GetterBase<ParentClass, sbyte?>
    {
        public Get_Prop_SByteNullable() : base(1, x => x.SbyteNullableProp)
        {
        }
    }

    public class Get_Prop_SByteNullable_NoValue : GetterBase<ParentClass, sbyte?>
    {
        public Get_Prop_SByteNullable_NoValue() : base(null, x => x.SbyteNullableProp)
        {
        }
    }
    #endregion

    #region Byte/ByteNullable
    public class Get_Prop_Byte : GetterBase<ParentClass, byte>
    {
        public Get_Prop_Byte() : base(1, x => x.ByteProp)
        {
        }
    }

    public class Get_Prop_ByteNullable : GetterBase<ParentClass, byte?>
    {
        public Get_Prop_ByteNullable() : base(1, x => x.ByteNullableProp)
        {
        }
    }

    public class Get_Prop_ByteNullable_NoValue : GetterBase<ParentClass, byte?>
    {
        public Get_Prop_ByteNullable_NoValue() : base(null, x => x.ByteNullableProp)
        {
        }
    }
    #endregion

    #region Short/ShortNullable
    public class Get_Prop_Short : GetterBase<ParentClass, short>
    {
        public Get_Prop_Short() : base(1, x => x.ShortProp)
        {
        }
    }

    public class Get_Prop_ShortNullable : GetterBase<ParentClass, short?>
    {
        public Get_Prop_ShortNullable() : base(1, x => x.ShortNullableProp)
        {
        }
    }

    public class Get_Prop_ShortNullable_NoValue : GetterBase<ParentClass, short?>
    {
        public Get_Prop_ShortNullable_NoValue() : base(null, x => x.ShortNullableProp)
        {
        }
    }
    #endregion

    #region UShort/UShortNullable
    public class Get_Prop_UShort : GetterBase<ParentClass, ushort>
    {
        public Get_Prop_UShort() : base(1, x => x.UShortProp)
        {
        }
    }

    public class Get_Prop_UShortNullable : GetterBase<ParentClass, ushort?>
    {
        public Get_Prop_UShortNullable() : base(1, x => x.UShortNullableProp)
        {
        }
    }

    public class Get_Prop_UShortNullable_NoValue : GetterBase<ParentClass, ushort?>
    {
        public Get_Prop_UShortNullable_NoValue() : base(null, x => x.UShortNullableProp)
        {
        }
    }
    #endregion

    #region Int/IntNullable
    public class Get_Prop_Int : GetterBase<ParentClass, int>
    {
        public Get_Prop_Int() : base(1, x => x.IntProp)
        {
        }
    }

    public class Get_Prop_IntNullable : GetterBase<ParentClass, int?>
    {
        public Get_Prop_IntNullable() : base(1, x => x.IntNullableProp)
        {
        }
    }

    public class Get_Prop_IntNullable_NoValue : GetterBase<ParentClass, int?>
    {
        public Get_Prop_IntNullable_NoValue() : base(null, x => x.IntNullableProp)
        {
        }
    }
    #endregion

    #region UInt/UIntNullable
    public class Get_Prop_UInt : GetterBase<ParentClass, uint>
    {
        public Get_Prop_UInt() : base(1, x => x.UIntProp)
        {
        }
    }

    public class Get_Prop_UIntNullable : GetterBase<ParentClass, uint?>
    {
        public Get_Prop_UIntNullable() : base(1, x => x.UIntNullableProp)
        {
        }
    }

    public class Get_Prop_UIntNullable_NoValue : GetterBase<ParentClass, uint?>
    {
        public Get_Prop_UIntNullable_NoValue() : base(null, x => x.UIntNullableProp)
        {
        }
    }
    #endregion

    #region Long/LongNullable
    public class Get_Prop_Long : GetterBase<ParentClass, long>
    {
        public Get_Prop_Long() : base(1, x => x.LongProp)
        {
        }
    }

    public class Get_Prop_LongNullable : GetterBase<ParentClass, long?>
    {
        public Get_Prop_LongNullable() : base(1, x => x.LongNullableProp)
        {
        }
    }

    public class Get_Prop_LongNullable_NoValue : GetterBase<ParentClass, long?>
    {
        public Get_Prop_LongNullable_NoValue() : base(null, x => x.LongNullableProp)
        {
        }
    }
    #endregion

    #region ULong/ULongNullable
    public class Get_Prop_ULong : GetterBase<ParentClass, ulong>
    {
        public Get_Prop_ULong() : base(1, x => x.ULongProp)
        {
        }
    }

    public class Get_Prop_ULongNullable : GetterBase<ParentClass, ulong?>
    {
        public Get_Prop_ULongNullable() : base(1, x => x.ULongNullableProp)
        {
        }
    }

    public class Get_Prop_ULongNullable_NoValue : GetterBase<ParentClass, ulong?>
    {
        public Get_Prop_ULongNullable_NoValue() : base(null, x => x.ULongNullableProp)
        {
        }
    }
    #endregion

    #region Float/FloatNullable
    public class Get_Prop_Float : GetterBase<ParentClass, float>
    {
        public Get_Prop_Float() : base(1, x => x.FloatProp)
        {
        }
    }

    public class Get_Prop_FloatNullable : GetterBase<ParentClass, float?>
    {
        public Get_Prop_FloatNullable() : base(1, x => x.FloatNullableProp)
        {
        }
    }

    public class Get_Prop_FloatNullable_NoValue : GetterBase<ParentClass, float?>
    {
        public Get_Prop_FloatNullable_NoValue() : base(null, x => x.FloatNullableProp)
        {
        }
    }
    #endregion

    #region Double/DoubleNullable
    public class Get_Prop_Double : GetterBase<ParentClass, double>
    {
        public Get_Prop_Double() : base(1, x => x.DoubleProp)
        {
        }
    }

    public class Get_Prop_DoubleNullable : GetterBase<ParentClass, double?>
    {
        public Get_Prop_DoubleNullable() : base(1, x => x.DoubleNullableProp)
        {
        }
    }

    public class Get_Prop_DoubleNullable_NoValue : GetterBase<ParentClass, double?>
    {
        public Get_Prop_DoubleNullable_NoValue() : base(null, x => x.DoubleNullableProp)
        {
        }
    }
    #endregion

    #region Decimal/DecimalNullable
    public class Get_Prop_Decimal : GetterBase<ParentClass, decimal>
    {
        public Get_Prop_Decimal() : base(1, x => x.DecimalProp)
        {
        }
    }

    public class Get_Prop_DecimalNullable : GetterBase<ParentClass, decimal?>
    {
        public Get_Prop_DecimalNullable() : base(1, x => x.DecimalNullableProp)
        {
        }
    }

    public class Get_Prop_DecimalNullable_NoValue : GetterBase<ParentClass, decimal?>
    {
        public Get_Prop_DecimalNullable_NoValue() : base(null, x => x.DecimalNullableProp)
        {
        }
    }
    #endregion

    #region DateTime/DateTimeNullable
    public class Get_Prop_DateTime : GetterBase<ParentClass, DateTime>
    {
        public Get_Prop_DateTime() : base(DateTime.MinValue, x => x.DateTimeProp)
        {
        }
    }

    public class Get_Prop_DateTimeNullable : GetterBase<ParentClass, DateTime?>
    {
        public Get_Prop_DateTimeNullable() : base(DateTime.MinValue, x => x.DateTimeNullableProp)
        {
        }
    }

    public class Get_Prop_DateTimeNullable_NoValue : GetterBase<ParentClass, DateTime?>
    {
        public Get_Prop_DateTimeNullable_NoValue() : base(null, x => x.DateTimeNullableProp)
        {
        }
    }
    #endregion

    #region String
    public class Get_Prop_String : GetterBase<ParentClass, string>
    {
        public Get_Prop_String() : base("1", x => x.StringProp)
        {
        }
    }

    public class Get_Prop_String_Empty : GetterBase<ParentClass, string>
    {
        public Get_Prop_String_Empty() : base(string.Empty, x => x.StringProp)
        {
        }
    }

    public class Get_Prop_String_NoValue : GetterBase<ParentClass, string>
    {
        public Get_Prop_String_NoValue() : base(null, x => x.StringProp)
        {
        }
    }
    #endregion

    #region Object
    public class Get_Prop_Object : GetterBase<ParentClass, object>
    {
        public Get_Prop_Object() : base(new object(), x => x.ObjectProp)
        {
        }
    }

    public class Get_Prop_Object_NoValue : GetterBase<ParentClass, object>
    {
        public Get_Prop_Object_NoValue() : base(null, x => x.ObjectProp)
        {
        }
    }
    #endregion

    #region Enum
    public class Get_Prop_Enum : GetterBase<ParentClass, TestEnum>
    {
        public Get_Prop_Enum() : base(TestEnum.One, x => x.EnumProp)
        {
        }
    }

    public class Get_Prop_EnumNullable : GetterBase<ParentClass, TestEnum?>
    {
        public Get_Prop_EnumNullable() : base(TestEnum.One, x => x.EnumNullableProp)
        {
        }
    }

    public class Get_Prop_EnumNullable_NoValue : GetterBase<ParentClass, TestEnum?>
    {
        public Get_Prop_EnumNullable_NoValue() : base(null, x => x.EnumNullableProp)
        {
        }
    }
    #endregion
}