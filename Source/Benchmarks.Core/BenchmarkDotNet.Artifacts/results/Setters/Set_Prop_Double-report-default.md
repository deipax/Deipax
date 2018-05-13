
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5505 ns | 0.0050 ns | 0.0042 ns |       0 B |
     FromBoolNullable |  2.3201 ns | 0.0064 ns | 0.0057 ns |       0 B |
             FromChar |  0.7792 ns | 0.0037 ns | 0.0032 ns |       0 B |
     FromCharNullable |  1.1239 ns | 0.0025 ns | 0.0023 ns |       0 B |
            FromSByte |  1.0351 ns | 0.0028 ns | 0.0026 ns |       0 B |
    FromSByteNullable |  1.3893 ns | 0.0031 ns | 0.0027 ns |       0 B |
             FromByte |  1.0414 ns | 0.0019 ns | 0.0016 ns |       0 B |
     FromByteNullable |  1.6044 ns | 0.0052 ns | 0.0048 ns |       0 B |
            FromShort |  1.0430 ns | 0.0055 ns | 0.0051 ns |       0 B |
    FromShortNullable |  1.7040 ns | 0.0264 ns | 0.0220 ns |       0 B |
           FromUShort |  1.0411 ns | 0.0028 ns | 0.0026 ns |       0 B |
   FromUShortNullable |  1.5692 ns | 0.0118 ns | 0.0105 ns |       0 B |
              FromInt |  1.0824 ns | 0.0086 ns | 0.0076 ns |       0 B |
      FromIntNullable |  1.7943 ns | 0.0203 ns | 0.0158 ns |       0 B |
             FromUInt |  1.0427 ns | 0.0049 ns | 0.0045 ns |       0 B |
     FromUIntNullable |  1.5545 ns | 0.0015 ns | 0.0013 ns |       0 B |
             FromLong |  1.0389 ns | 0.0035 ns | 0.0033 ns |       0 B |
     FromLongNullable |  2.3200 ns | 0.0014 ns | 0.0012 ns |       0 B |
            FromULong |  1.2966 ns | 0.0032 ns | 0.0029 ns |       0 B |
    FromULongNullable |  2.8321 ns | 0.0030 ns | 0.0027 ns |       0 B |
            FromFloat |  1.0904 ns | 0.0182 ns | 0.0171 ns |       0 B |
    FromFloatNullable |  1.6302 ns | 0.0110 ns | 0.0103 ns |       0 B |
           FromDouble |  1.0230 ns | 0.0027 ns | 0.0024 ns |       0 B |
   FromDoubleNullable |  2.1139 ns | 0.0033 ns | 0.0029 ns |       0 B |
          FromDecimal |  9.0279 ns | 0.0200 ns | 0.0187 ns |       0 B |
  FromDecimalNullable | 23.3851 ns | 0.0151 ns | 0.0134 ns |       0 B |
         FromDateTime |  1.0404 ns | 0.0049 ns | 0.0046 ns |       0 B |
 FromDateTimeNullable |  1.8131 ns | 0.0052 ns | 0.0049 ns |       0 B |
           FromObject |  2.9950 ns | 0.0035 ns | 0.0031 ns |       0 B |
           FromString | 92.4303 ns | 0.1020 ns | 0.0954 ns |       0 B |
             FromEnum |  1.0424 ns | 0.0027 ns | 0.0025 ns |       0 B |
     FromEnumNullable |  1.5572 ns | 0.0057 ns | 0.0054 ns |       0 B |
