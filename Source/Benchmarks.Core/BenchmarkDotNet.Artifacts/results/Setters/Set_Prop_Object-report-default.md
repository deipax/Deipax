
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |---------:|----------:|----------:|-------:|----------:|
             FromBool | 4.915 ns | 0.0077 ns | 0.0072 ns | 0.0057 |      24 B |
     FromBoolNullable | 1.840 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
             FromChar | 5.052 ns | 0.0130 ns | 0.0122 ns | 0.0057 |      24 B |
     FromCharNullable | 1.814 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
            FromSByte | 4.943 ns | 0.0088 ns | 0.0083 ns | 0.0057 |      24 B |
    FromSByteNullable | 2.020 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
             FromByte | 4.895 ns | 0.0090 ns | 0.0084 ns | 0.0057 |      24 B |
     FromByteNullable | 1.844 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
            FromShort | 4.916 ns | 0.0114 ns | 0.0107 ns | 0.0057 |      24 B |
    FromShortNullable | 1.810 ns | 0.0038 ns | 0.0035 ns |      - |       0 B |
           FromUShort | 4.929 ns | 0.0070 ns | 0.0066 ns | 0.0057 |      24 B |
   FromUShortNullable | 1.852 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
              FromInt | 4.941 ns | 0.0014 ns | 0.0011 ns | 0.0057 |      24 B |
      FromIntNullable | 1.862 ns | 0.0030 ns | 0.0026 ns |      - |       0 B |
             FromUInt | 4.971 ns | 0.0052 ns | 0.0046 ns | 0.0057 |      24 B |
     FromUIntNullable | 1.877 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
             FromLong | 5.010 ns | 0.0092 ns | 0.0086 ns | 0.0057 |      24 B |
     FromLongNullable | 2.326 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
            FromULong | 5.031 ns | 0.0141 ns | 0.0131 ns | 0.0057 |      24 B |
    FromULongNullable | 2.496 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
            FromFloat | 5.276 ns | 0.0146 ns | 0.0114 ns | 0.0057 |      24 B |
    FromFloatNullable | 1.828 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
           FromDouble | 5.213 ns | 0.0182 ns | 0.0161 ns | 0.0057 |      24 B |
   FromDoubleNullable | 2.340 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
          FromDecimal | 5.999 ns | 0.0146 ns | 0.0136 ns | 0.0076 |      32 B |
  FromDecimalNullable | 2.323 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
         FromDateTime | 5.047 ns | 0.0077 ns | 0.0072 ns | 0.0057 |      24 B |
 FromDateTimeNullable | 2.529 ns | 0.0234 ns | 0.0195 ns |      - |       0 B |
           FromObject | 2.836 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
           FromString | 4.364 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
             FromEnum | 4.973 ns | 0.0110 ns | 0.0103 ns | 0.0057 |      24 B |
     FromEnumNullable | 6.018 ns | 0.0092 ns | 0.0086 ns | 0.0057 |      24 B |
