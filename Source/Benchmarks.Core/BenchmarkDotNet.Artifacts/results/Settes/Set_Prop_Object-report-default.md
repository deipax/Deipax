
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |---------:|----------:|----------:|-------:|----------:|
             FromBool | 4.672 ns | 0.0022 ns | 0.0018 ns | 0.0057 |      24 B |
     FromBoolNullable | 1.917 ns | 0.0335 ns | 0.0280 ns |      - |       0 B |
             FromChar | 4.885 ns | 0.0130 ns | 0.0122 ns | 0.0057 |      24 B |
     FromCharNullable | 1.810 ns | 0.0051 ns | 0.0047 ns |      - |       0 B |
            FromSByte | 4.679 ns | 0.0088 ns | 0.0083 ns | 0.0057 |      24 B |
    FromSByteNullable | 1.839 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
             FromByte | 4.909 ns | 0.0074 ns | 0.0062 ns | 0.0057 |      24 B |
     FromByteNullable | 1.969 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
            FromShort | 5.024 ns | 0.0013 ns | 0.0010 ns | 0.0057 |      24 B |
    FromShortNullable | 1.957 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
           FromUShort | 4.879 ns | 0.0023 ns | 0.0016 ns | 0.0057 |      24 B |
   FromUShortNullable | 1.810 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
              FromInt | 4.759 ns | 0.0140 ns | 0.0124 ns | 0.0057 |      24 B |
      FromIntNullable | 1.822 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
             FromUInt | 4.981 ns | 0.0024 ns | 0.0017 ns | 0.0057 |      24 B |
     FromUIntNullable | 1.848 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
             FromLong | 5.213 ns | 0.0089 ns | 0.0084 ns | 0.0057 |      24 B |
     FromLongNullable | 2.105 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
            FromULong | 4.979 ns | 0.0248 ns | 0.0220 ns | 0.0057 |      24 B |
    FromULongNullable | 2.334 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
            FromFloat | 5.270 ns | 0.0012 ns | 0.0009 ns | 0.0057 |      24 B |
    FromFloatNullable | 1.855 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
           FromDouble | 5.269 ns | 0.0097 ns | 0.0091 ns | 0.0057 |      24 B |
   FromDoubleNullable | 2.321 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
          FromDecimal | 5.914 ns | 0.0031 ns | 0.0024 ns | 0.0076 |      32 B |
  FromDecimalNullable | 2.359 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
         FromDateTime | 4.975 ns | 0.0023 ns | 0.0016 ns | 0.0057 |      24 B |
 FromDateTimeNullable | 2.351 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
           FromObject | 2.571 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
           FromString | 4.613 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
             FromEnum | 4.999 ns | 0.0058 ns | 0.0054 ns | 0.0057 |      24 B |
     FromEnumNullable | 5.998 ns | 0.0083 ns | 0.0077 ns | 0.0057 |      24 B |
