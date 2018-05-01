
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.972 ns | 0.1372 ns | 0.1216 ns |      - |       0 B |
     FromBoolNullable | 12.783 ns | 0.0170 ns | 0.0151 ns |      - |       0 B |
             FromChar | 14.113 ns | 0.0208 ns | 0.0174 ns |      - |       0 B |
     FromCharNullable | 14.057 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
            FromSByte | 13.457 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
    FromSByteNullable | 13.309 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
             FromByte |  3.429 ns | 0.0078 ns | 0.0061 ns |      - |       0 B |
     FromByteNullable |  3.360 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
            FromShort | 14.068 ns | 0.0226 ns | 0.0200 ns |      - |       0 B |
    FromShortNullable | 14.126 ns | 0.1002 ns | 0.0937 ns |      - |       0 B |
           FromUShort | 13.279 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
   FromUShortNullable | 13.347 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
              FromInt | 14.085 ns | 0.0345 ns | 0.0306 ns |      - |       0 B |
      FromIntNullable | 14.245 ns | 0.0094 ns | 0.0074 ns |      - |       0 B |
             FromUInt | 13.331 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
     FromUIntNullable | 13.321 ns | 0.0172 ns | 0.0143 ns |      - |       0 B |
             FromLong | 14.217 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
     FromLongNullable | 14.062 ns | 0.0218 ns | 0.0193 ns |      - |       0 B |
            FromULong | 14.117 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
    FromULongNullable | 14.057 ns | 0.0067 ns | 0.0052 ns |      - |       0 B |
            FromFloat | 17.071 ns | 0.0327 ns | 0.0289 ns |      - |       0 B |
    FromFloatNullable | 16.872 ns | 0.0247 ns | 0.0219 ns |      - |       0 B |
           FromDouble | 16.438 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
   FromDoubleNullable | 16.400 ns | 0.0331 ns | 0.0294 ns |      - |       0 B |
          FromDecimal | 24.459 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
  FromDecimalNullable | 24.088 ns | 0.0614 ns | 0.0574 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.054 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
           FromObject |  3.404 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
           FromString | 84.931 ns | 0.0908 ns | 0.0805 ns |      - |       0 B |
             FromEnum | 44.762 ns | 0.2924 ns | 0.2735 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Byte.FromDateTime: DefaultJob
