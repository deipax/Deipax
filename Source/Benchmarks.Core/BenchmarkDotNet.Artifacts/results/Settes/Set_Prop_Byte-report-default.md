
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  3.660 ns | 0.0080 ns | 0.0075 ns |       0 B |
     FromBoolNullable |  4.570 ns | 0.0039 ns | 0.0035 ns |       0 B |
             FromChar |  4.256 ns | 0.0120 ns | 0.0112 ns |       0 B |
     FromCharNullable |  4.754 ns | 0.0097 ns | 0.0086 ns |       0 B |
            FromSByte |  4.318 ns | 0.0330 ns | 0.0292 ns |       0 B |
    FromSByteNullable |  4.663 ns | 0.0055 ns | 0.0051 ns |       0 B |
             FromByte |  1.074 ns | 0.0024 ns | 0.0021 ns |       0 B |
     FromByteNullable |  1.695 ns | 0.1473 ns | 0.1378 ns |       0 B |
            FromShort |  4.530 ns | 0.0110 ns | 0.0097 ns |       0 B |
    FromShortNullable |  5.452 ns | 0.0060 ns | 0.0056 ns |       0 B |
           FromUShort |  4.571 ns | 0.0041 ns | 0.0037 ns |       0 B |
   FromUShortNullable |  4.751 ns | 0.0021 ns | 0.0017 ns |       0 B |
              FromInt |  4.551 ns | 0.0078 ns | 0.0073 ns |       0 B |
      FromIntNullable |  5.608 ns | 0.0051 ns | 0.0048 ns |       0 B |
             FromUInt |  4.679 ns | 0.0047 ns | 0.0044 ns |       0 B |
     FromUIntNullable |  4.799 ns | 0.0061 ns | 0.0051 ns |       0 B |
             FromLong |  4.738 ns | 0.0249 ns | 0.0208 ns |       0 B |
     FromLongNullable |  6.719 ns | 0.0974 ns | 0.0911 ns |       0 B |
            FromULong |  4.884 ns | 0.0370 ns | 0.0289 ns |       0 B |
    FromULongNullable |  6.444 ns | 0.0770 ns | 0.0720 ns |       0 B |
            FromFloat |  8.461 ns | 0.0876 ns | 0.0819 ns |       0 B |
    FromFloatNullable |  9.350 ns | 0.0614 ns | 0.0479 ns |       0 B |
           FromDouble |  8.497 ns | 0.2166 ns | 0.2026 ns |       0 B |
   FromDoubleNullable |  9.314 ns | 0.0651 ns | 0.0609 ns |       0 B |
          FromDecimal | 18.115 ns | 0.0254 ns | 0.0225 ns |       0 B |
  FromDecimalNullable | 22.083 ns | 0.2084 ns | 0.1627 ns |       0 B |
         FromDateTime |  3.750 ns | 0.0092 ns | 0.0082 ns |       0 B |
 FromDateTimeNullable |  4.321 ns | 0.0485 ns | 0.0453 ns |       0 B |
           FromObject |  2.863 ns | 0.0116 ns | 0.0109 ns |       0 B |
           FromString | 80.111 ns | 1.6247 ns | 1.5197 ns |       0 B |
             FromEnum |  4.892 ns | 0.0184 ns | 0.0144 ns |       0 B |
     FromEnumNullable |  5.831 ns | 0.1451 ns | 0.1782 ns |       0 B |
