
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 3.706 ns | 0.0364 ns | 0.0341 ns |      0.0038 |           - |           - |                24 B |
     FromBoolNullable | 1.097 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
             FromChar | 3.743 ns | 0.0311 ns | 0.0291 ns |      0.0038 |           - |           - |                24 B |
     FromCharNullable | 1.221 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
            FromSByte | 3.802 ns | 0.0289 ns | 0.0270 ns |      0.0038 |           - |           - |                24 B |
    FromSByteNullable | 1.084 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
             FromByte | 3.861 ns | 0.0404 ns | 0.0378 ns |      0.0038 |           - |           - |                24 B |
     FromByteNullable | 1.098 ns | 0.0165 ns | 0.0155 ns |           - |           - |           - |                   - |
            FromShort | 3.706 ns | 0.0282 ns | 0.0263 ns |      0.0038 |           - |           - |                24 B |
    FromShortNullable | 1.198 ns | 0.0171 ns | 0.0160 ns |           - |           - |           - |                   - |
           FromUShort | 3.777 ns | 0.0382 ns | 0.0357 ns |      0.0038 |           - |           - |                24 B |
   FromUShortNullable | 1.215 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
              FromInt | 3.907 ns | 0.0410 ns | 0.0384 ns |      0.0038 |           - |           - |                24 B |
      FromIntNullable | 1.205 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
             FromUInt | 3.871 ns | 0.0374 ns | 0.0312 ns |      0.0038 |           - |           - |                24 B |
     FromUIntNullable | 1.232 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
             FromLong | 3.797 ns | 0.0213 ns | 0.0200 ns |      0.0038 |           - |           - |                24 B |
     FromLongNullable | 1.381 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
            FromULong | 3.851 ns | 0.0352 ns | 0.0329 ns |      0.0038 |           - |           - |                24 B |
    FromULongNullable | 2.067 ns | 0.0206 ns | 0.0192 ns |           - |           - |           - |                   - |
            FromFloat | 3.876 ns | 0.0289 ns | 0.0270 ns |      0.0038 |           - |           - |                24 B |
    FromFloatNullable | 1.245 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
           FromDouble | 3.804 ns | 0.0319 ns | 0.0298 ns |      0.0038 |           - |           - |                24 B |
   FromDoubleNullable | 1.510 ns | 0.0238 ns | 0.0223 ns |           - |           - |           - |                   - |
          FromDecimal | 4.700 ns | 0.0268 ns | 0.0251 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable | 1.580 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
         FromDateTime | 4.823 ns | 0.0270 ns | 0.0252 ns |      0.0038 |           - |           - |                24 B |
 FromDateTimeNullable | 1.550 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
           FromObject | 1.985 ns | 0.0194 ns | 0.0181 ns |           - |           - |           - |                   - |
           FromString | 3.283 ns | 0.0254 ns | 0.0237 ns |           - |           - |           - |                   - |
             FromEnum | 3.911 ns | 0.0290 ns | 0.0271 ns |      0.0038 |           - |           - |                24 B |
     FromEnumNullable | 4.291 ns | 0.0259 ns | 0.0243 ns |      0.0038 |           - |           - |                24 B |
