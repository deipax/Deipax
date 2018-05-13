
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5176 ns | 0.0019 ns | 0.0016 ns |       0 B |
     FromBoolNullable |  2.2842 ns | 0.0020 ns | 0.0019 ns |       0 B |
             FromChar |  1.7271 ns | 0.0023 ns | 0.0020 ns |       0 B |
     FromCharNullable |  2.2851 ns | 0.0074 ns | 0.0069 ns |       0 B |
            FromSByte |  0.7649 ns | 0.0057 ns | 0.0053 ns |       0 B |
    FromSByteNullable |  1.5619 ns | 0.0034 ns | 0.0029 ns |       0 B |
             FromByte |  1.3775 ns | 0.0059 ns | 0.0055 ns |       0 B |
     FromByteNullable |  1.5616 ns | 0.0032 ns | 0.0029 ns |       0 B |
            FromShort |  1.0872 ns | 0.0021 ns | 0.0018 ns |       0 B |
    FromShortNullable |  1.8172 ns | 0.0032 ns | 0.0030 ns |       0 B |
           FromUShort |  2.0214 ns | 0.0052 ns | 0.0043 ns |       0 B |
   FromUShortNullable |  2.2878 ns | 0.0011 ns | 0.0009 ns |       0 B |
              FromInt |  2.5474 ns | 0.0096 ns | 0.0080 ns |       0 B |
      FromIntNullable |  3.0758 ns | 0.0093 ns | 0.0072 ns |       0 B |
             FromUInt |  2.5457 ns | 0.0045 ns | 0.0042 ns |       0 B |
     FromUIntNullable |  3.0526 ns | 0.0017 ns | 0.0013 ns |       0 B |
             FromLong |  2.5569 ns | 0.0084 ns | 0.0074 ns |       0 B |
     FromLongNullable |  4.0806 ns | 0.0101 ns | 0.0090 ns |       0 B |
            FromULong |  2.8530 ns | 0.0097 ns | 0.0086 ns |       0 B |
    FromULongNullable |  4.0831 ns | 0.0066 ns | 0.0059 ns |       0 B |
            FromFloat |  5.4104 ns | 0.0315 ns | 0.0263 ns |       0 B |
    FromFloatNullable |  6.0030 ns | 0.0109 ns | 0.0097 ns |       0 B |
           FromDouble |  5.3695 ns | 0.0079 ns | 0.0070 ns |       0 B |
   FromDoubleNullable |  6.4054 ns | 0.0112 ns | 0.0105 ns |       0 B |
          FromDecimal | 15.4806 ns | 0.0307 ns | 0.0272 ns |       0 B |
  FromDecimalNullable | 25.7083 ns | 0.0157 ns | 0.0147 ns |       0 B |
         FromDateTime |  1.6970 ns | 0.0016 ns | 0.0014 ns |       0 B |
 FromDateTimeNullable |  5.0093 ns | 0.0101 ns | 0.0095 ns |       0 B |
           FromObject |  3.1153 ns | 0.0116 ns | 0.0103 ns |       0 B |
           FromString | 75.7089 ns | 0.1217 ns | 0.1138 ns |       0 B |
             FromEnum |  2.5963 ns | 0.0039 ns | 0.0036 ns |       0 B |
     FromEnumNullable |  3.0945 ns | 0.0075 ns | 0.0070 ns |       0 B |
