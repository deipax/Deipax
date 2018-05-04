
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |     Median |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-----------:|-------:|----------:|
             FromBool |   7.138 ns | 0.0030 ns | 0.0025 ns |   7.137 ns |      - |       0 B |
     FromBoolNullable |   5.096 ns | 0.0093 ns | 0.0087 ns |   5.093 ns |      - |       0 B |
             FromChar |   9.269 ns | 0.0187 ns | 0.0175 ns |   9.263 ns | 0.0076 |      32 B |
     FromCharNullable |   5.108 ns | 0.0101 ns | 0.0084 ns |   5.109 ns |      - |       0 B |
            FromSByte |  49.181 ns | 0.0262 ns | 0.0204 ns |  49.178 ns | 0.0076 |      32 B |
    FromSByteNullable |   5.117 ns | 0.0113 ns | 0.0100 ns |   5.119 ns |      - |       0 B |
             FromByte |  47.385 ns | 0.0095 ns | 0.0074 ns |  47.389 ns | 0.0076 |      32 B |
     FromByteNullable |   5.133 ns | 0.0093 ns | 0.0087 ns |   5.131 ns |      - |       0 B |
            FromShort |  49.213 ns | 0.0742 ns | 0.0658 ns |  49.181 ns | 0.0076 |      32 B |
    FromShortNullable |   5.857 ns | 0.0054 ns | 0.0048 ns |   5.855 ns |      - |       0 B |
           FromUShort |  41.742 ns | 0.0678 ns | 0.0635 ns |  41.712 ns | 0.0076 |      32 B |
   FromUShortNullable |   5.093 ns | 0.0019 ns | 0.0017 ns |   5.093 ns |      - |       0 B |
              FromInt |  46.817 ns | 0.0140 ns | 0.0131 ns |  46.820 ns | 0.0076 |      32 B |
      FromIntNullable |   5.095 ns | 0.0024 ns | 0.0022 ns |   5.095 ns |      - |       0 B |
             FromUInt |  42.138 ns | 0.0099 ns | 0.0088 ns |  42.136 ns | 0.0076 |      32 B |
     FromUIntNullable |   5.113 ns | 0.0112 ns | 0.0099 ns |   5.112 ns |      - |       0 B |
             FromLong |  48.466 ns | 0.0407 ns | 0.0361 ns |  48.455 ns | 0.0076 |      32 B |
     FromLongNullable |   6.140 ns | 0.0105 ns | 0.0087 ns |   6.142 ns |      - |       0 B |
            FromULong |  45.851 ns | 0.0415 ns | 0.0346 ns |  45.847 ns | 0.0076 |      32 B |
    FromULongNullable |   6.238 ns | 0.0359 ns | 0.0300 ns |   6.228 ns |      - |       0 B |
            FromFloat | 142.741 ns | 1.2121 ns | 1.1338 ns | 142.024 ns | 0.0074 |      32 B |
    FromFloatNullable |   5.101 ns | 0.0085 ns | 0.0071 ns |   5.103 ns |      - |       0 B |
           FromDouble | 157.775 ns | 0.0931 ns | 0.0825 ns | 157.747 ns | 0.0074 |      32 B |
   FromDoubleNullable |   5.625 ns | 0.0020 ns | 0.0015 ns |   5.625 ns |      - |       0 B |
          FromDecimal |  67.733 ns | 0.0340 ns | 0.0301 ns |  67.727 ns | 0.0075 |      32 B |
  FromDecimalNullable |   6.162 ns | 0.2370 ns | 0.4394 ns |   5.937 ns |      - |       0 B |
         FromDateTime | 418.123 ns | 0.2661 ns | 0.2222 ns | 418.177 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   5.861 ns | 0.0009 ns | 0.0007 ns |   5.861 ns |      - |       0 B |
           FromObject |   6.172 ns | 0.0015 ns | 0.0014 ns |   6.172 ns |      - |       0 B |
           FromString |   2.793 ns | 0.0003 ns | 0.0002 ns |   2.793 ns |      - |       0 B |
             FromEnum | 141.432 ns | 0.2155 ns | 0.2016 ns | 141.379 ns | 0.0191 |      80 B |
     FromEnumNullable |   5.614 ns | 0.0086 ns | 0.0081 ns |   5.610 ns |      - |       0 B |
