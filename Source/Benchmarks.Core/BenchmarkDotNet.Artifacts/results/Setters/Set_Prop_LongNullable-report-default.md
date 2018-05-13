
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.520 ns | 0.0028 ns | 0.0022 ns |       0 B |
     FromBoolNullable |  2.320 ns | 0.0209 ns | 0.0185 ns |       0 B |
             FromChar |  1.016 ns | 0.0102 ns | 0.0090 ns |       0 B |
     FromCharNullable |  1.796 ns | 0.0307 ns | 0.0257 ns |       0 B |
            FromSByte |  1.016 ns | 0.0241 ns | 0.0201 ns |       0 B |
    FromSByteNullable |  1.538 ns | 0.0123 ns | 0.0109 ns |       0 B |
             FromByte |  1.022 ns | 0.0164 ns | 0.0145 ns |       0 B |
     FromByteNullable |  1.610 ns | 0.0285 ns | 0.0253 ns |       0 B |
            FromShort |  1.060 ns | 0.0079 ns | 0.0070 ns |       0 B |
    FromShortNullable |  1.604 ns | 0.0054 ns | 0.0042 ns |       0 B |
           FromUShort |  1.048 ns | 0.0290 ns | 0.0257 ns |       0 B |
   FromUShortNullable |  1.636 ns | 0.0214 ns | 0.0200 ns |       0 B |
              FromInt |  1.029 ns | 0.0253 ns | 0.0237 ns |       0 B |
      FromIntNullable |  1.634 ns | 0.0742 ns | 0.0761 ns |       0 B |
             FromUInt |  1.036 ns | 0.0521 ns | 0.0487 ns |       0 B |
     FromUIntNullable |  1.752 ns | 0.0265 ns | 0.0248 ns |       0 B |
             FromLong |  1.003 ns | 0.0025 ns | 0.0023 ns |       0 B |
     FromLongNullable |  1.522 ns | 0.0009 ns | 0.0008 ns |       0 B |
            FromULong |  1.925 ns | 0.0067 ns | 0.0059 ns |       0 B |
    FromULongNullable |  3.116 ns | 0.0108 ns | 0.0095 ns |       0 B |
            FromFloat |  4.863 ns | 0.0086 ns | 0.0080 ns |       0 B |
    FromFloatNullable |  5.875 ns | 0.0093 ns | 0.0087 ns |       0 B |
           FromDouble |  4.978 ns | 0.0085 ns | 0.0076 ns |       0 B |
   FromDoubleNullable |  6.165 ns | 0.0073 ns | 0.0065 ns |       0 B |
          FromDecimal | 15.154 ns | 0.0148 ns | 0.0131 ns |       0 B |
  FromDecimalNullable | 29.704 ns | 0.2338 ns | 0.2072 ns |       0 B |
         FromDateTime |  1.009 ns | 0.0036 ns | 0.0033 ns |       0 B |
 FromDateTimeNullable |  1.853 ns | 0.0023 ns | 0.0018 ns |       0 B |
           FromObject | 13.764 ns | 0.0341 ns | 0.0319 ns |       0 B |
           FromString | 73.231 ns | 0.1276 ns | 0.1194 ns |       0 B |
             FromEnum |  1.006 ns | 0.0023 ns | 0.0021 ns |       0 B |
     FromEnumNullable |  1.992 ns | 0.0090 ns | 0.0084 ns |       0 B |
