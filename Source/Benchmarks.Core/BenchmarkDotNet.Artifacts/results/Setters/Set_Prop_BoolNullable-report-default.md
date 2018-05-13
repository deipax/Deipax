
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.0084 ns | 0.0027 ns | 0.0026 ns |       0 B |
     FromBoolNullable |  1.9503 ns | 0.0011 ns | 0.0010 ns |       0 B |
             FromChar |  1.0116 ns | 0.0009 ns | 0.0008 ns |       0 B |
     FromCharNullable |  0.9089 ns | 0.0025 ns | 0.0022 ns |       0 B |
            FromSByte |  1.4709 ns | 0.0190 ns | 0.0178 ns |       0 B |
    FromSByteNullable |  1.7577 ns | 0.0020 ns | 0.0018 ns |       0 B |
             FromByte |  1.0618 ns | 0.0558 ns | 0.0522 ns |       0 B |
     FromByteNullable |  1.8357 ns | 0.0051 ns | 0.0048 ns |       0 B |
            FromShort |  1.4501 ns | 0.0111 ns | 0.0098 ns |       0 B |
    FromShortNullable |  2.4546 ns | 0.0337 ns | 0.0315 ns |       0 B |
           FromUShort |  2.1301 ns | 0.0066 ns | 0.0058 ns |       0 B |
   FromUShortNullable |  2.2615 ns | 0.0057 ns | 0.0050 ns |       0 B |
              FromInt |  1.0098 ns | 0.0055 ns | 0.0048 ns |       0 B |
      FromIntNullable |  2.8464 ns | 0.0040 ns | 0.0036 ns |       0 B |
             FromUInt |  1.0122 ns | 0.0046 ns | 0.0041 ns |       0 B |
     FromUIntNullable |  2.0029 ns | 0.0190 ns | 0.0177 ns |       0 B |
             FromLong |  1.0514 ns | 0.0072 ns | 0.0067 ns |       0 B |
     FromLongNullable |  2.5488 ns | 0.0052 ns | 0.0048 ns |       0 B |
            FromULong |  1.0130 ns | 0.0016 ns | 0.0011 ns |       0 B |
    FromULongNullable |  2.5417 ns | 0.0015 ns | 0.0013 ns |       0 B |
            FromFloat |  1.1392 ns | 0.0054 ns | 0.0048 ns |       0 B |
    FromFloatNullable |  2.2270 ns | 0.0068 ns | 0.0060 ns |       0 B |
           FromDouble |  1.7112 ns | 0.0121 ns | 0.0114 ns |       0 B |
   FromDoubleNullable |  2.5799 ns | 0.0088 ns | 0.0083 ns |       0 B |
          FromDecimal | 11.4788 ns | 0.0019 ns | 0.0015 ns |       0 B |
  FromDecimalNullable | 18.0354 ns | 0.0196 ns | 0.0183 ns |       0 B |
         FromDateTime |  1.0076 ns | 0.0030 ns | 0.0027 ns |       0 B |
 FromDateTimeNullable |  1.9006 ns | 0.0032 ns | 0.0026 ns |       0 B |
           FromObject | 13.3969 ns | 0.0169 ns | 0.0150 ns |       0 B |
           FromString |  9.6201 ns | 0.0091 ns | 0.0085 ns |       0 B |
             FromEnum |  1.1753 ns | 0.0028 ns | 0.0026 ns |       0 B |
     FromEnumNullable |  1.7672 ns | 0.0020 ns | 0.0019 ns |       0 B |
