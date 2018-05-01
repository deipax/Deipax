
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 16.729 ns | 0.0130 ns | 0.0116 ns |      - |       0 B |
     FromBoolNullable | 16.639 ns | 0.0292 ns | 0.0259 ns |      - |       0 B |
             FromChar | 17.377 ns | 0.0038 ns | 0.0027 ns |      - |       0 B |
     FromCharNullable | 17.384 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
            FromSByte | 16.625 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
    FromSByteNullable | 16.750 ns | 0.0241 ns | 0.0225 ns |      - |       0 B |
             FromByte | 16.726 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
     FromByteNullable | 16.730 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
            FromShort | 16.732 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
    FromShortNullable | 16.623 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
           FromUShort | 16.617 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
   FromUShortNullable | 16.626 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
              FromInt | 16.617 ns | 0.0133 ns | 0.0111 ns |      - |       0 B |
      FromIntNullable | 16.742 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
             FromUInt | 16.727 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
     FromUIntNullable | 16.750 ns | 0.0145 ns | 0.0121 ns |      - |       0 B |
             FromLong | 14.468 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
     FromLongNullable | 14.173 ns | 0.0230 ns | 0.0204 ns |      - |       0 B |
            FromULong | 17.377 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
    FromULongNullable | 17.383 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
            FromFloat | 21.498 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
    FromFloatNullable | 21.636 ns | 0.0113 ns | 0.0075 ns |      - |       0 B |
           FromDouble | 21.371 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
   FromDoubleNullable | 21.425 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
          FromDecimal | 64.653 ns | 0.0316 ns | 0.0228 ns |      - |       0 B |
  FromDecimalNullable | 64.369 ns | 0.0619 ns | 0.0517 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.171 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
           FromObject | 14.251 ns | 0.0321 ns | 0.0301 ns |      - |       0 B |
           FromString | 88.070 ns | 0.0553 ns | 0.0517 ns |      - |       0 B |
             FromEnum | 46.322 ns | 0.0369 ns | 0.0308 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_LongNullable.FromDateTime: DefaultJob
