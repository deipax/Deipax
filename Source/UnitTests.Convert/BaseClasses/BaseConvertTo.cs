using Deipax.Core.Extensions;
using System;
using System.Globalization;
using UnitTests.Common;
using Xunit;

namespace UnitTests.Convert.BaseClasses
{
    public abstract class BaseConvertTo<TTo>
    {
        #region Protected Members
        protected abstract TTo ConvertFrom<X>(X from);

        protected static TTo GetExpected<TFrom>(TFrom from)
        {
            var toType = typeof(TTo);
            var fromType = typeof(TFrom);
            var underlyingToType = Nullable.GetUnderlyingType(toType) ?? toType;
            var underlyingFromType = Nullable.GetUnderlyingType(fromType) ?? fromType;
            var runtimeType = from?.GetType();
            var underlyingRuntimeType = runtimeType != null ? Nullable.GetUnderlyingType(runtimeType) : runtimeType;

            try
            {
                if (underlyingToType == underlyingFromType ||
                    runtimeType == underlyingToType ||
                    underlyingRuntimeType == underlyingToType ||
                    underlyingToType == typeof(object) ||
                    underlyingFromType.CanBeAssignedTo(underlyingToType))
                {
                    return (TTo)(object)from;
                }

                if (from != null)
                {
                    if (toType.IsEnum || underlyingToType.IsEnum)
                    {
                        if (fromType == typeof(string))
                        {
                            return (TTo)System.Enum.Parse(underlyingToType, from as string, true);
                        }
                        else
                        {
                            var intValue = System.Convert.ChangeType(from, typeof(int), CultureInfo.InvariantCulture);
                            return (TTo)System.Enum.Parse(underlyingToType, intValue.ToString(), true);
                        }
                    }

                    if (toType == typeof(string) && runtimeType == typeof(DBNull))
                    {
                        return default;
                    }

                    return (TTo)System.Convert.ChangeType(from, underlyingToType, CultureInfo.InvariantCulture);
                }
            }
            catch
            {
            }

            // TODO:  Fix this.  A non-convertable should return default TTo
            if (toType == typeof(string) && from != null)
            {
                return (TTo)(object)from.ToString();
            }

            return default;
        }
        #endregion

        #region Private Members
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

        #region Public Members
        public static TheoryData<bool, TTo> Bool()
        {
            return new TheoryData<bool, TTo>()
            {
                {true, GetExpected(true)},
                {false, GetExpected(false)},
            };
        }

        public static TheoryData<bool?, TTo> BoolNullable()
        {
            return new TheoryData<bool?, TTo>()
            {
                {true, GetExpected((bool?) true)},
                {false, GetExpected((bool?) false)},
                {null, GetExpected((bool?) null)},
            };
        }

        public static TheoryData<byte, TTo> Byte()
        {
            return new TheoryData<byte, TTo>()
            {
                {1, GetExpected((byte)1)},
            };
        }

        public static TheoryData<byte?, TTo> ByteNullable()
        {
            return new TheoryData<byte?, TTo>()
            {
                {1, GetExpected((byte?)1)},
                {null, GetExpected((byte?)null)},
            };
        }

        public static TheoryData<char, TTo> Char()
        {
            return new TheoryData<char, TTo>()
            {
                {'c', GetExpected('c')},
            };
        }

        public static TheoryData<char?, TTo> CharNullable()
        {
            return new TheoryData<char?, TTo>()
            {
                {'c', GetExpected((char?)'c')},
                {null, GetExpected((char?)null)},
            };
        }

        public static TheoryData<DateTime, TTo> DateTime()
        {
            return new TheoryData<DateTime, TTo>()
            {
                {System.DateTime.MinValue, GetExpected(System.DateTime.MinValue)},
                {System.DateTime.MaxValue, GetExpected(System.DateTime.MaxValue)},
            };
        }

        public static TheoryData<DateTime?, TTo> DateTimeNullable()
        {
            return new TheoryData<DateTime?, TTo>()
            {
                {(DateTime?)System.DateTime.MinValue, GetExpected((DateTime?)System.DateTime.MinValue)},
                {(DateTime?)System.DateTime.MaxValue, GetExpected((DateTime?)System.DateTime.MaxValue)},
                {null, GetExpected((DateTime?)null)},
            };
        }

        public static TheoryData<decimal, TTo> Decimal()
        {
            return new TheoryData<decimal, TTo>()
            {
                {1, GetExpected((decimal)1)},
            };
        }

        public static TheoryData<decimal?, TTo> DecimalNullable()
        {
            return new TheoryData<decimal?, TTo>()
            {
                {1, GetExpected((decimal?)1)},
                {null, GetExpected((decimal?)null)},
            };
        }

        public static TheoryData<double, TTo> Double()
        {
            return new TheoryData<double, TTo>()
            {
                {1, GetExpected((double)1)},
            };
        }

        public static TheoryData<double?, TTo> DoubleNullable()
        {
            return new TheoryData<double?, TTo>()
            {
                {1, GetExpected((double?)1)},
                {null, GetExpected((double?)null)},
            };
        }

        public static TheoryData<short, TTo> Short()
        {
            return new TheoryData<short, TTo>()
            {
                {1, GetExpected((short)1)},
            };
        }

        public static TheoryData<short?, TTo> ShortNullable()
        {
            return new TheoryData<short?, TTo>()
            {
                {1, GetExpected((short?)1)},
                {null, GetExpected((short?)null)},
            };
        }

        public static TheoryData<int, TTo> Int()
        {
            return new TheoryData<int, TTo>()
            {
                {1, GetExpected(1)},
            };
        }

        public static TheoryData<int?, TTo> IntNullable()
        {
            return new TheoryData<int?, TTo>()
            {
                {1, GetExpected((int?)1)},
                {null, GetExpected((int?)null)},
            };
        }

        public static TheoryData<long, TTo> Long()
        {
            return new TheoryData<long, TTo>()
            {
                {1, GetExpected((long)1)},
            };
        }

        public static TheoryData<long?, TTo> LongNullable()
        {
            return new TheoryData<long?, TTo>()
            {
                {1, GetExpected((long?)1)},
                {null, GetExpected((long?)null)},
            };
        }

        public static TheoryData<sbyte, TTo> SByte()
        {
            return new TheoryData<sbyte, TTo>()
            {
                {1, GetExpected((sbyte)1)},
            };
        }

        public static TheoryData<sbyte?, TTo> SByteNullable()
        {
            return new TheoryData<sbyte?, TTo>()
            {
                {1, GetExpected((sbyte?)1)},
                {null, GetExpected((sbyte?)null)},
            };
        }

        public static TheoryData<float, TTo> Float()
        {
            return new TheoryData<float, TTo>()
            {
                {1, GetExpected((float)1)},
            };
        }

        public static TheoryData<float?, TTo> FloatNullable()
        {
            return new TheoryData<float?, TTo>()
            {
                {1, GetExpected((float?)1)},
                {null, GetExpected((float?)null)},
            };
        }

        public static TheoryData<string, TTo> String()
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

        public static TheoryData<ushort, TTo> UShort()
        {
            return new TheoryData<ushort, TTo>()
            {
                {1, GetExpected((ushort)1)},
            };
        }

        public static TheoryData<ushort?, TTo> UShortNullable()
        {
            return new TheoryData<ushort?, TTo>()
            {
                {1, GetExpected((ushort?)1)},
                {null, GetExpected((ushort?)null)},
            };
        }

        public static TheoryData<uint, TTo> UInt()
        {
            return new TheoryData<uint, TTo>()
            {
                {1, GetExpected((uint)1)},
            };
        }

        public static TheoryData<uint?, TTo> UIntNullable()
        {
            return new TheoryData<uint?, TTo>()
            {
                {1, GetExpected((uint?)1)},
                {null, GetExpected((uint?)null)},
            };
        }

        public static TheoryData<ulong, TTo> ULong()
        {
            return new TheoryData<ulong, TTo>()
            {
                {1, GetExpected((ulong)1)},
            };
        }

        public static TheoryData<ulong?, TTo> ULongNullable()
        {
            return new TheoryData<ulong?, TTo>()
            {
                {1, GetExpected((ulong?)1)},
                {null, GetExpected((ulong?)null)},
            };
        }

        public static TheoryData<DBNull, TTo> DbNull()
        {

            return new TheoryData<DBNull, TTo>()
            {
                {DBNull.Value, GetExpected(DBNull.Value)},
                {null, GetExpected((DBNull)null)},
            };
        }

        public static TheoryData<ConvertibleClass, TTo> ConvertibleClass()
        {
            var input = new ConvertibleClass();

            return new TheoryData<ConvertibleClass, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((ConvertibleClass)null)},
            };
        }

        public static TheoryData<NonConvertibleClass, TTo> NonConvertibleClass()
        {
            var input = new NonConvertibleClass();

            return new TheoryData<NonConvertibleClass, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((NonConvertibleClass)null)},
            };
        }

        public static TheoryData<ConvertibleStruct, TTo> ConvertibleStruct()
        {
            var input = new ConvertibleStruct();

            return new TheoryData<ConvertibleStruct, TTo>()
            {
                {input, GetExpected(input)},
            };
        }

        public static TheoryData<ConvertibleStruct?, TTo> ConvertibleStructNullable()
        {
            var input = new ConvertibleStruct();

            return new TheoryData<ConvertibleStruct?, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((ConvertibleStruct?)null)},
            };
        }

        public static TheoryData<NonConvertibleStruct, TTo> NonConvertibleStruct()
        {
            var input = new NonConvertibleStruct();

            return new TheoryData<NonConvertibleStruct, TTo>()
            {
                {input, GetExpected(input)},
            };
        }

        public static TheoryData<NonConvertibleStruct?, TTo> NonConvertibleStructNullable()
        {
            var input = new NonConvertibleStruct();

            return new TheoryData<NonConvertibleStruct?, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((NonConvertibleStruct?)null)},
            };
        }

        public static TheoryData<TestEnum, TTo> Enum()
        {
            return new TheoryData<TestEnum, TTo>()
            {
                {TestEnum.One, GetExpected(TestEnum.One)},
            };
        }

        public static TheoryData<TestEnum?, TTo> EnumNullable()
        {
            return new TheoryData<TestEnum?, TTo>()
            {
                {TestEnum.One, GetExpected((TestEnum?)TestEnum.One)},
                {null, GetExpected((TestEnum?)null)},
            };
        }

        public static TheoryData<ParentClass, TTo> ParentClass()
        {
            var input = new ParentClass();

            return new TheoryData<ParentClass, TTo>()
            {
                {input, GetExpected(input)},
                {null, GetExpected((ParentClass)null)},
            };
        }

        public static TheoryData<ParentStruct, TTo> ParentStruct()
        {
            var input = new ParentStruct();

            return new TheoryData<ParentStruct, TTo>()
            {
                {input, GetExpected(input)},
            };
        }

        public static TheoryData<ParentStruct?, TTo> ParentStructNullable()
        {
            var input = new ParentStruct();

            return new TheoryData<ParentStruct?, TTo>()
            {
                {input, GetExpected((ParentStruct?)input)},
                {null, GetExpected((ParentStruct?)null)},
            };
        }
        #endregion

        #region From Bool
        [Theory]
        [MemberData(nameof(Bool))]
        public virtual void From_Bool(bool input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Bool))]
        public virtual void From_Bool_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(BoolNullable))]
        public virtual void From_Bool_Nullable(bool? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(BoolNullable))]
        public virtual void From_Bool_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Byte
        [Theory]
        [MemberData(nameof(Byte))]
        public virtual void From_Byte(byte input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Byte))]
        public virtual void From_Byte_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ByteNullable))]
        public virtual void From_Byte_Nullable(byte? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ByteNullable))]
        public virtual void From_Byte_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Char
        [Theory]
        [MemberData(nameof(Char))]
        public virtual void From_Char(char input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Char))]
        public virtual void From_Char_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(CharNullable))]
        public virtual void From_Char_Nullable(char? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(CharNullable))]
        public virtual void From_Char_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From DateTime
        [Theory]
        [MemberData(nameof(DateTime))]
        public virtual void From_DateTime(DateTime input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DateTime))]
        public virtual void From_DateTime_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DateTimeNullable))]
        public virtual void From_DateTime_Nullable(DateTime? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DateTimeNullable))]
        public virtual void From_DateTime_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Decimal
        [Theory]
        [MemberData(nameof(Decimal))]
        public virtual void From_Decimal(decimal input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Decimal))]
        public virtual void From_Decimal_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DecimalNullable))]
        public virtual void From_Decimal_Nullable(decimal? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DecimalNullable))]
        public virtual void From_Decimal_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Double
        [Theory]
        [MemberData(nameof(Double))]
        public virtual void From_Double(double input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Double))]
        public virtual void From_Double_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DoubleNullable))]
        public virtual void From_Double_Nullable(double? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DoubleNullable))]
        public virtual void From_Double_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Short
        [Theory]
        [MemberData(nameof(Short))]
        public virtual void From_Short(short input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Short))]
        public virtual void From_Short_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ShortNullable))]
        public virtual void From_Short_Nullable(short? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ShortNullable))]
        public virtual void From_Short_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Int
        [Theory]
        [MemberData(nameof(Int))]
        public virtual void From_Int(int input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Int))]
        public virtual void From_Int_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(IntNullable))]
        public virtual void From_Int_Nullable(int? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(IntNullable))]
        public virtual void From_Int_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Long
        [Theory]
        [MemberData(nameof(Long))]
        public virtual void From_Long(long input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Long))]
        public virtual void From_Long_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(LongNullable))]
        public virtual void From_Long_Nullable(long? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(LongNullable))]
        public virtual void From_Long_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From SByte
        [Theory]
        [MemberData(nameof(SByte))]
        public virtual void From_SByte(sbyte input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(SByte))]
        public virtual void From_SByte_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(SByteNullable))]
        public virtual void From_SByte_Nullable(sbyte? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(SByteNullable))]
        public virtual void From_SByte_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Float
        [Theory]
        [MemberData(nameof(Float))]
        public virtual void From_Float(float input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Float))]
        public virtual void From_Float_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(FloatNullable))]
        public virtual void From_Float_Nullable(float? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(FloatNullable))]
        public virtual void From_Float_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From String
        [Theory]
        [MemberData(nameof(String))]
        public virtual void From_String(string input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(String))]
        public virtual void From_String_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From UShort
        [Theory]
        [MemberData(nameof(UShort))]
        public virtual void From_UShort(ushort input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(UShort))]
        public virtual void From_UShort_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(UShortNullable))]
        public virtual void From_UShort_Nullable(ushort? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(UShortNullable))]
        public virtual void From_UShort_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From UInt
        [Theory]
        [MemberData(nameof(UInt))]
        public virtual void From_UInt(uint input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(UInt))]
        public virtual void From_UInt_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(UIntNullable))]
        public virtual void From_UInt_Nullable(uint? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(UIntNullable))]
        public virtual void From_UInt_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From ULong
        [Theory]
        [MemberData(nameof(ULong))]
        public virtual void From_ULong(ulong input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ULong))]
        public virtual void From_ULong_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ULongNullable))]
        public virtual void From_ULong_Nullable(ulong? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ULongNullable))]
        public virtual void From_ULong_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region Null/DbNull
        [Theory]
        [MemberData(nameof(DbNull))]
        public virtual void From_DBNull(DBNull input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(DbNull))]
        public virtual void From_DBNull_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From IConvertible Class
        [Theory]
        [MemberData(nameof(ConvertibleClass))]
        public virtual void From_ConvertibleClass(ConvertibleClass input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ConvertibleClass))]
        public virtual void From_ConvertibleClass_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Non-IConvertible Class
        [Theory]
        [MemberData(nameof(NonConvertibleClass))]
        public virtual void From_NonConvertibleClass(NonConvertibleClass input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(NonConvertibleClass))]
        public virtual void From_NonConvertibleClass_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From IConvertible Struct
        [Theory]
        [MemberData(nameof(ConvertibleStruct))]
        public virtual void From_ConvertibleStruct(ConvertibleStruct input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ConvertibleStruct))]
        public virtual void From_ConvertibleStruct_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ConvertibleStructNullable))]
        public virtual void From_ConvertibleStruct_Nullable(ConvertibleStruct? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ConvertibleStructNullable))]
        public virtual void From_ConvertibleStruct_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Non-IConvertible Structs
        [Theory]
        [MemberData(nameof(NonConvertibleStruct))]
        public virtual void From_NonConvertibleStruct(NonConvertibleStruct input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(NonConvertibleStruct))]
        public virtual void From_NonConvertibleStruct_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(NonConvertibleStructNullable))]
        public virtual void From_NonConvertibleStruct_WithValue(NonConvertibleStruct? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(NonConvertibleStructNullable))]
        public virtual void From_NonConvertibleStruct_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From Enum
        [Theory]
        [MemberData(nameof(Enum))]
        public virtual void From_Enum(TestEnum input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(Enum))]
        public virtual void From_Enum_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(EnumNullable))]
        public virtual void From_Enum_Nullable(TestEnum? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(EnumNullable))]
        public virtual void From_Enum_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From ParentClass
        [Theory]
        [MemberData(nameof(ParentClass))]
        public virtual void From_ParentClass(ParentClass input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ParentClass))]
        public virtual void From_ParentClass_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion

        #region From ParentStruct
        [Theory]
        [MemberData(nameof(ParentStruct))]
        public virtual void From_ParentStruct(ParentStruct input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ParentStruct))]
        public virtual void From_ParentStruct_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ParentStructNullable))]
        public virtual void From_ParentStruct_Nullable(ParentStruct? input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));

        [Theory]
        [MemberData(nameof(ParentStructNullable))]
        public virtual void From_ParentStruct_Nullable_AsObject(object input, TTo expected) => Assert.Equal(expected, ConvertFrom(input));
        #endregion
    }
}