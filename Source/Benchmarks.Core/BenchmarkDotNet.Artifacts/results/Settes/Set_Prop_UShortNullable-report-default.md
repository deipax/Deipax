
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.402 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
     FromBoolNullable | 15.329 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
             FromChar | 16.130 ns | 0.0211 ns | 0.0187 ns |      - |       0 B |
     FromCharNullable | 16.118 ns | 0.0499 ns | 0.0467 ns |      - |       0 B |
            FromSByte | 15.849 ns | 0.0190 ns | 0.0169 ns |      - |       0 B |
    FromSByteNullable | 15.838 ns | 0.0159 ns | 0.0148 ns |      - |       0 B |
             FromByte | 15.323 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
     FromByteNullable | 15.318 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
            FromShort | 15.841 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
    FromShortNullable | 15.841 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
           FromUShort | 14.074 ns | 0.0272 ns | 0.0254 ns |      - |       0 B |
   FromUShortNullable | 13.983 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
              FromInt | 16.602 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
      FromIntNullable | 16.608 ns | 0.0058 ns | 0.0052 ns |      - |       0 B |
             FromUInt | 15.823 ns | 0.0052 ns | 0.0041 ns |      - |       0 B |
     FromUIntNullable | 15.852 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
             FromLong | 16.588 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
     FromLongNullable | 16.606 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
            FromULong | 16.594 ns | 0.0089 ns | 0.0074 ns |      - |       0 B |
    FromULongNullable | 16.615 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
            FromFloat | 19.146 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
    FromFloatNullable | 19.169 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
           FromDouble | 18.892 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
   FromDoubleNullable | 18.946 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
          FromDecimal | 26.909 ns | 0.0313 ns | 0.0261 ns |      - |       0 B |
  FromDecimalNullable | 26.642 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.705 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
           FromObject | 14.158 ns | 0.0321 ns | 0.0301 ns |      - |       0 B |
           FromString | 86.938 ns | 0.0462 ns | 0.0410 ns |      - |       0 B |
             FromEnum | 47.858 ns | 0.0621 ns | 0.0581 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_UShortNullable.FromDateTime: DefaultJob
