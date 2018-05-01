
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.833 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
     FromBoolNullable | 12.820 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
             FromChar | 13.639 ns | 0.0243 ns | 0.0215 ns |      - |       0 B |
     FromCharNullable | 13.591 ns | 0.0333 ns | 0.0311 ns |      - |       0 B |
            FromSByte | 13.405 ns | 0.0306 ns | 0.0271 ns |      - |       0 B |
    FromSByteNullable | 13.308 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
             FromByte | 12.812 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
     FromByteNullable | 12.809 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
            FromShort | 13.362 ns | 0.0556 ns | 0.0493 ns |      - |       0 B |
    FromShortNullable | 13.339 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
           FromUShort |  3.408 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
   FromUShortNullable |  3.388 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
              FromInt | 14.098 ns | 0.0173 ns | 0.0144 ns |      - |       0 B |
      FromIntNullable | 14.114 ns | 0.0190 ns | 0.0148 ns |      - |       0 B |
             FromUInt | 13.313 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
     FromUIntNullable | 13.340 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
             FromLong | 14.099 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
     FromLongNullable | 14.187 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
            FromULong | 14.083 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
    FromULongNullable | 14.116 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
            FromFloat | 16.683 ns | 0.0294 ns | 0.0261 ns |      - |       0 B |
    FromFloatNullable | 16.735 ns | 0.0535 ns | 0.0500 ns |      - |       0 B |
           FromDouble | 16.421 ns | 0.0338 ns | 0.0300 ns |      - |       0 B |
   FromDoubleNullable | 16.421 ns | 0.0092 ns | 0.0066 ns |      - |       0 B |
          FromDecimal | 24.243 ns | 0.0889 ns | 0.0832 ns |      - |       0 B |
  FromDecimalNullable | 24.305 ns | 0.0415 ns | 0.0388 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.244 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
           FromObject |  3.419 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
           FromString | 83.664 ns | 0.1642 ns | 0.1456 ns |      - |       0 B |
             FromEnum | 44.677 ns | 0.0512 ns | 0.0454 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_UShort.FromDateTime: DefaultJob
