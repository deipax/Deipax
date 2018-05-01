
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 21.094 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
     FromBoolNullable |  8.401 ns | 0.0051 ns | 0.0042 ns |      - |       0 B |
             FromChar |        NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |  8.423 ns | 0.0056 ns | 0.0049 ns |      - |       0 B |
            FromSByte | 25.726 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |
    FromSByteNullable |  8.415 ns | 0.0040 ns | 0.0035 ns |      - |       0 B |
             FromByte | 21.120 ns | 0.0194 ns | 0.0162 ns |      - |       0 B |
     FromByteNullable |  8.435 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
            FromShort | 21.123 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
    FromShortNullable |  8.423 ns | 0.0135 ns | 0.0113 ns |      - |       0 B |
           FromUShort | 21.102 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
   FromUShortNullable |  8.423 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
              FromInt | 21.354 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
      FromIntNullable |  8.420 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
             FromUInt | 21.103 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
     FromUIntNullable |  8.420 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
             FromLong | 21.622 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
     FromLongNullable |  8.416 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
            FromULong | 21.123 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
    FromULongNullable |  8.413 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
            FromFloat | 26.730 ns | 0.0265 ns | 0.0221 ns |      - |       0 B |
    FromFloatNullable |  8.416 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
           FromDouble | 26.607 ns | 0.0216 ns | 0.0180 ns |      - |       0 B |
   FromDoubleNullable |  8.431 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
          FromDecimal | 15.794 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
  FromDecimalNullable |  8.416 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.423 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
           FromObject |  8.419 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
           FromString |  8.415 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
             FromEnum | 47.137 ns | 0.0657 ns | 0.0615 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_DecimalNullable_NoValue.FromChar: DefaultJob
  Set_Prop_DecimalNullable_NoValue.FromDateTime: DefaultJob
