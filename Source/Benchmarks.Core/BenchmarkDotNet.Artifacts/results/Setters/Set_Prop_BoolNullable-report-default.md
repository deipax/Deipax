
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  0.9934 ns | 0.0025 ns | 0.0023 ns |       0 B |
     FromBoolNullable |  1.0565 ns | 0.0040 ns | 0.0037 ns |       0 B |
             FromChar |  6.7523 ns | 0.0010 ns | 0.0008 ns |       0 B |
     FromCharNullable |  6.5044 ns | 0.0168 ns | 0.0131 ns |       0 B |
            FromSByte |  6.7502 ns | 0.0009 ns | 0.0007 ns |       0 B |
    FromSByteNullable |  6.7825 ns | 0.0133 ns | 0.0125 ns |       0 B |
             FromByte |  6.7528 ns | 0.0017 ns | 0.0014 ns |       0 B |
     FromByteNullable |  6.7909 ns | 0.0398 ns | 0.0372 ns |       0 B |
            FromShort |  6.7549 ns | 0.0042 ns | 0.0038 ns |       0 B |
    FromShortNullable |  6.7708 ns | 0.0043 ns | 0.0038 ns |       0 B |
           FromUShort |  6.7560 ns | 0.0040 ns | 0.0034 ns |       0 B |
   FromUShortNullable |  6.7713 ns | 0.0044 ns | 0.0036 ns |       0 B |
              FromInt |  6.7532 ns | 0.0006 ns | 0.0005 ns |       0 B |
      FromIntNullable |  6.7902 ns | 0.0110 ns | 0.0103 ns |       0 B |
             FromUInt |  7.1554 ns | 0.1753 ns | 0.2569 ns |       0 B |
     FromUIntNullable |  6.9616 ns | 0.1332 ns | 0.1246 ns |       0 B |
             FromLong |  6.8176 ns | 0.0051 ns | 0.0042 ns |       0 B |
     FromLongNullable |  7.5705 ns | 0.0451 ns | 0.0422 ns |       0 B |
            FromULong |  6.7685 ns | 0.0022 ns | 0.0019 ns |       0 B |
    FromULongNullable |  7.5170 ns | 0.0024 ns | 0.0021 ns |       0 B |
            FromFloat |  6.5241 ns | 0.0077 ns | 0.0064 ns |       0 B |
    FromFloatNullable |  7.0267 ns | 0.0016 ns | 0.0015 ns |       0 B |
           FromDouble |  6.5293 ns | 0.0005 ns | 0.0004 ns |       0 B |
   FromDoubleNullable |  7.7961 ns | 0.0418 ns | 0.0391 ns |       0 B |
          FromDecimal | 13.2684 ns | 0.0021 ns | 0.0017 ns |       0 B |
  FromDecimalNullable | 17.2539 ns | 0.0231 ns | 0.0216 ns |       0 B |
         FromDateTime |  6.8104 ns | 0.0030 ns | 0.0025 ns |       0 B |
 FromDateTimeNullable |  7.2908 ns | 0.0463 ns | 0.0411 ns |       0 B |
           FromObject | 13.4246 ns | 0.0402 ns | 0.0376 ns |       0 B |
           FromString | 15.2273 ns | 0.0096 ns | 0.0085 ns |       0 B |
             FromEnum |  6.6948 ns | 0.0235 ns | 0.0183 ns |       0 B |
     FromEnumNullable |  6.7742 ns | 0.0102 ns | 0.0085 ns |       0 B |
