
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool |        NA |        NA |        NA |    N/A |       N/A |
     FromBoolNullable |  7.189 ns | 0.0034 ns | 0.0031 ns |      - |       0 B |
             FromChar |  3.361 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
     FromCharNullable |  3.362 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
            FromSByte | 13.070 ns | 0.0155 ns | 0.0137 ns |      - |       0 B |
    FromSByteNullable | 13.096 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
             FromByte | 12.542 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
     FromByteNullable | 12.764 ns | 0.1874 ns | 0.1753 ns |      - |       0 B |
            FromShort | 13.367 ns | 0.0457 ns | 0.0406 ns |      - |       0 B |
    FromShortNullable | 13.058 ns | 0.0054 ns | 0.0042 ns |      - |       0 B |
           FromUShort | 12.601 ns | 0.0374 ns | 0.0292 ns |      - |       0 B |
   FromUShortNullable | 12.554 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
              FromInt | 13.817 ns | 0.0116 ns | 0.0097 ns |      - |       0 B |
      FromIntNullable | 13.841 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
             FromUInt | 13.077 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
     FromUIntNullable | 13.079 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
             FromLong | 13.841 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
     FromLongNullable | 13.847 ns | 0.0457 ns | 0.0382 ns |      - |       0 B |
            FromULong | 13.584 ns | 0.0323 ns | 0.0287 ns |      - |       0 B |
    FromULongNullable | 13.580 ns | 0.0307 ns | 0.0287 ns |      - |       0 B |
            FromFloat |        NA |        NA |        NA |    N/A |       N/A |
    FromFloatNullable |  6.929 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
           FromDouble |        NA |        NA |        NA |    N/A |       N/A |
   FromDoubleNullable |  6.925 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
          FromDecimal |        NA |        NA |        NA |    N/A |       N/A |
  FromDecimalNullable |  6.918 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  6.958 ns | 0.0061 ns | 0.0047 ns |      - |       0 B |
           FromObject |  3.378 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
           FromString | 12.605 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
             FromEnum | 43.901 ns | 0.0263 ns | 0.0234 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Char.FromBool: DefaultJob
  Set_Prop_Char.FromFloat: DefaultJob
  Set_Prop_Char.FromDouble: DefaultJob
  Set_Prop_Char.FromDecimal: DefaultJob
  Set_Prop_Char.FromDateTime: DefaultJob
