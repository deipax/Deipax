
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |        Mean |     Error |    StdDev | Allocated |
--------------------- |------------:|----------:|----------:|----------:|
             FromBool |   3.9912 ns | 0.0009 ns | 0.0008 ns |       0 B |
     FromBoolNullable |   4.1363 ns | 0.0074 ns | 0.0069 ns |       0 B |
             FromChar |   3.9163 ns | 0.0006 ns | 0.0005 ns |       0 B |
     FromCharNullable |   3.8851 ns | 0.0093 ns | 0.0087 ns |       0 B |
            FromSByte |   3.8908 ns | 0.0014 ns | 0.0012 ns |       0 B |
    FromSByteNullable |   4.1430 ns | 0.0128 ns | 0.0107 ns |       0 B |
             FromByte |   4.0956 ns | 0.0126 ns | 0.0118 ns |       0 B |
     FromByteNullable |   4.0809 ns | 0.0047 ns | 0.0042 ns |       0 B |
            FromShort |   3.9367 ns | 0.0008 ns | 0.0006 ns |       0 B |
    FromShortNullable |   3.9217 ns | 0.0049 ns | 0.0046 ns |       0 B |
           FromUShort |   4.5945 ns | 0.0007 ns | 0.0005 ns |       0 B |
   FromUShortNullable |   4.1226 ns | 0.0088 ns | 0.0082 ns |       0 B |
              FromInt |   3.7191 ns | 0.0008 ns | 0.0007 ns |       0 B |
      FromIntNullable |   3.9094 ns | 0.0368 ns | 0.0344 ns |       0 B |
             FromUInt |   4.0220 ns | 0.0008 ns | 0.0006 ns |       0 B |
     FromUIntNullable |   3.9187 ns | 0.0008 ns | 0.0007 ns |       0 B |
             FromLong |   3.8375 ns | 0.0018 ns | 0.0015 ns |       0 B |
     FromLongNullable |   3.8889 ns | 0.0101 ns | 0.0089 ns |       0 B |
            FromULong |   3.8015 ns | 0.0007 ns | 0.0006 ns |       0 B |
    FromULongNullable |   3.8726 ns | 0.0055 ns | 0.0052 ns |       0 B |
            FromFloat |   3.8876 ns | 0.0007 ns | 0.0006 ns |       0 B |
    FromFloatNullable |   3.8880 ns | 0.0015 ns | 0.0014 ns |       0 B |
           FromDouble |   3.9573 ns | 0.0023 ns | 0.0018 ns |       0 B |
   FromDoubleNullable |   3.8831 ns | 0.0053 ns | 0.0049 ns |       0 B |
          FromDecimal |   3.9668 ns | 0.0012 ns | 0.0010 ns |       0 B |
  FromDecimalNullable |   4.1719 ns | 0.0029 ns | 0.0026 ns |       0 B |
         FromDateTime |   0.8090 ns | 0.0081 ns | 0.0076 ns |       0 B |
 FromDateTimeNullable |   2.3222 ns | 0.0019 ns | 0.0018 ns |       0 B |
           FromObject |   2.7882 ns | 0.0021 ns | 0.0017 ns |       0 B |
           FromString | 545.0463 ns | 0.6085 ns | 0.4751 ns |       0 B |
             FromEnum |   4.0556 ns | 0.0068 ns | 0.0063 ns |       0 B |
     FromEnumNullable |   3.9548 ns | 0.0038 ns | 0.0036 ns |       0 B |
