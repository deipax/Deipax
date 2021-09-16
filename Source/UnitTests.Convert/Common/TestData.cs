using System;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Convert.Common
{
    // TODO: Add MinValue/MaxValue where appropriate
    // TODO: TheoryData string, MinValue/MaxValue for all types.
    public static class TestData
    {
        public static TheoryData<bool> Bool()
        {
            return new TheoryData<bool>()
            {
                {true},
                {false},
            };
        }

        public static TheoryData<bool?> BoolNullable()
        {
            return new TheoryData<bool?>()
            {
                {true},
                {false},
                {null},
            };
        }

        public static TheoryData<byte> Byte()
        {
            return new TheoryData<byte>()
            {
                {1},
            };
        }

        public static TheoryData<byte?> ByteNullable()
        {
            return new TheoryData<byte?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<char> Char()
        {
            return new TheoryData<char>()
            {
                {'c'},
            };
        }

        public static TheoryData<char?> CharNullable()
        {
            return new TheoryData<char?>()
            {
                {'c'},
                {null},
            };
        }

        public static TheoryData<DateTime> DateTime()
        {
            return new TheoryData<DateTime>()
            {
                {System.DateTime.MinValue},
                {System.DateTime.MaxValue},
            };
        }

        public static TheoryData<DateTime?> DateTimeNullable()
        {
            return new TheoryData<DateTime?>()
            {
                {(DateTime?)System.DateTime.MinValue},
                {(DateTime?)System.DateTime.MaxValue},
                {null},
            };
        }

        public static TheoryData<decimal> Decimal()
        {
            return new TheoryData<decimal>()
            {
                {1},
            };
        }

        public static TheoryData<decimal?> DecimalNullable()
        {
            return new TheoryData<decimal?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<double> Double()
        {
            return new TheoryData<double>()
            {
                {1},
            };
        }

        public static TheoryData<double?> DoubleNullable()
        {
            return new TheoryData<double?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<short> Short()
        {
            return new TheoryData<short>()
            {
                {1},
            };
        }

        public static TheoryData<short?> ShortNullable()
        {
            return new TheoryData<short?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<int> Int()
        {
            return new TheoryData<int>()
            {
                {1},
            };
        }

        public static TheoryData<int?> IntNullable()
        {
            return new TheoryData<int?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<long> Long()
        {
            return new TheoryData<long>()
            {
                {1},
            };
        }

        public static TheoryData<long?> LongNullable()
        {
            return new TheoryData<long?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<sbyte> SByte()
        {
            return new TheoryData<sbyte>()
            {
                {1},
            };
        }

        public static TheoryData<sbyte?> SByteNullable()
        {
            return new TheoryData<sbyte?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<float> Float()
        {
            return new TheoryData<float>()
            {
                {1},
            };
        }

        public static TheoryData<float?> FloatNullable()
        {
            return new TheoryData<float?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<string> String()
        {
            return new TheoryData<string>()
            {
                {string.Empty},
                {null},
            };
        }

        public static TheoryData<ushort> UShort()
        {
            return new TheoryData<ushort>()
            {
                {1},
            };
        }

        public static TheoryData<ushort?> UShortNullable()
        {
            return new TheoryData<ushort?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<uint> UInt()
        {
            return new TheoryData<uint>()
            {
                {1},
            };
        }

        public static TheoryData<uint?> UIntNullable()
        {
            return new TheoryData<uint?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<ulong> ULong()
        {
            return new TheoryData<ulong>()
            {
                {1},
            };
        }

        public static TheoryData<ulong?> ULongNullable()
        {
            return new TheoryData<ulong?>()
            {
                {1},
                {null},
            };
        }

        public static TheoryData<DBNull> DbNull()
        {

            return new TheoryData<DBNull>()
            {
                {DBNull.Value},
                {null},
            };
        }

        public static TheoryData<ConvertibleClass> ConvertibleClass()
        {
            return new TheoryData<ConvertibleClass>()
            {
                {new ConvertibleClass()},
                {null},
            };
        }

        public static TheoryData<NonConvertibleClass> NonConvertibleClass()
        {
            return new TheoryData<NonConvertibleClass>()
            {
                {new NonConvertibleClass()},
                {null},
            };
        }

        public static TheoryData<ConvertibleStruct> ConvertibleStruct()
        {
            return new TheoryData<ConvertibleStruct>()
            {
                {new ConvertibleStruct()},
            };
        }

        public static TheoryData<ConvertibleStruct?> ConvertibleStructNullable()
        {
            return new TheoryData<ConvertibleStruct?>()
            {
                {new ConvertibleStruct()},
                {null},
            };
        }

        public static TheoryData<NonConvertibleStruct> NonConvertibleStruct()
        {
            return new TheoryData<NonConvertibleStruct>()
            {
                {new NonConvertibleStruct()},
            };
        }

        public static TheoryData<NonConvertibleStruct?> NonConvertibleStructNullable()
        {
            return new TheoryData<NonConvertibleStruct?>()
            {
                {new NonConvertibleStruct()},
            };
        }

        public static TheoryData<TestEnum> Enum()
        {
            return new TheoryData<TestEnum>()
            {
                {TestEnum.One},
            };
        }

        public static TheoryData<TestEnum?> EnumNullable()
        {
            return new TheoryData<TestEnum?>()
            {
                {TestEnum.One},
                {null},
            };
        }

        public static TheoryData<ParentClass> ParentClass()
        {
            return new TheoryData<ParentClass>()
            {
                {new ParentClass()},
                {null},
            };
        }

        public static TheoryData<ParentStruct> ParentStruct()
        {
            return new TheoryData<ParentStruct>()
            {
                {new ParentStruct()},
            };
        }

        public static TheoryData<ParentStruct?> ParentStructNullable()
        {
            return new TheoryData<ParentStruct?>()
            {
                {new ParentStruct()},
                {null},
            };
        }
    }
}
