using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Common
{
    public static class RandGen
    {
        #region Field Members
        private static string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        #endregion

        #region Public Members
        public static string GenerateString(
            uint length)
        {
            StringBuilder sb = new StringBuilder();
            var rand = new Random();

            for (int i = 0; i < length; i++)
            {
                sb.Append(_chars[(int)(rand.NextDouble() * _chars.Length)]);
            }

            return sb.ToString();
        }

        public static List<string> GenerateStringList(
            uint listLength,
            uint stringLength)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < listLength; i++)
            {
                list.Add(GenerateString(stringLength));
            }

            return list;
        }

        public static int GenerateInt(
            int min = int.MinValue,
            int max = int.MaxValue)
        {
            return new Random().Next(min, max);
        }

        public static List<int> GenerateIntList(
            uint listLength,
            int min = int.MinValue,
            int max = int.MaxValue)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < listLength; i++)
            {
                list.Add(GenerateInt(min, max));
            }

            return list;
        }

        public static DateTime? GenerateNullableDate(
            uint daysFromNow)
        {
            var days = new Random().Next((int)daysFromNow);

            if (days % 2 == 0)
            {
                return DateTime.UtcNow.AddDays(days);
            }

            return null;
        }

        public static byte[] GenerateByteArray(
            uint length)
        {
            List<byte> data = new List<byte>((int)length);
            var rand = new Random();

            for (int x = 0; x < length; x++)
            {
                data.Add((byte)rand.Next(0, 255));
            }

            return data.ToArray();
        }
        #endregion
    }
}