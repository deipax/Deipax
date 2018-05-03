
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.752 ns | 0.0040 ns | 0.0033 ns |       0 B |
     FromBoolNullable |  6.841 ns | 0.0039 ns | 0.0023 ns |       0 B |
             FromChar |  6.754 ns | 0.0063 ns | 0.0053 ns |       0 B |
     FromCharNullable |  6.809 ns | 0.0400 ns | 0.0374 ns |       0 B |
            FromSByte |  6.756 ns | 0.0090 ns | 0.0080 ns |       0 B |
    FromSByteNullable |  6.541 ns | 0.0366 ns | 0.0342 ns |       0 B |
             FromByte |  6.713 ns | 0.0113 ns | 0.0088 ns |       0 B |
     FromByteNullable |  6.560 ns | 0.0380 ns | 0.0337 ns |       0 B |
            FromShort |  1.026 ns | 0.0029 ns | 0.0026 ns |       0 B |
    FromShortNullable |  1.080 ns | 0.0117 ns | 0.0103 ns |       0 B |
           FromUShort |  6.774 ns | 0.0040 ns | 0.0037 ns |       0 B |
   FromUShortNullable |  6.780 ns | 0.0344 ns | 0.0322 ns |       0 B |
              FromInt |  7.569 ns | 0.0086 ns | 0.0077 ns |       0 B |
      FromIntNullable |  7.185 ns | 0.0131 ns | 0.0116 ns |       0 B |
             FromUInt |  7.505 ns | 0.0123 ns | 0.0115 ns |       0 B |
     FromUIntNullable |  7.190 ns | 0.0027 ns | 0.0024 ns |       0 B |
             FromLong |  7.508 ns | 0.0090 ns | 0.0084 ns |       0 B |
     FromLongNullable |  8.041 ns | 0.0446 ns | 0.0372 ns |       0 B |
            FromULong |  7.261 ns | 0.0108 ns | 0.0095 ns |       0 B |
    FromULongNullable |  7.782 ns | 0.0118 ns | 0.0098 ns |       0 B |
            FromFloat |  9.049 ns | 0.0146 ns | 0.0137 ns |       0 B |
    FromFloatNullable |  9.731 ns | 0.0025 ns | 0.0021 ns |       0 B |
           FromDouble |  8.938 ns | 0.0117 ns | 0.0103 ns |       0 B |
   FromDoubleNullable |  9.808 ns | 0.0084 ns | 0.0075 ns |       0 B |
          FromDecimal | 20.809 ns | 0.0159 ns | 0.0141 ns |       0 B |
  FromDecimalNullable | 25.934 ns | 0.0190 ns | 0.0178 ns |       0 B |
         FromDateTime |  7.010 ns | 0.0083 ns | 0.0078 ns |       0 B |
 FromDateTimeNullable |  7.302 ns | 0.0356 ns | 0.0315 ns |       0 B |
           FromObject | 13.431 ns | 0.0069 ns | 0.0054 ns |       0 B |
           FromString | 79.118 ns | 0.1576 ns | 0.1475 ns |       0 B |
             FromEnum |  7.556 ns | 0.0059 ns | 0.0055 ns |       0 B |
     FromEnumNullable |  7.154 ns | 0.0052 ns | 0.0046 ns |       0 B |
