
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.094 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
     FromBoolNullable | 15.073 ns | 0.0274 ns | 0.0229 ns |      - |       0 B |
             FromChar | 16.380 ns | 0.0305 ns | 0.0255 ns |      - |       0 B |
     FromCharNullable | 16.388 ns | 0.0577 ns | 0.0511 ns |      - |       0 B |
            FromSByte | 14.010 ns | 0.0331 ns | 0.0277 ns |      - |       0 B |
    FromSByteNullable | 14.234 ns | 0.0129 ns | 0.0108 ns |      - |       0 B |
             FromByte | 15.645 ns | 0.0735 ns | 0.0651 ns |      - |       0 B |
     FromByteNullable | 15.782 ns | 0.0427 ns | 0.0357 ns |      - |       0 B |
            FromShort | 16.426 ns | 0.0921 ns | 0.0769 ns |      - |       0 B |
    FromShortNullable | 16.404 ns | 0.0732 ns | 0.0649 ns |      - |       0 B |
           FromUShort | 15.696 ns | 0.0959 ns | 0.0850 ns |      - |       0 B |
   FromUShortNullable | 15.679 ns | 0.1376 ns | 0.1149 ns |      - |       0 B |
              FromInt | 16.135 ns | 0.0371 ns | 0.0290 ns |      - |       0 B |
      FromIntNullable | 16.220 ns | 0.1912 ns | 0.1695 ns |      - |       0 B |
             FromUInt | 15.586 ns | 0.0346 ns | 0.0307 ns |      - |       0 B |
     FromUIntNullable | 15.754 ns | 0.1660 ns | 0.1553 ns |      - |       0 B |
             FromLong | 16.438 ns | 0.0880 ns | 0.0780 ns |      - |       0 B |
     FromLongNullable | 16.421 ns | 0.0343 ns | 0.0286 ns |      - |       0 B |
            FromULong | 15.587 ns | 0.0231 ns | 0.0205 ns |      - |       0 B |
    FromULongNullable | 15.655 ns | 0.0880 ns | 0.0780 ns |      - |       0 B |
            FromFloat | 18.747 ns | 0.0484 ns | 0.0378 ns |      - |       0 B |
    FromFloatNullable | 19.134 ns | 0.4993 ns | 0.5944 ns |      - |       0 B |
           FromDouble | 18.507 ns | 0.0757 ns | 0.0671 ns |      - |       0 B |
   FromDoubleNullable | 18.458 ns | 0.0664 ns | 0.0589 ns |      - |       0 B |
          FromDecimal | 27.612 ns | 0.0876 ns | 0.0776 ns |      - |       0 B |
  FromDecimalNullable | 27.364 ns | 0.0551 ns | 0.0430 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.740 ns | 0.0254 ns | 0.0225 ns |      - |       0 B |
           FromObject | 14.263 ns | 0.0537 ns | 0.0476 ns |      - |       0 B |
           FromString | 89.756 ns | 0.2088 ns | 0.1954 ns |      - |       0 B |
             FromEnum | 47.146 ns | 0.0734 ns | 0.0613 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_SByteNullable.FromDateTime: DefaultJob
