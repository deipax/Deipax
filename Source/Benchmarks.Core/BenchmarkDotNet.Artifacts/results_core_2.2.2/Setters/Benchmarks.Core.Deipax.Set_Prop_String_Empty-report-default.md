
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   3.424 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
     FromBoolNullable |   1.801 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromChar |   4.650 ns | 0.0044 ns | 0.0041 ns |      0.0051 |           - |           - |                32 B |
     FromCharNullable |   1.925 ns | 0.0011 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromSByte |  17.650 ns | 0.0206 ns | 0.0193 ns |      0.0051 |           - |           - |                32 B |
    FromSByteNullable |   2.213 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
             FromByte |  17.457 ns | 0.0128 ns | 0.0119 ns |      0.0051 |           - |           - |                32 B |
     FromByteNullable |   2.086 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
            FromShort |  17.716 ns | 0.0157 ns | 0.0147 ns |      0.0051 |           - |           - |                32 B |
    FromShortNullable |   2.101 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
           FromUShort |  17.338 ns | 0.0158 ns | 0.0140 ns |      0.0051 |           - |           - |                32 B |
   FromUShortNullable |   2.111 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
              FromInt |  17.720 ns | 0.0288 ns | 0.0270 ns |      0.0051 |           - |           - |                32 B |
      FromIntNullable |   2.103 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
             FromUInt |  17.327 ns | 0.0216 ns | 0.0202 ns |      0.0051 |           - |           - |                32 B |
     FromUIntNullable |   2.049 ns | 0.0034 ns | 0.0030 ns |           - |           - |           - |                   - |
             FromLong |  18.927 ns | 0.0492 ns | 0.0460 ns |      0.0051 |           - |           - |                32 B |
     FromLongNullable |   2.758 ns | 0.0031 ns | 0.0026 ns |           - |           - |           - |                   - |
            FromULong |  19.258 ns | 0.0188 ns | 0.0176 ns |      0.0051 |           - |           - |                32 B |
    FromULongNullable |   2.589 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
            FromFloat |  41.183 ns | 0.0875 ns | 0.0819 ns |      0.0051 |           - |           - |                32 B |
    FromFloatNullable |   2.484 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromDouble |  40.832 ns | 0.0534 ns | 0.0474 ns |      0.0051 |           - |           - |                32 B |
   FromDoubleNullable |   2.752 ns | 0.0044 ns | 0.0037 ns |           - |           - |           - |                   - |
          FromDecimal |  46.302 ns | 0.0449 ns | 0.0420 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable |   9.217 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
         FromDateTime | 269.960 ns | 0.2276 ns | 0.2129 ns |      0.0262 |           - |           - |               168 B |
 FromDateTimeNullable |   2.715 ns | 0.0055 ns | 0.0049 ns |           - |           - |           - |                   - |
           FromObject |   2.115 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromString |   1.567 ns | 0.0011 ns | 0.0011 ns |           - |           - |           - |                   - |
             FromEnum |  67.966 ns | 0.0876 ns | 0.0731 ns |      0.0126 |           - |           - |                80 B |
     FromEnumNullable |   2.096 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
