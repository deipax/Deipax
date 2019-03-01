
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9726 ns | 0.0050 ns | 0.0044 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1721 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
             ToChar |  0.9783 ns | 0.0053 ns | 0.0047 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.4474 ns | 0.0188 ns | 0.0166 ns |           - |           - |           - |                   - |
            ToSByte |  0.9633 ns | 0.0088 ns | 0.0083 ns |           - |           - |           - |                   - |
    ToSByteNullable |  0.9290 ns | 0.0221 ns | 0.0185 ns |           - |           - |           - |                   - |
             ToByte |  0.9833 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.4970 ns | 0.0451 ns | 0.0422 ns |           - |           - |           - |                   - |
            ToShort |  0.9813 ns | 0.0082 ns | 0.0073 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.4240 ns | 0.0251 ns | 0.0222 ns |           - |           - |           - |                   - |
           ToUShort |  0.9931 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.4209 ns | 0.0229 ns | 0.0191 ns |           - |           - |           - |                   - |
              ToInt |  0.9781 ns | 0.0067 ns | 0.0056 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.4505 ns | 0.0255 ns | 0.0238 ns |           - |           - |           - |                   - |
             ToUInt |  0.9436 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.4230 ns | 0.0124 ns | 0.0110 ns |           - |           - |           - |                   - |
             ToLong |  0.9860 ns | 0.0091 ns | 0.0080 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9433 ns | 0.0092 ns | 0.0082 ns |           - |           - |           - |                   - |
            ToULong |  0.9549 ns | 0.0041 ns | 0.0038 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.0559 ns | 0.0041 ns | 0.0036 ns |           - |           - |           - |                   - |
            ToFloat |  1.0176 ns | 0.0144 ns | 0.0128 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.6503 ns | 0.0195 ns | 0.0173 ns |           - |           - |           - |                   - |
           ToDouble |  1.0036 ns | 0.0056 ns | 0.0050 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.1097 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
          ToDecimal |  6.0789 ns | 0.0188 ns | 0.0157 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 13.4476 ns | 0.0852 ns | 0.0797 ns |           - |           - |           - |                   - |
         ToDateTime |  1.0128 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.4184 ns | 0.0458 ns | 0.0406 ns |           - |           - |           - |                   - |
           ToObject |  0.9663 ns | 0.0069 ns | 0.0061 ns |           - |           - |           - |                   - |
          To_String |  1.2853 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
             ToEnum |  1.2924 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.6371 ns | 0.0150 ns | 0.0133 ns |           - |           - |           - |                   - |
