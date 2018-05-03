
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  3.6836 ns | 0.0016 ns | 0.0013 ns |       0 B |
     FromBoolNullable |  4.5696 ns | 0.0055 ns | 0.0051 ns |       0 B |
             FromChar |  3.6817 ns | 0.0056 ns | 0.0052 ns |       0 B |
     FromCharNullable |  4.2759 ns | 0.0059 ns | 0.0053 ns |       0 B |
            FromSByte |  3.6859 ns | 0.0053 ns | 0.0047 ns |       0 B |
    FromSByteNullable |  4.6072 ns | 0.0050 ns | 0.0047 ns |       0 B |
             FromByte |  3.7677 ns | 0.0154 ns | 0.0144 ns |       0 B |
     FromByteNullable |  4.6149 ns | 0.0060 ns | 0.0056 ns |       0 B |
            FromShort |  4.6379 ns | 0.0352 ns | 0.0330 ns |       0 B |
    FromShortNullable |  4.5708 ns | 0.0032 ns | 0.0030 ns |       0 B |
           FromUShort |  3.7356 ns | 0.0058 ns | 0.0054 ns |       0 B |
   FromUShortNullable |  4.2607 ns | 0.0116 ns | 0.0108 ns |       0 B |
              FromInt |  0.7832 ns | 0.0005 ns | 0.0004 ns |       0 B |
      FromIntNullable |  1.6451 ns | 0.0099 ns | 0.0093 ns |       0 B |
             FromUInt |  5.3073 ns | 0.0415 ns | 0.0368 ns |       0 B |
     FromUIntNullable |  4.7448 ns | 0.0097 ns | 0.0091 ns |       0 B |
             FromLong |  4.5750 ns | 0.0135 ns | 0.0113 ns |       0 B |
     FromLongNullable |  6.9092 ns | 0.0017 ns | 0.0013 ns |       0 B |
            FromULong |  4.5122 ns | 0.0312 ns | 0.0292 ns |       0 B |
    FromULongNullable |  6.4263 ns | 0.0031 ns | 0.0027 ns |       0 B |
            FromFloat |  6.2787 ns | 0.0078 ns | 0.0073 ns |       0 B |
    FromFloatNullable |  7.6243 ns | 0.0012 ns | 0.0010 ns |       0 B |
           FromDouble |  6.0184 ns | 0.0083 ns | 0.0078 ns |       0 B |
   FromDoubleNullable |  7.6975 ns | 0.0099 ns | 0.0093 ns |       0 B |
          FromDecimal | 17.5605 ns | 0.0158 ns | 0.0148 ns |       0 B |
  FromDecimalNullable | 20.8023 ns | 0.0013 ns | 0.0010 ns |       0 B |
         FromDateTime |  4.4132 ns | 0.0027 ns | 0.0025 ns |       0 B |
 FromDateTimeNullable |  3.9596 ns | 0.0014 ns | 0.0011 ns |       0 B |
           FromObject |  2.7082 ns | 0.0031 ns | 0.0029 ns |       0 B |
           FromString | 75.9251 ns | 0.0187 ns | 0.0156 ns |       0 B |
             FromEnum |  3.8528 ns | 0.0099 ns | 0.0093 ns |       0 B |
     FromEnumNullable |  4.3894 ns | 0.0022 ns | 0.0018 ns |       0 B |
