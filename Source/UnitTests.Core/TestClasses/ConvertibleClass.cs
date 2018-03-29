using System;

namespace UnitTests.Core.TestClasses
{
    public class ConvertibleClass : IConvertible
    {
        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return true;
        }

        public byte ToByte(IFormatProvider provider)
        {
            return 1;
        }

        public char ToChar(IFormatProvider provider)
        {
            return 'c';
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return DateTime.MinValue;
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return 1;
        }

        public double ToDouble(IFormatProvider provider)
        {
            return 1;
        }

        public short ToInt16(IFormatProvider provider)
        {
            return 1;
        }

        public int ToInt32(IFormatProvider provider)
        {
            return 1;
        }

        public long ToInt64(IFormatProvider provider)
        {
            return 1;
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return 1;
        }

        public float ToSingle(IFormatProvider provider)
        {
            return 1;
        }

        public string ToString(IFormatProvider provider)
        {
            return "1";
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return 1;
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return 1;
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return 1;
        }
    }
}