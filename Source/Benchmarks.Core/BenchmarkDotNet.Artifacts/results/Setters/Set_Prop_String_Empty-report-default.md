
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |   7.138 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
     FromBoolNullable |   5.811 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
             FromChar |   8.757 ns | 0.0117 ns | 0.0110 ns | 0.0076 |      32 B |
     FromCharNullable |   5.096 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
            FromSByte |  49.179 ns | 0.0559 ns | 0.0523 ns | 0.0076 |      32 B |
    FromSByteNullable |   5.104 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
             FromByte |  49.123 ns | 0.0766 ns | 0.0717 ns | 0.0076 |      32 B |
     FromByteNullable |   5.132 ns | 0.0067 ns | 0.0062 ns |      - |       0 B |
            FromShort |  51.017 ns | 0.0773 ns | 0.0723 ns | 0.0076 |      32 B |
    FromShortNullable |   5.101 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
           FromUShort |  41.610 ns | 0.0120 ns | 0.0106 ns | 0.0076 |      32 B |
   FromUShortNullable |   5.095 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
              FromInt |  46.822 ns | 0.0589 ns | 0.0551 ns | 0.0076 |      32 B |
      FromIntNullable |   5.099 ns | 0.0040 ns | 0.0038 ns |      - |       0 B |
             FromUInt |  41.944 ns | 0.0186 ns | 0.0145 ns | 0.0076 |      32 B |
     FromUIntNullable |   5.102 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
             FromLong |  48.379 ns | 0.0092 ns | 0.0086 ns | 0.0076 |      32 B |
     FromLongNullable |   6.115 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
            FromULong |  47.035 ns | 0.0634 ns | 0.0562 ns | 0.0076 |      32 B |
    FromULongNullable |   5.861 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
            FromFloat | 140.982 ns | 0.3058 ns | 0.2710 ns | 0.0074 |      32 B |
    FromFloatNullable |   5.096 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
           FromDouble | 158.118 ns | 0.2275 ns | 0.2128 ns | 0.0074 |      32 B |
   FromDoubleNullable |   5.791 ns | 0.1282 ns | 0.1199 ns |      - |       0 B |
          FromDecimal |  67.779 ns | 0.0287 ns | 0.0224 ns | 0.0075 |      32 B |
  FromDecimalNullable |   5.888 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
         FromDateTime | 418.467 ns | 0.1807 ns | 0.1602 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   5.865 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
           FromObject |   4.328 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
           FromString |   2.793 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
             FromEnum | 142.419 ns | 0.1180 ns | 0.0986 ns | 0.0191 |      80 B |
     FromEnumNullable |   5.686 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
