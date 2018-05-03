
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.752 ns | 0.0118 ns | 0.0105 ns |       0 B |
     FromBoolNullable |  6.538 ns | 0.0283 ns | 0.0236 ns |       0 B |
             FromChar |  6.769 ns | 0.0200 ns | 0.0187 ns |       0 B |
     FromCharNullable |  6.774 ns | 0.0084 ns | 0.0070 ns |       0 B |
            FromSByte |  6.840 ns | 0.1626 ns | 0.1441 ns |       0 B |
    FromSByteNullable |  6.858 ns | 0.0738 ns | 0.0690 ns |       0 B |
             FromByte |  1.045 ns | 0.0314 ns | 0.0293 ns |       0 B |
     FromByteNullable |  1.046 ns | 0.0038 ns | 0.0035 ns |       0 B |
            FromShort |  7.376 ns | 0.0088 ns | 0.0078 ns |       0 B |
    FromShortNullable |  6.511 ns | 0.0013 ns | 0.0011 ns |       0 B |
           FromUShort |  6.761 ns | 0.0108 ns | 0.0101 ns |       0 B |
   FromUShortNullable |  6.770 ns | 0.0012 ns | 0.0011 ns |       0 B |
              FromInt |  7.528 ns | 0.0098 ns | 0.0092 ns |       0 B |
      FromIntNullable |  6.516 ns | 0.0037 ns | 0.0031 ns |       0 B |
             FromUInt |  6.754 ns | 0.0019 ns | 0.0015 ns |       0 B |
     FromUIntNullable |  6.823 ns | 0.0357 ns | 0.0334 ns |       0 B |
             FromLong |  7.521 ns | 0.0030 ns | 0.0028 ns |       0 B |
     FromLongNullable |  7.025 ns | 0.0086 ns | 0.0081 ns |       0 B |
            FromULong |  7.238 ns | 0.0015 ns | 0.0012 ns |       0 B |
    FromULongNullable |  7.057 ns | 0.0396 ns | 0.0351 ns |       0 B |
            FromFloat |  9.048 ns | 0.0093 ns | 0.0083 ns |       0 B |
    FromFloatNullable |  6.557 ns | 0.0520 ns | 0.0461 ns |       0 B |
           FromDouble |  9.079 ns | 0.0096 ns | 0.0090 ns |       0 B |
   FromDoubleNullable |  7.012 ns | 0.0077 ns | 0.0068 ns |       0 B |
          FromDecimal | 20.568 ns | 0.0213 ns | 0.0178 ns |       0 B |
  FromDecimalNullable |  7.279 ns | 0.0011 ns | 0.0009 ns |       0 B |
         FromDateTime |  6.807 ns | 0.0075 ns | 0.0067 ns |       0 B |
 FromDateTimeNullable |  7.263 ns | 0.0018 ns | 0.0015 ns |       0 B |
           FromObject |  7.537 ns | 0.0140 ns | 0.0131 ns |       0 B |
           FromString |  7.012 ns | 0.0049 ns | 0.0044 ns |       0 B |
             FromEnum |  7.441 ns | 0.0157 ns | 0.0147 ns |       0 B |
     FromEnumNullable |  6.516 ns | 0.0031 ns | 0.0026 ns |       0 B |
