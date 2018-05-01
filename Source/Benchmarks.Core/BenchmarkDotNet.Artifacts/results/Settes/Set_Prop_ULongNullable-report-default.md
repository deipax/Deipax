
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 16.604 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
     FromBoolNullable | 16.760 ns | 0.0426 ns | 0.0377 ns |      - |       0 B |
             FromChar | 17.512 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
     FromCharNullable | 17.527 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
            FromSByte | 17.282 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
    FromSByteNullable | 17.145 ns | 0.0341 ns | 0.0319 ns |      - |       0 B |
             FromByte | 16.625 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
     FromByteNullable | 16.641 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
            FromShort | 17.145 ns | 0.0371 ns | 0.0347 ns |      - |       0 B |
    FromShortNullable | 17.341 ns | 0.1329 ns | 0.1244 ns |      - |       0 B |
           FromUShort | 16.737 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
   FromUShortNullable | 16.744 ns | 0.0205 ns | 0.0191 ns |      - |       0 B |
              FromInt | 17.256 ns | 0.0344 ns | 0.0305 ns |      - |       0 B |
      FromIntNullable | 17.127 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
             FromUInt | 16.607 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
     FromUIntNullable | 16.623 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
             FromLong | 17.114 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
     FromLongNullable | 17.257 ns | 0.0136 ns | 0.0128 ns |      - |       0 B |
            FromULong | 14.108 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
    FromULongNullable | 14.130 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
            FromFloat | 21.088 ns | 0.0235 ns | 0.0219 ns |      - |       0 B |
    FromFloatNullable | 20.963 ns | 0.0292 ns | 0.0259 ns |      - |       0 B |
           FromDouble | 20.697 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
   FromDoubleNullable | 20.691 ns | 0.0095 ns | 0.0079 ns |      - |       0 B |
          FromDecimal | 34.062 ns | 0.0720 ns | 0.0562 ns |      - |       0 B |
  FromDecimalNullable | 36.226 ns | 0.0734 ns | 0.0687 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.211 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
           FromObject | 14.133 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
           FromString | 86.512 ns | 0.0929 ns | 0.0869 ns |      - |       0 B |
             FromEnum | 46.934 ns | 0.0593 ns | 0.0525 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_ULongNullable.FromDateTime: DefaultJob
