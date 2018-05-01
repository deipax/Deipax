
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.542 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
     FromBoolNullable | 12.533 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
             FromChar | 13.328 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
     FromCharNullable | 13.330 ns | 0.0242 ns | 0.0226 ns |      - |       0 B |
            FromSByte | 13.044 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
    FromSByteNullable | 13.267 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
             FromByte | 12.535 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
     FromByteNullable | 12.561 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
            FromShort | 13.344 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
    FromShortNullable | 13.058 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
           FromUShort | 12.528 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
   FromUShortNullable | 12.566 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
              FromInt | 13.040 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
      FromIntNullable | 13.048 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
             FromUInt |  3.308 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
     FromUIntNullable |  3.347 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
             FromLong | 13.820 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
     FromLongNullable | 13.812 ns | 0.0228 ns | 0.0203 ns |      - |       0 B |
            FromULong | 13.038 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
    FromULongNullable | 13.032 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
            FromFloat | 14.882 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
    FromFloatNullable | 15.059 ns | 0.0294 ns | 0.0246 ns |      - |       0 B |
           FromDouble | 14.232 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
   FromDoubleNullable | 14.355 ns | 0.0141 ns | 0.0118 ns |      - |       0 B |
          FromDecimal | 37.283 ns | 0.0786 ns | 0.0696 ns |      - |       0 B |
  FromDecimalNullable | 36.801 ns | 0.1018 ns | 0.0952 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  6.905 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
           FromObject |  3.314 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
           FromString | 80.889 ns | 0.0585 ns | 0.0547 ns |      - |       0 B |
             FromEnum | 42.762 ns | 0.0122 ns | 0.0114 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_UInt.FromDateTime: DefaultJob
