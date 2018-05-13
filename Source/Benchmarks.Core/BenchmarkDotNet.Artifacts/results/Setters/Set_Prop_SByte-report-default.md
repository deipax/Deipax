
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5185 ns | 0.0020 ns | 0.0018 ns |       0 B |
     FromBoolNullable |  2.2850 ns | 0.0035 ns | 0.0031 ns |       0 B |
             FromChar |  1.7458 ns | 0.0070 ns | 0.0062 ns |       0 B |
     FromCharNullable |  2.4635 ns | 0.0057 ns | 0.0053 ns |       0 B |
            FromSByte |  0.7542 ns | 0.0041 ns | 0.0038 ns |       0 B |
    FromSByteNullable |  1.5910 ns | 0.0046 ns | 0.0043 ns |       0 B |
             FromByte |  1.7216 ns | 0.0084 ns | 0.0079 ns |       0 B |
     FromByteNullable |  2.2521 ns | 0.0011 ns | 0.0008 ns |       0 B |
            FromShort |  2.7997 ns | 0.0072 ns | 0.0067 ns |       0 B |
    FromShortNullable |  4.3800 ns | 0.0086 ns | 0.0080 ns |       0 B |
           FromUShort |  1.7360 ns | 0.0061 ns | 0.0051 ns |       0 B |
   FromUShortNullable |  2.3209 ns | 0.0057 ns | 0.0050 ns |       0 B |
              FromInt |  2.3134 ns | 0.0061 ns | 0.0054 ns |       0 B |
      FromIntNullable |  2.9855 ns | 0.0059 ns | 0.0053 ns |       0 B |
             FromUInt |  2.0616 ns | 0.0247 ns | 0.0206 ns |       0 B |
     FromUIntNullable |  2.6226 ns | 0.0070 ns | 0.0058 ns |       0 B |
             FromLong |  2.5838 ns | 0.0077 ns | 0.0072 ns |       0 B |
     FromLongNullable |  4.0760 ns | 0.0066 ns | 0.0062 ns |       0 B |
            FromULong |  1.7570 ns | 0.0080 ns | 0.0075 ns |       0 B |
    FromULongNullable |  2.7968 ns | 0.0020 ns | 0.0017 ns |       0 B |
            FromFloat |  5.3979 ns | 0.0119 ns | 0.0112 ns |       0 B |
    FromFloatNullable |  5.9957 ns | 0.0260 ns | 0.0243 ns |       0 B |
           FromDouble |  5.3692 ns | 0.0193 ns | 0.0171 ns |       0 B |
   FromDoubleNullable |  6.1533 ns | 0.0193 ns | 0.0180 ns |       0 B |
          FromDecimal | 15.4399 ns | 0.0056 ns | 0.0052 ns |       0 B |
  FromDecimalNullable | 25.8484 ns | 0.0258 ns | 0.0241 ns |       0 B |
         FromDateTime |  0.9021 ns | 0.0007 ns | 0.0006 ns |       0 B |
 FromDateTimeNullable |  1.8004 ns | 0.0020 ns | 0.0018 ns |       0 B |
           FromObject |  3.1152 ns | 0.0916 ns | 0.0940 ns |       0 B |
           FromString | 76.2589 ns | 0.1207 ns | 0.1070 ns |       0 B |
             FromEnum |  2.3767 ns | 0.0086 ns | 0.0080 ns |       0 B |
     FromEnumNullable |  3.0838 ns | 0.0026 ns | 0.0024 ns |       0 B |
