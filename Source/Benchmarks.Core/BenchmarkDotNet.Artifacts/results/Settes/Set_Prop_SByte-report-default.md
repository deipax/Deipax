
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  3.672 ns | 0.0168 ns | 0.0157 ns |       0 B |
     FromBoolNullable |  4.565 ns | 0.0133 ns | 0.0124 ns |       0 B |
             FromChar |  4.290 ns | 0.0069 ns | 0.0064 ns |       0 B |
     FromCharNullable |  4.809 ns | 0.0057 ns | 0.0034 ns |       0 B |
            FromSByte |  1.088 ns | 0.0120 ns | 0.0100 ns |       0 B |
    FromSByteNullable |  1.562 ns | 0.0094 ns | 0.0083 ns |       0 B |
             FromByte |  4.367 ns | 0.0412 ns | 0.0386 ns |       0 B |
     FromByteNullable |  4.775 ns | 0.0052 ns | 0.0049 ns |       0 B |
            FromShort |  4.636 ns | 0.0099 ns | 0.0088 ns |       0 B |
    FromShortNullable |  5.518 ns | 0.0031 ns | 0.0028 ns |       0 B |
           FromUShort |  4.363 ns | 0.0085 ns | 0.0080 ns |       0 B |
   FromUShortNullable |  4.845 ns | 0.0048 ns | 0.0045 ns |       0 B |
              FromInt |  4.589 ns | 0.0220 ns | 0.0184 ns |       0 B |
      FromIntNullable |  5.418 ns | 0.0054 ns | 0.0048 ns |       0 B |
             FromUInt |  4.736 ns | 0.0062 ns | 0.0055 ns |       0 B |
     FromUIntNullable |  4.889 ns | 0.0109 ns | 0.0102 ns |       0 B |
             FromLong |  4.611 ns | 0.0028 ns | 0.0026 ns |       0 B |
     FromLongNullable |  6.625 ns | 0.0009 ns | 0.0007 ns |       0 B |
            FromULong |  4.425 ns | 0.0147 ns | 0.0123 ns |       0 B |
    FromULongNullable |  5.135 ns | 0.0015 ns | 0.0012 ns |       0 B |
            FromFloat |  8.405 ns | 0.0047 ns | 0.0039 ns |       0 B |
    FromFloatNullable |  9.320 ns | 0.0028 ns | 0.0022 ns |       0 B |
           FromDouble |  8.289 ns | 0.0098 ns | 0.0092 ns |       0 B |
   FromDoubleNullable |  8.929 ns | 0.0078 ns | 0.0073 ns |       0 B |
          FromDecimal | 16.471 ns | 0.0071 ns | 0.0063 ns |       0 B |
  FromDecimalNullable | 21.582 ns | 0.0106 ns | 0.0094 ns |       0 B |
         FromDateTime |  3.729 ns | 0.0053 ns | 0.0044 ns |       0 B |
 FromDateTimeNullable |  4.243 ns | 0.0020 ns | 0.0016 ns |       0 B |
           FromObject |  2.690 ns | 0.0025 ns | 0.0023 ns |       0 B |
           FromString | 77.801 ns | 0.0136 ns | 0.0114 ns |       0 B |
             FromEnum |  5.241 ns | 0.0023 ns | 0.0020 ns |       0 B |
     FromEnumNullable |  5.772 ns | 0.0986 ns | 0.0874 ns |       0 B |
