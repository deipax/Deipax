
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.071 ns | 0.0191 ns | 0.0178 ns |      - |       0 B |
     FromBoolNullable | 15.063 ns | 0.0085 ns | 0.0066 ns |      - |       0 B |
             FromChar | 15.838 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
     FromCharNullable | 15.835 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
            FromSByte | 15.058 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
    FromSByteNullable | 15.080 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
             FromByte | 15.060 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
     FromByteNullable | 15.065 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
            FromShort | 15.061 ns | 0.0049 ns | 0.0038 ns |      - |       0 B |
    FromShortNullable | 15.072 ns | 0.0183 ns | 0.0172 ns |      - |       0 B |
           FromUShort | 15.091 ns | 0.0322 ns | 0.0301 ns |      - |       0 B |
   FromUShortNullable | 15.067 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
              FromInt | 14.786 ns | 0.0053 ns | 0.0039 ns |      - |       0 B |
      FromIntNullable | 14.083 ns | 0.0265 ns | 0.0235 ns |      - |       0 B |
             FromUInt | 15.577 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
     FromUIntNullable | 15.577 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
             FromLong | 16.339 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
     FromLongNullable | 16.356 ns | 0.0281 ns | 0.0263 ns |      - |       0 B |
            FromULong | 16.341 ns | 0.0127 ns | 0.0112 ns |      - |       0 B |
    FromULongNullable | 16.345 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
            FromFloat | 17.112 ns | 0.0050 ns | 0.0044 ns |      - |       0 B |
    FromFloatNullable | 17.131 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
           FromDouble | 16.877 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
   FromDoubleNullable | 16.867 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
          FromDecimal | 25.681 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
  FromDecimalNullable | 27.800 ns | 0.0085 ns | 0.0067 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.715 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
           FromObject | 13.971 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
           FromString | 85.029 ns | 0.1350 ns | 0.1263 ns |      - |       0 B |
             FromEnum | 44.946 ns | 0.0740 ns | 0.0692 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_IntNullable.FromDateTime: DefaultJob
