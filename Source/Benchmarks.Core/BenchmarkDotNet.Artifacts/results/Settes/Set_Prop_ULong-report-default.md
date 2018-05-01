
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.569 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
     FromBoolNullable | 12.537 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
             FromChar | 13.332 ns | 0.0212 ns | 0.0165 ns |      - |       0 B |
     FromCharNullable | 13.317 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
            FromSByte | 13.094 ns | 0.0341 ns | 0.0302 ns |      - |       0 B |
    FromSByteNullable | 13.064 ns | 0.0068 ns | 0.0061 ns |      - |       0 B |
             FromByte | 12.541 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
     FromByteNullable | 12.561 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
            FromShort | 13.268 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
    FromShortNullable | 13.098 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
           FromUShort | 12.544 ns | 0.0046 ns | 0.0039 ns |      - |       0 B |
   FromUShortNullable | 12.557 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
              FromInt | 13.058 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
      FromIntNullable | 13.118 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
             FromUInt | 12.544 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
     FromUIntNullable | 12.573 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
             FromLong | 13.244 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
     FromLongNullable | 13.075 ns | 0.0120 ns | 0.0094 ns |      - |       0 B |
            FromULong |  3.413 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
    FromULongNullable |  3.442 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
            FromFloat | 16.920 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
    FromFloatNullable | 16.910 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
           FromDouble | 17.057 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
   FromDoubleNullable | 16.674 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |
          FromDecimal | 30.349 ns | 0.0188 ns | 0.0136 ns |      - |       0 B |
  FromDecimalNullable | 31.097 ns | 0.0253 ns | 0.0197 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.091 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
           FromObject |  3.415 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
           FromString | 82.891 ns | 0.0374 ns | 0.0332 ns |      - |       0 B |
             FromEnum | 42.805 ns | 0.0610 ns | 0.0540 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_ULong.FromDateTime: DefaultJob
