
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 20.187 ns | 0.0240 ns | 0.0225 ns |       0 B |
     FromBoolNullable |  2.475 ns | 0.0098 ns | 0.0091 ns |       0 B |
             FromChar | 20.467 ns | 0.0173 ns | 0.0162 ns |       0 B |
     FromCharNullable |  2.679 ns | 0.0038 ns | 0.0032 ns |       0 B |
            FromSByte | 20.319 ns | 0.0395 ns | 0.0370 ns |       0 B |
    FromSByteNullable |  2.470 ns | 0.0116 ns | 0.0103 ns |       0 B |
             FromByte | 20.239 ns | 0.0023 ns | 0.0018 ns |       0 B |
     FromByteNullable |  2.671 ns | 0.0051 ns | 0.0045 ns |       0 B |
            FromShort | 20.269 ns | 0.0281 ns | 0.0263 ns |       0 B |
    FromShortNullable |  2.659 ns | 0.0091 ns | 0.0085 ns |       0 B |
           FromUShort | 20.487 ns | 0.0226 ns | 0.0212 ns |       0 B |
   FromUShortNullable |  2.743 ns | 0.0200 ns | 0.0187 ns |       0 B |
              FromInt | 20.281 ns | 0.0079 ns | 0.0070 ns |       0 B |
      FromIntNullable |  2.549 ns | 0.0070 ns | 0.0066 ns |       0 B |
             FromUInt | 20.214 ns | 0.0136 ns | 0.0121 ns |       0 B |
     FromUIntNullable |  2.688 ns | 0.0036 ns | 0.0032 ns |       0 B |
             FromLong | 20.895 ns | 0.0165 ns | 0.0154 ns |       0 B |
     FromLongNullable |  2.585 ns | 0.0099 ns | 0.0093 ns |       0 B |
            FromULong | 21.197 ns | 0.0328 ns | 0.0307 ns |       0 B |
    FromULongNullable |  2.838 ns | 0.0093 ns | 0.0087 ns |       0 B |
            FromFloat | 21.905 ns | 0.0356 ns | 0.0315 ns |       0 B |
    FromFloatNullable |  2.536 ns | 0.0098 ns | 0.0087 ns |       0 B |
           FromDouble | 21.672 ns | 0.0372 ns | 0.0348 ns |       0 B |
   FromDoubleNullable |  2.588 ns | 0.0090 ns | 0.0080 ns |       0 B |
          FromDecimal | 37.111 ns | 0.0564 ns | 0.0527 ns |       0 B |
  FromDecimalNullable |  8.585 ns | 0.0247 ns | 0.0231 ns |       0 B |
         FromDateTime | 14.207 ns | 0.0233 ns | 0.0218 ns |       0 B |
 FromDateTimeNullable |  8.836 ns | 0.0107 ns | 0.0095 ns |       0 B |
           FromObject |  3.727 ns | 0.0068 ns | 0.0063 ns |       0 B |
           FromString |  2.319 ns | 0.0023 ns | 0.0020 ns |       0 B |
             FromEnum |  1.042 ns | 0.0041 ns | 0.0038 ns |       0 B |
     FromEnumNullable |  1.094 ns | 0.0024 ns | 0.0023 ns |       0 B |
