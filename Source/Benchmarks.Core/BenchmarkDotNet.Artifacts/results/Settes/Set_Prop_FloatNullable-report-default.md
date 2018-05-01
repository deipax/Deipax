
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  14.838 ns | 0.0160 ns | 0.0142 ns |      - |       0 B |
     FromBoolNullable |  14.853 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
             FromChar |         NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |   7.731 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
            FromSByte |  14.859 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
    FromSByteNullable |  14.853 ns | 0.0050 ns | 0.0044 ns |      - |       0 B |
             FromByte |  14.838 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
     FromByteNullable |  14.841 ns | 0.0093 ns | 0.0077 ns |      - |       0 B |
            FromShort |  15.109 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
    FromShortNullable |  15.101 ns | 0.0161 ns | 0.0135 ns |      - |       0 B |
           FromUShort |  14.867 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
   FromUShortNullable |  14.834 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
              FromInt |  14.854 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
      FromIntNullable |  14.877 ns | 0.0107 ns | 0.0094 ns |      - |       0 B |
             FromUInt |  15.111 ns | 0.0330 ns | 0.0275 ns |      - |       0 B |
     FromUIntNullable |  15.124 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
             FromLong |  16.755 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
     FromLongNullable |  15.102 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
            FromULong |  15.620 ns | 0.0171 ns | 0.0152 ns |      - |       0 B |
    FromULongNullable |  15.614 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
            FromFloat |  14.077 ns | 0.0372 ns | 0.0330 ns |      - |       0 B |
    FromFloatNullable |  13.942 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
           FromDouble |  14.858 ns | 0.0219 ns | 0.0183 ns |      - |       0 B |
   FromDoubleNullable |  14.846 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
          FromDecimal |  27.058 ns | 0.0466 ns | 0.0389 ns |      - |       0 B |
  FromDecimalNullable |  27.092 ns | 0.0595 ns | 0.0556 ns |      - |       0 B |
         FromDateTime |         NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |   7.710 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
           FromObject |  13.910 ns | 0.0111 ns | 0.0099 ns |      - |       0 B |
           FromString | 107.597 ns | 0.1451 ns | 0.1358 ns |      - |       0 B |
             FromEnum |  45.005 ns | 0.0395 ns | 0.0309 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_FloatNullable.FromChar: DefaultJob
  Set_Prop_FloatNullable.FromDateTime: DefaultJob
