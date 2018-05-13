
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5519 ns | 0.0058 ns | 0.0049 ns |       0 B |
     FromBoolNullable |  2.3200 ns | 0.0105 ns | 0.0098 ns |       0 B |
             FromChar |  0.7863 ns | 0.0043 ns | 0.0041 ns |       0 B |
     FromCharNullable |  1.2697 ns | 0.0045 ns | 0.0039 ns |       0 B |
            FromSByte |  1.0419 ns | 0.0037 ns | 0.0035 ns |       0 B |
    FromSByteNullable |  1.9375 ns | 0.0047 ns | 0.0044 ns |       0 B |
             FromByte |  1.0431 ns | 0.0045 ns | 0.0042 ns |       0 B |
     FromByteNullable |  1.5950 ns | 0.0096 ns | 0.0080 ns |       0 B |
            FromShort |  1.0405 ns | 0.0031 ns | 0.0029 ns |       0 B |
    FromShortNullable |  1.8486 ns | 0.0254 ns | 0.0238 ns |       0 B |
           FromUShort |  1.0417 ns | 0.0037 ns | 0.0035 ns |       0 B |
   FromUShortNullable |  1.6381 ns | 0.0169 ns | 0.0150 ns |       0 B |
              FromInt |  1.0396 ns | 0.0040 ns | 0.0037 ns |       0 B |
      FromIntNullable |  1.5842 ns | 0.0126 ns | 0.0118 ns |       0 B |
             FromUInt |  1.0411 ns | 0.0042 ns | 0.0040 ns |       0 B |
     FromUIntNullable |  3.2637 ns | 0.0500 ns | 0.0443 ns |       0 B |
             FromLong |  1.0430 ns | 0.0024 ns | 0.0022 ns |       0 B |
     FromLongNullable |  2.3182 ns | 0.0042 ns | 0.0039 ns |       0 B |
            FromULong |  1.2977 ns | 0.0054 ns | 0.0050 ns |       0 B |
    FromULongNullable |  3.4025 ns | 0.0064 ns | 0.0060 ns |       0 B |
            FromFloat |  1.7304 ns | 0.0025 ns | 0.0023 ns |       0 B |
    FromFloatNullable |  1.6516 ns | 0.0066 ns | 0.0062 ns |       0 B |
           FromDouble |  1.0288 ns | 0.0065 ns | 0.0054 ns |       0 B |
   FromDoubleNullable |  2.3185 ns | 0.0053 ns | 0.0049 ns |       0 B |
          FromDecimal | 11.3192 ns | 0.0101 ns | 0.0084 ns |       0 B |
  FromDecimalNullable | 26.4559 ns | 0.0187 ns | 0.0156 ns |       0 B |
         FromDateTime |  1.0435 ns | 0.0037 ns | 0.0034 ns |       0 B |
 FromDateTimeNullable |  1.8116 ns | 0.0046 ns | 0.0043 ns |       0 B |
           FromObject |  2.9973 ns | 0.0064 ns | 0.0054 ns |       0 B |
           FromString | 94.3636 ns | 0.1259 ns | 0.1178 ns |       0 B |
             FromEnum |  1.0403 ns | 0.0007 ns | 0.0005 ns |       0 B |
     FromEnumNullable |  2.1746 ns | 0.0453 ns | 0.0424 ns |       0 B |
