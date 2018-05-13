
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5169 ns | 0.0020 ns | 0.0018 ns |       0 B |
     FromBoolNullable |  2.2889 ns | 0.0054 ns | 0.0050 ns |       0 B |
             FromChar |  0.9302 ns | 0.0022 ns | 0.0020 ns |       0 B |
     FromCharNullable |  1.5295 ns | 0.0027 ns | 0.0024 ns |       0 B |
            FromSByte |  2.2993 ns | 0.0289 ns | 0.0270 ns |       0 B |
    FromSByteNullable |  2.1440 ns | 0.0107 ns | 0.0100 ns |       0 B |
             FromByte |  1.1081 ns | 0.0042 ns | 0.0039 ns |       0 B |
     FromByteNullable |  1.6078 ns | 0.0041 ns | 0.0037 ns |       0 B |
            FromShort |  2.1104 ns | 0.0051 ns | 0.0048 ns |       0 B |
    FromShortNullable |  2.4559 ns | 0.0097 ns | 0.0091 ns |       0 B |
           FromUShort |  1.1164 ns | 0.0290 ns | 0.0271 ns |       0 B |
   FromUShortNullable |  1.6268 ns | 0.0059 ns | 0.0055 ns |       0 B |
              FromInt |  2.4278 ns | 0.0194 ns | 0.0151 ns |       0 B |
      FromIntNullable |  2.5186 ns | 0.0177 ns | 0.0148 ns |       0 B |
             FromUInt |  0.8169 ns | 0.0037 ns | 0.0035 ns |       0 B |
     FromUIntNullable |  1.5310 ns | 0.0022 ns | 0.0017 ns |       0 B |
             FromLong |  1.8479 ns | 0.0077 ns | 0.0060 ns |       0 B |
     FromLongNullable |  2.8092 ns | 0.0092 ns | 0.0086 ns |       0 B |
            FromULong |  1.0902 ns | 0.0042 ns | 0.0037 ns |       0 B |
    FromULongNullable |  2.0830 ns | 0.0114 ns | 0.0107 ns |       0 B |
            FromFloat |  4.7714 ns | 0.0118 ns | 0.0105 ns |       0 B |
    FromFloatNullable |  5.8207 ns | 0.0156 ns | 0.0138 ns |       0 B |
           FromDouble |  4.3890 ns | 0.0100 ns | 0.0093 ns |       0 B |
   FromDoubleNullable |  6.0839 ns | 0.0018 ns | 0.0014 ns |       0 B |
          FromDecimal | 14.9528 ns | 0.0305 ns | 0.0286 ns |       0 B |
  FromDecimalNullable | 27.0908 ns | 0.0179 ns | 0.0159 ns |       0 B |
         FromDateTime |  1.0292 ns | 0.0042 ns | 0.0039 ns |       0 B |
 FromDateTimeNullable |  1.7801 ns | 0.0085 ns | 0.0071 ns |       0 B |
           FromObject |  3.1361 ns | 0.0478 ns | 0.0447 ns |       0 B |
           FromString | 72.6419 ns | 0.0209 ns | 0.0163 ns |       0 B |
             FromEnum |  1.9086 ns | 0.0063 ns | 0.0059 ns |       0 B |
     FromEnumNullable |  2.5346 ns | 0.0031 ns | 0.0028 ns |       0 B |
