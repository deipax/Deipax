
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5206 ns | 0.0033 ns | 0.0029 ns |       0 B |
     FromBoolNullable |  2.0296 ns | 0.0027 ns | 0.0026 ns |       0 B |
             FromChar |  1.9324 ns | 0.0054 ns | 0.0048 ns |       0 B |
     FromCharNullable |  2.9319 ns | 0.0074 ns | 0.0070 ns |       0 B |
            FromSByte |  1.2523 ns | 0.0038 ns | 0.0036 ns |       0 B |
    FromSByteNullable |  1.5419 ns | 0.0035 ns | 0.0033 ns |       0 B |
             FromByte |  1.0103 ns | 0.0019 ns | 0.0016 ns |       0 B |
     FromByteNullable |  1.6371 ns | 0.0042 ns | 0.0040 ns |       0 B |
            FromShort |  1.1206 ns | 0.0010 ns | 0.0009 ns |       0 B |
    FromShortNullable |  0.9794 ns | 0.0033 ns | 0.0031 ns |       0 B |
           FromUShort |  1.9325 ns | 0.0027 ns | 0.0024 ns |       0 B |
   FromUShortNullable |  2.9224 ns | 0.0067 ns | 0.0052 ns |       0 B |
              FromInt |  2.7660 ns | 0.0130 ns | 0.0115 ns |       0 B |
      FromIntNullable |  3.8664 ns | 0.0099 ns | 0.0093 ns |       0 B |
             FromUInt |  2.7772 ns | 0.0067 ns | 0.0062 ns |       0 B |
     FromUIntNullable |  3.8103 ns | 0.0086 ns | 0.0077 ns |       0 B |
             FromLong |  2.9838 ns | 0.0216 ns | 0.0192 ns |       0 B |
     FromLongNullable |  4.3326 ns | 0.0088 ns | 0.0083 ns |       0 B |
            FromULong |  2.6232 ns | 0.0072 ns | 0.0064 ns |       0 B |
    FromULongNullable |  4.3379 ns | 0.0054 ns | 0.0050 ns |       0 B |
            FromFloat |  5.6459 ns | 0.0133 ns | 0.0125 ns |       0 B |
    FromFloatNullable |  6.8811 ns | 0.0018 ns | 0.0016 ns |       0 B |
           FromDouble |  5.7086 ns | 0.0103 ns | 0.0091 ns |       0 B |
   FromDoubleNullable |  6.8515 ns | 0.0193 ns | 0.0180 ns |       0 B |
          FromDecimal | 15.7301 ns | 0.0262 ns | 0.0219 ns |       0 B |
  FromDecimalNullable | 26.2212 ns | 0.0243 ns | 0.0228 ns |       0 B |
         FromDateTime |  1.0096 ns | 0.0043 ns | 0.0040 ns |       0 B |
 FromDateTimeNullable |  1.8570 ns | 0.0040 ns | 0.0038 ns |       0 B |
           FromObject | 13.5003 ns | 0.0340 ns | 0.0302 ns |       0 B |
           FromString | 75.8226 ns | 0.1117 ns | 0.1044 ns |       0 B |
             FromEnum |  2.7271 ns | 0.0034 ns | 0.0028 ns |       0 B |
     FromEnumNullable |  3.9620 ns | 0.0058 ns | 0.0051 ns |       0 B |
