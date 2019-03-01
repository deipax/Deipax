
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.5195 ns | 0.0246 ns | 0.0218 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.0063 ns | 0.0252 ns | 0.0224 ns |           - |           - |           - |                   - |
             ToChar |  1.7728 ns | 0.0192 ns | 0.0170 ns |           - |           - |           - |                   - |
     ToCharNullable |  1.2699 ns | 0.0514 ns | 0.0571 ns |           - |           - |           - |                   - |
            ToSByte |  2.2910 ns | 0.0307 ns | 0.0287 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.4170 ns | 0.0769 ns | 0.0720 ns |           - |           - |           - |                   - |
             ToByte |  2.0585 ns | 0.0237 ns | 0.0222 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.3828 ns | 0.0586 ns | 0.0548 ns |           - |           - |           - |                   - |
            ToShort |  2.3075 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.3873 ns | 0.0256 ns | 0.0239 ns |           - |           - |           - |                   - |
           ToUShort |  1.1422 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.4369 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
              ToInt |  1.1631 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.4535 ns | 0.0184 ns | 0.0163 ns |           - |           - |           - |                   - |
             ToUInt |  1.1562 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.4617 ns | 0.0398 ns | 0.0372 ns |           - |           - |           - |                   - |
             ToLong |  0.9850 ns | 0.0139 ns | 0.0123 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.3392 ns | 0.0317 ns | 0.0265 ns |           - |           - |           - |                   - |
            ToULong |  1.1504 ns | 0.0080 ns | 0.0067 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.5620 ns | 0.0078 ns | 0.0061 ns |           - |           - |           - |                   - |
            ToFloat |  0.7085 ns | 0.0118 ns | 0.0105 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.4251 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
           ToDouble |  0.6739 ns | 0.0060 ns | 0.0054 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.6172 ns | 0.0051 ns | 0.0043 ns |           - |           - |           - |                   - |
          ToDecimal |  6.1026 ns | 0.0140 ns | 0.0109 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.8983 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1748 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.5762 ns | 0.0072 ns | 0.0060 ns |           - |           - |           - |                   - |
           ToObject |  3.8719 ns | 0.0881 ns | 0.0824 ns |      0.0038 |           - |           - |                24 B |
          To_String |  6.0783 ns | 0.0894 ns | 0.0836 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 15.0334 ns | 0.0814 ns | 0.0722 ns |           - |           - |           - |                   - |
     ToEnumNullable | 20.0240 ns | 0.4280 ns | 0.5566 ns |           - |           - |           - |                   - |
