
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.2660 ns | 0.0033 ns | 0.0031 ns |       0 B |
     FromBoolNullable |  1.7763 ns | 0.0049 ns | 0.0043 ns |       0 B |
             FromChar |  1.9217 ns | 0.0031 ns | 0.0026 ns |       0 B |
     FromCharNullable |  2.4905 ns | 0.0035 ns | 0.0031 ns |       0 B |
            FromSByte |  1.0094 ns | 0.0025 ns | 0.0023 ns |       0 B |
    FromSByteNullable |  1.7758 ns | 0.0034 ns | 0.0032 ns |       0 B |
             FromByte |  1.0090 ns | 0.0019 ns | 0.0018 ns |       0 B |
     FromByteNullable |  1.7739 ns | 0.0033 ns | 0.0031 ns |       0 B |
            FromShort |  1.0103 ns | 0.0018 ns | 0.0016 ns |       0 B |
    FromShortNullable |  0.9823 ns | 0.0012 ns | 0.0010 ns |       0 B |
           FromUShort |  1.9222 ns | 0.0021 ns | 0.0020 ns |       0 B |
   FromUShortNullable |  2.5202 ns | 0.0027 ns | 0.0024 ns |       0 B |
              FromInt |  2.7642 ns | 0.0077 ns | 0.0072 ns |       0 B |
      FromIntNullable |  2.4775 ns | 0.0092 ns | 0.0086 ns |       0 B |
             FromUInt |  2.6758 ns | 0.0047 ns | 0.0041 ns |       0 B |
     FromUIntNullable |  2.6129 ns | 0.0018 ns | 0.0016 ns |       0 B |
             FromLong |  2.6752 ns | 0.0085 ns | 0.0079 ns |       0 B |
     FromLongNullable |  2.6324 ns | 0.0133 ns | 0.0111 ns |       0 B |
            FromULong |  2.5840 ns | 0.0059 ns | 0.0055 ns |       0 B |
    FromULongNullable |  2.3043 ns | 0.0043 ns | 0.0036 ns |       0 B |
            FromFloat |  5.6462 ns | 0.0149 ns | 0.0139 ns |       0 B |
    FromFloatNullable |  2.4749 ns | 0.0071 ns | 0.0063 ns |       0 B |
           FromDouble |  6.0630 ns | 0.0087 ns | 0.0073 ns |       0 B |
   FromDoubleNullable |  2.9178 ns | 0.0110 ns | 0.0103 ns |       0 B |
          FromDecimal | 15.6822 ns | 0.0066 ns | 0.0052 ns |       0 B |
  FromDecimalNullable |  9.0263 ns | 0.0073 ns | 0.0065 ns |       0 B |
         FromDateTime |  1.0084 ns | 0.0041 ns | 0.0038 ns |       0 B |
 FromDateTimeNullable |  1.9327 ns | 0.0070 ns | 0.0062 ns |       0 B |
           FromObject |  3.9433 ns | 0.0045 ns | 0.0040 ns |       0 B |
           FromString |  2.4550 ns | 0.0057 ns | 0.0050 ns |       0 B |
             FromEnum |  3.4089 ns | 0.0403 ns | 0.0377 ns |       0 B |
     FromEnumNullable |  4.4213 ns | 0.0036 ns | 0.0033 ns |       0 B |
