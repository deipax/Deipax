
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.123 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
     FromBoolNullable | 15.125 ns | 0.0355 ns | 0.0314 ns |      - |       0 B |
             FromChar | 16.500 ns | 0.0233 ns | 0.0207 ns |      - |       0 B |
     FromCharNullable | 16.393 ns | 0.0292 ns | 0.0244 ns |      - |       0 B |
            FromSByte | 15.137 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
    FromSByteNullable | 15.135 ns | 0.0418 ns | 0.0391 ns |      - |       0 B |
             FromByte | 15.222 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
     FromByteNullable | 15.145 ns | 0.0375 ns | 0.0350 ns |      - |       0 B |
            FromShort | 14.879 ns | 0.0345 ns | 0.0323 ns |      - |       0 B |
    FromShortNullable | 14.121 ns | 0.0418 ns | 0.0371 ns |      - |       0 B |
           FromUShort | 15.689 ns | 0.0555 ns | 0.0519 ns |      - |       0 B |
   FromUShortNullable | 15.630 ns | 0.0368 ns | 0.0344 ns |      - |       0 B |
              FromInt | 16.425 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
      FromIntNullable | 16.396 ns | 0.0265 ns | 0.0235 ns |      - |       0 B |
             FromUInt | 16.484 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
     FromUIntNullable | 16.387 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
             FromLong | 16.398 ns | 0.0424 ns | 0.0396 ns |      - |       0 B |
     FromLongNullable | 16.393 ns | 0.0572 ns | 0.0507 ns |      - |       0 B |
            FromULong | 16.365 ns | 0.1809 ns | 0.1693 ns |      - |       0 B |
    FromULongNullable | 16.417 ns | 0.0443 ns | 0.0346 ns |      - |       0 B |
            FromFloat | 19.398 ns | 0.4144 ns | 0.4256 ns |      - |       0 B |
    FromFloatNullable | 19.028 ns | 0.0710 ns | 0.0630 ns |      - |       0 B |
           FromDouble | 19.048 ns | 0.5420 ns | 0.4805 ns |      - |       0 B |
   FromDoubleNullable | 18.887 ns | 0.1963 ns | 0.1740 ns |      - |       0 B |
          FromDecimal | 27.119 ns | 0.1637 ns | 0.1531 ns |      - |       0 B |
  FromDecimalNullable | 27.433 ns | 0.2051 ns | 0.1818 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.809 ns | 0.0426 ns | 0.0398 ns |      - |       0 B |
           FromObject | 14.086 ns | 0.0270 ns | 0.0211 ns |      - |       0 B |
           FromString | 88.311 ns | 0.1542 ns | 0.1288 ns |      - |       0 B |
             FromEnum | 46.893 ns | 0.3382 ns | 0.2824 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_ShortNullable.FromDateTime: DefaultJob
