
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |---------:|----------:|----------:|-------:|----------:|
             FromBool | 4.617 ns | 0.0056 ns | 0.0050 ns | 0.0057 |      24 B |
     FromBoolNullable | 1.788 ns | 0.0038 ns | 0.0035 ns |      - |       0 B |
             FromChar | 4.851 ns | 0.0030 ns | 0.0027 ns | 0.0057 |      24 B |
     FromCharNullable | 1.798 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
            FromSByte | 4.630 ns | 0.0009 ns | 0.0007 ns | 0.0057 |      24 B |
    FromSByteNullable | 1.873 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
             FromByte | 4.832 ns | 0.0018 ns | 0.0015 ns | 0.0057 |      24 B |
     FromByteNullable | 1.857 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
            FromShort | 4.785 ns | 0.0046 ns | 0.0038 ns | 0.0057 |      24 B |
    FromShortNullable | 1.870 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
           FromUShort | 4.840 ns | 0.0015 ns | 0.0012 ns | 0.0057 |      24 B |
   FromUShortNullable | 1.800 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
              FromInt | 4.720 ns | 0.0070 ns | 0.0050 ns | 0.0057 |      24 B |
      FromIntNullable | 2.333 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
             FromUInt | 5.311 ns | 0.0025 ns | 0.0022 ns | 0.0057 |      24 B |
     FromUIntNullable | 1.837 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
             FromLong | 4.681 ns | 0.0023 ns | 0.0019 ns | 0.0057 |      24 B |
     FromLongNullable | 2.369 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
            FromULong | 4.957 ns | 0.0013 ns | 0.0011 ns | 0.0057 |      24 B |
    FromULongNullable | 2.289 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
            FromFloat | 4.977 ns | 0.0070 ns | 0.0062 ns | 0.0057 |      24 B |
    FromFloatNullable | 1.818 ns | 0.0014 ns | 0.0013 ns |      - |       0 B |
           FromDouble | 5.056 ns | 0.0018 ns | 0.0014 ns | 0.0057 |      24 B |
   FromDoubleNullable | 2.401 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
          FromDecimal | 5.734 ns | 0.0020 ns | 0.0018 ns | 0.0076 |      32 B |
  FromDecimalNullable | 2.372 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
         FromDateTime | 4.963 ns | 0.0052 ns | 0.0049 ns | 0.0057 |      24 B |
 FromDateTimeNullable | 2.322 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
           FromObject | 2.538 ns | 0.0003 ns | 0.0003 ns |      - |       0 B |
           FromString | 3.312 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
             FromEnum | 5.153 ns | 0.0026 ns | 0.0023 ns | 0.0057 |      24 B |
     FromEnumNullable | 1.885 ns | 0.0024 ns | 0.0023 ns |      - |       0 B |
