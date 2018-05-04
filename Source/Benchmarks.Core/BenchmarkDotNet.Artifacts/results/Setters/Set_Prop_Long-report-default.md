
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  3.7382 ns | 0.0015 ns | 0.0012 ns |       0 B |
     FromBoolNullable |  4.6345 ns | 0.0110 ns | 0.0092 ns |       0 B |
             FromChar |  3.6505 ns | 0.0033 ns | 0.0029 ns |       0 B |
     FromCharNullable |  4.3656 ns | 0.0040 ns | 0.0036 ns |       0 B |
            FromSByte |  3.6659 ns | 0.0020 ns | 0.0017 ns |       0 B |
    FromSByteNullable |  4.6026 ns | 0.0069 ns | 0.0061 ns |       0 B |
             FromByte |  3.7096 ns | 0.0036 ns | 0.0034 ns |       0 B |
     FromByteNullable |  4.7553 ns | 0.0105 ns | 0.0093 ns |       0 B |
            FromShort |  3.6800 ns | 0.0020 ns | 0.0016 ns |       0 B |
    FromShortNullable |  4.6091 ns | 0.0093 ns | 0.0082 ns |       0 B |
           FromUShort |  3.7651 ns | 0.0085 ns | 0.0076 ns |       0 B |
   FromUShortNullable |  4.3872 ns | 0.0100 ns | 0.0089 ns |       0 B |
              FromInt |  3.5263 ns | 0.0087 ns | 0.0077 ns |       0 B |
      FromIntNullable |  4.4694 ns | 0.0031 ns | 0.0029 ns |       0 B |
             FromUInt |  3.6911 ns | 0.0035 ns | 0.0033 ns |       0 B |
     FromUIntNullable |  4.3814 ns | 0.0097 ns | 0.0086 ns |       0 B |
             FromLong |  0.7528 ns | 0.0012 ns | 0.0010 ns |       0 B |
     FromLongNullable |  2.2680 ns | 0.0037 ns | 0.0031 ns |       0 B |
            FromULong |  4.5495 ns | 0.0050 ns | 0.0046 ns |       0 B |
    FromULongNullable |  5.3727 ns | 0.0133 ns | 0.0124 ns |       0 B |
            FromFloat |  7.0275 ns | 0.0033 ns | 0.0028 ns |       0 B |
    FromFloatNullable |  8.2113 ns | 0.0159 ns | 0.0149 ns |       0 B |
           FromDouble |  7.1118 ns | 0.0049 ns | 0.0046 ns |       0 B |
   FromDoubleNullable |  7.9271 ns | 0.0013 ns | 0.0010 ns |       0 B |
          FromDecimal | 31.2745 ns | 0.0145 ns | 0.0136 ns |       0 B |
  FromDecimalNullable | 24.9720 ns | 0.0117 ns | 0.0104 ns |       0 B |
         FromDateTime |  4.4343 ns | 0.0021 ns | 0.0018 ns |       0 B |
 FromDateTimeNullable |  4.0883 ns | 0.0024 ns | 0.0022 ns |       0 B |
           FromObject |  2.6964 ns | 0.0005 ns | 0.0004 ns |       0 B |
           FromString | 76.0196 ns | 0.0509 ns | 0.0451 ns |       0 B |
             FromEnum |  4.0063 ns | 0.0006 ns | 0.0004 ns |       0 B |
     FromEnumNullable |  4.5255 ns | 0.0026 ns | 0.0024 ns |       0 B |
