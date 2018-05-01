
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 16.743 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
     FromBoolNullable |  8.266 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
             FromChar |        NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |  8.265 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
            FromSByte | 16.703 ns | 0.0226 ns | 0.0200 ns |      - |       0 B |
    FromSByteNullable |  8.262 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
             FromByte | 16.771 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
     FromByteNullable |  8.288 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
            FromShort | 17.008 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
    FromShortNullable |  8.266 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
           FromUShort | 16.695 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
   FromUShortNullable |  8.259 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
              FromInt | 16.694 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
      FromIntNullable |  8.350 ns | 0.1913 ns | 0.2047 ns |      - |       0 B |
             FromUInt | 16.965 ns | 0.0313 ns | 0.0244 ns |      - |       0 B |
     FromUIntNullable |  8.293 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
             FromLong | 16.954 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
     FromLongNullable |  8.267 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
            FromULong | 17.368 ns | 0.0256 ns | 0.0239 ns |      - |       0 B |
    FromULongNullable |  8.260 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
            FromFloat | 16.595 ns | 0.0246 ns | 0.0218 ns |      - |       0 B |
    FromFloatNullable |  8.939 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
           FromDouble | 14.176 ns | 0.0454 ns | 0.0425 ns |      - |       0 B |
   FromDoubleNullable |  8.298 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
          FromDecimal | 22.061 ns | 0.0394 ns | 0.0307 ns |      - |       0 B |
  FromDecimalNullable |  8.264 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.271 ns | 0.0204 ns | 0.0181 ns |      - |       0 B |
           FromObject |  8.253 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
           FromString |  8.265 ns | 0.0044 ns | 0.0032 ns |      - |       0 B |
             FromEnum | 47.614 ns | 0.0933 ns | 0.0827 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_DoubleNullable_NoValue.FromChar: DefaultJob
  Set_Prop_DoubleNullable_NoValue.FromDateTime: DefaultJob
