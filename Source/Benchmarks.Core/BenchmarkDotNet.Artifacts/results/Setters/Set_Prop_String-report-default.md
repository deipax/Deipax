
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |     Median |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-----------:|-------:|----------:|
             FromBool |   5.394 ns | 0.0048 ns | 0.0045 ns |   5.393 ns |      - |       0 B |
     FromBoolNullable |   3.349 ns | 0.0102 ns | 0.0096 ns |   3.348 ns |      - |       0 B |
             FromChar |   6.779 ns | 0.0839 ns | 0.0743 ns |   6.761 ns | 0.0076 |      32 B |
     FromCharNullable |   7.017 ns | 0.0436 ns | 0.0408 ns |   7.016 ns | 0.0076 |      32 B |
            FromSByte |  43.069 ns | 0.1735 ns | 0.1623 ns |  43.016 ns | 0.0076 |      32 B |
    FromSByteNullable |  43.857 ns | 0.1200 ns | 0.0937 ns |  43.818 ns | 0.0076 |      32 B |
             FromByte |  43.065 ns | 0.1146 ns | 0.1072 ns |  43.008 ns | 0.0076 |      32 B |
     FromByteNullable |  45.680 ns | 0.0613 ns | 0.0543 ns |  45.667 ns | 0.0076 |      32 B |
            FromShort |  44.542 ns | 0.0537 ns | 0.0502 ns |  44.529 ns | 0.0076 |      32 B |
    FromShortNullable |  43.818 ns | 0.0458 ns | 0.0406 ns |  43.803 ns | 0.0076 |      32 B |
           FromUShort |  39.158 ns | 0.1289 ns | 0.1206 ns |  39.099 ns | 0.0076 |      32 B |
   FromUShortNullable |  39.662 ns | 0.0932 ns | 0.0871 ns |  39.654 ns | 0.0076 |      32 B |
              FromInt |  43.296 ns | 0.2395 ns | 0.2123 ns |  43.373 ns | 0.0076 |      32 B |
      FromIntNullable |  43.676 ns | 0.1025 ns | 0.0959 ns |  43.601 ns | 0.0076 |      32 B |
             FromUInt |  39.631 ns | 0.1855 ns | 0.1644 ns |  39.711 ns | 0.0076 |      32 B |
     FromUIntNullable |  39.903 ns | 0.0753 ns | 0.0705 ns |  39.878 ns | 0.0076 |      32 B |
             FromLong |  45.226 ns | 0.2042 ns | 0.1910 ns |  45.135 ns | 0.0076 |      32 B |
     FromLongNullable |  45.943 ns | 0.0821 ns | 0.0728 ns |  45.917 ns | 0.0076 |      32 B |
            FromULong |  44.807 ns | 0.1370 ns | 0.0990 ns |  44.810 ns | 0.0076 |      32 B |
    FromULongNullable |  44.623 ns | 0.0778 ns | 0.0689 ns |  44.627 ns | 0.0076 |      32 B |
            FromFloat | 219.783 ns | 0.4263 ns | 0.3560 ns | 219.615 ns | 0.0074 |      32 B |
    FromFloatNullable | 220.548 ns | 0.3425 ns | 0.3203 ns | 220.372 ns | 0.0074 |      32 B |
           FromDouble | 256.055 ns | 1.2681 ns | 1.1241 ns | 255.940 ns | 0.0072 |      32 B |
   FromDoubleNullable | 259.033 ns | 0.7904 ns | 0.7393 ns | 259.014 ns | 0.0072 |      32 B |
          FromDecimal |  74.699 ns | 0.2402 ns | 0.2247 ns |  74.585 ns | 0.0075 |      32 B |
  FromDecimalNullable |  78.425 ns | 0.1202 ns | 0.1125 ns |  78.453 ns | 0.0075 |      32 B |
         FromDateTime | 414.750 ns | 1.7734 ns | 1.4809 ns | 414.294 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   4.107 ns | 0.0067 ns | 0.0056 ns |   4.106 ns |      - |       0 B |
           FromObject |   3.859 ns | 0.0136 ns | 0.0121 ns |   3.851 ns |      - |       0 B |
           FromString |   2.831 ns | 0.0095 ns | 0.0089 ns |   2.830 ns |      - |       0 B |
             FromEnum |  67.814 ns | 0.1641 ns | 0.1535 ns |  67.724 ns | 0.0057 |      24 B |
     FromEnumNullable |  70.203 ns | 0.1346 ns | 0.1259 ns |  70.223 ns | 0.0057 |      24 B |
