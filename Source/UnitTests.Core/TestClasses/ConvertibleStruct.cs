using System;

namespace UnitTests.Core.TestClasses
{
    public struct ConvertibleStruct : IConvertible
    {
        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            AssertProvider(provider);
            return true;
        }

        public byte ToByte(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public char ToChar(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 'c';
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            AssertProvider(provider);
            return DateTime.MinValue;
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public double ToDouble(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public short ToInt16(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public int ToInt32(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public long ToInt64(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public float ToSingle(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public string ToString(IFormatProvider provider)
        {
            AssertProvider(provider);
            return "1";
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            AssertProvider(provider);
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            AssertProvider(provider);
            return 1;
        }

        #region Private Members
        private void AssertProvider(IFormatProvider provider)
        {
            if (provider == null)
            {
                throw new Exception("Provider not set.");
            }
        }
        #endregion
    }
}