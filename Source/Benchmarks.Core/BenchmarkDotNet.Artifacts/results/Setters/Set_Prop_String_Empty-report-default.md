
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |   5.389 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
     FromBoolNullable |   3.346 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
             FromChar |   6.752 ns | 0.0388 ns | 0.0363 ns | 0.0076 |      32 B |
     FromCharNullable |   3.344 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
            FromSByte |  42.878 ns | 0.1748 ns | 0.1549 ns | 0.0076 |      32 B |
    FromSByteNullable |   3.599 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
             FromByte |  43.045 ns | 0.1897 ns | 0.1775 ns | 0.0076 |      32 B |
     FromByteNullable |   3.342 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
            FromShort |  43.433 ns | 0.1648 ns | 0.1461 ns | 0.0076 |      32 B |
    FromShortNullable |   3.621 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
           FromUShort |  38.746 ns | 0.0179 ns | 0.0139 ns | 0.0076 |      32 B |
   FromUShortNullable |   3.347 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
              FromInt |  42.835 ns | 0.0939 ns | 0.0879 ns | 0.0076 |      32 B |
      FromIntNullable |   3.361 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
             FromUInt |  38.570 ns | 0.0368 ns | 0.0307 ns | 0.0076 |      32 B |
     FromUIntNullable |   3.597 ns | 0.0065 ns | 0.0055 ns |      - |       0 B |
             FromLong |  45.184 ns | 0.1972 ns | 0.1646 ns | 0.0076 |      32 B |
     FromLongNullable |   4.107 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
            FromULong |  43.879 ns | 0.1736 ns | 0.1624 ns | 0.0076 |      32 B |
    FromULongNullable |   4.159 ns | 0.0779 ns | 0.0729 ns |      - |       0 B |
            FromFloat | 139.124 ns | 1.0582 ns | 0.9898 ns | 0.0074 |      32 B |
    FromFloatNullable |   3.596 ns | 0.0049 ns | 0.0044 ns |      - |       0 B |
           FromDouble | 155.965 ns | 0.5975 ns | 0.5296 ns | 0.0074 |      32 B |
   FromDoubleNullable |   4.111 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
          FromDecimal |  71.521 ns | 0.3259 ns | 0.2889 ns | 0.0075 |      32 B |
  FromDecimalNullable |   9.120 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
         FromDateTime | 414.840 ns | 0.3179 ns | 0.2654 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   5.437 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
           FromObject |   3.862 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
           FromString |   2.825 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
             FromEnum | 140.346 ns | 0.1400 ns | 0.1241 ns | 0.0191 |      80 B |
     FromEnumNullable |   3.594 ns | 0.0007 ns | 0.0007 ns |      - |       0 B |
