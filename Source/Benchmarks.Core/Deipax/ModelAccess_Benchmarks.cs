using System;
using Benchmarks.Core.BaseClasses;
using Benchmarks.Core.TestClasses;

namespace Benchmarks.Core.Deipax
{
    public class Bool_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, bool, string>
    {
        public Bool_ModelAccess() : base(
            true,
            bool.TrueString,
            x => x.BoolProp,
            x => x.BoolField,
            x => x.BoolProp,
            x => x.BoolField)
        {
        }
    }

    public class BoolNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, bool?, string>
    {
        public BoolNullable_ModelAccess() : base(
            true,
            bool.TrueString,
            x => x.BoolNullableProp,
            x => x.BoolNullableField,
            x => x.BoolNullableProp,
            x => x.BoolNullableField)
        {
        }
    }

    public class Char_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, char, string>
    {
        public Char_ModelAccess() : base(
            'c',
            "c",
            x => x.CharProp,
            x => x.CharField,
            x => x.CharProp,
            x => x.CharField)
        {
        }
    }

    public class CharNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, char?, string>
    {
        public CharNullable_ModelAccess() : base(
            'c',
            "c",
            x => x.CharNullableProp,
            x => x.CharNullableField,
            x => x.CharNullableProp,
            x => x.CharNullableField)
        {
        }
    }

    public class Sbyte_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, sbyte, string>
    {
        public Sbyte_ModelAccess() : base(
            sbyte.MaxValue,
            sbyte.MaxValue.ToString(),
            x => x.SbyteProp,
            x => x.SbyteField,
            x => x.SbyteProp,
            x => x.SbyteField)
        {
        }
    }

    public class SbyteNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, sbyte?, string>
    {
        public SbyteNullable_ModelAccess() : base(
            sbyte.MaxValue,
            sbyte.MaxValue.ToString(),
            x => x.SbyteNullableProp,
            x => x.SbyteNullableField,
            x => x.SbyteNullableProp,
            x => x.SbyteNullableField)
        {
        }
    }

    public class Byte_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, byte, string>
    {
        public Byte_ModelAccess() : base(
            byte.MaxValue,
            byte.MaxValue.ToString(),
            x => x.ByteProp,
            x => x.ByteField,
            x => x.ByteProp,
            x => x.ByteField)
        {
        }
    }

    public class ByteNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, byte?, string>
    {
        public ByteNullable_ModelAccess() : base(
            byte.MaxValue,
            byte.MaxValue.ToString(),
            x => x.ByteNullableProp,
            x => x.ByteNullableField,
            x => x.ByteNullableProp,
            x => x.ByteNullableField)
        {
        }
    }

    public class Short_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, short, string>
    {
        public Short_ModelAccess() : base(
            short.MaxValue,
            short.MaxValue.ToString(),
            x => x.ShortProp,
            x => x.ShortField,
            x => x.ShortProp,
            x => x.ShortField)
        {
        }
    }

    public class ShortNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, short?, string>
    {
        public ShortNullable_ModelAccess() : base(
            short.MaxValue,
            short.MaxValue.ToString(),
            x => x.ShortNullableProp,
            x => x.ShortNullableField,
            x => x.ShortNullableProp,
            x => x.ShortNullableField)
        {
        }
    }

    public class UShort_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, ushort, string>
    {
        public UShort_ModelAccess() : base(
            ushort.MaxValue,
            ushort.MaxValue.ToString(),
            x => x.UShortProp,
            x => x.UShortField,
            x => x.UShortProp,
            x => x.UShortField)
        {
        }
    }

    public class UShortNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, ushort?, string>
    {
        public UShortNullable_ModelAccess() : base(
            ushort.MaxValue,
            ushort.MaxValue.ToString(),
            x => x.UShortNullableProp,
            x => x.UShortNullableField,
            x => x.UShortNullableProp,
            x => x.UShortNullableField)
        {
        }
    }

    public class Int_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, int, string>
    {
        public Int_ModelAccess() : base(
            int.MaxValue,
            int.MaxValue.ToString(),
            x => x.IntProp,
            x => x.IntField,
            x => x.IntProp,
            x => x.IntField)
        {
        }
    }

    public class IntNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, int?, string>
    {
        public IntNullable_ModelAccess() : base(
            int.MaxValue,
            int.MaxValue.ToString(),
            x => x.IntNullableProp,
            x => x.IntNullableField,
            x => x.IntNullableProp,
            x => x.IntNullableField)
        {
        }
    }

    public class UInt_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, uint, string>
    {
        public UInt_ModelAccess() : base(
            uint.MaxValue,
            uint.MaxValue.ToString(),
            x => x.UIntProp,
            x => x.UIntField,
            x => x.UIntProp,
            x => x.UIntField)
        {
        }
    }

    public class UIntNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, uint?, string>
    {
        public UIntNullable_ModelAccess() : base(
            uint.MaxValue,
            uint.MaxValue.ToString(),
            x => x.UIntNullableProp,
            x => x.UIntNullableField,
            x => x.UIntNullableProp,
            x => x.UIntNullableField)
        {
        }
    }

    public class Long_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, long, string>
    {
        public Long_ModelAccess() : base(
            long.MaxValue,
            long.MaxValue.ToString(),
            x => x.LongProp,
            x => x.LongField,
            x => x.LongProp,
            x => x.LongField)
        {
        }
    }

    public class LongNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, long?, string>
    {
        public LongNullable_ModelAccess() : base(
            long.MaxValue,
            long.MaxValue.ToString(),
            x => x.LongNullableProp,
            x => x.LongNullableField,
            x => x.LongNullableProp,
            x => x.LongNullableField)
        {
        }
    }

    public class ULong_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, ulong, string>
    {
        public ULong_ModelAccess() : base(
            ulong.MaxValue,
            ulong.MaxValue.ToString(),
            x => x.ULongProp,
            x => x.ULongField,
            x => x.ULongProp,
            x => x.ULongField)
        {
        }
    }

    public class ULongNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, ulong?, string>
    {
        public ULongNullable_ModelAccess() : base(
            ulong.MaxValue,
            ulong.MaxValue.ToString(),
            x => x.ULongNullableProp,
            x => x.ULongNullableField,
            x => x.ULongNullableProp,
            x => x.ULongNullableField)
        {
        }
    }

    public class Float_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, float, string>
    {
        public Float_ModelAccess() : base(
            float.MaxValue,
            float.MaxValue.ToString(),
            x => x.FloatProp,
            x => x.FloatField,
            x => x.FloatProp,
            x => x.FloatField)
        {
        }
    }

    public class FloatNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, float?, string>
    {
        public FloatNullable_ModelAccess() : base(
            float.MaxValue,
            float.MaxValue.ToString(),
            x => x.FloatNullableProp,
            x => x.FloatNullableField,
            x => x.FloatNullableProp,
            x => x.FloatNullableField)
        {
        }
    }

    public class Double_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, double, string>
    {
        public Double_ModelAccess() : base(
            double.MaxValue,
            double.MaxValue.ToString(),
            x => x.DoubleProp,
            x => x.DoubleField,
            x => x.DoubleProp,
            x => x.DoubleField)
        {
        }
    }

    public class DoubleNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, double?, string>
    {
        public DoubleNullable_ModelAccess() : base(
            double.MaxValue,
            double.MaxValue.ToString(),
            x => x.DoubleNullableProp,
            x => x.DoubleNullableField,
            x => x.DoubleNullableProp,
            x => x.DoubleNullableField)
        {
        }
    }

    public class Decimal_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, decimal, string>
    {
        public Decimal_ModelAccess() : base(
            decimal.MaxValue,
            decimal.MaxValue.ToString(),
            x => x.DecimalProp,
            x => x.DecimalField,
            x => x.DecimalProp,
            x => x.DecimalField)
        {
        }
    }

    public class DecimalNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, decimal?, string>
    {
        public DecimalNullable_ModelAccess() : base(
            decimal.MaxValue,
            decimal.MaxValue.ToString(),
            x => x.DecimalNullableProp,
            x => x.DecimalNullableField,
            x => x.DecimalNullableProp,
            x => x.DecimalNullableField)
        {
        }
    }

    public class DateTime_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, DateTime, string>
    {
        public DateTime_ModelAccess() : base(
            DateTime.MaxValue,
            DateTime.MaxValue.ToString(),
            x => x.DateTimeProp,
            x => x.DateTimeField,
            x => x.DateTimeProp,
            x => x.DateTimeField)
        {
        }
    }

    public class DateTimeNullable_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, DateTime?, string>
    {
        public DateTimeNullable_ModelAccess() : base(
            DateTime.MaxValue,
            DateTime.MaxValue.ToString(),
            x => x.DateTimeNullableProp,
            x => x.DateTimeNullableField,
            x => x.DateTimeNullableProp,
            x => x.DateTimeNullableField)
        {
        }
    }

    public class String_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, string, int>
    {
        public String_ModelAccess() : base(
            "Hello",
            int.MaxValue,
            x => x.StringProp,
            x => x.StringField,
            x => x.StringProp,
            x => x.StringField)
        {
        }
    }

    public class Object_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, object, string>
    {
        public Object_ModelAccess() : base(
            "Hello",
            int.MaxValue.ToString(),
            x => x.ObjectProp,
            x => x.ObjectField,
            x => x.ObjectProp,
            x => x.ObjectField)
        {
        }
    }

    public class Enum_ModelAccess : BaseModelAccess<ParentClass, ParentStruct, TestEnum, string>
    {
        public Enum_ModelAccess() : base(
            TestEnum.One,
            TestEnum.One.ToString(),
            x => x.EnumProp,
            x => x.EnumField,
            x => x.EnumProp,
            x => x.EnumField)
        {
        }
    }
}