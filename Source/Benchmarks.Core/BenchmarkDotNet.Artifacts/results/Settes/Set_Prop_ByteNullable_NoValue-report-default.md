
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.382 ns | 0.1059 ns | 0.0884 ns |      - |       0 B |
     FromBoolNullable |  7.887 ns | 0.2045 ns | 0.1913 ns |      - |       0 B |
             FromChar | 16.804 ns | 0.2053 ns | 0.1715 ns |      - |       0 B |
     FromCharNullable |  7.913 ns | 0.1801 ns | 0.1685 ns |      - |       0 B |
            FromSByte | 15.986 ns | 0.1016 ns | 0.0848 ns |      - |       0 B |
    FromSByteNullable |  7.880 ns | 0.1658 ns | 0.1551 ns |      - |       0 B |
             FromByte | 14.787 ns | 0.3127 ns | 0.3211 ns |      - |       0 B |
     FromByteNullable |  7.743 ns | 0.0317 ns | 0.0247 ns |      - |       0 B |
            FromShort | 16.629 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
    FromShortNullable |  7.895 ns | 0.1589 ns | 0.1487 ns |      - |       0 B |
           FromUShort | 16.277 ns | 0.5520 ns | 0.5669 ns |      - |       0 B |
   FromUShortNullable |  7.730 ns | 0.0123 ns | 0.0096 ns |      - |       0 B |
              FromInt | 16.604 ns | 0.0264 ns | 0.0234 ns |      - |       0 B |
      FromIntNullable |  8.015 ns | 0.1891 ns | 0.2251 ns |      - |       0 B |
             FromUInt | 15.907 ns | 0.0646 ns | 0.0573 ns |      - |       0 B |
     FromUIntNullable |  7.738 ns | 0.0160 ns | 0.0134 ns |      - |       0 B |
             FromLong | 16.651 ns | 0.0604 ns | 0.0471 ns |      - |       0 B |
     FromLongNullable |  7.811 ns | 0.0320 ns | 0.0267 ns |      - |       0 B |
            FromULong | 16.626 ns | 0.0287 ns | 0.0239 ns |      - |       0 B |
    FromULongNullable |  7.924 ns | 0.1729 ns | 0.1532 ns |      - |       0 B |
            FromFloat | 19.430 ns | 0.0549 ns | 0.0513 ns |      - |       0 B |
    FromFloatNullable |  7.732 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
           FromDouble | 19.554 ns | 0.4621 ns | 0.6478 ns |      - |       0 B |
   FromDoubleNullable |  7.838 ns | 0.0808 ns | 0.0756 ns |      - |       0 B |
          FromDecimal | 27.472 ns | 0.6175 ns | 0.6607 ns |      - |       0 B |
  FromDecimalNullable |  7.888 ns | 0.1503 ns | 0.1333 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.860 ns | 0.0943 ns | 0.0882 ns |      - |       0 B |
           FromObject |  7.731 ns | 0.0113 ns | 0.0088 ns |      - |       0 B |
           FromString |  7.937 ns | 0.2369 ns | 0.2216 ns |      - |       0 B |
             FromEnum | 47.138 ns | 0.4142 ns | 0.3458 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_ByteNullable_NoValue.FromDateTime: DefaultJob
