
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 3.496 ns | 0.0371 ns | 0.0347 ns |      0.0038 |           - |           - |                24 B |
     FromBoolNullable | 1.057 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
             FromChar | 3.686 ns | 0.0326 ns | 0.0305 ns |      0.0038 |           - |           - |                24 B |
     FromCharNullable | 1.366 ns | 0.0198 ns | 0.0185 ns |           - |           - |           - |                   - |
            FromSByte | 3.633 ns | 0.0232 ns | 0.0217 ns |      0.0038 |           - |           - |                24 B |
    FromSByteNullable | 1.050 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
             FromByte | 3.858 ns | 0.0347 ns | 0.0325 ns |      0.0038 |           - |           - |                24 B |
     FromByteNullable | 1.164 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
            FromShort | 3.502 ns | 0.0386 ns | 0.0361 ns |      0.0038 |           - |           - |                24 B |
    FromShortNullable | 1.190 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
           FromUShort | 3.817 ns | 0.0366 ns | 0.0342 ns |      0.0038 |           - |           - |                24 B |
   FromUShortNullable | 1.181 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
              FromInt | 3.748 ns | 0.0335 ns | 0.0313 ns |      0.0038 |           - |           - |                24 B |
      FromIntNullable | 1.213 ns | 0.0170 ns | 0.0159 ns |           - |           - |           - |                   - |
             FromUInt | 3.728 ns | 0.0233 ns | 0.0218 ns |      0.0038 |           - |           - |                24 B |
     FromUIntNullable | 1.223 ns | 0.0195 ns | 0.0183 ns |           - |           - |           - |                   - |
             FromLong | 4.402 ns | 0.0429 ns | 0.0401 ns |      0.0038 |           - |           - |                24 B |
     FromLongNullable | 1.401 ns | 0.0122 ns | 0.0115 ns |           - |           - |           - |                   - |
            FromULong | 3.825 ns | 0.0495 ns | 0.0463 ns |      0.0038 |           - |           - |                24 B |
    FromULongNullable | 1.408 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
            FromFloat | 3.644 ns | 0.0310 ns | 0.0290 ns |      0.0038 |           - |           - |                24 B |
    FromFloatNullable | 1.196 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
           FromDouble | 3.641 ns | 0.0317 ns | 0.0296 ns |      0.0038 |           - |           - |                24 B |
   FromDoubleNullable | 1.610 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
          FromDecimal | 4.821 ns | 0.0276 ns | 0.0258 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable | 1.685 ns | 0.0127 ns | 0.0113 ns |           - |           - |           - |                   - |
         FromDateTime | 3.715 ns | 0.0263 ns | 0.0246 ns |      0.0038 |           - |           - |                24 B |
 FromDateTimeNullable | 1.605 ns | 0.0203 ns | 0.0170 ns |           - |           - |           - |                   - |
           FromObject | 1.715 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
           FromString | 2.162 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
             FromEnum | 3.789 ns | 0.0258 ns | 0.0241 ns |      0.0038 |           - |           - |                24 B |
     FromEnumNullable | 1.224 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
