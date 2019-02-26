
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   3.427 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
     FromBoolNullable |   1.800 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
             FromChar |   4.656 ns | 0.0040 ns | 0.0038 ns |      0.0051 |           - |           - |                32 B |
     FromCharNullable |   1.923 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
            FromSByte |  17.687 ns | 0.0228 ns | 0.0202 ns |      0.0051 |           - |           - |                32 B |
    FromSByteNullable |   2.204 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
             FromByte |  17.443 ns | 0.0140 ns | 0.0131 ns |      0.0051 |           - |           - |                32 B |
     FromByteNullable |   2.085 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromShort |  17.722 ns | 0.0293 ns | 0.0274 ns |      0.0051 |           - |           - |                32 B |
    FromShortNullable |   2.110 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
           FromUShort |  17.956 ns | 0.0190 ns | 0.0177 ns |      0.0051 |           - |           - |                32 B |
   FromUShortNullable |   2.622 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
              FromInt |  17.561 ns | 0.0148 ns | 0.0138 ns |      0.0051 |           - |           - |                32 B |
      FromIntNullable |   2.090 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
             FromUInt |  17.408 ns | 0.0289 ns | 0.0270 ns |      0.0051 |           - |           - |                32 B |
     FromUIntNullable |   2.038 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromLong |  18.980 ns | 0.0484 ns | 0.0453 ns |      0.0051 |           - |           - |                32 B |
     FromLongNullable |   2.751 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromULong |  19.139 ns | 0.0109 ns | 0.0091 ns |      0.0051 |           - |           - |                32 B |
    FromULongNullable |   2.587 ns | 0.0194 ns | 0.0181 ns |           - |           - |           - |                   - |
            FromFloat |  41.090 ns | 0.0701 ns | 0.0655 ns |      0.0051 |           - |           - |                32 B |
    FromFloatNullable |   2.045 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
           FromDouble |  40.987 ns | 0.0298 ns | 0.0249 ns |      0.0051 |           - |           - |                32 B |
   FromDoubleNullable |   2.753 ns | 0.0028 ns | 0.0023 ns |           - |           - |           - |                   - |
          FromDecimal |  46.233 ns | 0.0404 ns | 0.0378 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable |   9.186 ns | 0.0076 ns | 0.0068 ns |           - |           - |           - |                   - |
         FromDateTime | 270.628 ns | 0.2316 ns | 0.2053 ns |      0.0262 |           - |           - |               168 B |
 FromDateTimeNullable |   2.692 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
           FromObject |   2.798 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromString |   1.566 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
             FromEnum |  67.897 ns | 0.0572 ns | 0.0535 ns |      0.0126 |           - |           - |                80 B |
     FromEnumNullable |   2.116 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
