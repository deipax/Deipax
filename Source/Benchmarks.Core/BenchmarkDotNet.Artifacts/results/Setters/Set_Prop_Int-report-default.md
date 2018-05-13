
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5166 ns | 0.0013 ns | 0.0011 ns |       0 B |
     FromBoolNullable |  2.2882 ns | 0.0034 ns | 0.0030 ns |       0 B |
             FromChar |  1.0488 ns | 0.0057 ns | 0.0053 ns |       0 B |
     FromCharNullable |  1.5175 ns | 0.0052 ns | 0.0049 ns |       0 B |
            FromSByte |  1.3998 ns | 0.0019 ns | 0.0017 ns |       0 B |
    FromSByteNullable |  1.5221 ns | 0.0015 ns | 0.0014 ns |       0 B |
             FromByte |  1.0757 ns | 0.0023 ns | 0.0022 ns |       0 B |
     FromByteNullable |  1.5744 ns | 0.0038 ns | 0.0035 ns |       0 B |
            FromShort |  1.0375 ns | 0.0042 ns | 0.0039 ns |       0 B |
    FromShortNullable |  1.5584 ns | 0.0021 ns | 0.0018 ns |       0 B |
           FromUShort |  0.9968 ns | 0.0102 ns | 0.0096 ns |       0 B |
   FromUShortNullable |  1.5185 ns | 0.0038 ns | 0.0036 ns |       0 B |
              FromInt |  0.7845 ns | 0.0066 ns | 0.0062 ns |       0 B |
      FromIntNullable |  1.5929 ns | 0.0099 ns | 0.0093 ns |       0 B |
             FromUInt |  2.1887 ns | 0.0122 ns | 0.0115 ns |       0 B |
     FromUIntNullable |  2.6009 ns | 0.0696 ns | 0.0651 ns |       0 B |
             FromLong |  2.5451 ns | 0.0021 ns | 0.0020 ns |       0 B |
     FromLongNullable |  4.2403 ns | 0.0044 ns | 0.0036 ns |       0 B |
            FromULong |  2.5464 ns | 0.0032 ns | 0.0030 ns |       0 B |
    FromULongNullable |  4.0878 ns | 0.0048 ns | 0.0040 ns |       0 B |
            FromFloat |  4.4636 ns | 0.0149 ns | 0.0140 ns |       0 B |
    FromFloatNullable |  5.1822 ns | 0.0029 ns | 0.0026 ns |       0 B |
           FromDouble |  4.1488 ns | 0.0074 ns | 0.0065 ns |       0 B |
   FromDoubleNullable |  4.8507 ns | 0.0061 ns | 0.0054 ns |       0 B |
          FromDecimal | 14.7163 ns | 0.0365 ns | 0.0323 ns |       0 B |
  FromDecimalNullable | 25.2334 ns | 0.0081 ns | 0.0063 ns |       0 B |
         FromDateTime |  0.7638 ns | 0.0045 ns | 0.0042 ns |       0 B |
 FromDateTimeNullable |  1.7784 ns | 0.0030 ns | 0.0028 ns |       0 B |
           FromObject |  3.1281 ns | 0.0660 ns | 0.0585 ns |       0 B |
           FromString | 74.4132 ns | 0.0909 ns | 0.0806 ns |       0 B |
             FromEnum |  0.9055 ns | 0.0025 ns | 0.0023 ns |       0 B |
     FromEnumNullable |  1.5225 ns | 0.0043 ns | 0.0040 ns |       0 B |
