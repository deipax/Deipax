
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5198 ns | 0.0027 ns | 0.0025 ns |       0 B |
     FromBoolNullable |  2.0416 ns | 0.0017 ns | 0.0014 ns |       0 B |
             FromChar |  1.0069 ns | 0.0050 ns | 0.0046 ns |       0 B |
     FromCharNullable |  1.0156 ns | 0.0005 ns | 0.0005 ns |       0 B |
            FromSByte |  1.0309 ns | 0.0013 ns | 0.0012 ns |       0 B |
    FromSByteNullable |  1.5344 ns | 0.0040 ns | 0.0037 ns |       0 B |
             FromByte |  1.0069 ns | 0.0045 ns | 0.0042 ns |       0 B |
     FromByteNullable |  1.9341 ns | 0.0087 ns | 0.0077 ns |       0 B |
            FromShort |  1.0028 ns | 0.0018 ns | 0.0017 ns |       0 B |
    FromShortNullable |  2.2670 ns | 0.0856 ns | 0.0985 ns |       0 B |
           FromUShort |  1.0114 ns | 0.0032 ns | 0.0030 ns |       0 B |
   FromUShortNullable |  2.5150 ns | 0.0470 ns | 0.0417 ns |       0 B |
              FromInt |  1.0085 ns | 0.0036 ns | 0.0034 ns |       0 B |
      FromIntNullable |  1.6697 ns | 0.0438 ns | 0.0410 ns |       0 B |
             FromUInt |  1.0068 ns | 0.0006 ns | 0.0005 ns |       0 B |
     FromUIntNullable |  2.0048 ns | 0.0057 ns | 0.0054 ns |       0 B |
             FromLong |  1.0182 ns | 0.0052 ns | 0.0049 ns |       0 B |
     FromLongNullable |  2.5910 ns | 0.0054 ns | 0.0048 ns |       0 B |
            FromULong |  1.2689 ns | 0.0041 ns | 0.0038 ns |       0 B |
    FromULongNullable |  3.0642 ns | 0.0073 ns | 0.0068 ns |       0 B |
            FromFloat |  1.0296 ns | 0.0048 ns | 0.0045 ns |       0 B |
    FromFloatNullable |  2.3535 ns | 0.0114 ns | 0.0107 ns |       0 B |
           FromDouble |  1.1109 ns | 0.0027 ns | 0.0024 ns |       0 B |
   FromDoubleNullable |  1.7801 ns | 0.0043 ns | 0.0040 ns |       0 B |
          FromDecimal |  9.3542 ns | 0.0129 ns | 0.0115 ns |       0 B |
  FromDecimalNullable | 23.4216 ns | 0.0123 ns | 0.0115 ns |       0 B |
         FromDateTime |  0.9008 ns | 0.0019 ns | 0.0017 ns |       0 B |
 FromDateTimeNullable |  2.0581 ns | 0.0075 ns | 0.0070 ns |       0 B |
           FromObject | 13.7094 ns | 0.0226 ns | 0.0211 ns |       0 B |
           FromString | 91.9845 ns | 0.1203 ns | 0.1067 ns |       0 B |
             FromEnum |  1.0804 ns | 0.0025 ns | 0.0022 ns |       0 B |
     FromEnumNullable |  3.3265 ns | 0.0869 ns | 0.0771 ns |       0 B |
