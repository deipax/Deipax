
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.340 ns | 0.0208 ns | 0.0194 ns |      - |       0 B |
     FromBoolNullable | 15.396 ns | 0.0413 ns | 0.0345 ns |      - |       0 B |
             FromChar | 16.640 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
     FromCharNullable | 16.733 ns | 0.1079 ns | 0.1009 ns |      - |       0 B |
            FromSByte | 15.883 ns | 0.0349 ns | 0.0327 ns |      - |       0 B |
    FromSByteNullable | 15.905 ns | 0.0499 ns | 0.0442 ns |      - |       0 B |
             FromByte | 14.105 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
     FromByteNullable | 14.200 ns | 0.1062 ns | 0.0993 ns |      - |       0 B |
            FromShort | 16.641 ns | 0.0197 ns | 0.0154 ns |      - |       0 B |
    FromShortNullable | 16.690 ns | 0.0620 ns | 0.0518 ns |      - |       0 B |
           FromUShort | 15.946 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
   FromUShortNullable | 15.881 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |
              FromInt | 16.665 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
      FromIntNullable | 16.655 ns | 0.0260 ns | 0.0243 ns |      - |       0 B |
             FromUInt | 15.888 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
     FromUIntNullable | 15.985 ns | 0.1071 ns | 0.1002 ns |      - |       0 B |
             FromLong | 16.647 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
     FromLongNullable | 16.652 ns | 0.0348 ns | 0.0309 ns |      - |       0 B |
            FromULong | 16.651 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
    FromULongNullable | 16.709 ns | 0.1129 ns | 0.1056 ns |      - |       0 B |
            FromFloat | 19.432 ns | 0.0162 ns | 0.0127 ns |      - |       0 B |
    FromFloatNullable | 19.458 ns | 0.0332 ns | 0.0277 ns |      - |       0 B |
           FromDouble | 19.075 ns | 0.1461 ns | 0.1366 ns |      - |       0 B |
   FromDoubleNullable | 19.128 ns | 0.2208 ns | 0.1957 ns |      - |       0 B |
          FromDecimal | 26.870 ns | 0.1163 ns | 0.0971 ns |      - |       0 B |
  FromDecimalNullable | 26.732 ns | 0.1490 ns | 0.1393 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.801 ns | 0.0445 ns | 0.0395 ns |      - |       0 B |
           FromObject | 14.403 ns | 0.1829 ns | 0.1621 ns |      - |       0 B |
           FromString | 89.777 ns | 1.8129 ns | 2.2264 ns |      - |       0 B |
             FromEnum | 47.273 ns | 0.1825 ns | 0.1618 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_ByteNullable.FromDateTime: DefaultJob
