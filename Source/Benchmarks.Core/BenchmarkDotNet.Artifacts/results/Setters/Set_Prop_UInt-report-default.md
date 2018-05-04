
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  3.6829 ns | 0.0022 ns | 0.0020 ns |       0 B |
     FromBoolNullable |  4.5722 ns | 0.0101 ns | 0.0079 ns |       0 B |
             FromChar |  3.6728 ns | 0.0032 ns | 0.0030 ns |       0 B |
     FromCharNullable |  4.3074 ns | 0.0080 ns | 0.0075 ns |       0 B |
            FromSByte |  4.2179 ns | 0.0009 ns | 0.0007 ns |       0 B |
    FromSByteNullable |  4.6920 ns | 0.0054 ns | 0.0045 ns |       0 B |
             FromByte |  3.8333 ns | 0.0301 ns | 0.0267 ns |       0 B |
     FromByteNullable |  5.4422 ns | 0.0114 ns | 0.0107 ns |       0 B |
            FromShort |  4.5329 ns | 0.0356 ns | 0.0315 ns |       0 B |
    FromShortNullable |  4.9984 ns | 0.0144 ns | 0.0135 ns |       0 B |
           FromUShort |  3.6781 ns | 0.0075 ns | 0.0070 ns |       0 B |
   FromUShortNullable |  4.2810 ns | 0.0049 ns | 0.0046 ns |       0 B |
              FromInt |  4.4491 ns | 0.0019 ns | 0.0015 ns |       0 B |
      FromIntNullable |  4.8141 ns | 0.0084 ns | 0.0078 ns |       0 B |
             FromUInt |  0.9757 ns | 0.0003 ns | 0.0003 ns |       0 B |
     FromUIntNullable |  1.6185 ns | 0.0061 ns | 0.0054 ns |       0 B |
             FromLong |  5.0131 ns | 0.0046 ns | 0.0043 ns |       0 B |
     FromLongNullable |  6.6739 ns | 0.0056 ns | 0.0053 ns |       0 B |
            FromULong |  4.4164 ns | 0.0054 ns | 0.0039 ns |       0 B |
    FromULongNullable |  5.4105 ns | 0.0117 ns | 0.0110 ns |       0 B |
            FromFloat |  6.0430 ns | 0.0008 ns | 0.0006 ns |       0 B |
    FromFloatNullable |  7.7823 ns | 0.0158 ns | 0.0148 ns |       0 B |
           FromDouble |  6.2104 ns | 0.0065 ns | 0.0055 ns |       0 B |
   FromDoubleNullable |  7.2596 ns | 0.0024 ns | 0.0020 ns |       0 B |
          FromDecimal | 15.3379 ns | 0.0041 ns | 0.0034 ns |       0 B |
  FromDecimalNullable | 20.5704 ns | 0.0046 ns | 0.0038 ns |       0 B |
         FromDateTime |  3.6536 ns | 0.0026 ns | 0.0022 ns |       0 B |
 FromDateTimeNullable |  4.0815 ns | 0.0012 ns | 0.0009 ns |       0 B |
           FromObject |  2.7612 ns | 0.0058 ns | 0.0052 ns |       0 B |
           FromString | 76.1606 ns | 0.0044 ns | 0.0037 ns |       0 B |
             FromEnum |  4.6088 ns | 0.0066 ns | 0.0058 ns |       0 B |
     FromEnumNullable |  4.9131 ns | 0.0062 ns | 0.0058 ns |       0 B |
