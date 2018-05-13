
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |        Mean |     Error |    StdDev | Allocated |
--------------------- |------------:|----------:|----------:|----------:|
             FromBool |   1.2869 ns | 0.0030 ns | 0.0027 ns |       0 B |
     FromBoolNullable |   1.1601 ns | 0.0020 ns | 0.0019 ns |       0 B |
             FromChar |   1.1573 ns | 0.0045 ns | 0.0042 ns |       0 B |
     FromCharNullable |   1.1556 ns | 0.0048 ns | 0.0045 ns |       0 B |
            FromSByte |   1.1422 ns | 0.0054 ns | 0.0045 ns |       0 B |
    FromSByteNullable |   1.1883 ns | 0.0062 ns | 0.0058 ns |       0 B |
             FromByte |   1.1044 ns | 0.0053 ns | 0.0050 ns |       0 B |
     FromByteNullable |   1.3206 ns | 0.0042 ns | 0.0039 ns |       0 B |
            FromShort |   1.2906 ns | 0.0047 ns | 0.0042 ns |       0 B |
    FromShortNullable |   1.2252 ns | 0.0035 ns | 0.0033 ns |       0 B |
           FromUShort |   2.0127 ns | 0.0126 ns | 0.0111 ns |       0 B |
   FromUShortNullable |   1.1927 ns | 0.0035 ns | 0.0031 ns |       0 B |
              FromInt |   1.0445 ns | 0.0050 ns | 0.0047 ns |       0 B |
      FromIntNullable |   1.1943 ns | 0.0025 ns | 0.0021 ns |       0 B |
             FromUInt |   1.7646 ns | 0.0045 ns | 0.0042 ns |       0 B |
     FromUIntNullable |   1.2170 ns | 0.0037 ns | 0.0034 ns |       0 B |
             FromLong |   1.1328 ns | 0.0046 ns | 0.0043 ns |       0 B |
     FromLongNullable |   1.5521 ns | 0.0057 ns | 0.0053 ns |       0 B |
            FromULong |   1.0454 ns | 0.0050 ns | 0.0047 ns |       0 B |
    FromULongNullable |   1.6262 ns | 0.0221 ns | 0.0207 ns |       0 B |
            FromFloat |   1.2839 ns | 0.0042 ns | 0.0039 ns |       0 B |
    FromFloatNullable |   1.2289 ns | 0.0039 ns | 0.0035 ns |       0 B |
           FromDouble |   1.2850 ns | 0.0035 ns | 0.0033 ns |       0 B |
   FromDoubleNullable |   1.5577 ns | 0.0046 ns | 0.0041 ns |       0 B |
          FromDecimal |   1.8206 ns | 0.0065 ns | 0.0051 ns |       0 B |
  FromDecimalNullable |   1.5408 ns | 0.0009 ns | 0.0006 ns |       0 B |
         FromDateTime |   0.7870 ns | 0.0006 ns | 0.0005 ns |       0 B |
 FromDateTimeNullable |   2.0699 ns | 0.0044 ns | 0.0041 ns |       0 B |
           FromObject |   3.0174 ns | 0.0194 ns | 0.0162 ns |       0 B |
           FromString | 544.8030 ns | 0.9897 ns | 0.9257 ns |       0 B |
             FromEnum |   1.2242 ns | 0.0036 ns | 0.0030 ns |       0 B |
     FromEnumNullable |   1.2123 ns | 0.0042 ns | 0.0037 ns |       0 B |
