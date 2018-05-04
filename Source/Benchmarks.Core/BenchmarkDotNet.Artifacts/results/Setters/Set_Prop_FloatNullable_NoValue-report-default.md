
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.771 ns | 0.0058 ns | 0.0051 ns |       0 B |
     FromBoolNullable |  6.532 ns | 0.0055 ns | 0.0049 ns |       0 B |
             FromChar |  6.770 ns | 0.0055 ns | 0.0052 ns |       0 B |
     FromCharNullable |  6.537 ns | 0.0141 ns | 0.0125 ns |       0 B |
            FromSByte |  6.794 ns | 0.0050 ns | 0.0047 ns |       0 B |
    FromSByteNullable |  6.541 ns | 0.0145 ns | 0.0128 ns |       0 B |
             FromByte |  6.770 ns | 0.0015 ns | 0.0011 ns |       0 B |
     FromByteNullable |  6.530 ns | 0.0020 ns | 0.0015 ns |       0 B |
            FromShort |  6.780 ns | 0.0055 ns | 0.0051 ns |       0 B |
    FromShortNullable |  6.528 ns | 0.0114 ns | 0.0082 ns |       0 B |
           FromUShort |  6.772 ns | 0.0072 ns | 0.0068 ns |       0 B |
   FromUShortNullable |  6.543 ns | 0.0156 ns | 0.0138 ns |       0 B |
              FromInt |  6.773 ns | 0.0087 ns | 0.0077 ns |       0 B |
      FromIntNullable |  6.544 ns | 0.0141 ns | 0.0132 ns |       0 B |
             FromUInt |  6.775 ns | 0.0051 ns | 0.0047 ns |       0 B |
     FromUIntNullable |  6.539 ns | 0.0130 ns | 0.0115 ns |       0 B |
             FromLong |  6.780 ns | 0.0034 ns | 0.0031 ns |       0 B |
     FromLongNullable |  7.022 ns | 0.0009 ns | 0.0008 ns |       0 B |
            FromULong |  6.787 ns | 0.0139 ns | 0.0123 ns |       0 B |
    FromULongNullable |  7.021 ns | 0.0025 ns | 0.0022 ns |       0 B |
            FromFloat |  1.031 ns | 0.0030 ns | 0.0028 ns |       0 B |
    FromFloatNullable |  1.039 ns | 0.0014 ns | 0.0013 ns |       0 B |
           FromDouble |  6.516 ns | 0.0130 ns | 0.0121 ns |       0 B |
   FromDoubleNullable |  7.026 ns | 0.0023 ns | 0.0019 ns |       0 B |
          FromDecimal | 13.306 ns | 0.0119 ns | 0.0111 ns |       0 B |
  FromDecimalNullable |  7.263 ns | 0.0008 ns | 0.0007 ns |       0 B |
         FromDateTime |  6.951 ns | 0.0043 ns | 0.0040 ns |       0 B |
 FromDateTimeNullable |  7.284 ns | 0.0017 ns | 0.0014 ns |       0 B |
           FromObject |  7.599 ns | 0.0642 ns | 0.0600 ns |       0 B |
           FromString |  7.032 ns | 0.0108 ns | 0.0101 ns |       0 B |
             FromEnum |  6.773 ns | 0.0056 ns | 0.0052 ns |       0 B |
     FromEnumNullable |  6.529 ns | 0.0016 ns | 0.0013 ns |       0 B |
