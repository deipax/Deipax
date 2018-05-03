
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  3.9130 ns | 0.0172 ns | 0.0161 ns |       0 B |
     FromBoolNullable |  4.6778 ns | 0.0043 ns | 0.0040 ns |       0 B |
             FromChar |  3.6449 ns | 0.0052 ns | 0.0046 ns |       0 B |
     FromCharNullable |  3.6109 ns | 0.0051 ns | 0.0037 ns |       0 B |
            FromSByte |  3.8432 ns | 0.0110 ns | 0.0098 ns |       0 B |
    FromSByteNullable |  4.8119 ns | 0.0082 ns | 0.0072 ns |       0 B |
             FromByte |  4.1676 ns | 0.0219 ns | 0.0205 ns |       0 B |
     FromByteNullable |  4.7687 ns | 0.0115 ns | 0.0102 ns |       0 B |
            FromShort |  3.7973 ns | 0.0038 ns | 0.0034 ns |       0 B |
    FromShortNullable |  4.5088 ns | 0.0074 ns | 0.0057 ns |       0 B |
           FromUShort |  3.8331 ns | 0.0039 ns | 0.0035 ns |       0 B |
   FromUShortNullable |  4.4134 ns | 0.0119 ns | 0.0105 ns |       0 B |
              FromInt |  3.5879 ns | 0.0028 ns | 0.0024 ns |       0 B |
      FromIntNullable |  4.7910 ns | 0.0100 ns | 0.0093 ns |       0 B |
             FromUInt |  4.0745 ns | 0.0039 ns | 0.0034 ns |       0 B |
     FromUIntNullable |  4.7407 ns | 0.0054 ns | 0.0045 ns |       0 B |
             FromLong |  4.0580 ns | 0.0007 ns | 0.0006 ns |       0 B |
     FromLongNullable |  5.1799 ns | 0.0101 ns | 0.0089 ns |       0 B |
            FromULong |  3.9949 ns | 0.0045 ns | 0.0042 ns |       0 B |
    FromULongNullable |  5.6159 ns | 0.0088 ns | 0.0078 ns |       0 B |
            FromFloat |  0.8841 ns | 0.0051 ns | 0.0047 ns |       0 B |
    FromFloatNullable |  1.6147 ns | 0.0042 ns | 0.0037 ns |       0 B |
           FromDouble |  3.7870 ns | 0.0032 ns | 0.0028 ns |       0 B |
   FromDoubleNullable |  4.6436 ns | 0.0011 ns | 0.0008 ns |       0 B |
          FromDecimal | 12.8150 ns | 0.0067 ns | 0.0063 ns |       0 B |
  FromDecimalNullable | 21.8193 ns | 0.0011 ns | 0.0009 ns |       0 B |
         FromDateTime |  3.7201 ns | 0.0043 ns | 0.0040 ns |       0 B |
 FromDateTimeNullable |  3.8591 ns | 0.0073 ns | 0.0068 ns |       0 B |
           FromObject |  2.7001 ns | 0.0061 ns | 0.0057 ns |       0 B |
           FromString | 95.6576 ns | 0.0234 ns | 0.0183 ns |       0 B |
             FromEnum |  4.1476 ns | 0.0031 ns | 0.0028 ns |       0 B |
     FromEnumNullable |  4.5067 ns | 0.0039 ns | 0.0033 ns |       0 B |
