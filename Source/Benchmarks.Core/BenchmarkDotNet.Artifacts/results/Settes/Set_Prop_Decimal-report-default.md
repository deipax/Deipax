
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  14.852 ns | 0.0187 ns | 0.0166 ns |      - |       0 B |
     FromBoolNullable |  14.859 ns | 0.0307 ns | 0.0256 ns |      - |       0 B |
             FromChar |         NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |   8.580 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
            FromSByte |  15.114 ns | 0.0179 ns | 0.0159 ns |      - |       0 B |
    FromSByteNullable |  15.120 ns | 0.0206 ns | 0.0183 ns |      - |       0 B |
             FromByte |  14.851 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
     FromByteNullable |  14.859 ns | 0.0265 ns | 0.0235 ns |      - |       0 B |
            FromShort |  15.131 ns | 0.0401 ns | 0.0375 ns |      - |       0 B |
    FromShortNullable |  15.123 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
           FromUShort |  15.110 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
   FromUShortNullable |  15.097 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
              FromInt |  15.117 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
      FromIntNullable |  15.113 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
             FromUInt |  14.603 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
     FromUIntNullable |  14.594 ns | 0.0106 ns | 0.0089 ns |      - |       0 B |
             FromLong |  15.385 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
     FromLongNullable |  15.370 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
            FromULong |  14.608 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
    FromULongNullable |  14.590 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
            FromFloat |  34.232 ns | 0.1481 ns | 0.1237 ns |      - |       0 B |
    FromFloatNullable |  34.123 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
           FromDouble |  72.875 ns | 0.0582 ns | 0.0544 ns |      - |       0 B |
   FromDoubleNullable |  72.912 ns | 0.0470 ns | 0.0439 ns |      - |       0 B |
          FromDecimal |   3.904 ns | 0.1050 ns | 0.1031 ns |      - |       0 B |
  FromDecimalNullable |   4.612 ns | 0.1671 ns | 0.4926 ns |      - |       0 B |
         FromDateTime |         NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |   8.582 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
           FromObject |   4.575 ns | 0.1627 ns | 0.4797 ns |      - |       0 B |
           FromString | 118.385 ns | 0.0357 ns | 0.0317 ns |      - |       0 B |
             FromEnum |  45.111 ns | 0.0657 ns | 0.0615 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Decimal.FromChar: DefaultJob
  Set_Prop_Decimal.FromDateTime: DefaultJob
