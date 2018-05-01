
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 37.951 ns | 0.0290 ns | 0.0242 ns |       0 B |
     FromBoolNullable | 37.316 ns | 0.0695 ns | 0.0580 ns |       0 B |
             FromChar | 38.121 ns | 0.0144 ns | 0.0120 ns |       0 B |
     FromCharNullable | 38.091 ns | 0.0984 ns | 0.0872 ns |       0 B |
            FromSByte | 37.290 ns | 0.0122 ns | 0.0102 ns |       0 B |
    FromSByteNullable | 37.664 ns | 0.0226 ns | 0.0201 ns |       0 B |
             FromByte | 37.332 ns | 0.0165 ns | 0.0137 ns |       0 B |
     FromByteNullable | 37.500 ns | 0.1155 ns | 0.1024 ns |       0 B |
            FromShort | 37.812 ns | 0.0163 ns | 0.0127 ns |       0 B |
    FromShortNullable | 37.127 ns | 0.0255 ns | 0.0226 ns |       0 B |
           FromUShort | 37.326 ns | 0.0326 ns | 0.0305 ns |       0 B |
   FromUShortNullable | 37.379 ns | 0.0769 ns | 0.0719 ns |       0 B |
              FromInt | 31.460 ns | 0.0135 ns | 0.0126 ns |       0 B |
      FromIntNullable | 31.417 ns | 0.0161 ns | 0.0143 ns |       0 B |
             FromUInt | 37.985 ns | 0.0224 ns | 0.0187 ns |       0 B |
     FromUIntNullable | 37.895 ns | 0.0341 ns | 0.0303 ns |       0 B |
             FromLong | 39.641 ns | 0.0159 ns | 0.0148 ns |       0 B |
     FromLongNullable | 38.947 ns | 0.0628 ns | 0.0557 ns |       0 B |
            FromULong | 38.655 ns | 0.0337 ns | 0.0315 ns |       0 B |
    FromULongNullable | 38.571 ns | 0.0117 ns | 0.0098 ns |       0 B |
            FromFloat | 39.224 ns | 0.0158 ns | 0.0140 ns |       0 B |
    FromFloatNullable | 39.342 ns | 0.1186 ns | 0.1109 ns |       0 B |
           FromDouble | 39.341 ns | 0.0392 ns | 0.0348 ns |       0 B |
   FromDoubleNullable | 39.376 ns | 0.1155 ns | 0.1080 ns |       0 B |
          FromDecimal | 50.523 ns | 0.0198 ns | 0.0185 ns |       0 B |
  FromDecimalNullable | 49.288 ns | 0.0624 ns | 0.0521 ns |       0 B |
         FromDateTime |        NA |        NA |        NA |       N/A |
 FromDateTimeNullable |  6.041 ns | 0.0029 ns | 0.0024 ns |       0 B |
           FromObject |  2.995 ns | 0.0018 ns | 0.0015 ns |       0 B |
           FromString | 37.966 ns | 0.0249 ns | 0.0208 ns |       0 B |
             FromEnum |  3.041 ns | 0.0059 ns | 0.0049 ns |       0 B |

Benchmarks with issues:
  Set_Prop_Enum.FromDateTime: DefaultJob
