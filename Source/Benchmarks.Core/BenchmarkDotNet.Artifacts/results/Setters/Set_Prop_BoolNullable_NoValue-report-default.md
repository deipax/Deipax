
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.0378 ns | 0.0006 ns | 0.0004 ns |       0 B |
     FromBoolNullable |  0.9881 ns | 0.0024 ns | 0.0022 ns |       0 B |
             FromChar |  1.0390 ns | 0.0020 ns | 0.0018 ns |       0 B |
     FromCharNullable |  1.0011 ns | 0.0023 ns | 0.0022 ns |       0 B |
            FromSByte |  1.1394 ns | 0.0023 ns | 0.0022 ns |       0 B |
    FromSByteNullable |  1.8113 ns | 0.0046 ns | 0.0043 ns |       0 B |
             FromByte |  1.0944 ns | 0.0017 ns | 0.0015 ns |       0 B |
     FromByteNullable |  1.8068 ns | 0.0059 ns | 0.0053 ns |       0 B |
            FromShort |  1.1353 ns | 0.0040 ns | 0.0037 ns |       0 B |
    FromShortNullable |  1.8572 ns | 0.0123 ns | 0.0115 ns |       0 B |
           FromUShort |  1.0484 ns | 0.0023 ns | 0.0021 ns |       0 B |
   FromUShortNullable |  1.8068 ns | 0.0047 ns | 0.0039 ns |       0 B |
              FromInt |  1.0517 ns | 0.0041 ns | 0.0034 ns |       0 B |
      FromIntNullable |  1.7092 ns | 0.0120 ns | 0.0112 ns |       0 B |
             FromUInt |  1.0425 ns | 0.0063 ns | 0.0059 ns |       0 B |
     FromUIntNullable |  2.4844 ns | 0.0124 ns | 0.0116 ns |       0 B |
             FromLong |  1.0429 ns | 0.0052 ns | 0.0048 ns |       0 B |
     FromLongNullable |  2.3190 ns | 0.0067 ns | 0.0063 ns |       0 B |
            FromULong |  1.0472 ns | 0.0032 ns | 0.0030 ns |       0 B |
    FromULongNullable |  2.3154 ns | 0.0006 ns | 0.0005 ns |       0 B |
            FromFloat |  1.2847 ns | 0.0054 ns | 0.0048 ns |       0 B |
    FromFloatNullable |  1.8058 ns | 0.0028 ns | 0.0025 ns |       0 B |
           FromDouble |  1.2800 ns | 0.0035 ns | 0.0033 ns |       0 B |
   FromDoubleNullable |  2.3785 ns | 0.0052 ns | 0.0044 ns |       0 B |
          FromDecimal | 11.5144 ns | 0.0043 ns | 0.0033 ns |       0 B |
  FromDecimalNullable |  8.5697 ns | 0.0035 ns | 0.0029 ns |       0 B |
         FromDateTime |  1.0796 ns | 0.0088 ns | 0.0082 ns |       0 B |
 FromDateTimeNullable |  1.8974 ns | 0.0003 ns | 0.0003 ns |       0 B |
           FromObject |  4.4665 ns | 0.0111 ns | 0.0098 ns |       0 B |
           FromString |  2.2358 ns | 0.0040 ns | 0.0036 ns |       0 B |
             FromEnum |  1.0856 ns | 0.0020 ns | 0.0018 ns |       0 B |
     FromEnumNullable |  2.2244 ns | 0.0200 ns | 0.0178 ns |       0 B |
