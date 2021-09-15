using Deipax.Core.Extensions;
using System;
using System.Globalization;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Convert.Common
{
    public class TestData<TTo>
    {
        public TheoryData<bool, TTo> Bool()
        {
            return new TheoryData<bool, TTo>()
            {
                {true, GetExpected(true)},
                {false, GetExpected(false)},
            };
        }

        public TheoryData<bool?, TTo> BoolNullable()
        {
            return new TheoryData<bool?, TTo>()
            {
                {true, GetExpected((bool?) true)},
                {false, GetExpected((bool?) false)},
                {null, GetExpected((bool?) null)},
            };
        }

        public TheoryData<byte, TTo> Byte()
        {
            return new TheoryData<byte, TTo>()
            {
                {1, GetExpected((byte)1)},
            };
        }

        public TheoryData<byte?, TTo> ByteNullable()
        {
            return new TheoryData<byte?, TTo>()
            {
                {1, GetExpected((byte?)1)},
                {null, GetExpected((byte?)null)},
            };
        }

        public TheoryData<char, TTo> Char()
        {
            return new TheoryData<char, TTo>()
            {
                {'c', GetExpected('c')},
            };
        }

        public TheoryData<char?, TTo> CharNullable()
        {
            return new TheoryData<char?, TTo>()
            {
                {'c', GetExpected((char?)'c')},
                {null, GetExpected((char?)null)},
            };
        }

        public TheoryData<DateTime, TTo> DateTime()
        {
            return new TheoryData<DateTime, TTo>()
            {
                {System.DateTime.MinValue, GetExpected(System.DateTime.MinValue)},
                {System.DateTime.MaxValue, GetExpected(System.DateTime.MaxValue)},
            };
        }

        public TheoryData<DateTime?, TTo> DateTimeNullable()
        {
            return new TheoryData<DateTime?, TTo>()
            {
                {(DateTime?)System.DateTime.MinValue, GetExpected((DateTime?)System.DateTime.MinValue)},
                {(DateTime?)System.DateTime.MaxValue, GetExpected((DateTime?)System.DateTime.MaxValue)},
                {null, GetExpected((DateTime?)null)},
            };
        }

        public TheoryData<decimal, TTo> Decimal()
        {
            return new TheoryData<decimal, TTo>()
            {
                {1, GetExpected((decimal)1)},
            };
        }

        public TheoryData<decimal?, TTo> DecimalNullable()
        {
            return new TheoryData<decimal?, TTo>()
            {
                {1, GetExpected((decimal?)1)},
                {null, GetExpected((decimal?)null)},
            };
        }

        public TheoryData<double, TTo> Double()
        {
            return new TheoryData<double, TTo>()
            {
                {1, GetExpected((double)1)},
            };
        }

        public TheoryData<double?, TTo> DoubleNullable()
        {
            return new TheoryData<double?, TTo>()
            {
                {1, GetExpected((double?)1)},
                {null, GetExpected((double?)null)},
            };
        }

        public TheoryData<short, TTo> Short()
        {
            return new TheoryData<short, TTo>()
            {
                {1, GetExpected((short)1)},
            };
        }

        public TheoryData<short?, TTo> ShortNullable()
        {
            return new TheoryData<short?, TTo>()
            {
                {1, GetExpected((short?)1)},
                {null, GetExpected((short?)null)},
            };
        }

        public TheoryData<int, TTo> Int()
        {
            return new TheoryData<int, TTo>()
            {
                {1, GetExpected(1)},
            };
        }

        public TheoryData<int?, TTo> IntNullable()
        {
            return new TheoryData<int?, TTo>()
            {
                {1, GetExpected((int?)1)},
                {null, GetExpected((int?)null)},
            };
        }

        public TheoryData<long, TTo> Long()
        {
            return new TheoryData<long, TTo>()
            {
                {1, GetExpected((long)1)},
            };
        }

        public TheoryData<long?, TTo> LongNullable()
        {
            return new TheoryData<long?, TTo>()
            {
                {1, GetExpected((long?)1)},
                {null, GetExpected((long?)null)},
            };
        }

        public TheoryData<sbyte, TTo> SByte()
        {
            return new TheoryData<sbyte, TTo>()
            {
                {1, GetExpected((sbyte)1)},
            };
        }

        public TheoryData<sbyte?, TTo> SByteNullable()
        {
            return new TheoryData<sbyte?, TTo>()
            {
                {1, GetExpected((sbyte?)1)},
                {null, GetExpected((sbyte?)null)},
            };
        }

        public TheoryData<float, TTo> Float()
        {
            return new TheoryData<float, TTo>()
            {
                {1, GetExpected((float)1)},
            };
        }

        public TheoryData<float?, TTo> FloatNullable()
        {
            return new TheoryData<float?, TTo>()
            {
                {1, GetExpected((float?)1)},
                {null, GetExpected((float?)null)},
            };
        }

        public TheoryData<string, TTo> String()
        {
            var data = new TheoryData<string, TTo>()
            {
                {string.Empty, GetExpected(string.Empty)},
                {null, GetExpected((string)null)},
            };

            var minValue = MinValue()?.ToString();
            var maxValue = MaxValue()?.ToString();

            if (!string.IsNullOrEmpty(minValue)) data.Add(minValue, GetExpected(minValue));
            if (!string.IsNullOrEmpty(maxValue)) data.Add(maxValue, GetExpected(maxValue));

            return data;
        }

        public TheoryData<ushort, TTo> UShort()
        {
            return new TheoryData<ushort, TTo>()
            {
                {1, GetExpected((ushort)1)},
            };
        }

        public TheoryData<ushort?, TTo> UShortNullable()
        {
            return new TheoryData<ushort?, TTo>()
            {
                {1, GetExpected((ushort?)1)},
                {null, GetExpected((ushort?)null)},
            };
        }

        public TheoryData<uint, TTo> UInt()
        {
            return new TheoryData<uint, TTo>()
            {
                {1, GetExpected((uint)1)},
            };
        }

        public TheoryData<uint?, TTo> UIntNullable()
        {
            return new TheoryData<uint?, TTo>()
            {
                {1, GetExpected((uint?)1)},
                {null, GetExpected((uint?)null)},
            };
        }

        public TheoryData<ulong, TTo> ULong()
        {
            return new TheoryData<ulong, TTo>()
            {
                {1, GetExpected((ulong)1)},
            };
        }

        public TheoryData<ulong?, TTo> ULongNullable()
        {
            return new TheoryData<ulong?, TTo>()
            {
                {1, GetExpected((ulong?)1)},
                {null, GetExpected((ulong?)null)},
            };
        }

        public TheoryData<DBNull, TTo> DbNull()
        {

            return new TheoryData<DBNull, TTo>()
            {
                {DBNull.Value, GetExpected(DBNull.Value)},
                {null, GetExpected((DBNull)null)},
            };
        }

        public TheoryData<ConvertibleClass, TTo> ConvertibleClass()
        {
            var input = new ConvertibleClass();

            return new TheoryData<ConvertibleClass, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((ConvertibleClass)null)},
            };
        }

        public TheoryData<NonConvertibleClass, TTo> NonConvertibleClass()
        {
            var input = new NonConvertibleClass();

            return new TheoryData<NonConvertibleClass, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((NonConvertibleClass)null)},
            };
        }

        public TheoryData<ConvertibleStruct, TTo> ConvertibleStruct()
        {
            var input = new ConvertibleStruct();

            return new TheoryData<ConvertibleStruct, TTo>()
            {
                {input, GetExpected(input)},
            };
        }

        public TheoryData<ConvertibleStruct?, TTo> ConvertibleStructNullable()
        {
            var input = new ConvertibleStruct();

            return new TheoryData<ConvertibleStruct?, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((ConvertibleStruct?)null)},
            };
        }

        public TheoryData<NonConvertibleStruct, TTo> NonConvertibleStruct()
        {
            var input = new NonConvertibleStruct();

            return new TheoryData<NonConvertibleStruct, TTo>()
            {
                {input, GetExpected(input)},
            };
        }

        public TheoryData<NonConvertibleStruct?, TTo> NonConvertibleStructNullable()
        {
            var input = new NonConvertibleStruct();

            return new TheoryData<NonConvertibleStruct?, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((NonConvertibleStruct?)null)},
            };
        }

        public TheoryData<TestEnum, TTo> Enum()
        {
            return new TheoryData<TestEnum, TTo>()
            {
                {TestEnum.One, GetExpected(TestEnum.One)},
            };
        }

        public TheoryData<TestEnum?, TTo> EnumNullable()
        {
            return new TheoryData<TestEnum?, TTo>()
            {
                {TestEnum.One, GetExpected((TestEnum?)TestEnum.One)},
                {null, GetExpected((TestEnum?)null)},
            };
        }

        public TheoryData<ParentClass, TTo> ParentClass()
        {
            var input = new ParentClass();

            return new TheoryData<ParentClass, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((ParentClass)null)},
            };
        }

        public TheoryData<ParentStruct, TTo> ParentStruct()
        {
            var input = new ParentStruct();

            return new TheoryData<ParentStruct, TTo>()
            {
                {input, GetExpected(input)},
            };
        }

        public TheoryData<ParentStruct?, TTo> ParentStructNullable()
        {
            var input = new ParentStruct();

            return new TheoryData<ParentStruct?, TTo>()
            {
                {input, GetExpected((ParentStruct?)input)},
                {null, GetExpected((ParentStruct?)null)},
            };
        }

        #region Private Members
        private static TTo GetExpected<TFrom>(TFrom value)
        {
            var toType = typeof(TTo);
            var fromType = typeof(TFrom);
            var underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            var underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;
            var runtimeType = value?.GetType();
            var underlyingRuntimeType = runtimeType != null ? Nullable.GetUnderlyingType(runtimeType) : runtimeType;

            try
            {
                if (underlyingToType == underlyingFromType ||
                    runtimeType == underlyingToType ||
                    underlyingRuntimeType == underlyingToType ||
                    underlyingToType == typeof(object) ||
                    underlyingFromType.CanBeAssignedTo(underlyingToType))
                {
                    return (TTo)(object)value;
                }

                if (value != null)
                {
                    if (toType.IsEnum || underlyingToType.IsEnum)
                    {
                        if (fromType == typeof(string))
                        {
                            return (TTo)System.Enum.Parse(underlyingToType, value as string, true);
                        }
                        else
                        {
                            var intValue = System.Convert.ChangeType(value, typeof(int), CultureInfo.InvariantCulture);
                            return (TTo)System.Enum.Parse(underlyingToType, intValue.ToString(), true);
                        }
                    }

                    if (toType == typeof(string) && runtimeType == typeof(DBNull))
                    {
                        return default;
                    }

                    return (TTo)System.Convert.ChangeType(value, underlyingToType, CultureInfo.InvariantCulture);
                }
            }
            catch
            {
            }

            // TODO:  Fix this.  A non-convertable should return default TTo
            if (toType == typeof(string) && value != null)
            {
                return (TTo)(object)value.ToString();
            }

            return default;
        }

        private static TTo MinValue()
        {
            var type = Nullable.GetUnderlyingType(typeof(TTo)) ?? typeof(TTo);
            var field = type.GetField("MinValue");
            object value = field?.GetValue(null);
            return value == null ? default : (TTo)value;
        }

        private static TTo MaxValue()
        {
            var type = Nullable.GetUnderlyingType(typeof(TTo)) ?? typeof(TTo);
            var field = type.GetField("MaxValue");
            object value = field?.GetValue(null);
            return value == null ? default : (TTo)value;
        }
        #endregion
    }
}
