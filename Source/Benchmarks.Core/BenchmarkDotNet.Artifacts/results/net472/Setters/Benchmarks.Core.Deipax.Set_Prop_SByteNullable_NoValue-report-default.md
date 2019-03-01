
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.3125 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9366 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
             FromChar |  1.7736 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8018 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
            FromSByte |  0.7086 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.6786 ns | 0.0104 ns | 0.0098 ns |           - |           - |           - |                   - |
             FromByte |  1.7845 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9519 ns | 0.0214 ns | 0.0190 ns |           - |           - |           - |                   - |
            FromShort |  2.1349 ns | 0.0196 ns | 0.0174 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.1336 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
           FromUShort |  1.7682 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.0229 ns | 0.1407 ns | 0.1445 ns |           - |           - |           - |                   - |
              FromInt |  1.6795 ns | 0.0206 ns | 0.0183 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8705 ns | 0.0137 ns | 0.0122 ns |           - |           - |           - |                   - |
             FromUInt |  1.7805 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9838 ns | 0.0067 ns | 0.0059 ns |           - |           - |           - |                   - |
             FromLong |  1.6897 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.9040 ns | 0.0351 ns | 0.0328 ns |           - |           - |           - |                   - |
            FromULong |  1.9153 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8332 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
            FromFloat |  3.7448 ns | 0.0288 ns | 0.0269 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8759 ns | 0.0195 ns | 0.0183 ns |           - |           - |           - |                   - |
           FromDouble |  3.3977 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9555 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
          FromDecimal | 13.3846 ns | 0.0938 ns | 0.0877 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.2711 ns | 0.0537 ns | 0.0503 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6943 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6288 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
           FromObject |  2.7022 ns | 0.0242 ns | 0.0226 ns |           - |           - |           - |                   - |
           FromString |  1.7269 ns | 0.0314 ns | 0.0278 ns |           - |           - |           - |                   - |
             FromEnum |  1.6769 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8845 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
