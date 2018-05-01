
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 14.291 ns | 0.0296 ns | 0.0276 ns |      - |       0 B |
     FromBoolNullable | 14.033 ns | 0.0559 ns | 0.0523 ns |      - |       0 B |
             FromChar |        NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |  7.760 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
            FromSByte | 15.113 ns | 0.0264 ns | 0.0220 ns |      - |       0 B |
    FromSByteNullable | 15.215 ns | 0.0323 ns | 0.0287 ns |      - |       0 B |
             FromByte | 15.385 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
     FromByteNullable | 15.464 ns | 0.0207 ns | 0.0173 ns |      - |       0 B |
            FromShort | 15.099 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
    FromShortNullable | 15.154 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
           FromUShort | 15.105 ns | 0.0260 ns | 0.0231 ns |      - |       0 B |
   FromUShortNullable | 15.207 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
              FromInt | 15.114 ns | 0.0281 ns | 0.0263 ns |      - |       0 B |
      FromIntNullable | 15.154 ns | 0.0194 ns | 0.0181 ns |      - |       0 B |
             FromUInt | 15.134 ns | 0.0614 ns | 0.0574 ns |      - |       0 B |
     FromUIntNullable | 15.204 ns | 0.0137 ns | 0.0107 ns |      - |       0 B |
             FromLong | 15.093 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
     FromLongNullable | 15.119 ns | 0.0288 ns | 0.0270 ns |      - |       0 B |
            FromULong | 15.096 ns | 0.0079 ns | 0.0062 ns |      - |       0 B |
    FromULongNullable | 15.100 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
            FromFloat | 15.105 ns | 0.0225 ns | 0.0188 ns |      - |       0 B |
    FromFloatNullable | 15.121 ns | 0.0301 ns | 0.0282 ns |      - |       0 B |
           FromDouble | 15.353 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
   FromDoubleNullable | 15.361 ns | 0.0198 ns | 0.0186 ns |      - |       0 B |
          FromDecimal | 24.811 ns | 0.0171 ns | 0.0143 ns |      - |       0 B |
  FromDecimalNullable | 24.813 ns | 0.0251 ns | 0.0222 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.741 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
           FromObject | 14.177 ns | 0.0271 ns | 0.0253 ns |      - |       0 B |
           FromString | 21.118 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
             FromEnum | 45.487 ns | 0.0680 ns | 0.0636 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_BoolNullable.FromChar: DefaultJob
  Set_Prop_BoolNullable.FromDateTime: DefaultJob
