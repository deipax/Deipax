
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  4.9287 ns | 0.0021 ns | 0.0018 ns |       0 B |
     FromBoolNullable |  5.9076 ns | 0.0089 ns | 0.0079 ns |       0 B |
             FromChar |  4.7994 ns | 0.0041 ns | 0.0039 ns |       0 B |
     FromCharNullable |  5.2844 ns | 0.0154 ns | 0.0128 ns |       0 B |
            FromSByte |  4.8041 ns | 0.0059 ns | 0.0055 ns |       0 B |
    FromSByteNullable |  5.6367 ns | 0.0083 ns | 0.0069 ns |       0 B |
             FromByte |  4.7426 ns | 0.0019 ns | 0.0016 ns |       0 B |
     FromByteNullable |  5.8032 ns | 0.0131 ns | 0.0116 ns |       0 B |
            FromShort |  4.8030 ns | 0.0032 ns | 0.0025 ns |       0 B |
    FromShortNullable |  5.3753 ns | 0.0081 ns | 0.0072 ns |       0 B |
           FromUShort |  4.8000 ns | 0.0010 ns | 0.0008 ns |       0 B |
   FromUShortNullable |  5.2905 ns | 0.0363 ns | 0.0339 ns |       0 B |
              FromInt |  4.7103 ns | 0.0146 ns | 0.0136 ns |       0 B |
      FromIntNullable |  5.4320 ns | 0.0089 ns | 0.0070 ns |       0 B |
             FromUInt |  6.1467 ns | 0.0396 ns | 0.0351 ns |       0 B |
     FromUIntNullable |  5.4449 ns | 0.0161 ns | 0.0143 ns |       0 B |
             FromLong |  0.8063 ns | 0.0020 ns | 0.0018 ns |       0 B |
     FromLongNullable |  1.7937 ns | 0.0025 ns | 0.0024 ns |       0 B |
            FromULong |  5.4207 ns | 0.0051 ns | 0.0047 ns |       0 B |
    FromULongNullable |  5.9077 ns | 0.0311 ns | 0.0291 ns |       0 B |
            FromFloat |  8.5917 ns | 0.0029 ns | 0.0024 ns |       0 B |
    FromFloatNullable | 10.4582 ns | 0.0245 ns | 0.0217 ns |       0 B |
           FromDouble |  9.8856 ns | 0.0078 ns | 0.0073 ns |       0 B |
   FromDoubleNullable | 10.3114 ns | 0.0329 ns | 0.0292 ns |       0 B |
          FromDecimal | 16.8381 ns | 0.0146 ns | 0.0130 ns |       0 B |
  FromDecimalNullable | 23.4135 ns | 0.0083 ns | 0.0074 ns |       0 B |
         FromDateTime |  5.2182 ns | 0.0024 ns | 0.0022 ns |       0 B |
 FromDateTimeNullable |  5.0785 ns | 0.0082 ns | 0.0077 ns |       0 B |
           FromObject | 13.7820 ns | 0.0134 ns | 0.0112 ns |       0 B |
           FromString | 77.5070 ns | 0.0155 ns | 0.0137 ns |       0 B |
             FromEnum |  5.3121 ns | 0.0021 ns | 0.0018 ns |       0 B |
     FromEnumNullable |  5.7224 ns | 0.0062 ns | 0.0055 ns |       0 B |
