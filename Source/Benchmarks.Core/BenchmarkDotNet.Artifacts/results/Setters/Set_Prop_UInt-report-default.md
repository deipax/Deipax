
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5500 ns | 0.0227 ns | 0.0190 ns |       0 B |
     FromBoolNullable |  2.3179 ns | 0.0061 ns | 0.0054 ns |       0 B |
             FromChar |  1.1196 ns | 0.0083 ns | 0.0074 ns |       0 B |
     FromCharNullable |  1.5541 ns | 0.0055 ns | 0.0046 ns |       0 B |
            FromSByte |  2.1607 ns | 0.0250 ns | 0.0222 ns |       0 B |
    FromSByteNullable |  2.1294 ns | 0.0119 ns | 0.0106 ns |       0 B |
             FromByte |  0.7853 ns | 0.0032 ns | 0.0028 ns |       0 B |
     FromByteNullable |  1.6107 ns | 0.0011 ns | 0.0009 ns |       0 B |
            FromShort |  1.7740 ns | 0.0034 ns | 0.0030 ns |       0 B |
    FromShortNullable |  2.2029 ns | 0.0042 ns | 0.0037 ns |       0 B |
           FromUShort |  0.7914 ns | 0.0061 ns | 0.0057 ns |       0 B |
   FromUShortNullable |  1.5582 ns | 0.0030 ns | 0.0027 ns |       0 B |
              FromInt |  1.7195 ns | 0.0144 ns | 0.0128 ns |       0 B |
      FromIntNullable |  2.5912 ns | 0.0224 ns | 0.0209 ns |       0 B |
             FromUInt |  0.7893 ns | 0.0068 ns | 0.0064 ns |       0 B |
     FromUIntNullable |  1.6508 ns | 0.0039 ns | 0.0035 ns |       0 B |
             FromLong |  2.5747 ns | 0.0049 ns | 0.0044 ns |       0 B |
     FromLongNullable |  4.1223 ns | 0.0163 ns | 0.0152 ns |       0 B |
            FromULong |  1.8627 ns | 0.0140 ns | 0.0117 ns |       0 B |
    FromULongNullable |  3.0151 ns | 0.0897 ns | 0.0921 ns |       0 B |
            FromFloat |  4.4912 ns | 0.0116 ns | 0.0091 ns |       0 B |
    FromFloatNullable |  5.2484 ns | 0.0063 ns | 0.0056 ns |       0 B |
           FromDouble |  3.8773 ns | 0.0075 ns | 0.0070 ns |       0 B |
   FromDoubleNullable |  4.9665 ns | 0.1325 ns | 0.1942 ns |       0 B |
          FromDecimal | 14.3099 ns | 0.0119 ns | 0.0106 ns |       0 B |
  FromDecimalNullable | 24.9605 ns | 0.0065 ns | 0.0051 ns |       0 B |
         FromDateTime |  0.8426 ns | 0.0034 ns | 0.0030 ns |       0 B |
 FromDateTimeNullable |  1.8092 ns | 0.0057 ns | 0.0053 ns |       0 B |
           FromObject |  3.4062 ns | 0.0343 ns | 0.0321 ns |       0 B |
           FromString | 72.3245 ns | 0.0851 ns | 0.0796 ns |       0 B |
             FromEnum |  1.9246 ns | 0.0051 ns | 0.0048 ns |       0 B |
     FromEnumNullable |  2.5428 ns | 0.0034 ns | 0.0032 ns |       0 B |
