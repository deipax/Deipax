
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |   7.138 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
     FromBoolNullable |   5.103 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
             FromChar |   9.030 ns | 0.0159 ns | 0.0149 ns | 0.0076 |      32 B |
     FromCharNullable |   9.439 ns | 0.0059 ns | 0.0052 ns | 0.0076 |      32 B |
            FromSByte |  49.009 ns | 0.0561 ns | 0.0525 ns | 0.0076 |      32 B |
    FromSByteNullable |  47.567 ns | 0.0600 ns | 0.0562 ns | 0.0076 |      32 B |
             FromByte |  47.974 ns | 0.0427 ns | 0.0399 ns | 0.0076 |      32 B |
     FromByteNullable |  47.905 ns | 0.0773 ns | 0.0685 ns | 0.0076 |      32 B |
            FromShort |  49.256 ns | 0.0409 ns | 0.0383 ns | 0.0076 |      32 B |
    FromShortNullable |  47.302 ns | 0.0335 ns | 0.0280 ns | 0.0076 |      32 B |
           FromUShort |  42.478 ns | 0.0437 ns | 0.0388 ns | 0.0076 |      32 B |
   FromUShortNullable |  41.940 ns | 0.0814 ns | 0.0761 ns | 0.0076 |      32 B |
              FromInt |  46.936 ns | 0.0375 ns | 0.0332 ns | 0.0076 |      32 B |
      FromIntNullable |  47.161 ns | 0.0778 ns | 0.0690 ns | 0.0076 |      32 B |
             FromUInt |  42.763 ns | 0.0431 ns | 0.0382 ns | 0.0076 |      32 B |
     FromUIntNullable |  43.037 ns | 0.0635 ns | 0.0563 ns | 0.0076 |      32 B |
             FromLong |  48.729 ns | 0.0186 ns | 0.0165 ns | 0.0076 |      32 B |
     FromLongNullable |  51.142 ns | 0.0213 ns | 0.0154 ns | 0.0076 |      32 B |
            FromULong |  47.066 ns | 0.0200 ns | 0.0156 ns | 0.0076 |      32 B |
    FromULongNullable |  48.543 ns | 0.0871 ns | 0.0772 ns | 0.0076 |      32 B |
            FromFloat | 226.229 ns | 0.1976 ns | 0.1848 ns | 0.0074 |      32 B |
    FromFloatNullable | 223.142 ns | 0.3573 ns | 0.3342 ns | 0.0074 |      32 B |
           FromDouble | 260.552 ns | 0.7227 ns | 0.6407 ns | 0.0072 |      32 B |
   FromDoubleNullable | 258.564 ns | 0.1706 ns | 0.1425 ns | 0.0072 |      32 B |
          FromDecimal |  72.457 ns | 0.0655 ns | 0.0613 ns | 0.0075 |      32 B |
  FromDecimalNullable |  73.948 ns | 0.1282 ns | 0.1136 ns | 0.0075 |      32 B |
         FromDateTime | 469.497 ns | 0.2747 ns | 0.2435 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   5.860 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
           FromObject |   4.340 ns | 0.0057 ns | 0.0050 ns |      - |       0 B |
           FromString |   2.794 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
             FromEnum |  72.009 ns | 0.0168 ns | 0.0140 ns | 0.0057 |      24 B |
     FromEnumNullable |  73.417 ns | 0.1519 ns | 0.1421 ns | 0.0057 |      24 B |
