
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5208 ns | 0.0028 ns | 0.0025 ns |       0 B |
     FromBoolNullable |  2.2825 ns | 0.0018 ns | 0.0015 ns |       0 B |
             FromChar |  0.7520 ns | 0.0017 ns | 0.0015 ns |       0 B |
     FromCharNullable |  1.8446 ns | 0.0193 ns | 0.0180 ns |       0 B |
            FromSByte |  1.7319 ns | 0.0061 ns | 0.0054 ns |       0 B |
    FromSByteNullable |  2.3084 ns | 0.0042 ns | 0.0039 ns |       0 B |
             FromByte |  0.7519 ns | 0.0027 ns | 0.0024 ns |       0 B |
     FromByteNullable |  1.5443 ns | 0.0031 ns | 0.0029 ns |       0 B |
            FromShort |  1.7516 ns | 0.0038 ns | 0.0036 ns |       0 B |
    FromShortNullable |  2.2929 ns | 0.0021 ns | 0.0019 ns |       0 B |
           FromUShort |  0.8642 ns | 0.0015 ns | 0.0014 ns |       0 B |
   FromUShortNullable |  1.6384 ns | 0.0032 ns | 0.0030 ns |       0 B |
              FromInt |  2.5449 ns | 0.0021 ns | 0.0017 ns |       0 B |
      FromIntNullable |  3.0618 ns | 0.0084 ns | 0.0078 ns |       0 B |
             FromUInt |  1.8164 ns | 0.0034 ns | 0.0029 ns |       0 B |
     FromUIntNullable |  2.5327 ns | 0.0071 ns | 0.0067 ns |       0 B |
             FromLong |  2.6028 ns | 0.0028 ns | 0.0025 ns |       0 B |
     FromLongNullable |  4.0783 ns | 0.0023 ns | 0.0018 ns |       0 B |
            FromULong |  2.5484 ns | 0.0077 ns | 0.0068 ns |       0 B |
    FromULongNullable |  4.0934 ns | 0.0086 ns | 0.0081 ns |       0 B |
            FromFloat |  5.3481 ns | 0.0052 ns | 0.0049 ns |       0 B |
    FromFloatNullable |  6.1634 ns | 0.0086 ns | 0.0077 ns |       0 B |
           FromDouble |  5.2939 ns | 0.0054 ns | 0.0045 ns |       0 B |
   FromDoubleNullable |  6.4385 ns | 0.0070 ns | 0.0066 ns |       0 B |
          FromDecimal | 15.1910 ns | 0.0187 ns | 0.0175 ns |       0 B |
  FromDecimalNullable | 25.4708 ns | 0.0086 ns | 0.0081 ns |       0 B |
         FromDateTime |  1.0052 ns | 0.0005 ns | 0.0004 ns |       0 B |
 FromDateTimeNullable |  1.7764 ns | 0.0015 ns | 0.0014 ns |       0 B |
           FromObject |  3.3587 ns | 0.0072 ns | 0.0068 ns |       0 B |
           FromString | 72.6625 ns | 0.0735 ns | 0.0613 ns |       0 B |
             FromEnum |  2.6491 ns | 0.0051 ns | 0.0048 ns |       0 B |
     FromEnumNullable |  3.1043 ns | 0.0042 ns | 0.0033 ns |       0 B |
