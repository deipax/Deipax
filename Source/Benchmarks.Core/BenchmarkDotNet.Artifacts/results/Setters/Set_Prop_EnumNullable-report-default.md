
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool | 20.2034 ns | 0.0292 ns | 0.0259 ns |       0 B |
     FromBoolNullable | 20.7438 ns | 0.0404 ns | 0.0358 ns |       0 B |
             FromChar | 20.4986 ns | 0.0294 ns | 0.0275 ns |       0 B |
     FromCharNullable | 21.3415 ns | 0.0612 ns | 0.0511 ns |       0 B |
            FromSByte | 20.2785 ns | 0.0205 ns | 0.0192 ns |       0 B |
    FromSByteNullable | 20.6710 ns | 0.0350 ns | 0.0311 ns |       0 B |
             FromByte | 20.2852 ns | 0.0275 ns | 0.0257 ns |       0 B |
     FromByteNullable | 20.6795 ns | 0.0375 ns | 0.0333 ns |       0 B |
            FromShort | 20.2771 ns | 0.0258 ns | 0.0241 ns |       0 B |
    FromShortNullable | 20.7085 ns | 0.0386 ns | 0.0322 ns |       0 B |
           FromUShort | 20.4759 ns | 0.0254 ns | 0.0238 ns |       0 B |
   FromUShortNullable | 21.2873 ns | 0.0608 ns | 0.0508 ns |       0 B |
              FromInt | 20.2579 ns | 0.0351 ns | 0.0329 ns |       0 B |
      FromIntNullable | 20.8055 ns | 0.0278 ns | 0.0247 ns |       0 B |
             FromUInt | 20.2156 ns | 0.0272 ns | 0.0255 ns |       0 B |
     FromUIntNullable | 20.6806 ns | 0.0238 ns | 0.0222 ns |       0 B |
             FromLong | 20.8804 ns | 0.0296 ns | 0.0277 ns |       0 B |
     FromLongNullable | 21.4019 ns | 0.0513 ns | 0.0428 ns |       0 B |
            FromULong | 20.7597 ns | 0.0264 ns | 0.0247 ns |       0 B |
    FromULongNullable | 21.4288 ns | 0.0349 ns | 0.0327 ns |       0 B |
            FromFloat | 21.9038 ns | 0.0242 ns | 0.0215 ns |       0 B |
    FromFloatNullable | 22.1519 ns | 0.0358 ns | 0.0335 ns |       0 B |
           FromDouble | 21.6834 ns | 0.0309 ns | 0.0289 ns |       0 B |
   FromDoubleNullable | 22.3998 ns | 0.0429 ns | 0.0401 ns |       0 B |
          FromDecimal | 37.1321 ns | 0.0645 ns | 0.0572 ns |       0 B |
  FromDecimalNullable | 44.6901 ns | 0.0770 ns | 0.0720 ns |       0 B |
         FromDateTime | 14.4287 ns | 0.0334 ns | 0.0296 ns |       0 B |
 FromDateTimeNullable |  8.8374 ns | 0.0220 ns | 0.0206 ns |       0 B |
           FromObject | 13.6581 ns | 0.0066 ns | 0.0052 ns |       0 B |
           FromString | 30.3988 ns | 0.1144 ns | 0.1014 ns |       0 B |
             FromEnum |  1.0421 ns | 0.0037 ns | 0.0034 ns |       0 B |
     FromEnumNullable |  0.9995 ns | 0.0040 ns | 0.0037 ns |       0 B |
