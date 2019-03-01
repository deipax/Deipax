
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.3912 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9250 ns | 0.0412 ns | 0.0385 ns |           - |           - |           - |                   - |
             ToChar |  0.4028 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9162 ns | 0.0288 ns | 0.0270 ns |           - |           - |           - |                   - |
            ToSByte |  1.2801 ns | 0.0129 ns | 0.0115 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.5823 ns | 0.0270 ns | 0.0253 ns |           - |           - |           - |                   - |
             ToByte |  1.2681 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.5722 ns | 0.0317 ns | 0.0297 ns |           - |           - |           - |                   - |
            ToShort |  1.4942 ns | 0.0152 ns | 0.0143 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.5612 ns | 0.0205 ns | 0.0192 ns |           - |           - |           - |                   - |
           ToUShort |  0.4074 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
   ToUShortNullable |  3.9166 ns | 0.0348 ns | 0.0325 ns |           - |           - |           - |                   - |
              ToInt |  0.4004 ns | 0.0054 ns | 0.0048 ns |           - |           - |           - |                   - |
      ToIntNullable |  3.9196 ns | 0.0275 ns | 0.0258 ns |           - |           - |           - |                   - |
             ToUInt |  0.4256 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
     ToUIntNullable |  3.9263 ns | 0.0318 ns | 0.0297 ns |           - |           - |           - |                   - |
             ToLong |  0.4060 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.3728 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
            ToULong |  0.4022 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.4402 ns | 0.0100 ns | 0.0088 ns |           - |           - |           - |                   - |
            ToFloat |  0.4093 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.1125 ns | 0.0219 ns | 0.0204 ns |           - |           - |           - |                   - |
           ToDouble |  0.4064 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.4923 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
          ToDecimal |  5.4259 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 16.7816 ns | 0.1111 ns | 0.1039 ns |           - |           - |           - |                   - |
         ToDateTime |  0.8775 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.7035 ns | 0.0399 ns | 0.0373 ns |           - |           - |           - |                   - |
           ToObject |  2.5093 ns | 0.0212 ns | 0.0198 ns |      0.0038 |           - |           - |                24 B |
          To_String | 29.1974 ns | 0.2088 ns | 0.1953 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 11.5263 ns | 0.1031 ns | 0.0964 ns |           - |           - |           - |                   - |
     ToEnumNullable | 15.8527 ns | 0.0601 ns | 0.0562 ns |           - |           - |           - |                   - |
