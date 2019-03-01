
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.175 ns | 0.0151 ns | 0.0134 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.215 ns | 0.0089 ns | 0.0074 ns |           - |           - |           - |                   - |
             ToChar |  2.607 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.974 ns | 0.0627 ns | 0.0524 ns |           - |           - |           - |                   - |
            ToSByte |  2.512 ns | 0.0223 ns | 0.0198 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.916 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
             ToByte |  2.495 ns | 0.0147 ns | 0.0131 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.895 ns | 0.0070 ns | 0.0055 ns |           - |           - |           - |                   - |
            ToShort |  2.173 ns | 0.0322 ns | 0.0269 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.934 ns | 0.0224 ns | 0.0199 ns |           - |           - |           - |                   - |
           ToUShort |  2.464 ns | 0.0114 ns | 0.0101 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.892 ns | 0.0223 ns | 0.0209 ns |           - |           - |           - |                   - |
              ToInt |  1.174 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.334 ns | 0.1035 ns | 0.0917 ns |           - |           - |           - |                   - |
             ToUInt |  1.467 ns | 0.0304 ns | 0.0270 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.233 ns | 0.0110 ns | 0.0097 ns |           - |           - |           - |                   - |
             ToLong |  1.170 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.731 ns | 0.0076 ns | 0.0064 ns |           - |           - |           - |                   - |
            ToULong |  1.489 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.176 ns | 0.0127 ns | 0.0113 ns |           - |           - |           - |                   - |
            ToFloat |  1.215 ns | 0.0091 ns | 0.0080 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.442 ns | 0.0140 ns | 0.0109 ns |           - |           - |           - |                   - |
           ToDouble |  1.200 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.733 ns | 0.0227 ns | 0.0213 ns |           - |           - |           - |                   - |
          ToDecimal |  5.822 ns | 0.0442 ns | 0.0413 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.408 ns | 0.0361 ns | 0.0338 ns |           - |           - |           - |                   - |
         ToDateTime |  2.197 ns | 0.0046 ns | 0.0039 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.968 ns | 0.0405 ns | 0.0379 ns |           - |           - |           - |                   - |
           ToObject |  3.593 ns | 0.0109 ns | 0.0102 ns |      0.0038 |           - |           - |                24 B |
          To_String | 49.602 ns | 0.5458 ns | 0.5105 ns |      0.0038 |           - |           - |                24 B |
             ToEnum |  1.209 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.484 ns | 0.0504 ns | 0.0447 ns |           - |           - |           - |                   - |
