
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.541 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
     FromBoolNullable | 12.533 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
             FromChar | 13.331 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
     FromCharNullable | 13.357 ns | 0.0146 ns | 0.0130 ns |      - |       0 B |
            FromSByte | 12.551 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
    FromSByteNullable | 12.595 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
             FromByte | 12.551 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
     FromByteNullable | 12.540 ns | 0.0202 ns | 0.0179 ns |      - |       0 B |
            FromShort | 12.566 ns | 0.0038 ns | 0.0033 ns |      - |       0 B |
    FromShortNullable | 12.571 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
           FromUShort | 12.539 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
   FromUShortNullable | 12.530 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
              FromInt |  3.379 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
      FromIntNullable |  3.370 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
             FromUInt | 13.058 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
     FromUIntNullable | 13.064 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
             FromLong | 13.801 ns | 0.0136 ns | 0.0121 ns |      - |       0 B |
     FromLongNullable | 13.832 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
            FromULong | 13.785 ns | 0.0051 ns | 0.0048 ns |      - |       0 B |
    FromULongNullable | 13.803 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
            FromFloat | 14.642 ns | 0.0163 ns | 0.0136 ns |      - |       0 B |
    FromFloatNullable | 14.668 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
           FromDouble | 14.416 ns | 0.0165 ns | 0.0147 ns |      - |       0 B |
   FromDoubleNullable | 14.535 ns | 0.0164 ns | 0.0128 ns |      - |       0 B |
          FromDecimal | 22.025 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
  FromDecimalNullable | 22.585 ns | 0.4586 ns | 0.4504 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.622 ns | 0.0033 ns | 0.0030 ns |      - |       0 B |
           FromObject |  3.325 ns | 0.0028 ns | 0.0026 ns |      - |       0 B |
           FromString | 83.442 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
             FromEnum | 42.839 ns | 0.0505 ns | 0.0472 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Int.FromDateTime: DefaultJob
