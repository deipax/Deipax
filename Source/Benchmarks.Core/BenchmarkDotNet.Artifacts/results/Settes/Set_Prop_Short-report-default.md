
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.700 ns | 0.1719 ns | 0.1524 ns |      - |       0 B |
     FromBoolNullable | 12.554 ns | 0.0491 ns | 0.0460 ns |      - |       0 B |
             FromChar | 13.862 ns | 0.0483 ns | 0.0452 ns |      - |       0 B |
     FromCharNullable | 13.880 ns | 0.0561 ns | 0.0468 ns |      - |       0 B |
            FromSByte | 12.627 ns | 0.0720 ns | 0.0601 ns |      - |       0 B |
    FromSByteNullable | 12.667 ns | 0.1165 ns | 0.0973 ns |      - |       0 B |
             FromByte | 13.096 ns | 0.2928 ns | 0.4008 ns |      - |       0 B |
     FromByteNullable | 12.810 ns | 0.2260 ns | 0.2114 ns |      - |       0 B |
            FromShort |  3.377 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
    FromShortNullable |  3.361 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
           FromUShort | 13.052 ns | 0.0047 ns | 0.0040 ns |      - |       0 B |
   FromUShortNullable | 13.071 ns | 0.0143 ns | 0.0112 ns |      - |       0 B |
              FromInt | 13.894 ns | 0.0234 ns | 0.0207 ns |      - |       0 B |
      FromIntNullable | 13.833 ns | 0.0426 ns | 0.0398 ns |      - |       0 B |
             FromUInt | 13.838 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
     FromUIntNullable | 13.821 ns | 0.0358 ns | 0.0318 ns |      - |       0 B |
             FromLong | 13.884 ns | 0.0094 ns | 0.0084 ns |      - |       0 B |
     FromLongNullable | 13.821 ns | 0.0424 ns | 0.0397 ns |      - |       0 B |
            FromULong | 13.822 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
    FromULongNullable | 13.821 ns | 0.0436 ns | 0.0408 ns |      - |       0 B |
            FromFloat | 16.469 ns | 0.0275 ns | 0.0244 ns |      - |       0 B |
    FromFloatNullable | 16.438 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
           FromDouble | 16.144 ns | 0.0060 ns | 0.0047 ns |      - |       0 B |
   FromDoubleNullable | 16.299 ns | 0.1597 ns | 0.1494 ns |      - |       0 B |
          FromDecimal | 23.408 ns | 0.0084 ns | 0.0065 ns |      - |       0 B |
  FromDecimalNullable | 25.831 ns | 0.0961 ns | 0.0852 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  6.940 ns | 0.0057 ns | 0.0053 ns |      - |       0 B |
           FromObject |  3.357 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
           FromString | 86.098 ns | 0.0738 ns | 0.0654 ns |      - |       0 B |
             FromEnum | 43.811 ns | 0.0215 ns | 0.0168 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Short.FromDateTime: DefaultJob
