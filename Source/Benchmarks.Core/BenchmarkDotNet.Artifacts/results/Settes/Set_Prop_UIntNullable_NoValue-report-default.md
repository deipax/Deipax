
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.316 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
     FromBoolNullable |  8.440 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
             FromChar | 16.089 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
     FromCharNullable |  7.706 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
            FromSByte | 15.835 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
    FromSByteNullable |  7.703 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
             FromByte | 15.326 ns | 0.0095 ns | 0.0079 ns |      - |       0 B |
     FromByteNullable |  7.709 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
            FromShort | 15.842 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
    FromShortNullable |  7.705 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
           FromUShort | 15.320 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
   FromUShortNullable |  7.710 ns | 0.0195 ns | 0.0183 ns |      - |       0 B |
              FromInt | 15.822 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
      FromIntNullable |  7.704 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
             FromUInt | 14.216 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
     FromUIntNullable |  7.730 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
             FromLong | 16.592 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
     FromLongNullable |  9.115 ns | 0.0037 ns | 0.0034 ns |      - |       0 B |
            FromULong | 15.823 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
    FromULongNullable |  7.729 ns | 0.0129 ns | 0.0101 ns |      - |       0 B |
            FromFloat | 17.125 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
    FromFloatNullable |  7.703 ns | 0.0089 ns | 0.0084 ns |      - |       0 B |
           FromDouble | 16.906 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
   FromDoubleNullable |  7.730 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
          FromDecimal | 38.640 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
  FromDecimalNullable |  7.832 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.695 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
           FromObject |  7.704 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
           FromString |  7.709 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
             FromEnum | 45.564 ns | 0.0350 ns | 0.0328 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_UIntNullable_NoValue.FromDateTime: DefaultJob
