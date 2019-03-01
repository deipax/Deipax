
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   0.8926 ns | 0.0211 ns | 0.0198 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.5928 ns | 0.0375 ns | 0.0332 ns |           - |           - |           - |                   - |
             ToChar |   0.6767 ns | 0.0148 ns | 0.0131 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.1372 ns | 0.0326 ns | 0.0305 ns |           - |           - |           - |                   - |
            ToSByte |   4.0903 ns | 0.0232 ns | 0.0206 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.3333 ns | 0.0267 ns | 0.0249 ns |           - |           - |           - |                   - |
             ToByte |   3.3491 ns | 0.0200 ns | 0.0187 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.3524 ns | 0.0623 ns | 0.0583 ns |           - |           - |           - |                   - |
            ToShort |   3.4374 ns | 0.0317 ns | 0.0281 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.3084 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
           ToUShort |   3.5041 ns | 0.0269 ns | 0.0251 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.3292 ns | 0.0250 ns | 0.0209 ns |           - |           - |           - |                   - |
              ToInt |   2.1977 ns | 0.0202 ns | 0.0179 ns |           - |           - |           - |                   - |
      ToIntNullable |   5.6936 ns | 0.0396 ns | 0.0370 ns |           - |           - |           - |                   - |
             ToUInt |   2.1893 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
     ToUIntNullable |   5.6397 ns | 0.0194 ns | 0.0181 ns |           - |           - |           - |                   - |
             ToLong |   3.4994 ns | 0.0229 ns | 0.0215 ns |           - |           - |           - |                   - |
     ToLongNullable |   4.5960 ns | 0.0224 ns | 0.0210 ns |           - |           - |           - |                   - |
            ToULong |   3.5308 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
    ToULongNullable |   4.8856 ns | 0.0192 ns | 0.0179 ns |           - |           - |           - |                   - |
            ToFloat |   0.6591 ns | 0.0094 ns | 0.0083 ns |           - |           - |           - |                   - |
    ToFloatNullable |   3.9226 ns | 0.0276 ns | 0.0258 ns |           - |           - |           - |                   - |
           ToDouble |   0.6856 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.5917 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
          ToDecimal |  22.7938 ns | 0.1375 ns | 0.1286 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  32.2604 ns | 0.1434 ns | 0.1341 ns |           - |           - |           - |                   - |
         ToDateTime |   1.1017 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   7.7031 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
           ToObject |   2.6512 ns | 0.0181 ns | 0.0160 ns |      0.0038 |           - |           - |                24 B |
          To_String | 261.2074 ns | 1.7930 ns | 1.5895 ns |      0.0048 |           - |           - |                32 B |
             ToEnum |  13.4855 ns | 0.0925 ns | 0.0865 ns |           - |           - |           - |                   - |
     ToEnumNullable |  18.0128 ns | 0.0949 ns | 0.0887 ns |           - |           - |           - |                   - |
