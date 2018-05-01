
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 38.550 ns | 0.0509 ns | 0.0452 ns |       0 B |
     FromBoolNullable | 38.306 ns | 0.0640 ns | 0.0598 ns |       0 B |
             FromChar | 39.293 ns | 0.0205 ns | 0.0160 ns |       0 B |
     FromCharNullable | 39.087 ns | 0.0724 ns | 0.0678 ns |       0 B |
            FromSByte | 38.245 ns | 0.0134 ns | 0.0119 ns |       0 B |
    FromSByteNullable | 38.285 ns | 0.0514 ns | 0.0481 ns |       0 B |
             FromByte | 38.257 ns | 0.0363 ns | 0.0339 ns |       0 B |
     FromByteNullable | 38.279 ns | 0.0460 ns | 0.0408 ns |       0 B |
            FromShort | 39.171 ns | 0.0672 ns | 0.0629 ns |       0 B |
    FromShortNullable | 38.287 ns | 0.0513 ns | 0.0428 ns |       0 B |
           FromUShort | 38.508 ns | 0.0725 ns | 0.0678 ns |       0 B |
   FromUShortNullable | 38.295 ns | 0.0538 ns | 0.0503 ns |       0 B |
              FromInt | 33.045 ns | 0.0486 ns | 0.0454 ns |       0 B |
      FromIntNullable | 32.248 ns | 0.0778 ns | 0.0690 ns |       0 B |
             FromUInt | 38.796 ns | 0.0498 ns | 0.0466 ns |       0 B |
     FromUIntNullable | 38.760 ns | 0.0294 ns | 0.0246 ns |       0 B |
             FromLong | 40.707 ns | 0.0220 ns | 0.0184 ns |       0 B |
     FromLongNullable | 40.365 ns | 0.0682 ns | 0.0569 ns |       0 B |
            FromULong | 39.505 ns | 0.0113 ns | 0.0094 ns |       0 B |
    FromULongNullable | 39.809 ns | 0.0248 ns | 0.0207 ns |       0 B |
            FromFloat | 41.429 ns | 0.0153 ns | 0.0136 ns |       0 B |
    FromFloatNullable | 41.456 ns | 0.0807 ns | 0.0715 ns |       0 B |
           FromDouble | 41.586 ns | 0.0306 ns | 0.0271 ns |       0 B |
   FromDoubleNullable | 41.066 ns | 0.0277 ns | 0.0216 ns |       0 B |
          FromDecimal | 64.054 ns | 0.0300 ns | 0.0266 ns |       0 B |
  FromDecimalNullable | 52.595 ns | 0.0344 ns | 0.0305 ns |       0 B |
         FromDateTime |        NA |        NA |        NA |       N/A |
 FromDateTimeNullable |  7.516 ns | 0.0016 ns | 0.0015 ns |       0 B |
           FromObject | 14.071 ns | 0.0141 ns | 0.0132 ns |       0 B |
           FromString | 36.629 ns | 0.0331 ns | 0.0276 ns |       0 B |
             FromEnum | 13.961 ns | 0.0050 ns | 0.0039 ns |       0 B |

Benchmarks with issues:
  Set_Prop_EnumNullable.FromDateTime: DefaultJob
